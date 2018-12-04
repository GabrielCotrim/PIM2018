using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nucleo.Negocio
{
    public class Categoria : IEntidadeDeNegocio
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public Projeto Projeto { get; set; }
    }
}
