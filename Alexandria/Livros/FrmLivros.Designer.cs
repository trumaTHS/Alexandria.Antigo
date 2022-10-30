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
            this.BtnLivrosVisualizar = new System.Windows.Forms.Button();
            this.BtnLivrosCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLivrosVisualizar
            // 
            this.BtnLivrosVisualizar.Location = new System.Drawing.Point(540, 130);
            this.BtnLivrosVisualizar.Name = "BtnLivrosVisualizar";
            this.BtnLivrosVisualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnLivrosVisualizar.TabIndex = 0;
            this.BtnLivrosVisualizar.Text = "Visualizar";
            this.BtnLivrosVisualizar.UseVisualStyleBackColor = true;
            this.BtnLivrosVisualizar.Click += new System.EventHandler(this.BtnLivrosVisualizar_Click);
            // 
            // BtnLivrosCadastrar
            // 
            this.BtnLivrosCadastrar.Location = new System.Drawing.Point(210, 119);
            this.BtnLivrosCadastrar.Name = "BtnLivrosCadastrar";
            this.BtnLivrosCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnLivrosCadastrar.TabIndex = 1;
            this.BtnLivrosCadastrar.Text = "Cadastrar";
            this.BtnLivrosCadastrar.UseVisualStyleBackColor = true;
            this.BtnLivrosCadastrar.Click += new System.EventHandler(this.BtnLivrosCadastrar_Click);
            // 
            // FrmLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLivrosCadastrar);
            this.Controls.Add(this.BtnLivrosVisualizar);
            this.Name = "FrmLivros";
            this.Text = "FrmLivros";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLivrosVisualizar;
        private System.Windows.Forms.Button BtnLivrosCadastrar;
    }
}