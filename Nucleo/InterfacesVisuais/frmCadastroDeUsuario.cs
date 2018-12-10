using Nucleo.Enumeradores;
using Nucleo.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Nucleo.Negocio.Login;

namespace InterfacesVisuais
{
    public partial class frmCadastroDeUsuario : Form
    {
        Image imagem;
        Usuario Usuario;

        public frmCadastroDeUsuario()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            bsCboClassificacao.DataSource = EnumeradorClassificacaoUsuario.ObtenhaTodos().OrderBy(a => a.Codigo);
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
