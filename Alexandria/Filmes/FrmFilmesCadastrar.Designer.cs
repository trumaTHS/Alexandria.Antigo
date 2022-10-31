namespace Alexandria.Filmes
{
    partial class FrmFilmesCadastrar
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
            this.TxtboxFilmeNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFilmesSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtboxFilmeNome
            // 
            this.TxtboxFilmeNome.Location = new System.Drawing.Point(359, 152);
            this.TxtboxFilmeNome.Name = "TxtboxFilmeNome";
            this.TxtboxFilmeNome.Size = new System.Drawing.Size(100, 20);
            this.TxtboxFilmeNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // BtnFilmesSalvar
            // 
            this.BtnFilmesSalvar.Location = new System.Drawing.Point(362, 237);
            this.BtnFilmesSalvar.Name = "BtnFilmesSalvar";
            this.BtnFilmesSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnFilmesSalvar.TabIndex = 2;
            this.BtnFilmesSalvar.Text = "button1";
            this.BtnFilmesSalvar.UseVisualStyleBackColor = true;
            this.BtnFilmesSalvar.Click += new System.EventHandler(this.BtnFilmesSalvar_Click);
            // 
            // FrmFilmesCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnFilmesSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtboxFilmeNome);
            this.Name = "FrmFilmesCadastrar";
            this.Text = "FrmLivrosCadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtboxFilmeNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFilmesSalvar;
    }
}