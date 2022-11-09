namespace Alexandria.Filmes
{
    partial class FrmFilmesVisualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFilmesVisualizar));
            this.DataFilmes = new System.Windows.Forms.DataGridView();
            this.BtnFilmesUniversalismo = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataFilmes)).BeginInit();
            this.SuspendLayout();
            // 
            // DataFilmes
            // 
            this.DataFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataFilmes.Location = new System.Drawing.Point(12, 12);
            this.DataFilmes.Name = "DataFilmes";
            this.DataFilmes.Size = new System.Drawing.Size(1092, 524);
            this.DataFilmes.TabIndex = 0;
            // 
            // BtnFilmesUniversalismo
            // 
            this.BtnFilmesUniversalismo.Font = new System.Drawing.Font("SpellcasterW01-Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFilmesUniversalismo.Location = new System.Drawing.Point(12, 542);
            this.BtnFilmesUniversalismo.Name = "BtnFilmesUniversalismo";
            this.BtnFilmesUniversalismo.Size = new System.Drawing.Size(924, 55);
            this.BtnFilmesUniversalismo.TabIndex = 1;
            this.BtnFilmesUniversalismo.Text = "Universalizar";
            this.BtnFilmesUniversalismo.UseVisualStyleBackColor = true;
            this.BtnFilmesUniversalismo.Click += new System.EventHandler(this.BtnFilmesUniversalismo_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("SpellcasterW01-Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(943, 542);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(161, 55);
            this.BtnVoltar.TabIndex = 2;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // FrmFilmesVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 609);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnFilmesUniversalismo);
            this.Controls.Add(this.DataFilmes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFilmesVisualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Filmes";
            ((System.ComponentModel.ISupportInitialize)(this.DataFilmes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataFilmes;
        private System.Windows.Forms.Button BtnFilmesUniversalismo;
        private System.Windows.Forms.Button BtnVoltar;
    }
}