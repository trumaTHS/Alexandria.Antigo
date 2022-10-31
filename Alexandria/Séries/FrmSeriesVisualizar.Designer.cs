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
            this.DataSeries = new System.Windows.Forms.DataGridView();
            this.BtnSeriesUniversalismo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataSeries)).BeginInit();
            this.SuspendLayout();
            // 
            // DataSeries
            // 
            this.DataSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataSeries.Location = new System.Drawing.Point(308, 108);
            this.DataSeries.Name = "DataSeries";
            this.DataSeries.Size = new System.Drawing.Size(240, 150);
            this.DataSeries.TabIndex = 0;
            // 
            // BtnSeriesUniversalismo
            // 
            this.BtnSeriesUniversalismo.Location = new System.Drawing.Point(326, 313);
            this.BtnSeriesUniversalismo.Name = "BtnSeriesUniversalismo";
            this.BtnSeriesUniversalismo.Size = new System.Drawing.Size(75, 23);
            this.BtnSeriesUniversalismo.TabIndex = 1;
            this.BtnSeriesUniversalismo.Text = "button1";
            this.BtnSeriesUniversalismo.UseVisualStyleBackColor = true;
            this.BtnSeriesUniversalismo.Click += new System.EventHandler(this.BtnSeriesUniversalismo_Click);
            // 
            // FrmSeriesVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSeriesUniversalismo);
            this.Controls.Add(this.DataSeries);
            this.Name = "FrmSeriesVisualizar";
            this.Text = "FrmSeriesVisualizar";
            ((System.ComponentModel.ISupportInitialize)(this.DataSeries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataSeries;
        private System.Windows.Forms.Button BtnSeriesUniversalismo;
    }
}