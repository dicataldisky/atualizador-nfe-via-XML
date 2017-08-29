namespace atualizadorDataeHoraEmissaoPeloXML
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.gbProcesso1 = new System.Windows.Forms.GroupBox();
            this.btnCarregarArquivos = new System.Windows.Forms.Button();
            this.btnDiretorio = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTotalXMLCarregados = new System.Windows.Forms.Label();
            this.gbProcesso2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerificarConexao = new System.Windows.Forms.Button();
            this.txtStringConexao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbProcesso3 = new System.Windows.Forms.GroupBox();
            this.btnConcluirConfig = new System.Windows.Forms.Button();
            this.txtTempoEmMS = new System.Windows.Forms.TextBox();
            this.lblQueryDeAtualizacao = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lsbColunasDataEHora = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lsbColunasChaveAcesso = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lsbTabela = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbProcesso4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lblAvisoCor = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerArcoIrisCorAviso = new System.Windows.Forms.Timer(this.components);
            this.gbProcesso1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.gbProcesso2.SuspendLayout();
            this.gbProcesso3.SuspendLayout();
            this.gbProcesso4.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clique no botão \'Escolher Diretório\' em seguida clique no botão \'Carregar Arquivo" +
    "s\'";
            // 
            // gbProcesso1
            // 
            this.gbProcesso1.Controls.Add(this.btnCarregarArquivos);
            this.gbProcesso1.Controls.Add(this.btnDiretorio);
            this.gbProcesso1.Controls.Add(this.label2);
            this.gbProcesso1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.gbProcesso1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.gbProcesso1.Location = new System.Drawing.Point(12, 12);
            this.gbProcesso1.Name = "gbProcesso1";
            this.gbProcesso1.Size = new System.Drawing.Size(605, 88);
            this.gbProcesso1.TabIndex = 10;
            this.gbProcesso1.TabStop = false;
            this.gbProcesso1.Text = "Processo 1";
            // 
            // btnCarregarArquivos
            // 
            this.btnCarregarArquivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregarArquivos.Image = global::atualizadorDataeHoraEmissaoPeloXML.Properties.Resources.Refresh_icon32;
            this.btnCarregarArquivos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarregarArquivos.Location = new System.Drawing.Point(207, 41);
            this.btnCarregarArquivos.Name = "btnCarregarArquivos";
            this.btnCarregarArquivos.Size = new System.Drawing.Size(183, 41);
            this.btnCarregarArquivos.TabIndex = 4;
            this.btnCarregarArquivos.Text = "Carregar Arquivos";
            this.btnCarregarArquivos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCarregarArquivos.UseVisualStyleBackColor = true;
            this.btnCarregarArquivos.Click += new System.EventHandler(this.btnCarregarArquivos_Click);
            // 
            // btnDiretorio
            // 
            this.btnDiretorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiretorio.Image = global::atualizadorDataeHoraEmissaoPeloXML.Properties.Resources.folder_invoices_icon32;
            this.btnDiretorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiretorio.Location = new System.Drawing.Point(4, 41);
            this.btnDiretorio.Name = "btnDiretorio";
            this.btnDiretorio.Size = new System.Drawing.Size(186, 41);
            this.btnDiretorio.TabIndex = 1;
            this.btnDiretorio.Text = "Escolher Diretório";
            this.btnDiretorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDiretorio.UseVisualStyleBackColor = true;
            this.btnDiretorio.Click += new System.EventHandler(this.btnDiretorio_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblTotalXMLCarregados);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(418, 35);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(189, 57);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Total de Arquivos XML Carregados:";
            // 
            // lblTotalXMLCarregados
            // 
            this.lblTotalXMLCarregados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalXMLCarregados.ForeColor = System.Drawing.Color.Red;
            this.lblTotalXMLCarregados.Location = new System.Drawing.Point(6, 16);
            this.lblTotalXMLCarregados.Name = "lblTotalXMLCarregados";
            this.lblTotalXMLCarregados.Size = new System.Drawing.Size(177, 37);
            this.lblTotalXMLCarregados.TabIndex = 0;
            this.lblTotalXMLCarregados.Text = "0";
            this.lblTotalXMLCarregados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbProcesso2
            // 
            this.gbProcesso2.Controls.Add(this.label3);
            this.gbProcesso2.Controls.Add(this.btnVerificarConexao);
            this.gbProcesso2.Controls.Add(this.txtStringConexao);
            this.gbProcesso2.Controls.Add(this.label5);
            this.gbProcesso2.Enabled = false;
            this.gbProcesso2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.gbProcesso2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.gbProcesso2.Location = new System.Drawing.Point(12, 106);
            this.gbProcesso2.Name = "gbProcesso2";
            this.gbProcesso2.Size = new System.Drawing.Size(607, 131);
            this.gbProcesso2.TabIndex = 11;
            this.gbProcesso2.TabStop = false;
            this.gbProcesso2.Text = "Processo 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(564, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Informe a STRING de conexão com a base de dados SQL Server e clique no botão \'Val" +
    "idar Conexão e Listar Tabelas\'";
            // 
            // btnVerificarConexao
            // 
            this.btnVerificarConexao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnVerificarConexao.Image = global::atualizadorDataeHoraEmissaoPeloXML.Properties.Resources.Actions_dialog_ok_apply_icon32;
            this.btnVerificarConexao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerificarConexao.Location = new System.Drawing.Point(161, 85);
            this.btnVerificarConexao.Name = "btnVerificarConexao";
            this.btnVerificarConexao.Size = new System.Drawing.Size(284, 41);
            this.btnVerificarConexao.TabIndex = 2;
            this.btnVerificarConexao.Text = "Validar Conexão e Listar Tabelas";
            this.btnVerificarConexao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerificarConexao.UseVisualStyleBackColor = true;
            this.btnVerificarConexao.Click += new System.EventHandler(this.btnVerificarConexao_Click);
            // 
            // txtStringConexao
            // 
            this.txtStringConexao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStringConexao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.txtStringConexao.Location = new System.Drawing.Point(6, 59);
            this.txtStringConexao.Name = "txtStringConexao";
            this.txtStringConexao.Size = new System.Drawing.Size(595, 20);
            this.txtStringConexao.TabIndex = 4;
            this.txtStringConexao.Text = "Server=SERVIDOR;Database=DATABASE;Trusted_Connection=True\r\n";
            this.txtStringConexao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "String de conexão:";
            // 
            // gbProcesso3
            // 
            this.gbProcesso3.Controls.Add(this.btnConcluirConfig);
            this.gbProcesso3.Controls.Add(this.txtTempoEmMS);
            this.gbProcesso3.Controls.Add(this.lblQueryDeAtualizacao);
            this.gbProcesso3.Controls.Add(this.label10);
            this.gbProcesso3.Controls.Add(this.label11);
            this.gbProcesso3.Controls.Add(this.label9);
            this.gbProcesso3.Controls.Add(this.lsbColunasDataEHora);
            this.gbProcesso3.Controls.Add(this.label6);
            this.gbProcesso3.Controls.Add(this.lsbColunasChaveAcesso);
            this.gbProcesso3.Controls.Add(this.label4);
            this.gbProcesso3.Controls.Add(this.lsbTabela);
            this.gbProcesso3.Controls.Add(this.label1);
            this.gbProcesso3.Enabled = false;
            this.gbProcesso3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.gbProcesso3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.gbProcesso3.Location = new System.Drawing.Point(12, 243);
            this.gbProcesso3.Name = "gbProcesso3";
            this.gbProcesso3.Size = new System.Drawing.Size(607, 254);
            this.gbProcesso3.TabIndex = 12;
            this.gbProcesso3.TabStop = false;
            this.gbProcesso3.Text = "Processo 3";
            // 
            // btnConcluirConfig
            // 
            this.btnConcluirConfig.Enabled = false;
            this.btnConcluirConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluirConfig.Image = global::atualizadorDataeHoraEmissaoPeloXML.Properties.Resources.Actions_dialog_ok_apply_icon321;
            this.btnConcluirConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConcluirConfig.Location = new System.Drawing.Point(301, 213);
            this.btnConcluirConfig.Name = "btnConcluirConfig";
            this.btnConcluirConfig.Size = new System.Drawing.Size(300, 31);
            this.btnConcluirConfig.TabIndex = 17;
            this.btnConcluirConfig.Text = "Concluir Configuração e Parametros";
            this.btnConcluirConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConcluirConfig.UseVisualStyleBackColor = true;
            this.btnConcluirConfig.Click += new System.EventHandler(this.btnConcluirConfig_Click);
            // 
            // txtTempoEmMS
            // 
            this.txtTempoEmMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempoEmMS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.txtTempoEmMS.Location = new System.Drawing.Point(241, 219);
            this.txtTempoEmMS.Name = "txtTempoEmMS";
            this.txtTempoEmMS.Size = new System.Drawing.Size(41, 20);
            this.txtTempoEmMS.TabIndex = 16;
            this.txtTempoEmMS.Text = "650";
            this.txtTempoEmMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQueryDeAtualizacao
            // 
            this.lblQueryDeAtualizacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblQueryDeAtualizacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQueryDeAtualizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueryDeAtualizacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblQueryDeAtualizacao.Location = new System.Drawing.Point(301, 152);
            this.lblQueryDeAtualizacao.Name = "lblQueryDeAtualizacao";
            this.lblQueryDeAtualizacao.Size = new System.Drawing.Size(300, 56);
            this.lblQueryDeAtualizacao.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(298, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Layout da Query de Atualização:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(49, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Tempo de Cada Query (MiliSegundos):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(298, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Coluna que contenha à DATA E HORA:";
            // 
            // lsbColunasDataEHora
            // 
            this.lsbColunasDataEHora.Enabled = false;
            this.lsbColunasDataEHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbColunasDataEHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.lsbColunasDataEHora.FormattingEnabled = true;
            this.lsbColunasDataEHora.Location = new System.Drawing.Point(301, 68);
            this.lsbColunasDataEHora.Name = "lsbColunasDataEHora";
            this.lsbColunasDataEHora.ScrollAlwaysVisible = true;
            this.lsbColunasDataEHora.Size = new System.Drawing.Size(300, 56);
            this.lsbColunasDataEHora.TabIndex = 11;
            this.lsbColunasDataEHora.SelectedIndexChanged += new System.EventHandler(this.lsbColunasDataEHora_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Coluna que contenha à CHAVE DE ACESSO:";
            // 
            // lsbColunasChaveAcesso
            // 
            this.lsbColunasChaveAcesso.Enabled = false;
            this.lsbColunasChaveAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbColunasChaveAcesso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.lsbColunasChaveAcesso.FormattingEnabled = true;
            this.lsbColunasChaveAcesso.Location = new System.Drawing.Point(13, 152);
            this.lsbColunasChaveAcesso.Name = "lsbColunasChaveAcesso";
            this.lsbColunasChaveAcesso.ScrollAlwaysVisible = true;
            this.lsbColunasChaveAcesso.Size = new System.Drawing.Size(269, 56);
            this.lsbColunasChaveAcesso.TabIndex = 9;
            this.lsbColunasChaveAcesso.SelectedIndexChanged += new System.EventHandler(this.lsbColunasChaveAcesso_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Selecione a tabela de NF-e:";
            // 
            // lsbTabela
            // 
            this.lsbTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbTabela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.lsbTabela.FormattingEnabled = true;
            this.lsbTabela.Location = new System.Drawing.Point(13, 68);
            this.lsbTabela.Name = "lsbTabela";
            this.lsbTabela.ScrollAlwaysVisible = true;
            this.lsbTabela.Size = new System.Drawing.Size(269, 56);
            this.lsbTabela.TabIndex = 7;
            this.lsbTabela.SelectedIndexChanged += new System.EventHandler(this.lsbTabela_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selecione primeiramente a \'Tabela NF-e\' em seguida a coluna \'CHAVE DE ACESSO\' e p" +
    "or ultimo a coluna \'DATA E HORA\'";
            // 
            // gbProcesso4
            // 
            this.gbProcesso4.Controls.Add(this.label8);
            this.gbProcesso4.Controls.Add(this.btnAtualizar);
            this.gbProcesso4.Controls.Add(this.lblAvisoCor);
            this.gbProcesso4.Enabled = false;
            this.gbProcesso4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.gbProcesso4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.gbProcesso4.Location = new System.Drawing.Point(12, 503);
            this.gbProcesso4.Name = "gbProcesso4";
            this.gbProcesso4.Size = new System.Drawing.Size(605, 129);
            this.gbProcesso4.TabIndex = 13;
            this.gbProcesso4.TabStop = false;
            this.gbProcesso4.Text = "Processo 4";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(6, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(593, 27);
            this.label8.TabIndex = 4;
            this.label8.Text = "É ALTAMENTE ACONSELHAVEL QUE VOCÊ REALIZE UM BACKUP DA SUA BASE DE DADOS ANTES DE" +
    " INICIAR A ATUALIZAÇÃO!";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Image = global::atualizadorDataeHoraEmissaoPeloXML.Properties.Resources.RUN_icon32;
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(207, 83);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(183, 41);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Iniciar Atualização";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lblAvisoCor
            // 
            this.lblAvisoCor.AutoSize = true;
            this.lblAvisoCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoCor.ForeColor = System.Drawing.Color.Navy;
            this.lblAvisoCor.Location = new System.Drawing.Point(64, 25);
            this.lblAvisoCor.Name = "lblAvisoCor";
            this.lblAvisoCor.Size = new System.Drawing.Size(474, 24);
            this.lblAvisoCor.TabIndex = 3;
            this.lblAvisoCor.Text = "ATENÇÃO ESTE PROCESSO É IRREVERSSIVEL";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 640);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(629, 22);
            this.statusStrip.TabIndex = 14;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // timerArcoIrisCorAviso
            // 
            this.timerArcoIrisCorAviso.Interval = 150;
            this.timerArcoIrisCorAviso.Tick += new System.EventHandler(this.timerArcoIrisCorAviso_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 662);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.gbProcesso4);
            this.Controls.Add(this.gbProcesso3);
            this.Controls.Add(this.gbProcesso2);
            this.Controls.Add(this.gbProcesso1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizador de Data e Hora da Emissao Pelo XML do NF-e";
            this.gbProcesso1.ResumeLayout(false);
            this.gbProcesso1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.gbProcesso2.ResumeLayout(false);
            this.gbProcesso2.PerformLayout();
            this.gbProcesso3.ResumeLayout(false);
            this.gbProcesso3.PerformLayout();
            this.gbProcesso4.ResumeLayout(false);
            this.gbProcesso4.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDiretorio;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbProcesso1;
        private System.Windows.Forms.GroupBox gbProcesso2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVerificarConexao;
        private System.Windows.Forms.TextBox txtStringConexao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbProcesso3;
        private System.Windows.Forms.ListBox lsbTabela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lsbColunasChaveAcesso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCarregarArquivos;
        private System.Windows.Forms.GroupBox gbProcesso4;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label lblAvisoCor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblTotalXMLCarregados;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lsbColunasDataEHora;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Label lblQueryDeAtualizacao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTempoEmMS;
        private System.Windows.Forms.Button btnConcluirConfig;
        private System.Windows.Forms.Timer timerArcoIrisCorAviso;
    }
}

