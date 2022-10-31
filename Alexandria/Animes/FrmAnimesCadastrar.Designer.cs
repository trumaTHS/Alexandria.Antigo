namespace Alexandria.Animes
{
    partial class FrmAnimesCadastrar
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
            this.TxtboxAnimeNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAnimesSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtboxAnimeNome
            // 
            this.TxtboxAnimeNome.Location = new System.Drawing.Point(407, 174);
            this.TxtboxAnimeNome.Name = "TxtboxAnimeNome";
            this.TxtboxAnimeNome.Size = new System.Drawing.Size(100, 20);
            this.TxtboxAnimeNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // BtnAnimesSalvar
            // 
            this.BtnAnimesSalvar.Location = new System.Drawing.Point(407, 245);
            this.BtnAnimesSalvar.Name = "BtnAnimesSalvar";
            this.BtnAnimesSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnAnimesSalvar.TabIndex = 2;
            this.BtnAnimesSalvar.Text = "button1";
            this.BtnAnimesSalvar.UseVisualStyleBackColor = true;
            this.BtnAnimesSalvar.Click += new System.EventHandler(this.BtnAnimesSalvar_Click);
            // 
            // FrmAnimesCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAnimesSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtboxAnimeNome);
            this.Name = "FrmAnimesCadastrar";
            this.Text = "FrmAnimesCadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtboxAnimeNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAnimesSalvar;
    }
}