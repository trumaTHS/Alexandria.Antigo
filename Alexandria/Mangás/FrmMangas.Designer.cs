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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMangas));
            this.BtnMangasCadastrar = new System.Windows.Forms.Button();
            this.BtnMangasVisualizar = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMangasCadastrar
            // 
            this.BtnMangasCadastrar.Font = new System.Drawing.Font("SpellcasterW01-Regular", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMangasCadastrar.Location = new System.Drawing.Point(12, 12);
            this.BtnMangasCadastrar.Name = "BtnMangasCadastrar";
            this.BtnMangasCadastrar.Size = new System.Drawing.Size(543, 527);
            this.BtnMangasCadastrar.TabIndex = 2;
            this.BtnMangasCadastrar.Text = "Cadastrar";
            this.BtnMangasCadastrar.UseVisualStyleBackColor = true;
            this.BtnMangasCadastrar.Click += new System.EventHandler(this.BtnMangasCadastrar_Click);
            // 
            // BtnMangasVisualizar
            // 
            this.BtnMangasVisualizar.Font = new System.Drawing.Font("SpellcasterW01-Regular", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMangasVisualizar.Location = new System.Drawing.Point(561, 12);
            this.BtnMangasVisualizar.Name = "BtnMangasVisualizar";
            this.BtnMangasVisualizar.Size = new System.Drawing.Size(543, 527);
            this.BtnMangasVisualizar.TabIndex = 3;
            this.BtnMangasVisualizar.Text = "Visualizar";
            this.BtnMangasVisualizar.UseVisualStyleBackColor = true;
            this.BtnMangasVisualizar.Click += new System.EventHandler(this.BtnMangasVisualizar_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("SpellcasterW01-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(12, 545);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(1092, 52);
            this.BtnVoltar.TabIndex = 5;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // FrmMangas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 609);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnMangasVisualizar);
            this.Controls.Add(this.BtnMangasCadastrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMangas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mangás";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMangasCadastrar;
        private System.Windows.Forms.Button BtnMangasVisualizar;
        private System.Windows.Forms.Button BtnVoltar;
    }
}