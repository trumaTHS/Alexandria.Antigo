namespace Alexandria.Botões
{
    partial class FrmFilmes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFilmes));
            this.BtnFilmesCadastrar = new System.Windows.Forms.Button();
            this.BtnFilmesVisualizar = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnFilmesCadastrar
            // 
            this.BtnFilmesCadastrar.Font = new System.Drawing.Font("SpellcasterW01-Regular", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFilmesCadastrar.Location = new System.Drawing.Point(12, 12);
            this.BtnFilmesCadastrar.Name = "BtnFilmesCadastrar";
            this.BtnFilmesCadastrar.Size = new System.Drawing.Size(543, 527);
            this.BtnFilmesCadastrar.TabIndex = 0;
            this.BtnFilmesCadastrar.Text = "Cadastrar";
            this.BtnFilmesCadastrar.UseVisualStyleBackColor = true;
            this.BtnFilmesCadastrar.Click += new System.EventHandler(this.BtnFilmesCadastrar_Click);
            // 
            // BtnFilmesVisualizar
            // 
            this.BtnFilmesVisualizar.Font = new System.Drawing.Font("SpellcasterW01-Regular", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFilmesVisualizar.Location = new System.Drawing.Point(561, 12);
            this.BtnFilmesVisualizar.Name = "BtnFilmesVisualizar";
            this.BtnFilmesVisualizar.Size = new System.Drawing.Size(543, 527);
            this.BtnFilmesVisualizar.TabIndex = 1;
            this.BtnFilmesVisualizar.Text = "Visualizar";
            this.BtnFilmesVisualizar.UseVisualStyleBackColor = true;
            this.BtnFilmesVisualizar.Click += new System.EventHandler(this.BtnFilmesVisualizar_Click);
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
            // FrmFilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 609);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnFilmesVisualizar);
            this.Controls.Add(this.BtnFilmesCadastrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFilmes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filmes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnFilmesCadastrar;
        private System.Windows.Forms.Button BtnFilmesVisualizar;
        private System.Windows.Forms.Button BtnVoltar;
    }
}