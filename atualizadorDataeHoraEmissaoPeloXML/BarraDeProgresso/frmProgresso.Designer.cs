namespace atualizadorDataeHoraEmissaoPeloXML.BarraDeProgresso
{
    partial class frmProgresso
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
            this.lblMensagem = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblValor = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblMensagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.lblMensagem.Location = new System.Drawing.Point(23, 9);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(204, 19);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "Aguarde, processando...";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 53);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(223, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // lblValor
            // 
            this.lblValor.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.lblValor.Location = new System.Drawing.Point(16, 34);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(222, 16);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "0 de 1";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmProgresso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 88);
            this.ControlBox = false;
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblMensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProgresso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lendo Arquivos XML";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProgresso_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Timer timer;
    }
}