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
            this.DataFilmes = new System.Windows.Forms.DataGridView();
            this.BtnFilmesUniversalismo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataFilmes)).BeginInit();
            this.SuspendLayout();
            // 
            // DataFilmes
            // 
            this.DataFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataFilmes.Location = new System.Drawing.Point(252, 121);
            this.DataFilmes.Name = "DataFilmes";
            this.DataFilmes.Size = new System.Drawing.Size(240, 150);
            this.DataFilmes.TabIndex = 0;
            // 
            // BtnFilmesUniversalismo
            // 
            this.BtnFilmesUniversalismo.Location = new System.Drawing.Point(341, 313);
            this.BtnFilmesUniversalismo.Name = "BtnFilmesUniversalismo";
            this.BtnFilmesUniversalismo.Size = new System.Drawing.Size(75, 23);
            this.BtnFilmesUniversalismo.TabIndex = 1;
            this.BtnFilmesUniversalismo.Text = "button1";
            this.BtnFilmesUniversalismo.UseVisualStyleBackColor = true;
            this.BtnFilmesUniversalismo.Click += new System.EventHandler(this.BtnFilmesUniversalismo_Click);
            // 
            // FrmFilmesVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnFilmesUniversalismo);
            this.Controls.Add(this.DataFilmes);
            this.Name = "FrmFilmesVisualizar";
            this.Text = "FrmFilmesVisualizar";
            ((System.ComponentModel.ISupportInitialize)(this.DataFilmes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataFilmes;
        private System.Windows.Forms.Button BtnFilmesUniversalismo;
    }
}