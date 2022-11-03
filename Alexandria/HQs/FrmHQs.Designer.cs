namespace Alexandria.Botões
{
    partial class FrmHQs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHQs));
            this.BtnHQsCadastrar = new System.Windows.Forms.Button();
            this.BtnHQsVisualizar = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnHQsCadastrar
            // 
            this.BtnHQsCadastrar.Font = new System.Drawing.Font("SpellcasterW01-Regular", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHQsCadastrar.Location = new System.Drawing.Point(12, 12);
            this.BtnHQsCadastrar.Name = "BtnHQsCadastrar";
            this.BtnHQsCadastrar.Size = new System.Drawing.Size(543, 527);
            this.BtnHQsCadastrar.TabIndex = 0;
            this.BtnHQsCadastrar.Text = "Cadastrar";
            this.BtnHQsCadastrar.UseVisualStyleBackColor = true;
            this.BtnHQsCadastrar.Click += new System.EventHandler(this.BtnHQsCadastrar_Click);
            // 
            // BtnHQsVisualizar
            // 
            this.BtnHQsVisualizar.Font = new System.Drawing.Font("SpellcasterW01-Regular", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHQsVisualizar.Location = new System.Drawing.Point(561, 12);
            this.BtnHQsVisualizar.Name = "BtnHQsVisualizar";
            this.BtnHQsVisualizar.Size = new System.Drawing.Size(543, 527);
            this.BtnHQsVisualizar.TabIndex = 1;
            this.BtnHQsVisualizar.Text = "Visualizar";
            this.BtnHQsVisualizar.UseVisualStyleBackColor = true;
            this.BtnHQsVisualizar.Click += new System.EventHandler(this.BtnHQsVisualizar_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("SpellcasterW01-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(12, 545);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(1092, 52);
            this.BtnVoltar.TabIndex = 5;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // FrmHQs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 609);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnHQsVisualizar);
            this.Controls.Add(this.BtnHQsCadastrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHQs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HQs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnHQsCadastrar;
        private System.Windows.Forms.Button BtnHQsVisualizar;
        private System.Windows.Forms.Button BtnVoltar;
    }
}