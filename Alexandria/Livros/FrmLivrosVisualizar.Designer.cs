namespace Alexandria
{
    partial class FrmLivrosVisualizar
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
            this.DataLivros = new System.Windows.Forms.DataGridView();
            this.BtnLivrosUniversalismo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // DataLivros
            // 
            this.DataLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataLivros.Location = new System.Drawing.Point(46, 32);
            this.DataLivros.Name = "DataLivros";
            this.DataLivros.Size = new System.Drawing.Size(944, 454);
            this.DataLivros.TabIndex = 0;
            // 
            // BtnLivrosUniversalismo
            // 
            this.BtnLivrosUniversalismo.Location = new System.Drawing.Point(462, 510);
            this.BtnLivrosUniversalismo.Name = "BtnLivrosUniversalismo";
            this.BtnLivrosUniversalismo.Size = new System.Drawing.Size(75, 23);
            this.BtnLivrosUniversalismo.TabIndex = 1;
            this.BtnLivrosUniversalismo.Text = "button1";
            this.BtnLivrosUniversalismo.UseVisualStyleBackColor = true;
            this.BtnLivrosUniversalismo.Click += new System.EventHandler(this.BtnLivrosUniversalismo_Click);
            // 
            // FrmLivrosVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 551);
            this.Controls.Add(this.BtnLivrosUniversalismo);
            this.Controls.Add(this.DataLivros);
            this.Name = "FrmLivrosVisualizar";
            this.Text = "FrmLivrosVisualizar";
            ((System.ComponentModel.ISupportInitialize)(this.DataLivros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataLivros;
        private System.Windows.Forms.Button BtnLivrosUniversalismo;
    }
}