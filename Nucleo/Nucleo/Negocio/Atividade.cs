using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Nucleo.Negocio.Login;

namespace Nucleo.Negocio
{
    public class Atividade : IEntidadeDeNegocio
    {
        public int Codigo { get; set; }
        public Tarefa Tarefa { get; set; }
        public Usuario Usuario { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
    }
}
