namespace Alexandria
{
    partial class FrmObrasFisicas
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
            this.BtnLivros = new System.Windows.Forms.Button();
            this.BtnMangas = new System.Windows.Forms.Button();
            this.BtnHQs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLivros
            // 
            this.BtnLivros.Location = new System.Drawing.Point(272, 79);
            this.BtnLivros.Name = "BtnLivros";
            this.BtnLivros.Size = new System.Drawing.Size(221, 23);
            this.BtnLivros.TabIndex = 0;
            this.BtnLivros.Text = "Livros";
            this.BtnLivros.UseVisualStyleBackColor = true;
            this.BtnLivros.Click += new System.EventHandler(this.BtnLivros_Click);
            // 
            // BtnMangas
            // 
            this.BtnMangas.Location = new System.Drawing.Point(272, 146);
            this.BtnMangas.Name = "BtnMangas";
            this.BtnMangas.Size = new System.Drawing.Size(221, 23);
            this.BtnMangas.TabIndex = 1;
            this.BtnMangas.Text = "Mangás";
            this.BtnMangas.UseVisualStyleBackColor = true;
            this.BtnMangas.Click += new System.EventHandler(this.BtnMangas_Click);
            // 
            // BtnHQs
            // 
            this.BtnHQs.Location = new System.Drawing.Point(272, 210);
            this.BtnHQs.Name = "BtnHQs";
            this.BtnHQs.Size = new System.Drawing.Size(221, 23);
            this.BtnHQs.TabIndex = 2;
            this.BtnHQs.Text = "HQs";
            this.BtnHQs.UseVisualStyleBackColor = true;
            this.BtnHQs.Click += new System.EventHandler(this.BtnHQs_Click);
            // 
            // FrmObrasFisicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnHQs);
            this.Controls.Add(this.BtnMangas);
            this.Controls.Add(this.BtnLivros);
            this.Name = "FrmObrasFisicas";
            this.Text = "Obras Físicas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLivros;
        private System.Windows.Forms.Button BtnMangas;
        private System.Windows.Forms.Button BtnHQs;
    }
}