namespace Alexandria.Botões
{
    partial class FrmAnimes
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
            this.BtnAnimesCadastrar = new System.Windows.Forms.Button();
            this.BtnAnimesVisualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAnimesCadastrar
            // 
            this.BtnAnimesCadastrar.Location = new System.Drawing.Point(205, 112);
            this.BtnAnimesCadastrar.Name = "BtnAnimesCadastrar";
            this.BtnAnimesCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnAnimesCadastrar.TabIndex = 0;
            this.BtnAnimesCadastrar.Text = "button1";
            this.BtnAnimesCadastrar.UseVisualStyleBackColor = true;
            this.BtnAnimesCadastrar.Click += new System.EventHandler(this.BtnAnimesCadastrar_Click);
            // 
            // BtnAnimesVisualizar
            // 
            this.BtnAnimesVisualizar.Location = new System.Drawing.Point(502, 112);
            this.BtnAnimesVisualizar.Name = "BtnAnimesVisualizar";
            this.BtnAnimesVisualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnAnimesVisualizar.TabIndex = 1;
            this.BtnAnimesVisualizar.Text = "button2";
            this.BtnAnimesVisualizar.UseVisualStyleBackColor = true;
            this.BtnAnimesVisualizar.Click += new System.EventHandler(this.BtnAnimesVisualizar_Click);
            // 
            // FrmAnimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAnimesVisualizar);
            this.Controls.Add(this.BtnAnimesCadastrar);
            this.Name = "FrmAnimes";
            this.Text = "FrmAnimes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAnimesCadastrar;
        private System.Windows.Forms.Button BtnAnimesVisualizar;
    }
}