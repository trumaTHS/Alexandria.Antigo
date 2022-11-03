namespace Alexandria.Botões
{
    partial class FrmSeries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeries));
            this.BtnSeriesCadastrar = new System.Windows.Forms.Button();
            this.BtnSeriesVisualizar = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSeriesCadastrar
            // 
            this.BtnSeriesCadastrar.Font = new System.Drawing.Font("SpellcasterW01-Regular", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeriesCadastrar.Location = new System.Drawing.Point(12, 12);
            this.BtnSeriesCadastrar.Name = "BtnSeriesCadastrar";
            this.BtnSeriesCadastrar.Size = new System.Drawing.Size(543, 527);
            this.BtnSeriesCadastrar.TabIndex = 0;
            this.BtnSeriesCadastrar.Text = "Cadastrar";
            this.BtnSeriesCadastrar.UseVisualStyleBackColor = true;
            this.BtnSeriesCadastrar.Click += new System.EventHandler(this.BtnSeriesCadastrar_Click);
            // 
            // BtnSeriesVisualizar
            // 
            this.BtnSeriesVisualizar.Font = new System.Drawing.Font("SpellcasterW01-Regular", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeriesVisualizar.Location = new System.Drawing.Point(561, 12);
            this.BtnSeriesVisualizar.Name = "BtnSeriesVisualizar";
            this.BtnSeriesVisualizar.Size = new System.Drawing.Size(543, 527);
            this.BtnSeriesVisualizar.TabIndex = 1;
            this.BtnSeriesVisualizar.Text = "Visualizar";
            this.BtnSeriesVisualizar.UseVisualStyleBackColor = true;
            this.BtnSeriesVisualizar.Click += new System.EventHandler(this.BtnSeriesVisualizar_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("SpellcasterW01-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(12, 545);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(1092, 52);
            this.BtnVoltar.TabIndex = 5;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // FrmSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 609);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnSeriesVisualizar);
            this.Controls.Add(this.BtnSeriesCadastrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSeries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Séries";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSeriesCadastrar;
        private System.Windows.Forms.Button BtnSeriesVisualizar;
        private System.Windows.Forms.Button BtnVoltar;
    }
}