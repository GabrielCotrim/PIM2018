using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nucleo.Enumeradores
{
    public class EnumeradorSeguro<T, k> : IEnumeradorSeguro<k> where T : IEnumeradorSeguro<k>
    {
        public k Codigo<k>()
        {
            throw new NotImplementedException();
        }
    }
}
