using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atualizador.BarraDeProgresso;

namespace atualizadorDataeHoraEmissaoPeloXML.BarraDeProgresso
{
    public partial class frmProgresso : Form
    {
        Form mainForm;
        private int _valorAtual = 0;
        private int _valorMaximo = 100;
        int Passo = 0;

        public int valorAtual
        {
            get {
                return this._valorAtual;
            }
            set {
                this._valorAtual = value;
                AjustarLimites();
            }
        }
        public int valorMaximo
        {
            get {
                return this._valorMaximo;
            }
            set {
                this._valorMaximo = value;
                AjustarLimites();
            }
        }
        private void AjustarLimites()
        {

            if ((_valorAtual < 0))
            {
                valorAtual = 0;
            }
            else if ((_valorAtual > _valorMaximo))
            {
                _valorAtual = _valorMaximo;
            }
            this.progressBar1.Value = this._valorAtual * 100 / this._valorMaximo;
            lblValor.Text = string.Format("{0} de {1}", this._valorAtual, this._valorMaximo);
        }
        public frmProgresso()
        {
            InitializeComponent();
        }

        public void Mostrar(Form mainForm)
        {
           // mainForm.Enabled = false;
            this.Show();
        }
        private void frmProgresso_FormClosing(object sender, FormClosingEventArgs e)
        {
         //   this.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            string texto = "Aguarde, Processando {0}";
            switch (Passo)
            {
                case 0:
                    lblMensagem.Text = string.Format(texto, new string('.', (Passo + 1)));
                    break;
                default:
                    lblMensagem.Text = string.Format(texto, "...");
                    Passo = -1;
                    break;
            }
            Passo++;
        }
    }
}
