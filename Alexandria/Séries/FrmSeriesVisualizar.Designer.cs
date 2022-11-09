namespace Alexandria.Séries
{
    partial class FrmSeriesVisualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeriesVisualizar));
            this.DataSeries = new System.Windows.Forms.DataGridView();
            this.BtnSeriesUniversalismo = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataSeries)).BeginInit();
            this.SuspendLayout();
            // 
            // DataSeries
            // 
            this.DataSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataSeries.Location = new System.Drawing.Point(12, 12);
            this.DataSeries.Name = "DataSeries";
            this.DataSeries.Size = new System.Drawing.Size(1092, 524);
            this.DataSeries.TabIndex = 0;
            // 
            // BtnSeriesUniversalismo
            // 
            this.BtnSeriesUniversalismo.Font = new System.Drawing.Font("SpellcasterW01-Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeriesUniversalismo.Location = new System.Drawing.Point(12, 542);
            this.BtnSeriesUniversalismo.Name = "BtnSeriesUniversalismo";
            this.BtnSeriesUniversalismo.Size = new System.Drawing.Size(924, 55);
            this.BtnSeriesUniversalismo.TabIndex = 1;
            this.BtnSeriesUniversalismo.Text = "Universalizar";
            this.BtnSeriesUniversalismo.UseVisualStyleBackColor = true;
            this.BtnSeriesUniversalismo.Click += new System.EventHandler(this.BtnSeriesUniversalismo_Click);
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
            // FrmSeriesVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 609);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnSeriesUniversalismo);
            this.Controls.Add(this.DataSeries);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSeriesVisualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Séries";
            ((System.ComponentModel.ISupportInitialize)(this.DataSeries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataSeries;
        private System.Windows.Forms.Button BtnSeriesUniversalismo;
        private System.Windows.Forms.Button BtnVoltar;
    }
}