using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nucleo.Enumeradores
{
    public sealed class EnumeradorGravidadeDaTarefa : EnumeradorSeguro<EnumeradorGravidadeDaTarefa, int>
    {
        public static EnumeradorGravidadeDaTarefa PEQUENO = new EnumeradorGravidadeDaTarefa(1, "Pequeno");
        public static EnumeradorGravidadeDaTarefa GRANDE = new EnumeradorGravidadeDaTarefa(2, "Grande");
        public static EnumeradorGravidadeDaTarefa TRAVAMENTO = new EnumeradorGravidadeDaTarefa(3, "Travamento");

        private EnumeradorGravidadeDaTarefa(int cod, string descricao) : base(cod, descricao)
        {

        }
    }
}
