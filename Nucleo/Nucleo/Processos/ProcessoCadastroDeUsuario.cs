using Nucleo.Mapeadores;
using Nucleo.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nucleo.Processos
{
    public class ProcessoCadastroDeUsuario
    {
        MapeadorDeUsuario mapeador = new MapeadorDeUsuario();

        public void InsiraUsuario(Usuario usuario)
        {
            mapeador.InsiraUsuario(usuario);
        }
    }
}
