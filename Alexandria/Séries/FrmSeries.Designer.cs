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
            this.BtnSeriesCadastrar = new System.Windows.Forms.Button();
            this.BtnSeriesVisualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSeriesCadastrar
            // 
            this.BtnSeriesCadastrar.Location = new System.Drawing.Point(183, 137);
            this.BtnSeriesCadastrar.Name = "BtnSeriesCadastrar";
            this.BtnSeriesCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnSeriesCadastrar.TabIndex = 0;
            this.BtnSeriesCadastrar.Text = "button1";
            this.BtnSeriesCadastrar.UseVisualStyleBackColor = true;
            this.BtnSeriesCadastrar.Click += new System.EventHandler(this.BtnSeriesCadastrar_Click);
            // 
            // BtnSeriesVisualizar
            // 
            this.BtnSeriesVisualizar.Location = new System.Drawing.Point(557, 136);
            this.BtnSeriesVisualizar.Name = "BtnSeriesVisualizar";
            this.BtnSeriesVisualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnSeriesVisualizar.TabIndex = 1;
            this.BtnSeriesVisualizar.Text = "button2";
            this.BtnSeriesVisualizar.UseVisualStyleBackColor = true;
            this.BtnSeriesVisualizar.Click += new System.EventHandler(this.BtnSeriesVisualizar_Click);
            // 
            // FrmSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSeriesVisualizar);
            this.Controls.Add(this.BtnSeriesCadastrar);
            this.Name = "FrmSeries";
            this.Text = "FrmSeries";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSeriesCadastrar;
        private System.Windows.Forms.Button BtnSeriesVisualizar;
    }
}