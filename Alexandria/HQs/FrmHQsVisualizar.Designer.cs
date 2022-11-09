namespace Alexandria.HQs
{
    partial class FrmHQsVisualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHQsVisualizar));
            this.DataHQs = new System.Windows.Forms.DataGridView();
            this.BtnHQsUniversalismo = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataHQs)).BeginInit();
            this.SuspendLayout();
            // 
            // DataHQs
            // 
            this.DataHQs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataHQs.Location = new System.Drawing.Point(12, 12);
            this.DataHQs.Name = "DataHQs";
            this.DataHQs.Size = new System.Drawing.Size(1092, 524);
            this.DataHQs.TabIndex = 0;
            // 
            // BtnHQsUniversalismo
            // 
            this.BtnHQsUniversalismo.Font = new System.Drawing.Font("SpellcasterW01-Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHQsUniversalismo.Location = new System.Drawing.Point(12, 542);
            this.BtnHQsUniversalismo.Name = "BtnHQsUniversalismo";
            this.BtnHQsUniversalismo.Size = new System.Drawing.Size(924, 55);
            this.BtnHQsUniversalismo.TabIndex = 1;
            this.BtnHQsUniversalismo.Text = "Universalizar";
            this.BtnHQsUniversalismo.UseVisualStyleBackColor = true;
            this.BtnHQsUniversalismo.Click += new System.EventHandler(this.BtnHQsUniversalismo_Click);
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
            // FrmHQsVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 609);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnHQsUniversalismo);
            this.Controls.Add(this.DataHQs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHQsVisualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar HQs";
            ((System.ComponentModel.ISupportInitialize)(this.DataHQs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataHQs;
        private System.Windows.Forms.Button BtnHQsUniversalismo;
        private System.Windows.Forms.Button BtnVoltar;
    }
}