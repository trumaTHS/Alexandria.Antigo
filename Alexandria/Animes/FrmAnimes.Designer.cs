namespace Alexandria.Botões
{
    partial class FrmAnimes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnimes));
            this.BtnAnimesCadastrar = new System.Windows.Forms.Button();
            this.BtnAnimesVisualizar = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAnimesCadastrar
            // 
            this.BtnAnimesCadastrar.Font = new System.Drawing.Font("SpellcasterW01-Regular", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnimesCadastrar.Location = new System.Drawing.Point(12, 12);
            this.BtnAnimesCadastrar.Name = "BtnAnimesCadastrar";
            this.BtnAnimesCadastrar.Size = new System.Drawing.Size(543, 527);
            this.BtnAnimesCadastrar.TabIndex = 0;
            this.BtnAnimesCadastrar.Text = "Cadastrar";
            this.BtnAnimesCadastrar.UseVisualStyleBackColor = true;
            this.BtnAnimesCadastrar.Click += new System.EventHandler(this.BtnAnimesCadastrar_Click);
            // 
            // BtnAnimesVisualizar
            // 
            this.BtnAnimesVisualizar.Font = new System.Drawing.Font("SpellcasterW01-Regular", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnimesVisualizar.Location = new System.Drawing.Point(561, 12);
            this.BtnAnimesVisualizar.Name = "BtnAnimesVisualizar";
            this.BtnAnimesVisualizar.Size = new System.Drawing.Size(543, 527);
            this.BtnAnimesVisualizar.TabIndex = 1;
            this.BtnAnimesVisualizar.Text = "Visualizar";
            this.BtnAnimesVisualizar.UseVisualStyleBackColor = true;
            this.BtnAnimesVisualizar.Click += new System.EventHandler(this.BtnAnimesVisualizar_Click);
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
            // FrmAnimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 609);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnAnimesVisualizar);
            this.Controls.Add(this.BtnAnimesCadastrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnimes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAnimesCadastrar;
        private System.Windows.Forms.Button BtnAnimesVisualizar;
        private System.Windows.Forms.Button BtnVoltar;
    }
}