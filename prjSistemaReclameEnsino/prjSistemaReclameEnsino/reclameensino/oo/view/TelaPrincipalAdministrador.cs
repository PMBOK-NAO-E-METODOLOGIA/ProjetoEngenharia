﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSistemaReclameEnsino.reclameensino.oo.view
{
    public partial class TelaPrincipalAdministrador : Form
    {
        public TelaPrincipalAdministrador()
        {
            InitializeComponent();
        }

        private void cadastrarAdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastroAdministrador cadastroAdministrador = new TelaCadastroAdministrador();
            cadastroAdministrador.ShowDialog();
        }
    }
}
