﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastrosBeta
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            var frmClientes = new FrmCliente();
            frmClientes.Show();
        }

        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            var frmProdutos = new FrmProduto();
            frmProdutos.Show();
        }

        private void LblProdutos_Click(object sender, EventArgs e)
        {

        }
    }
}
