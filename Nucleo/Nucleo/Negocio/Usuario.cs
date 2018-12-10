using Nucleo.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nucleo.Negocio
{
    public class Usuario : EntidadeDeNegocio
    {
        public string Nome { get; set; }
        public EnumeradorClassificacaoUsuario Classificacao { get; set; }
        public Login Login { get; set; }
        public ImagemTratada Imagem { get; set; }
        public bool EhAdministrador => Classificacao.Equals(EnumeradorClassificacaoUsuario.ADMINISTRADOR);

        public override int GetHashCode()
        {
            return Codigo.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return (obj is Usuario) && ((Usuario)obj).Codigo.Equals(this.Codigo);
        }
    }
}
