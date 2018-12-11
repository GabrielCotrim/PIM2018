using Nucleo.Processos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nucleo.Negocio
{
    public class SessaoUsuario
    {
        public Usuario Usuario { get; set; }

        private SessaoUsuario()
        {

        }

        private static SessaoUsuario _instancia;

        private static object syncLock = new object();

        public static SessaoUsuario Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    lock (syncLock)
                    {
                        if (_instancia == null)
                        {
                            _instancia = new SessaoUsuario();
                        }
                    }
                }

                return _instancia;
            }
        }


    }
}
