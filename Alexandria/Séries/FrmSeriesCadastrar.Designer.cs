namespace Alexandria.Séries
{
    partial class FrmSeriesCadastrar
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtboxSerieNome = new System.Windows.Forms.TextBox();
            this.BtnSeriesSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // TxtboxSerieNome
            // 
            this.TxtboxSerieNome.Location = new System.Drawing.Point(302, 132);
            this.TxtboxSerieNome.Name = "TxtboxSerieNome";
            this.TxtboxSerieNome.Size = new System.Drawing.Size(100, 20);
            this.TxtboxSerieNome.TabIndex = 1;
            // 
            // BtnSeriesSalvar
            // 
            this.BtnSeriesSalvar.Location = new System.Drawing.Point(302, 223);
            this.BtnSeriesSalvar.Name = "BtnSeriesSalvar";
            this.BtnSeriesSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSeriesSalvar.TabIndex = 2;
            this.BtnSeriesSalvar.Text = "button1";
            this.BtnSeriesSalvar.UseVisualStyleBackColor = true;
            this.BtnSeriesSalvar.Click += new System.EventHandler(this.BtnSeriesSalvar_Click);
            // 
            // FrmSeriesCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSeriesSalvar);
            this.Controls.Add(this.TxtboxSerieNome);
            this.Controls.Add(this.label1);
            this.Name = "FrmSeriesCadastrar";
            this.Text = "FrmSeriesCadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtboxSerieNome;
        private System.Windows.Forms.Button BtnSeriesSalvar;
    }
}