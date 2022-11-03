namespace Alexandria
{
    partial class FrmObrasVisuais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmObrasVisuais));
            this.BtnFilmes = new System.Windows.Forms.Button();
            this.BtnAnimes = new System.Windows.Forms.Button();
            this.BtnSeries = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnFilmes
            // 
            this.BtnFilmes.Font = new System.Drawing.Font("SpellcasterW01-Regular", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFilmes.Location = new System.Drawing.Point(12, 12);
            this.BtnFilmes.Name = "BtnFilmes";
            this.BtnFilmes.Size = new System.Drawing.Size(360, 527);
            this.BtnFilmes.TabIndex = 0;
            this.BtnFilmes.Text = "Filmes";
            this.BtnFilmes.UseVisualStyleBackColor = true;
            this.BtnFilmes.Click += new System.EventHandler(this.BtnFilmes_Click);
            // 
            // BtnAnimes
            // 
            this.BtnAnimes.Font = new System.Drawing.Font("SpellcasterW01-Regular", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnimes.Location = new System.Drawing.Point(378, 12);
            this.BtnAnimes.Name = "BtnAnimes";
            this.BtnAnimes.Size = new System.Drawing.Size(360, 527);
            this.BtnAnimes.TabIndex = 1;
            this.BtnAnimes.Text = "Animes";
            this.BtnAnimes.UseVisualStyleBackColor = true;
            this.BtnAnimes.Click += new System.EventHandler(this.BtnAnimes_Click);
            // 
            // BtnSeries
            // 
            this.BtnSeries.Font = new System.Drawing.Font("SpellcasterW01-Regular", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeries.Location = new System.Drawing.Point(744, 12);
            this.BtnSeries.Name = "BtnSeries";
            this.BtnSeries.Size = new System.Drawing.Size(360, 527);
            this.BtnSeries.TabIndex = 2;
            this.BtnSeries.Text = "Séries";
            this.BtnSeries.UseVisualStyleBackColor = true;
            this.BtnSeries.Click += new System.EventHandler(this.BtnSeries_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("SpellcasterW01-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(12, 545);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(1092, 52);
            this.BtnVoltar.TabIndex = 4;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // FrmObrasVisuais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 609);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnSeries);
            this.Controls.Add(this.BtnAnimes);
            this.Controls.Add(this.BtnFilmes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmObrasVisuais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obras Visuais";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnFilmes;
        private System.Windows.Forms.Button BtnAnimes;
        private System.Windows.Forms.Button BtnSeries;
        private System.Windows.Forms.Button BtnVoltar;
    }
}