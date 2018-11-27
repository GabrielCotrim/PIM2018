using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nucleo.Enumeradores
{
    public sealed class EnumeradorPrioridadeDaTarefa : EnumeradorSeguro<EnumeradorPrioridadeDaTarefa, int>
    {
        public static EnumeradorPrioridadeDaTarefa QUALQUER = new EnumeradorPrioridadeDaTarefa(1, "Qualquer");
        public static EnumeradorPrioridadeDaTarefa BAIXA = new EnumeradorPrioridadeDaTarefa(2, "Baixa");
        public static EnumeradorPrioridadeDaTarefa NORMAL = new EnumeradorPrioridadeDaTarefa(3, "Normal");
        public static EnumeradorPrioridadeDaTarefa ALTA = new EnumeradorPrioridadeDaTarefa(4, "Alta");
        public static EnumeradorPrioridadeDaTarefa URGENTE = new EnumeradorPrioridadeDaTarefa(5, "Urgente");
        public static EnumeradorPrioridadeDaTarefa IMEDIATO = new EnumeradorPrioridadeDaTarefa(6, "Imediato");

        private EnumeradorPrioridadeDaTarefa(int cod, string descricao) : base(cod, descricao)
        {

        }
    }
}
