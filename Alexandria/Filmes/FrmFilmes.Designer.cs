namespace Alexandria.Botões
{
    partial class FrmFilmes
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
            this.BtnFilmesCadastrar = new System.Windows.Forms.Button();
            this.BtnFilmesVisualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnFilmesCadastrar
            // 
            this.BtnFilmesCadastrar.Location = new System.Drawing.Point(187, 117);
            this.BtnFilmesCadastrar.Name = "BtnFilmesCadastrar";
            this.BtnFilmesCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnFilmesCadastrar.TabIndex = 0;
            this.BtnFilmesCadastrar.Text = "button1";
            this.BtnFilmesCadastrar.UseVisualStyleBackColor = true;
            this.BtnFilmesCadastrar.Click += new System.EventHandler(this.BtnFilmesCadastrar_Click);
            // 
            // BtnFilmesVisualizar
            // 
            this.BtnFilmesVisualizar.Location = new System.Drawing.Point(566, 116);
            this.BtnFilmesVisualizar.Name = "BtnFilmesVisualizar";
            this.BtnFilmesVisualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnFilmesVisualizar.TabIndex = 1;
            this.BtnFilmesVisualizar.Text = "button2";
            this.BtnFilmesVisualizar.UseVisualStyleBackColor = true;
            this.BtnFilmesVisualizar.Click += new System.EventHandler(this.BtnFilmesVisualizar_Click);
            // 
            // FrmFilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnFilmesVisualizar);
            this.Controls.Add(this.BtnFilmesCadastrar);
            this.Name = "FrmFilmes";
            this.Text = "FrmFilmes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnFilmesCadastrar;
        private System.Windows.Forms.Button BtnFilmesVisualizar;
    }
}