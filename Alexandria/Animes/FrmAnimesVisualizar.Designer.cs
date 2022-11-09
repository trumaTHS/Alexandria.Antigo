namespace Alexandria.Animes
{
    partial class FrmAnimesVisualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnimesVisualizar));
            this.DataAnimes = new System.Windows.Forms.DataGridView();
            this.BtnAnimesUniversalismo = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataAnimes)).BeginInit();
            this.SuspendLayout();
            // 
            // DataAnimes
            // 
            this.DataAnimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataAnimes.Location = new System.Drawing.Point(12, 12);
            this.DataAnimes.Name = "DataAnimes";
            this.DataAnimes.Size = new System.Drawing.Size(1092, 524);
            this.DataAnimes.TabIndex = 0;
            // 
            // BtnAnimesUniversalismo
            // 
            this.BtnAnimesUniversalismo.Font = new System.Drawing.Font("SpellcasterW01-Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnimesUniversalismo.Location = new System.Drawing.Point(12, 542);
            this.BtnAnimesUniversalismo.Name = "BtnAnimesUniversalismo";
            this.BtnAnimesUniversalismo.Size = new System.Drawing.Size(924, 55);
            this.BtnAnimesUniversalismo.TabIndex = 1;
            this.BtnAnimesUniversalismo.Text = "Universalizar";
            this.BtnAnimesUniversalismo.UseVisualStyleBackColor = true;
            this.BtnAnimesUniversalismo.Click += new System.EventHandler(this.BtnAnimesUniversalismo_Click);
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
            // FrmAnimesVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 609);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnAnimesUniversalismo);
            this.Controls.Add(this.DataAnimes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnimesVisualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Animes";
            ((System.ComponentModel.ISupportInitialize)(this.DataAnimes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataAnimes;
        private System.Windows.Forms.Button BtnAnimesUniversalismo;
        private System.Windows.Forms.Button BtnVoltar;
    }
}