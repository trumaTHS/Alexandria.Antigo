namespace Alexandria.HQs
{
    partial class FrmHQsVisualizar
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
            this.DataHQs = new System.Windows.Forms.DataGridView();
            this.BtnHQsUniversalismo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataHQs)).BeginInit();
            this.SuspendLayout();
            // 
            // DataHQs
            // 
            this.DataHQs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataHQs.Location = new System.Drawing.Point(313, 146);
            this.DataHQs.Name = "DataHQs";
            this.DataHQs.Size = new System.Drawing.Size(240, 150);
            this.DataHQs.TabIndex = 0;
            // 
            // BtnHQsUniversalismo
            // 
            this.BtnHQsUniversalismo.Location = new System.Drawing.Point(378, 341);
            this.BtnHQsUniversalismo.Name = "BtnHQsUniversalismo";
            this.BtnHQsUniversalismo.Size = new System.Drawing.Size(75, 23);
            this.BtnHQsUniversalismo.TabIndex = 1;
            this.BtnHQsUniversalismo.Text = "button1";
            this.BtnHQsUniversalismo.UseVisualStyleBackColor = true;
            this.BtnHQsUniversalismo.Click += new System.EventHandler(this.BtnHQsUniversalismo_Click);
            // 
            // FrmHQsVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnHQsUniversalismo);
            this.Controls.Add(this.DataHQs);
            this.Name = "FrmHQsVisualizar";
            this.Text = "FrmHQsVisualizar";
            ((System.ComponentModel.ISupportInitialize)(this.DataHQs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataHQs;
        private System.Windows.Forms.Button BtnHQsUniversalismo;
    }
}