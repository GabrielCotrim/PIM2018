﻿using Nucleo.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesVisuais
{
    public partial class frmCadastroDeUsuario : Form
    {
        Image imagem;

        public frmCadastroDeUsuario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*.JPG) | *.jpg";

            if (f.ShowDialog() == DialogResult.OK)
            {
                imagem = Image.FromFile(f.FileName);
                pictureBox1.Image = imagem;
            }

        }

        private void btnAnotacao_Click(object sender, EventArgs e)
        {
            txtAnotacao.Visible = true;
        }

        private void btnAnotacao_Leave(object sender, EventArgs e)
        {
            txtAnotacao.Visible = false;
        }
    }
}
