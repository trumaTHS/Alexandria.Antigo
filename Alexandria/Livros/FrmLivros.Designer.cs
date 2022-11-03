namespace Alexandria
{
    partial class FrmLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLivros));
            this.BtnLivrosVisualizar = new System.Windows.Forms.Button();
            this.BtnLivrosCadastrar = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLivrosVisualizar
            // 
            this.BtnLivrosVisualizar.Font = new System.Drawing.Font("SpellcasterW01-Regular", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLivrosVisualizar.Location = new System.Drawing.Point(561, 12);
            this.BtnLivrosVisualizar.Name = "BtnLivrosVisualizar";
            this.BtnLivrosVisualizar.Size = new System.Drawing.Size(543, 527);
            this.BtnLivrosVisualizar.TabIndex = 0;
            this.BtnLivrosVisualizar.Text = "Visualizar";
            this.BtnLivrosVisualizar.UseVisualStyleBackColor = true;
            this.BtnLivrosVisualizar.Click += new System.EventHandler(this.BtnLivrosVisualizar_Click);
            // 
            // BtnLivrosCadastrar
            // 
            this.BtnLivrosCadastrar.Font = new System.Drawing.Font("SpellcasterW01-Regular", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLivrosCadastrar.Location = new System.Drawing.Point(12, 12);
            this.BtnLivrosCadastrar.Name = "BtnLivrosCadastrar";
            this.BtnLivrosCadastrar.Size = new System.Drawing.Size(543, 527);
            this.BtnLivrosCadastrar.TabIndex = 1;
            this.BtnLivrosCadastrar.Text = "Cadastrar";
            this.BtnLivrosCadastrar.UseVisualStyleBackColor = true;
            this.BtnLivrosCadastrar.Click += new System.EventHandler(this.BtnLivrosCadastrar_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("SpellcasterW01-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(12, 545);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(1092, 52);
            this.BtnVoltar.TabIndex = 4;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // FrmLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 609);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnLivrosCadastrar);
            this.Controls.Add(this.BtnLivrosVisualizar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Livros";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLivrosVisualizar;
        private System.Windows.Forms.Button BtnLivrosCadastrar;
        private System.Windows.Forms.Button BtnVoltar;
    }
}