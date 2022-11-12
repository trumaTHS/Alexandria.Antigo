namespace Alexandria
{
    partial class FrmInicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.PicMonstro = new System.Windows.Forms.PictureBox();
            this.LabNome = new System.Windows.Forms.Label();
            this.LabTitulo = new System.Windows.Forms.Label();
            this.TimerInicio = new System.Windows.Forms.Timer(this.components);
            this.ProbarInicio = new System.Windows.Forms.ProgressBar();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.BtnDesconhecido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicMonstro)).BeginInit();
            this.SuspendLayout();
            // 
            // PicMonstro
            // 
            this.PicMonstro.Image = global::Alexandria.Properties.Resources.monstro;
            this.PicMonstro.Location = new System.Drawing.Point(12, 95);
            this.PicMonstro.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.PicMonstro.Name = "PicMonstro";
            this.PicMonstro.Size = new System.Drawing.Size(650, 217);
            this.PicMonstro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicMonstro.TabIndex = 0;
            this.PicMonstro.TabStop = false;
            // 
            // LabNome
            // 
            this.LabNome.AutoSize = true;
            this.LabNome.Font = new System.Drawing.Font("Beyond Wonderland", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabNome.Location = new System.Drawing.Point(248, 28);
            this.LabNome.Name = "LabNome";
            this.LabNome.Size = new System.Drawing.Size(179, 41);
            this.LabNome.TabIndex = 1;
            this.LabNome.Text = "Alexandria";
            // 
            // LabTitulo
            // 
            this.LabTitulo.AutoSize = true;
            this.LabTitulo.Font = new System.Drawing.Font("Beyond Wonderland", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTitulo.Location = new System.Drawing.Point(110, 69);
            this.LabTitulo.Name = "LabTitulo";
            this.LabTitulo.Size = new System.Drawing.Size(454, 39);
            this.LabTitulo.TabIndex = 2;
            this.LabTitulo.Text = "A Biblioteca Completa das Obras";
            // 
            // TimerInicio
            // 
            this.TimerInicio.Enabled = true;
            this.TimerInicio.Tick += new System.EventHandler(this.TimerInicio_Tick);
            // 
            // ProbarInicio
            // 
            this.ProbarInicio.Location = new System.Drawing.Point(117, 298);
            this.ProbarInicio.Name = "ProbarInicio";
            this.ProbarInicio.Size = new System.Drawing.Size(447, 23);
            this.ProbarInicio.TabIndex = 3;
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.Location = new System.Drawing.Point(255, 327);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(172, 66);
            this.BtnEntrar.TabIndex = 4;
            this.BtnEntrar.Text = "Entrar";
            this.BtnEntrar.UseVisualStyleBackColor = true;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // BtnDesconhecido
            // 
            this.BtnDesconhecido.Font = new System.Drawing.Font("Beyond Wonderland", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDesconhecido.Location = new System.Drawing.Point(329, 12);
            this.BtnDesconhecido.Name = "BtnDesconhecido";
            this.BtnDesconhecido.Size = new System.Drawing.Size(22, 23);
            this.BtnDesconhecido.TabIndex = 5;
            this.BtnDesconhecido.Text = "𓅓";
            this.BtnDesconhecido.UseVisualStyleBackColor = true;
            this.BtnDesconhecido.Click += new System.EventHandler(this.BtnDesconhecido_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 405);
            this.Controls.Add(this.BtnDesconhecido);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.ProbarInicio);
            this.Controls.Add(this.LabTitulo);
            this.Controls.Add(this.LabNome);
            this.Controls.Add(this.PicMonstro);
            this.Font = new System.Drawing.Font("Beyond Wonderland", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInicio";
            ((System.ComponentModel.ISupportInitialize)(this.PicMonstro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicMonstro;
        private System.Windows.Forms.Label LabNome;
        private System.Windows.Forms.Label LabTitulo;
        private System.Windows.Forms.Timer TimerInicio;
        private System.Windows.Forms.ProgressBar ProbarInicio;
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.Button BtnDesconhecido;
    }
}