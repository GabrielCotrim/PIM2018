using Nucleo.Enumeradores;
using Nucleo.Mapeadores;
using Nucleo.Negocio;
using Nucleo.Processos;
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
        private Usuario _usuario;
        private ProcessoCadastroDeUsuario _processo = new ProcessoCadastroDeUsuario();

        public frmCadastroDeUsuario()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            bsCboClassificacao.DataSource = EnumeradorClassificacaoUsuario.ObtenhaTodos().Where(a => !a.Equals(EnumeradorClassificacaoUsuario.PROJETO)).OrderBy(a => a.Codigo);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            _usuario = new Usuario
            {
                Nome = txtNome.Text,
                Classificacao = (EnumeradorClassificacaoUsuario)cboClassificacao.SelectedItem,
                Login = new Login(txtUser.Text, txtSenha.Text)
            };

            _processo.InsiraUsuario(_usuario);

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUser.Text))
            {
                _usuario = new Usuario
                {
                    Login = new Login
                    {
                        User = txtUser.Text
                    }
                };
                if (_processo.PossuiUsuario(_usuario))
                {
                    _processo.DeleteUsuario(_usuario);
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _usuario = new Usuario
            {
                Nome = txtNome.Text,
                Classificacao = (EnumeradorClassificacaoUsuario)cboClassificacao.SelectedItem,
                Login = new Login(txtUser.Text, txtSenha.Text)
            };
            if(_processo.PossuiUsuario(_usuario))
            {
                _processo.AtualizaUsuario(_usuario);
            }
            else
            {
                MessageBox.Show("Usuário ainda não foi cadastrado!", "Atenção", MessageBoxButtons.OK);
            }
        }
    }
}
