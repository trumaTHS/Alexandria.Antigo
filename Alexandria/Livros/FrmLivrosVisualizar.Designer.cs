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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLivrosVisualizar));
            this.DataLivros = new System.Windows.Forms.DataGridView();
            this.BtnLivrosUniversalismo = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // DataLivros
            // 
            this.DataLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataLivros.Location = new System.Drawing.Point(12, 12);
            this.DataLivros.Name = "DataLivros";
            this.DataLivros.Size = new System.Drawing.Size(1092, 524);
            this.DataLivros.TabIndex = 0;
            // 
            // BtnLivrosUniversalismo
            // 
            this.BtnLivrosUniversalismo.Font = new System.Drawing.Font("SpellcasterW01-Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLivrosUniversalismo.Location = new System.Drawing.Point(12, 542);
            this.BtnLivrosUniversalismo.Name = "BtnLivrosUniversalismo";
            this.BtnLivrosUniversalismo.Size = new System.Drawing.Size(924, 55);
            this.BtnLivrosUniversalismo.TabIndex = 1;
            this.BtnLivrosUniversalismo.Text = "Universalizar";
            this.BtnLivrosUniversalismo.UseVisualStyleBackColor = true;
            this.BtnLivrosUniversalismo.Click += new System.EventHandler(this.BtnLivrosUniversalismo_Click);
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
            // FrmLivrosVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 609);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnLivrosUniversalismo);
            this.Controls.Add(this.DataLivros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLivrosVisualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Livros";
            ((System.ComponentModel.ISupportInitialize)(this.DataLivros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataLivros;
        private System.Windows.Forms.Button BtnLivrosUniversalismo;
        private System.Windows.Forms.Button BtnVoltar;
    }
}