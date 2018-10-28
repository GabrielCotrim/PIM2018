using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nucleo
{
    public struct Flutuante
    {
        private decimal _decimal;

        public Flutuante(double d)
        {
            _decimal =  Convert.ToDecimal(d);
        }

        public Flutuante(decimal d)
        {
            _decimal = d;
        }

        public Flutuante(int d)
        {
            _decimal = Convert.ToDecimal(d);
        }

        public Flutuante(float f)
        {
            _decimal = Convert.ToDecimal(f);
        }


    }
}
