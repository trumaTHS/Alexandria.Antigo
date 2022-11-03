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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmObrasFisicas));
            this.BtnLivros = new System.Windows.Forms.Button();
            this.BtnMangas = new System.Windows.Forms.Button();
            this.BtnHQs = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLivros
            // 
            this.BtnLivros.Font = new System.Drawing.Font("SpellcasterW01-Regular", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLivros.Location = new System.Drawing.Point(12, 12);
            this.BtnLivros.Name = "BtnLivros";
            this.BtnLivros.Size = new System.Drawing.Size(360, 527);
            this.BtnLivros.TabIndex = 0;
            this.BtnLivros.Text = "Livros";
            this.BtnLivros.UseVisualStyleBackColor = true;
            this.BtnLivros.Click += new System.EventHandler(this.BtnLivros_Click);
            // 
            // BtnMangas
            // 
            this.BtnMangas.Font = new System.Drawing.Font("SpellcasterW01-Regular", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMangas.Location = new System.Drawing.Point(378, 12);
            this.BtnMangas.Name = "BtnMangas";
            this.BtnMangas.Size = new System.Drawing.Size(360, 527);
            this.BtnMangas.TabIndex = 1;
            this.BtnMangas.Text = "Mangás";
            this.BtnMangas.UseVisualStyleBackColor = true;
            this.BtnMangas.Click += new System.EventHandler(this.BtnMangas_Click);
            // 
            // BtnHQs
            // 
            this.BtnHQs.Font = new System.Drawing.Font("SpellcasterW01-Regular", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHQs.Location = new System.Drawing.Point(744, 12);
            this.BtnHQs.Name = "BtnHQs";
            this.BtnHQs.Size = new System.Drawing.Size(360, 527);
            this.BtnHQs.TabIndex = 2;
            this.BtnHQs.Text = "HQs";
            this.BtnHQs.UseVisualStyleBackColor = true;
            this.BtnHQs.Click += new System.EventHandler(this.BtnHQs_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("SpellcasterW01-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(12, 545);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(1092, 52);
            this.BtnVoltar.TabIndex = 3;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // FrmObrasFisicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 609);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnHQs);
            this.Controls.Add(this.BtnMangas);
            this.Controls.Add(this.BtnLivros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmObrasFisicas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obras Físicas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLivros;
        private System.Windows.Forms.Button BtnMangas;
        private System.Windows.Forms.Button BtnHQs;
        private System.Windows.Forms.Button BtnVoltar;
    }
}