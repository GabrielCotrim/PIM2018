using Nucleo.Enumeradores;
using Nucleo.Negocio;
using Nucleo.Processos;
using Nucleo.Utilitarios;
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

            var helper = new HelperDataGrid(dgvTarefas);
            MonteColunas(helper);
        }

        private static void MonteColunas(HelperDataGrid helper)
        {
            helper.AddColumn("Categoria", "Descricao");
            helper.AddColumn("Gravidade", "Gravidade");
            helper.AddColumn("Estado", "Descricao");
            helper.AddColumn("Prioridade", "Prioridade");
            helper.AddColumn("Relator", "Relator");
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
