using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Atualizador.Classes;
using System.IO;
using System.Xml;
using atualizadorDataeHoraEmissaoPeloXML.BarraDeProgresso;
using Atualizador.DAO;
using System.Collections.Generic;

namespace atualizadorDataeHoraEmissaoPeloXML
{
    public partial class frmPrincipal : Form
    {
        Utils utils = new Utils();
        string stringDeConexao;
        string caminho = null;

        Repositorio<XML> repositorioXML = new Repositorio<XML>();

        public frmPrincipal()
        {
            InitializeComponent();
        }
      
        public void PreencherListBox(ListBox listBox, DataTable dataTable, Int16 posicao)
        {
            listBox.Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                string nomeTabela = (string)row[posicao];
                listBox.Items.Add(nomeTabela);
            }
        }
        private void btnVerificarConexao_Click(object sender, EventArgs e)
        {
            stringDeConexao = txtStringConexao.Text;
            DAOUtils sql= new DAOUtils(stringDeConexao);
            XMLDAO xmlDAO = new XMLDAO();
            

            try
            {
                PreencherListBox(lsbTabela, xmlDAO.CapturarTabelas(), 2);
                gbProcesso2.Enabled = false;
                gbProcesso3.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Atualizador de Data e Hora da Emissao Pelo XML do NF-e", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnDiretorio_Click(object sender, EventArgs e)
        {
            var x = new FolderBrowserDialog();
            x.ShowNewFolderButton = false;
            x.Description = "Informe o diretório aonde estão os arquivos XML 'NF-e'.";
            x.SelectedPath = @"C:\NFE\Processadas";
            if (x.ShowDialog() == DialogResult.OK)
            {
                caminho = x.SelectedPath;
                btnDiretorio.Enabled = false;
            }
        }
        private void btnCarregarArquivos_Click(object sender, EventArgs e)
        {
            btnCarregarArquivos.Enabled = false;


            DirectoryInfo DiretorioFonte = new DirectoryInfo(caminho);
            FileInfo[] Arquivos = DiretorioFonte.GetFiles("*.xml");

            frmProgresso frmProgresso = new frmProgresso();
            frmProgresso.valorMaximo = Arquivos.Length;
            frmProgresso.valorAtual = 0;
            frmProgresso.Mostrar(this);

            foreach (FileInfo Arquivo in Arquivos)
            {
                frmProgresso.valorAtual++;
                Application.DoEvents();

                string caminhoArqXML = string.Concat(caminho, @"\", Arquivo);

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(caminhoArqXML); //Carregando o arquivo

                //Valida se o XML é do tipo NF-e
                XmlNodeList axml = xmlDoc.GetElementsByTagName("infNFe");
                if (axml.Count > 0)
                {
                    //Pegando elemento pelo nome da TAG
                    XmlNodeList xnList = xmlDoc.GetElementsByTagName("ide");


                    foreach (XmlNode xn in xnList)
                    {
                        try
                        {
                            //Versão da NF-e 3.0
                            XML dadosDoXML = new XML();

                            dadosDoXML.versaoNFe = axml.Item(0).Attributes.Item(1).Value;
                            Char delimiter = 'T';
                            String[] substring = xn["dhEmi"].InnerText.Split(delimiter);
                            dadosDoXML.chaveNFe = axml.Item(0).Attributes.Item(0).Value.Remove(0, 3);
                            dadosDoXML.numeroNFe = xn["nNF"].InnerText;
                            dadosDoXML.dataEmissao = substring[0];
                            dadosDoXML.horaEmissao = substring[1];

                            repositorioXML.Insert(dadosDoXML);
                        }
                        catch
                        {
                            //Tratamento de Versão da NF-e versão 2.0 
                            try
                            {
                                XML dadosDoXML = new XML();
                                dadosDoXML.versaoNFe = axml.Item(0).Attributes.Item(1).Value;
                                dadosDoXML.chaveNFe = axml.Item(0).Attributes.Item(0).Value.Remove(0, 3);
                                dadosDoXML.numeroNFe = xn["nNF"].InnerText;
                                dadosDoXML.dataEmissao = xn["dSaiEnt"].InnerText;
                                dadosDoXML.horaEmissao = xn["hSaiEnt"].InnerText;

                                repositorioXML.Insert(dadosDoXML);
                            }
                            catch { }

                        }
                    }
                }
            }
            frmProgresso.Close();

            lblTotalXMLCarregados.Text = Convert.ToString(repositorioXML.Get().Count);
            lblTotalXMLCarregados.ForeColor = Color.Blue;

            gbProcesso2.Enabled = true;
        }
        private void btnConcluirConfig_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("TODOS OS CAMPOS FORAM INFORMADOS CORRETAMENTE?" + "\n\n" + "Verifique o campo 'Layout da Query de Atualização', nele é possivel confirmar a expressão que será utilizada para atualizar a base de dados!" + "\n\n" + "ATENÇÃO: Caso algum campo tenha sido informado errado para corrigir APÓS o OK será necessário fechar e abrir o programa e começar todo o processo novamente!", "Atualizador de Data e Hora da Emissao Pelo XML do NF-e", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                gbProcesso1.Enabled = false;
                gbProcesso2.Enabled = false;
                gbProcesso3.Enabled = false;
                gbProcesso4.Enabled = true;
                timerArcoIrisCorAviso.Enabled = true;
            }
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("VOCÊ ESTÁ 100% CERTO DISTO?\n\nNÃO PROSSIGA SE VOCÊ NÃO TEM TOTAL CERTEZA DO QUE ESTÁ FAZENDO!" +
                 "\n\n" +
                "O MAU USO DESTA APLICAÇÃO PODE DANIFICAR OS DADOS DA SUA BASE DE DADOS PARA SEMPRE!\n\n" + 
                "APÓS CLICAR EM 'SIM' O O PROCESSO É IRREVERSIVEL!",
                "Atualizador de Data e Hora da Emissao Pelo XML do NF-e", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                this.Enabled = false;
               List<XML> lista = repositorioXML.Get();
                if (lista.Count > 0)
                {
                    frmProgresso frmProgresso = new frmProgresso();
                    frmProgresso.valorMaximo = lista.Count;
                    frmProgresso.valorAtual = 0;
                    frmProgresso.Mostrar(this);
                    int contador = 0;
                        foreach (var l in lista)
                        {
                        Application.DoEvents();
                        XMLDAO.Atualizar(lsbTabela.Text,lsbColunasDataEHora.Text,lsbColunasChaveAcesso.Text, l.chaveNFe, l.dataEmissao, l.horaEmissao);
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(Convert.ToInt32(txtTempoEmMS.Text));
                            frmProgresso.valorAtual = contador++;
                        }
                }
                MessageBox.Show("A atualização foi concluída!", "Atualizador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void lsbTabela_SelectedIndexChanged(object sender, EventArgs e)
        {
            DAOUtils sql = new DAOUtils(stringDeConexao);
            XMLDAO xmlDAO = new XMLDAO();

            string tabela = lsbTabela.GetItemText(lsbTabela.SelectedItem);
            PreencherListBox(lsbColunasChaveAcesso, xmlDAO.CapturarCampos(tabela), 3);
            PreencherListBox(lsbColunasDataEHora, xmlDAO.CapturarCampos(tabela), 3);
            lblQueryDeAtualizacao.Text = utils.MontarQueryDeExemplo(Convert.ToString(lsbTabela.SelectedItem),null,null);
            lsbColunasDataEHora.Enabled = true;
        }

        private void lsbColunasChaveAcesso_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblQueryDeAtualizacao.Text = utils.MontarQueryDeExemplo(Convert.ToString(lsbTabela.SelectedItem), Convert.ToString(lsbColunasChaveAcesso.SelectedItem), Convert.ToString(lsbColunasDataEHora.SelectedItem));
            txtTempoEmMS.Enabled = true;
            btnConcluirConfig.Enabled = true;
        }

        private void lsbColunasDataEHora_SelectedIndexChanged(object sender, EventArgs e)
        {
           lblQueryDeAtualizacao.Text =  utils.MontarQueryDeExemplo(Convert.ToString(lsbTabela.SelectedItem), null, Convert.ToString(lsbColunasDataEHora.SelectedItem));
           lsbColunasChaveAcesso.Enabled = true;
        }
 
        private void timerArcoIrisCorAviso_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Color randomColor = Color.FromArgb(rnd.Next(256),20, rnd.Next(256));
            lblAvisoCor.ForeColor = randomColor;
        }
    }
}
