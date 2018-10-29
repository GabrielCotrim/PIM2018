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

        public k Codigo => throw new NotImplementedException();

        public string Descricao => throw new NotImplementedException();

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
