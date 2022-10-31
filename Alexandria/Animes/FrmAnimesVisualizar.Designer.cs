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
            this.DataAnimes = new System.Windows.Forms.DataGridView();
            this.BtnAnimesUniversalismo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataAnimes)).BeginInit();
            this.SuspendLayout();
            // 
            // DataAnimes
            // 
            this.DataAnimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataAnimes.Location = new System.Drawing.Point(279, 87);
            this.DataAnimes.Name = "DataAnimes";
            this.DataAnimes.Size = new System.Drawing.Size(240, 150);
            this.DataAnimes.TabIndex = 0;
            // 
            // BtnAnimesUniversalismo
            // 
            this.BtnAnimesUniversalismo.Location = new System.Drawing.Point(406, 274);
            this.BtnAnimesUniversalismo.Name = "BtnAnimesUniversalismo";
            this.BtnAnimesUniversalismo.Size = new System.Drawing.Size(75, 23);
            this.BtnAnimesUniversalismo.TabIndex = 1;
            this.BtnAnimesUniversalismo.Text = "button1";
            this.BtnAnimesUniversalismo.UseVisualStyleBackColor = true;
            this.BtnAnimesUniversalismo.Click += new System.EventHandler(this.BtnAnimesUniversalismo_Click);
            // 
            // FrmAnimesVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAnimesUniversalismo);
            this.Controls.Add(this.DataAnimes);
            this.Name = "FrmAnimesVisualizar";
            this.Text = "FrmAnimesVisualizar";
            ((System.ComponentModel.ISupportInitialize)(this.DataAnimes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataAnimes;
        private System.Windows.Forms.Button BtnAnimesUniversalismo;
    }
}