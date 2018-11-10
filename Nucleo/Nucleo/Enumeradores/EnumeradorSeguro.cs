using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Nucleo.Enumeradores
{
    public class EnumeradorSeguro<T, k> : IEnumeradorSeguro<k> where T : IEnumeradorSeguro<k>
    {
        public k Codigo => _codigo;
        public string Descricao => _descricao;

        private k _codigo;
        private string _descricao;

        public EnumeradorSeguro(k codigo, string descricao)
        {
            _codigo = codigo;
            _descricao = descricao;
        }

        public List<T> ObtenhaTodos()
        {
            return ObtenhaTodos<T>();
        }

        public override bool Equals(object outroObjeto)
        {
            return outroObjeto is EnumeradorSeguro<T,k> && ((EnumeradorSeguro<T, k>)outroObjeto).Codigo.Equals(Codigo);
        }
        
        public T ObtenhaEnumerador(k codigo)
        {
            return ObtenhaEnumerador<T>(codigo);
        }

        protected TEnumerador ObtenhaEnumerador<TEnumerador>(k codigo) where TEnumerador : IEnumeradorSeguro<k>
        {
            foreach(var enumerador in ObtenhaTodos<TEnumerador>())
            {
                if (enumerador.Codigo.Equals(codigo))
                {
                    return enumerador;
                }
            }
            return default(TEnumerador);
        }

        protected List<TEnumerador> ObtenhaTodos<TEnumerador>() where TEnumerador : IEnumeradorSeguro<k>
        {
            var tipo = typeof(TEnumerador);
            return tipo.GetFields(BindingFlags.Static | BindingFlags.Public).Select(campo => (TEnumerador)campo.GetValue(null)).ToList();
        }

    }
}
