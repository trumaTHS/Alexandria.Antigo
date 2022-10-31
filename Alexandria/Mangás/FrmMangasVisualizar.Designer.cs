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
            this.DataMangas = new System.Windows.Forms.DataGridView();
            this.BtnMangasUniversalismo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataMangas)).BeginInit();
            this.SuspendLayout();
            // 
            // DataMangas
            // 
            this.DataMangas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataMangas.Location = new System.Drawing.Point(396, 136);
            this.DataMangas.Name = "DataMangas";
            this.DataMangas.Size = new System.Drawing.Size(240, 150);
            this.DataMangas.TabIndex = 0;
            // 
            // BtnMangasUniversalismo
            // 
            this.BtnMangasUniversalismo.Location = new System.Drawing.Point(447, 321);
            this.BtnMangasUniversalismo.Name = "BtnMangasUniversalismo";
            this.BtnMangasUniversalismo.Size = new System.Drawing.Size(75, 23);
            this.BtnMangasUniversalismo.TabIndex = 1;
            this.BtnMangasUniversalismo.Text = "button1";
            this.BtnMangasUniversalismo.UseVisualStyleBackColor = true;
            this.BtnMangasUniversalismo.Click += new System.EventHandler(this.BtnMangasUniversalismo_Click);
            // 
            // FrmMangasVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnMangasUniversalismo);
            this.Controls.Add(this.DataMangas);
            this.Name = "FrmMangasVisualizar";
            this.Text = "FrmMangasVisualizar";
            ((System.ComponentModel.ISupportInitialize)(this.DataMangas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataMangas;
        private System.Windows.Forms.Button BtnMangasUniversalismo;
    }
}