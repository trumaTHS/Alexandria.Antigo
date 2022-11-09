namespace Alexandria.Séries
{
    partial class FrmSeriesCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeriesCadastrar));
            this.BtnSeriesSalvar = new System.Windows.Forms.Button();
            this.NudEpisódios = new System.Windows.Forms.NumericUpDown();
            this.TxtboxElenco_Principal = new System.Windows.Forms.TextBox();
            this.LabTérmino = new System.Windows.Forms.Label();
            this.MtxtboxTérmino = new System.Windows.Forms.MaskedTextBox();
            this.MtxtboxPublicação = new System.Windows.Forms.MaskedTextBox();
            this.TxtboxResenha = new System.Windows.Forms.TextBox();
            this.TxtboxGênero = new System.Windows.Forms.TextBox();
            this.TxtboxFaixa_Etária = new System.Windows.Forms.TextBox();
            this.TxtboxEstúdio = new System.Windows.Forms.TextBox();
            this.NudTemporada = new System.Windows.Forms.NumericUpDown();
            this.NudNota = new System.Windows.Forms.NumericUpDown();
            this.MtxtboxData_de_Conclusão = new System.Windows.Forms.MaskedTextBox();
            this.MtxtboxData_de_Início = new System.Windows.Forms.MaskedTextBox();
            this.TxtboxSérie = new System.Windows.Forms.TextBox();
            this.TxtboxDiretor = new System.Windows.Forms.TextBox();
            this.TxtboxNome_Original = new System.Windows.Forms.TextBox();
            this.LabResenha = new System.Windows.Forms.Label();
            this.LabData_de_Conclusão = new System.Windows.Forms.Label();
            this.LabData_de_Início = new System.Windows.Forms.Label();
            this.LabGênero = new System.Windows.Forms.Label();
            this.LabFaixa_Etária = new System.Windows.Forms.Label();
            this.LabSérie = new System.Windows.Forms.Label();
            this.LabEpisódios = new System.Windows.Forms.Label();
            this.LabElenco_Principal = new System.Windows.Forms.Label();
            this.LabTemporada = new System.Windows.Forms.Label();
            this.LabNota = new System.Windows.Forms.Label();
            this.LabNome_Original = new System.Windows.Forms.Label();
            this.LabEstúdio = new System.Windows.Forms.Label();
            this.LabPublicação = new System.Windows.Forms.Label();
            this.LabDiretor = new System.Windows.Forms.Label();
            this.LabNome = new System.Windows.Forms.Label();
            this.TxtboxNome = new System.Windows.Forms.TextBox();
            this.BtnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NudEpisódios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudTemporada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudNota)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSeriesSalvar
            // 
            this.BtnSeriesSalvar.Location = new System.Drawing.Point(13, 556);
            this.BtnSeriesSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSeriesSalvar.Name = "BtnSeriesSalvar";
            this.BtnSeriesSalvar.Size = new System.Drawing.Size(913, 40);
            this.BtnSeriesSalvar.TabIndex = 2;
            this.BtnSeriesSalvar.Text = "Honrar";
            this.BtnSeriesSalvar.UseVisualStyleBackColor = true;
            this.BtnSeriesSalvar.Click += new System.EventHandler(this.BtnSeriesSalvar_Click);
            // 
            // NudEpisódios
            // 
            this.NudEpisódios.Location = new System.Drawing.Point(986, 54);
            this.NudEpisódios.Margin = new System.Windows.Forms.Padding(4);
            this.NudEpisódios.Name = "NudEpisódios";
            this.NudEpisódios.Size = new System.Drawing.Size(117, 23);
            this.NudEpisódios.TabIndex = 97;
            // 
            // TxtboxElenco_Principal
            // 
            this.TxtboxElenco_Principal.Location = new System.Drawing.Point(585, 104);
            this.TxtboxElenco_Principal.Margin = new System.Windows.Forms.Padding(4);
            this.TxtboxElenco_Principal.Multiline = true;
            this.TxtboxElenco_Principal.Name = "TxtboxElenco_Principal";
            this.TxtboxElenco_Principal.Size = new System.Drawing.Size(396, 69);
            this.TxtboxElenco_Principal.TabIndex = 96;
            // 
            // LabTérmino
            // 
            this.LabTérmino.AutoSize = true;
            this.LabTérmino.Location = new System.Drawing.Point(983, 131);
            this.LabTérmino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabTérmino.Name = "LabTérmino";
            this.LabTérmino.Size = new System.Drawing.Size(49, 16);
            this.LabTérmino.TabIndex = 95;
            this.LabTérmino.Text = "Término";
            // 
            // MtxtboxTérmino
            // 
            this.MtxtboxTérmino.Location = new System.Drawing.Point(986, 150);
            this.MtxtboxTérmino.Margin = new System.Windows.Forms.Padding(4);
            this.MtxtboxTérmino.Mask = "00/00/0000";
            this.MtxtboxTérmino.Name = "MtxtboxTérmino";
            this.MtxtboxTérmino.Size = new System.Drawing.Size(117, 23);
            this.MtxtboxTérmino.TabIndex = 94;
            this.MtxtboxTérmino.ValidatingType = typeof(System.DateTime);
            // 
            // MtxtboxPublicação
            // 
            this.MtxtboxPublicação.Location = new System.Drawing.Point(986, 104);
            this.MtxtboxPublicação.Margin = new System.Windows.Forms.Padding(4);
            this.MtxtboxPublicação.Mask = "00/00/0000";
            this.MtxtboxPublicação.Name = "MtxtboxPublicação";
            this.MtxtboxPublicação.Size = new System.Drawing.Size(117, 23);
            this.MtxtboxPublicação.TabIndex = 93;
            this.MtxtboxPublicação.ValidatingType = typeof(System.DateTime);
            // 
            // TxtboxResenha
            // 
            this.TxtboxResenha.Location = new System.Drawing.Point(13, 440);
            this.TxtboxResenha.Margin = new System.Windows.Forms.Padding(4);
            this.TxtboxResenha.Multiline = true;
            this.TxtboxResenha.Name = "TxtboxResenha";
            this.TxtboxResenha.Size = new System.Drawing.Size(1090, 108);
            this.TxtboxResenha.TabIndex = 92;
            // 
            // TxtboxGênero
            // 
            this.TxtboxGênero.Location = new System.Drawing.Point(26, 238);
            this.TxtboxGênero.Margin = new System.Windows.Forms.Padding(4);
            this.TxtboxGênero.Name = "TxtboxGênero";
            this.TxtboxGênero.Size = new System.Drawing.Size(551, 23);
            this.TxtboxGênero.TabIndex = 91;
            // 
            // TxtboxFaixa_Etária
            // 
            this.TxtboxFaixa_Etária.Location = new System.Drawing.Point(26, 319);
            this.TxtboxFaixa_Etária.Margin = new System.Windows.Forms.Padding(4);
            this.TxtboxFaixa_Etária.Name = "TxtboxFaixa_Etária";
            this.TxtboxFaixa_Etária.Size = new System.Drawing.Size(551, 23);
            this.TxtboxFaixa_Etária.TabIndex = 90;
            // 
            // TxtboxEstúdio
            // 
            this.TxtboxEstúdio.Location = new System.Drawing.Point(305, 150);
            this.TxtboxEstúdio.Margin = new System.Windows.Forms.Padding(4);
            this.TxtboxEstúdio.Name = "TxtboxEstúdio";
            this.TxtboxEstúdio.Size = new System.Drawing.Size(272, 23);
            this.TxtboxEstúdio.TabIndex = 89;
            // 
            // NudTemporada
            // 
            this.NudTemporada.Location = new System.Drawing.Point(864, 54);
            this.NudTemporada.Margin = new System.Windows.Forms.Padding(4);
            this.NudTemporada.Name = "NudTemporada";
            this.NudTemporada.Size = new System.Drawing.Size(117, 23);
            this.NudTemporada.TabIndex = 88;
            // 
            // NudNota
            // 
            this.NudNota.Location = new System.Drawing.Point(509, 386);
            this.NudNota.Margin = new System.Windows.Forms.Padding(4);
            this.NudNota.Name = "NudNota";
            this.NudNota.Size = new System.Drawing.Size(165, 23);
            this.NudNota.TabIndex = 87;
            // 
            // MtxtboxData_de_Conclusão
            // 
            this.MtxtboxData_de_Conclusão.Location = new System.Drawing.Point(585, 319);
            this.MtxtboxData_de_Conclusão.Margin = new System.Windows.Forms.Padding(4);
            this.MtxtboxData_de_Conclusão.Mask = "00/00/0000";
            this.MtxtboxData_de_Conclusão.Name = "MtxtboxData_de_Conclusão";
            this.MtxtboxData_de_Conclusão.Size = new System.Drawing.Size(518, 23);
            this.MtxtboxData_de_Conclusão.TabIndex = 86;
            this.MtxtboxData_de_Conclusão.ValidatingType = typeof(System.DateTime);
            // 
            // MtxtboxData_de_Início
            // 
            this.MtxtboxData_de_Início.Location = new System.Drawing.Point(585, 238);
            this.MtxtboxData_de_Início.Margin = new System.Windows.Forms.Padding(4);
            this.MtxtboxData_de_Início.Mask = "00/00/0000";
            this.MtxtboxData_de_Início.Name = "MtxtboxData_de_Início";
            this.MtxtboxData_de_Início.Size = new System.Drawing.Size(518, 23);
            this.MtxtboxData_de_Início.TabIndex = 85;
            this.MtxtboxData_de_Início.ValidatingType = typeof(System.DateTime);
            // 
            // TxtboxSérie
            // 
            this.TxtboxSérie.Location = new System.Drawing.Point(585, 53);
            this.TxtboxSérie.Margin = new System.Windows.Forms.Padding(4);
            this.TxtboxSérie.Name = "TxtboxSérie";
            this.TxtboxSérie.Size = new System.Drawing.Size(271, 23);
            this.TxtboxSérie.TabIndex = 84;
            // 
            // TxtboxDiretor
            // 
            this.TxtboxDiretor.Location = new System.Drawing.Point(305, 53);
            this.TxtboxDiretor.Margin = new System.Windows.Forms.Padding(4);
            this.TxtboxDiretor.Name = "TxtboxDiretor";
            this.TxtboxDiretor.Size = new System.Drawing.Size(272, 23);
            this.TxtboxDiretor.TabIndex = 83;
            // 
            // TxtboxNome_Original
            // 
            this.TxtboxNome_Original.Location = new System.Drawing.Point(26, 150);
            this.TxtboxNome_Original.Margin = new System.Windows.Forms.Padding(4);
            this.TxtboxNome_Original.Name = "TxtboxNome_Original";
            this.TxtboxNome_Original.Size = new System.Drawing.Size(272, 23);
            this.TxtboxNome_Original.TabIndex = 82;
            // 
            // LabResenha
            // 
            this.LabResenha.AutoSize = true;
            this.LabResenha.Location = new System.Drawing.Point(566, 420);
            this.LabResenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabResenha.Name = "LabResenha";
            this.LabResenha.Size = new System.Drawing.Size(51, 16);
            this.LabResenha.TabIndex = 81;
            this.LabResenha.Text = "Resenha";
            // 
            // LabData_de_Conclusão
            // 
            this.LabData_de_Conclusão.AutoSize = true;
            this.LabData_de_Conclusão.Location = new System.Drawing.Point(582, 299);
            this.LabData_de_Conclusão.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabData_de_Conclusão.Name = "LabData_de_Conclusão";
            this.LabData_de_Conclusão.Size = new System.Drawing.Size(108, 16);
            this.LabData_de_Conclusão.TabIndex = 80;
            this.LabData_de_Conclusão.Text = "Data de Conclusão";
            // 
            // LabData_de_Início
            // 
            this.LabData_de_Início.AutoSize = true;
            this.LabData_de_Início.Location = new System.Drawing.Point(582, 218);
            this.LabData_de_Início.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabData_de_Início.Name = "LabData_de_Início";
            this.LabData_de_Início.Size = new System.Drawing.Size(82, 16);
            this.LabData_de_Início.TabIndex = 79;
            this.LabData_de_Início.Text = "Data de Início";
            // 
            // LabGênero
            // 
            this.LabGênero.AutoSize = true;
            this.LabGênero.Location = new System.Drawing.Point(23, 218);
            this.LabGênero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabGênero.Name = "LabGênero";
            this.LabGênero.Size = new System.Drawing.Size(44, 16);
            this.LabGênero.TabIndex = 78;
            this.LabGênero.Text = "Gênero";
            // 
            // LabFaixa_Etária
            // 
            this.LabFaixa_Etária.AutoSize = true;
            this.LabFaixa_Etária.Location = new System.Drawing.Point(23, 299);
            this.LabFaixa_Etária.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabFaixa_Etária.Name = "LabFaixa_Etária";
            this.LabFaixa_Etária.Size = new System.Drawing.Size(77, 16);
            this.LabFaixa_Etária.TabIndex = 77;
            this.LabFaixa_Etária.Text = "Faixa Etária";
            // 
            // LabSérie
            // 
            this.LabSérie.AutoSize = true;
            this.LabSérie.Location = new System.Drawing.Point(582, 34);
            this.LabSérie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabSérie.Name = "LabSérie";
            this.LabSérie.Size = new System.Drawing.Size(33, 16);
            this.LabSérie.TabIndex = 76;
            this.LabSérie.Text = "Série";
            // 
            // LabEpisódios
            // 
            this.LabEpisódios.AutoSize = true;
            this.LabEpisódios.Location = new System.Drawing.Point(983, 34);
            this.LabEpisódios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabEpisódios.Name = "LabEpisódios";
            this.LabEpisódios.Size = new System.Drawing.Size(55, 16);
            this.LabEpisódios.TabIndex = 75;
            this.LabEpisódios.Text = "Episódios";
            // 
            // LabElenco_Principal
            // 
            this.LabElenco_Principal.AutoSize = true;
            this.LabElenco_Principal.Location = new System.Drawing.Point(582, 88);
            this.LabElenco_Principal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabElenco_Principal.Name = "LabElenco_Principal";
            this.LabElenco_Principal.Size = new System.Drawing.Size(190, 16);
            this.LabElenco_Principal.TabIndex = 74;
            this.LabElenco_Principal.Text = "Elenco Principal (utlize vírgulas)";
            // 
            // LabTemporada
            // 
            this.LabTemporada.AutoSize = true;
            this.LabTemporada.Location = new System.Drawing.Point(861, 34);
            this.LabTemporada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabTemporada.Name = "LabTemporada";
            this.LabTemporada.Size = new System.Drawing.Size(64, 16);
            this.LabTemporada.TabIndex = 73;
            this.LabTemporada.Text = "Temporada";
            // 
            // LabNota
            // 
            this.LabNota.AutoSize = true;
            this.LabNota.Location = new System.Drawing.Point(573, 366);
            this.LabNota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabNota.Name = "LabNota";
            this.LabNota.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabNota.Size = new System.Drawing.Size(34, 16);
            this.LabNota.TabIndex = 72;
            this.LabNota.Text = "Nota";
            // 
            // LabNome_Original
            // 
            this.LabNome_Original.AutoSize = true;
            this.LabNome_Original.Location = new System.Drawing.Point(23, 131);
            this.LabNome_Original.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabNome_Original.Name = "LabNome_Original";
            this.LabNome_Original.Size = new System.Drawing.Size(85, 16);
            this.LabNome_Original.TabIndex = 71;
            this.LabNome_Original.Text = "Nome Original";
            // 
            // LabEstúdio
            // 
            this.LabEstúdio.AutoSize = true;
            this.LabEstúdio.Location = new System.Drawing.Point(303, 131);
            this.LabEstúdio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabEstúdio.Name = "LabEstúdio";
            this.LabEstúdio.Size = new System.Drawing.Size(47, 16);
            this.LabEstúdio.TabIndex = 70;
            this.LabEstúdio.Text = "Estúdio";
            // 
            // LabPublicação
            // 
            this.LabPublicação.AutoSize = true;
            this.LabPublicação.Location = new System.Drawing.Point(983, 88);
            this.LabPublicação.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabPublicação.Name = "LabPublicação";
            this.LabPublicação.Size = new System.Drawing.Size(66, 16);
            this.LabPublicação.TabIndex = 69;
            this.LabPublicação.Text = "Publicação";
            // 
            // LabDiretor
            // 
            this.LabDiretor.AutoSize = true;
            this.LabDiretor.Location = new System.Drawing.Point(303, 34);
            this.LabDiretor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabDiretor.Name = "LabDiretor";
            this.LabDiretor.Size = new System.Drawing.Size(47, 16);
            this.LabDiretor.TabIndex = 68;
            this.LabDiretor.Text = "Diretor";
            // 
            // LabNome
            // 
            this.LabNome.AutoSize = true;
            this.LabNome.Location = new System.Drawing.Point(23, 34);
            this.LabNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabNome.Name = "LabNome";
            this.LabNome.Size = new System.Drawing.Size(36, 16);
            this.LabNome.TabIndex = 67;
            this.LabNome.Text = "Nome";
            // 
            // TxtboxNome
            // 
            this.TxtboxNome.Location = new System.Drawing.Point(26, 53);
            this.TxtboxNome.Margin = new System.Windows.Forms.Padding(4);
            this.TxtboxNome.Name = "TxtboxNome";
            this.TxtboxNome.Size = new System.Drawing.Size(272, 23);
            this.TxtboxNome.TabIndex = 66;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(930, 556);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(173, 40);
            this.BtnVoltar.TabIndex = 98;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // FrmSeriesCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 609);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.NudEpisódios);
            this.Controls.Add(this.TxtboxElenco_Principal);
            this.Controls.Add(this.LabTérmino);
            this.Controls.Add(this.MtxtboxTérmino);
            this.Controls.Add(this.MtxtboxPublicação);
            this.Controls.Add(this.TxtboxResenha);
            this.Controls.Add(this.TxtboxGênero);
            this.Controls.Add(this.TxtboxFaixa_Etária);
            this.Controls.Add(this.TxtboxEstúdio);
            this.Controls.Add(this.NudTemporada);
            this.Controls.Add(this.NudNota);
            this.Controls.Add(this.MtxtboxData_de_Conclusão);
            this.Controls.Add(this.MtxtboxData_de_Início);
            this.Controls.Add(this.TxtboxSérie);
            this.Controls.Add(this.TxtboxDiretor);
            this.Controls.Add(this.TxtboxNome_Original);
            this.Controls.Add(this.LabResenha);
            this.Controls.Add(this.LabData_de_Conclusão);
            this.Controls.Add(this.LabData_de_Início);
            this.Controls.Add(this.LabGênero);
            this.Controls.Add(this.LabFaixa_Etária);
            this.Controls.Add(this.LabSérie);
            this.Controls.Add(this.LabEpisódios);
            this.Controls.Add(this.LabElenco_Principal);
            this.Controls.Add(this.LabTemporada);
            this.Controls.Add(this.LabNota);
            this.Controls.Add(this.LabNome_Original);
            this.Controls.Add(this.LabEstúdio);
            this.Controls.Add(this.LabPublicação);
            this.Controls.Add(this.LabDiretor);
            this.Controls.Add(this.LabNome);
            this.Controls.Add(this.TxtboxNome);
            this.Controls.Add(this.BtnSeriesSalvar);
            this.Font = new System.Drawing.Font("SpellcasterW01-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSeriesCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Séries";
            ((System.ComponentModel.ISupportInitialize)(this.NudEpisódios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudTemporada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSeriesSalvar;
        private System.Windows.Forms.NumericUpDown NudEpisódios;
        private System.Windows.Forms.TextBox TxtboxElenco_Principal;
        private System.Windows.Forms.Label LabTérmino;
        private System.Windows.Forms.MaskedTextBox MtxtboxTérmino;
        private System.Windows.Forms.MaskedTextBox MtxtboxPublicação;
        private System.Windows.Forms.TextBox TxtboxResenha;
        private System.Windows.Forms.TextBox TxtboxGênero;
        private System.Windows.Forms.TextBox TxtboxFaixa_Etária;
        private System.Windows.Forms.TextBox TxtboxEstúdio;
        private System.Windows.Forms.NumericUpDown NudTemporada;
        private System.Windows.Forms.NumericUpDown NudNota;
        private System.Windows.Forms.MaskedTextBox MtxtboxData_de_Conclusão;
        private System.Windows.Forms.MaskedTextBox MtxtboxData_de_Início;
        private System.Windows.Forms.TextBox TxtboxSérie;
        private System.Windows.Forms.TextBox TxtboxDiretor;
        private System.Windows.Forms.TextBox TxtboxNome_Original;
        private System.Windows.Forms.Label LabResenha;
        private System.Windows.Forms.Label LabData_de_Conclusão;
        private System.Windows.Forms.Label LabData_de_Início;
        private System.Windows.Forms.Label LabGênero;
        private System.Windows.Forms.Label LabFaixa_Etária;
        private System.Windows.Forms.Label LabSérie;
        private System.Windows.Forms.Label LabEpisódios;
        private System.Windows.Forms.Label LabElenco_Principal;
        private System.Windows.Forms.Label LabTemporada;
        private System.Windows.Forms.Label LabNota;
        private System.Windows.Forms.Label LabNome_Original;
        private System.Windows.Forms.Label LabEstúdio;
        private System.Windows.Forms.Label LabPublicação;
        private System.Windows.Forms.Label LabDiretor;
        private System.Windows.Forms.Label LabNome;
        private System.Windows.Forms.TextBox TxtboxNome;
        private System.Windows.Forms.Button BtnVoltar;
    }
}