﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexandria.Séries
{
    public partial class FrmSeriesVisualizar : Form
    {
        public FrmSeriesVisualizar()
        {
            InitializeComponent();
        }

        private void BtnSeriesUniversalismo_Click(object sender, EventArgs e)
        {
            var serie = new ClaVerSeries();
            DataSeries.DataSource = serie.ObterSeries();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
