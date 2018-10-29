using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nucleo.Enumeradores
{
    public class EnumeradorSeguro<T, k> : IEnumeradorSeguro<k>, IComparable where T : IEnumeradorSeguro<k>
    {
        private k _codigo;
        private string _descricao;

        public EnumeradorSeguro(k codigo, string descricao)
        {
            _codigo = codigo;
            _descricao = descricao;
        }

        public k Codigo => _codigo;

        public string Descricao => _descricao;

        public int CompareTo(object other)
        {
            if (other as IEnumeradorSeguro<k> == null) return 1;

            var otherEnumerador = other as IEnumeradorSeguro<k>;

            return CompareTo(otherEnumerador);
        }
    }
}
