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
            this.BtnFilmes = new System.Windows.Forms.Button();
            this.BtnAnimes = new System.Windows.Forms.Button();
            this.BtnSeries = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnFilmes
            // 
            this.BtnFilmes.Location = new System.Drawing.Point(308, 85);
            this.BtnFilmes.Name = "BtnFilmes";
            this.BtnFilmes.Size = new System.Drawing.Size(188, 23);
            this.BtnFilmes.TabIndex = 0;
            this.BtnFilmes.Text = "Filmes";
            this.BtnFilmes.UseVisualStyleBackColor = true;
            this.BtnFilmes.Click += new System.EventHandler(this.BtnFilmes_Click);
            // 
            // BtnAnimes
            // 
            this.BtnAnimes.Location = new System.Drawing.Point(308, 158);
            this.BtnAnimes.Name = "BtnAnimes";
            this.BtnAnimes.Size = new System.Drawing.Size(188, 23);
            this.BtnAnimes.TabIndex = 1;
            this.BtnAnimes.Text = "Animes";
            this.BtnAnimes.UseVisualStyleBackColor = true;
            this.BtnAnimes.Click += new System.EventHandler(this.BtnAnimes_Click);
            // 
            // BtnSeries
            // 
            this.BtnSeries.Location = new System.Drawing.Point(308, 231);
            this.BtnSeries.Name = "BtnSeries";
            this.BtnSeries.Size = new System.Drawing.Size(188, 23);
            this.BtnSeries.TabIndex = 2;
            this.BtnSeries.Text = "Séries";
            this.BtnSeries.UseVisualStyleBackColor = true;
            this.BtnSeries.Click += new System.EventHandler(this.BtnSeries_Click);
            // 
            // FrmObrasVisuais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSeries);
            this.Controls.Add(this.BtnAnimes);
            this.Controls.Add(this.BtnFilmes);
            this.Name = "FrmObrasVisuais";
            this.Text = "Obras Visuais";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnFilmes;
        private System.Windows.Forms.Button BtnAnimes;
        private System.Windows.Forms.Button BtnSeries;
    }
}