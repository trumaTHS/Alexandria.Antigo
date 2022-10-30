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
            this.BtnHQsCadastrar = new System.Windows.Forms.Button();
            this.BtnHQsVisualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnHQsCadastrar
            // 
            this.BtnHQsCadastrar.Location = new System.Drawing.Point(273, 98);
            this.BtnHQsCadastrar.Name = "BtnHQsCadastrar";
            this.BtnHQsCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnHQsCadastrar.TabIndex = 0;
            this.BtnHQsCadastrar.Text = "button1";
            this.BtnHQsCadastrar.UseVisualStyleBackColor = true;
            this.BtnHQsCadastrar.Click += new System.EventHandler(this.BtnHQsCadastrar_Click);
            // 
            // BtnHQsVisualizar
            // 
            this.BtnHQsVisualizar.Location = new System.Drawing.Point(564, 127);
            this.BtnHQsVisualizar.Name = "BtnHQsVisualizar";
            this.BtnHQsVisualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnHQsVisualizar.TabIndex = 1;
            this.BtnHQsVisualizar.Text = "button2";
            this.BtnHQsVisualizar.UseVisualStyleBackColor = true;
            this.BtnHQsVisualizar.Click += new System.EventHandler(this.BtnHQsVisualizar_Click);
            // 
            // FrmHQs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnHQsVisualizar);
            this.Controls.Add(this.BtnHQsCadastrar);
            this.Name = "FrmHQs";
            this.Text = "FrmHQs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnHQsCadastrar;
        private System.Windows.Forms.Button BtnHQsVisualizar;
    }
}