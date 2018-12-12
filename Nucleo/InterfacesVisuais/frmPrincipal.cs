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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            this.Visible = false;
            var frm = new frmLogin();
            if(frm.ShowDialog() == DialogResult.OK)
                this.Visible = true;
            else if(frm.DialogResult == DialogResult.Cancel)
            {
                Close();
                return;
            }

            if (SessaoUsuario.Instancia.Usuario.EhAdministrador)
            {
                btnCadastrarProjeto.Enabled = true;
                btnCadastrarUsuarios.Enabled = true;
            }
                
        }

        private void btnCadastrarProjeto_Click(object sender, EventArgs e)
        {
            using (var frm = new frmCadastroProjeto())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    bsProjetos.ResetBindings(false);
            }

        }

        private void btnCadastrarUsuarios_Click(object sender, EventArgs e)
        {
            using (var frm = new frmCadastroDeUsuario())
            {
                frm.ShowDialog();
            }
        }

        private void btnMinhaVisao_Click(object sender, EventArgs e)
        {
            using (var frm = new frmMinhasTarefas())
            {
                frm.ShowDialog();
            }
        }

        private void btnVerTarefas_Click(object sender, EventArgs e)
        {
            using (var frm = new frmVisualizarTarefa())
            {
                frm.ShowDialog();
            }
        }

        private void btnCriarTarefas_Click(object sender, EventArgs e)
        {

        }
    }
}
