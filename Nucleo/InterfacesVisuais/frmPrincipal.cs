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

            if (SessaoUsuario.Instancia.Usuario.EhAdministrador)
                btnCadastrarProjeto.Enabled = true;
        }

        private void btnCadastrarProjeto_Click(object sender, EventArgs e)
        {
            using (var frm = new frmCadastroProjeto())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    bsProjetos.ResetBindings(false);
            }

        }
    }
}
