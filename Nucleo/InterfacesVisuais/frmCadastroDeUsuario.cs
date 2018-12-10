using Nucleo.Enumeradores;
using Nucleo.Mapeadores;
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
        Usuario Usuario;

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
            var conn = AuxilliarDeBd.Instancia.CreateConnection();
            conn.Open();
            conn.Dispose();
        }
    }
}
