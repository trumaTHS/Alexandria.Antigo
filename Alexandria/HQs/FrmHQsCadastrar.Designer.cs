namespace Alexandria.HQs
{
    partial class FrmHQsCadastrar
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
            this.TxtboxHQISBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnHQsSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtboxHQISBN
            // 
            this.TxtboxHQISBN.Location = new System.Drawing.Point(402, 170);
            this.TxtboxHQISBN.Name = "TxtboxHQISBN";
            this.TxtboxHQISBN.Size = new System.Drawing.Size(100, 20);
            this.TxtboxHQISBN.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // BtnHQsSalvar
            // 
            this.BtnHQsSalvar.Location = new System.Drawing.Point(405, 259);
            this.BtnHQsSalvar.Name = "BtnHQsSalvar";
            this.BtnHQsSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnHQsSalvar.TabIndex = 2;
            this.BtnHQsSalvar.Text = "button1";
            this.BtnHQsSalvar.UseVisualStyleBackColor = true;
            this.BtnHQsSalvar.Click += new System.EventHandler(this.BtnHQsSalvar_Click);
            // 
            // FrmHQsCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnHQsSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtboxHQISBN);
            this.Name = "FrmHQsCadastrar";
            this.Text = "FrmHQsCadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtboxHQISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnHQsSalvar;
    }
}