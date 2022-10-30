namespace Alexandria
{
    partial class FrmLivrosCadastrar
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
            this.LabLivroISBN = new System.Windows.Forms.Label();
            this.LabLivroNome = new System.Windows.Forms.Label();
            this.TxtboxLivroISBN = new System.Windows.Forms.TextBox();
            this.TxtboxLivroNome = new System.Windows.Forms.TextBox();
            this.BtnLivrosSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabLivroISBN
            // 
            this.LabLivroISBN.AutoSize = true;
            this.LabLivroISBN.Location = new System.Drawing.Point(291, 139);
            this.LabLivroISBN.Name = "LabLivroISBN";
            this.LabLivroISBN.Size = new System.Drawing.Size(32, 13);
            this.LabLivroISBN.TabIndex = 0;
            this.LabLivroISBN.Text = "ISBN";
            // 
            // LabLivroNome
            // 
            this.LabLivroNome.AutoSize = true;
            this.LabLivroNome.Location = new System.Drawing.Point(593, 138);
            this.LabLivroNome.Name = "LabLivroNome";
            this.LabLivroNome.Size = new System.Drawing.Size(35, 13);
            this.LabLivroNome.TabIndex = 1;
            this.LabLivroNome.Text = "Nome";
            // 
            // TxtboxLivroISBN
            // 
            this.TxtboxLivroISBN.Location = new System.Drawing.Point(294, 175);
            this.TxtboxLivroISBN.Name = "TxtboxLivroISBN";
            this.TxtboxLivroISBN.Size = new System.Drawing.Size(100, 20);
            this.TxtboxLivroISBN.TabIndex = 2;
            // 
            // TxtboxLivroNome
            // 
            this.TxtboxLivroNome.Location = new System.Drawing.Point(596, 175);
            this.TxtboxLivroNome.Name = "TxtboxLivroNome";
            this.TxtboxLivroNome.Size = new System.Drawing.Size(100, 20);
            this.TxtboxLivroNome.TabIndex = 3;
            // 
            // BtnLivrosSalvar
            // 
            this.BtnLivrosSalvar.Location = new System.Drawing.Point(444, 313);
            this.BtnLivrosSalvar.Name = "BtnLivrosSalvar";
            this.BtnLivrosSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnLivrosSalvar.TabIndex = 4;
            this.BtnLivrosSalvar.Text = "Salvar";
            this.BtnLivrosSalvar.UseVisualStyleBackColor = true;
            this.BtnLivrosSalvar.Click += new System.EventHandler(this.BtnLivrosSalvar_Click);
            // 
            // FrmLivrosCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 530);
            this.Controls.Add(this.BtnLivrosSalvar);
            this.Controls.Add(this.TxtboxLivroNome);
            this.Controls.Add(this.TxtboxLivroISBN);
            this.Controls.Add(this.LabLivroNome);
            this.Controls.Add(this.LabLivroISBN);
            this.Name = "FrmLivrosCadastrar";
            this.Text = "FrmLivrosCadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabLivroISBN;
        private System.Windows.Forms.Label LabLivroNome;
        private System.Windows.Forms.TextBox TxtboxLivroISBN;
        private System.Windows.Forms.TextBox TxtboxLivroNome;
        private System.Windows.Forms.Button BtnLivrosSalvar;
    }
}