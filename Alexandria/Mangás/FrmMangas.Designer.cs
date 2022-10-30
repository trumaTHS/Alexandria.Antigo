namespace Alexandria.Botões
{
    partial class FrmMangas
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
            this.BtnMangasCadastrar = new System.Windows.Forms.Button();
            this.BtnMangasVisualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMangasCadastrar
            // 
            this.BtnMangasCadastrar.Location = new System.Drawing.Point(178, 122);
            this.BtnMangasCadastrar.Name = "BtnMangasCadastrar";
            this.BtnMangasCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnMangasCadastrar.TabIndex = 2;
            this.BtnMangasCadastrar.Text = "Cadastrar";
            this.BtnMangasCadastrar.UseVisualStyleBackColor = true;
            this.BtnMangasCadastrar.Click += new System.EventHandler(this.BtnMangasCadastrar_Click);
            // 
            // BtnMangasVisualizar
            // 
            this.BtnMangasVisualizar.Location = new System.Drawing.Point(475, 133);
            this.BtnMangasVisualizar.Name = "BtnMangasVisualizar";
            this.BtnMangasVisualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnMangasVisualizar.TabIndex = 3;
            this.BtnMangasVisualizar.Text = "Visualizar";
            this.BtnMangasVisualizar.UseVisualStyleBackColor = true;
            this.BtnMangasVisualizar.Click += new System.EventHandler(this.BtnMangasVisualizar_Click);
            // 
            // FrmMangas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnMangasVisualizar);
            this.Controls.Add(this.BtnMangasCadastrar);
            this.Name = "FrmMangas";
            this.Text = "FrmMangas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMangasCadastrar;
        private System.Windows.Forms.Button BtnMangasVisualizar;
    }
}