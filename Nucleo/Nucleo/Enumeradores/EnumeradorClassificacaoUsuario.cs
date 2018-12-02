using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nucleo.Enumeradores
{
    public sealed class EnumeradorClassificacaoUsuario : EnumeradorSeguro<EnumeradorClassificacaoUsuario, int>
    {
        public static EnumeradorClassificacaoUsuario ADMINISTRADOR = new EnumeradorClassificacaoUsuario(1, "Administrador");
        public static EnumeradorClassificacaoUsuario SUPORTE = new EnumeradorClassificacaoUsuario(2, "Suporte");
        public static EnumeradorClassificacaoUsuario DESENVOLVEVIMENTO = new EnumeradorClassificacaoUsuario(3, "Desenvolvimento");
        public static EnumeradorClassificacaoUsuario PROJETO = new EnumeradorClassificacaoUsuario(4, "Projeto");

        private EnumeradorClassificacaoUsuario(int cod, string descricao) : base(cod, descricao)
        {

        }
    }
}
