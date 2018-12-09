using Nucleo.Enumeradores;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;


namespace Nucleo.Negocio
{

    
    public class Login
    {
        private const int CHAVE = 1010;

        private string _senhaCriptografada => ObtenhaSenhaCriptografada(_senha);
        private string _senha;

        public string User { get; set; }
        public string Senha => _senha;

        public Login(string user, string senha)
        {
            this._senha = senha;
            this.User = user;
        }

        public class Usuario : EntidadeDeNegocio
        {
            public string Nome { get; set; }
            public EnumeradorClassificacaoUsuario Classificacao { get; set; }
            public Login Login { get; set; }
            public Image Imagem { get; set; }

            public override int GetHashCode()
            {
                return Codigo.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                return (obj is Usuario) && ((Usuario)obj).Codigo.Equals(this.Codigo); 
            }
        }

        public bool EhSenhaValida(string senhaDescriptografada)
        {
            return senhaDescriptografada.Equals(_senha);
        }

        private string ObtenhaSenhaCriptografada(string senha)
        {
            var senhaCriptografada = string.Empty;

            for (int i = 0; i < senha.Length; i++)
                senhaCriptografada = senhaCriptografada + (char)(senha.ElementAt(i) ^ CHAVE);

            return senhaCriptografada;
        }

        public static string ObtenhaSenhaDiscriptografada(string senha)
        {
            var senhaDescriptografada = string.Empty;

            for (int i = 0; i < senha.Length; i++)
                senhaDescriptografada = senhaDescriptografada + (char)(senha.ElementAt(i) ^ CHAVE);

            return senhaDescriptografada;
        }
    }
}
