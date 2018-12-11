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

        public bool PossuiUsuario(Usuario usuario)
        {
            return mapeador.PossuiUsuarioCadastrado(usuario);
        }

        public void DeleteUsuario(Usuario usuario)
        {
            mapeador.DeleteUsuario(usuario);
        }

        public void AtualizaUsuario(Usuario usuario)
        {
            mapeador.AtualizaUsuario(usuario);
        }

        public List<Usuario> ObtenhaTodos()
        {
            return mapeador.ObtenhaTodos();
        }

    }
}
