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

namespace InterfacesVisuais
{
    public partial class frmCadastroProjeto : Form
    {
        public frmCadastroProjeto()
        {
            InitializeComponent();

            dgvCategorias.AllowUserToOrderColumns = true;
            dgvCategorias.Columns.Add("Descricao", "Descrição");

            dgvCategorias.Columns[0].Width = 480;
            dgvCategorias.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        protected override void OnShown(EventArgs e)
        {
            dgvCategorias.DataSource = bsCategorias;
            bsClassificacao.DataSource = EnumeradorClassificacaoUsuario.PROJETO;
        }

        private Projeto ObtenhaProjeto()
        {
            var projeto = new Projeto
            {
                Descricao = txtDescricao.Text,
                Usuario = new Usuario
                {
                    Nome = txtNome.Text,
                    Classificacao = (EnumeradorClassificacaoUsuario)cboClassificacao.SelectedItem
                }
            };
            return projeto;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var projeto = ObtenhaProjeto();
        }

        private void frmCadastroProjeto_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescricaoCategoria.Text))
            {
                var categorias = new List<Categoria>();
                categorias.Add(new Categoria { Descricao = txtDescricaoCategoria.Text });
                bsCategorias.DataSource = categorias;
                bsCategorias.ResetBindings(false);
            }
                
        }
    }
}
