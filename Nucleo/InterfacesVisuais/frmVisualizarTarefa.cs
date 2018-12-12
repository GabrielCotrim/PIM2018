using Nucleo.Enumeradores;
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

namespace InterfacesVisuais
{
    public partial class frmVisualizarTarefa : Form
    {
        private ProcessoCadastroDeUsuario _processo = new ProcessoCadastroDeUsuario();
        public frmVisualizarTarefa()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            var usuarios = _processo.ObtenhaTodos();

            var usuariosSuporte = usuarios.Select(l=>l).Where(u => u.Classificacao.Equals(EnumeradorClassificacaoUsuario.SUPORTE)).ToList();

            var categorias = new List<Categoria>();
            categorias.Add(new Categoria { Descricao = "Defeito" });
            categorias.Add(new Categoria { Descricao = "Erro" });
            bsCategoria.DataSource = categorias;
            bsGravidade.DataSource = EnumeradorGravidadeDaTarefa.ObtenhaTodos();
            bsEstado.DataSource = EnumeradorSituacaoDaTarefa.ObtenhaTodos();
            bsAtribuido.DataSource = usuarios;
            bsRelator.DataSource = usuariosSuporte;
            bsPrioridade.DataSource = EnumeradorPrioridadeDaTarefa.ObtenhaTodos();
        }
    }
}
