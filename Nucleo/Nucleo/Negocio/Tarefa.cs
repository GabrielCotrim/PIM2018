using Nucleo.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using static Nucleo.Negocio.Login;

namespace Nucleo.Negocio
{
    public class Tarefa : EntidadeDeNegocio
    {

        public Usuario Relator { get; set; }
        public Usuario UsuarioAtribuido { get; set; }
        public EnumeradorSituacaoDaTarefa Situacao { get; set; } = EnumeradorSituacaoDaTarefa.NOVO;
        public EnumeradorGravidadeDaTarefa Gravidade { get; set; }
        public EnumeradorPrioridadeDaTarefa Prioridade { get; set; }
        public string Resumo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacaoDaTarefa { get; set; }
        public DateTime? DataEncerramentoTarefa { get; set; }
        public Projeto Projeto { get; set; }
    }
}
