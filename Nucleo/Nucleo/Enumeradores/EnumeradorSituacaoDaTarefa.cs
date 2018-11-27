using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nucleo.Enumeradores
{
    public class EnumeradorSituacaoDaTarefa : EnumeradorSeguro<EnumeradorSituacaoDaTarefa, int>
    {
        public static EnumeradorSituacaoDaTarefa NOVO = new EnumeradorSituacaoDaTarefa(1, "Novo");
        public static EnumeradorSituacaoDaTarefa ATRIBUIDO = new EnumeradorSituacaoDaTarefa(2, "Atribuido");
        public static EnumeradorSituacaoDaTarefa CONFIRMADO = new EnumeradorSituacaoDaTarefa(3, "Confirmado");
        public static EnumeradorSituacaoDaTarefa RESOLVIDO = new EnumeradorSituacaoDaTarefa(4, "Resolvido");
        public static EnumeradorSituacaoDaTarefa RETORNO = new EnumeradorSituacaoDaTarefa(5, "Retornado");
        public static EnumeradorSituacaoDaTarefa FECHADO = new EnumeradorSituacaoDaTarefa(6, "Fechado");

        private EnumeradorSituacaoDaTarefa(int codigo, string descricao) : base(codigo, descricao)
        {
        }
    }
}
