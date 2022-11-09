namespace Alexandria.Livros
{
    partial class FrmMangasVisualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMangasVisualizar));
            this.DataMangas = new System.Windows.Forms.DataGridView();
            this.BtnMangasUniversalismo = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataMangas)).BeginInit();
            this.SuspendLayout();
            // 
            // DataMangas
            // 
            this.DataMangas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataMangas.Location = new System.Drawing.Point(12, 12);
            this.DataMangas.Name = "DataMangas";
            this.DataMangas.Size = new System.Drawing.Size(1092, 524);
            this.DataMangas.TabIndex = 0;
            // 
            // BtnMangasUniversalismo
            // 
            this.BtnMangasUniversalismo.Font = new System.Drawing.Font("SpellcasterW01-Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMangasUniversalismo.Location = new System.Drawing.Point(12, 542);
            this.BtnMangasUniversalismo.Name = "BtnMangasUniversalismo";
            this.BtnMangasUniversalismo.Size = new System.Drawing.Size(924, 55);
            this.BtnMangasUniversalismo.TabIndex = 1;
            this.BtnMangasUniversalismo.Text = "Universalizar";
            this.BtnMangasUniversalismo.UseVisualStyleBackColor = true;
            this.BtnMangasUniversalismo.Click += new System.EventHandler(this.BtnMangasUniversalismo_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("SpellcasterW01-Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(943, 542);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(161, 55);
            this.BtnVoltar.TabIndex = 3;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // FrmMangasVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 609);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnMangasUniversalismo);
            this.Controls.Add(this.DataMangas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMangasVisualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Mangás";
            ((System.ComponentModel.ISupportInitialize)(this.DataMangas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataMangas;
        private System.Windows.Forms.Button BtnMangasUniversalismo;
        private System.Windows.Forms.Button BtnVoltar;
    }
}