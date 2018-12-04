using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nucleo.Negocio
{
    public class EntidadeDeNegocio : IEntidadeDeNegocio
    {
        public int Codigo { get; set; }

        public override int GetHashCode()
        {
            return Codigo.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return (obj is EntidadeDeNegocio) && ((EntidadeDeNegocio) obj).Codigo.Equals(Codigo);
        }
    }
}
