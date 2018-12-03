﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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