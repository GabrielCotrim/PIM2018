using System.Linq;


namespace Nucleo.Negocio
{

    public class Login
    {
        private const char CHAVE = 'b';

        private string _senhaCriptografada => ObtenhaSenhaCriptografada(_senha);
        private string _senha;

        public string User { get; set; }
        public string Senha { get { return _senha; }set { _senha = value; } }
        public string SenhaCriptografada => _senhaCriptografada;

        public string SenhaDescriptografada => ObtenhaSenhaDiscriptografada(_senhaCriptografada);

        public Login(string user, string senha)
        {
            this._senha = senha;
            this.User = user;
        }

        public Login()
        {

        }

        public bool EhSenhaValida(string senhaDescriptografada)
        {
            return senhaDescriptografada.Equals(SenhaDescriptografada);
        }

        public static string ObtenhaSenhaCriptografada(string senha)
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

        public override string ToString()
        {
            return User;
        }

        public override bool Equals(object obj)
        {
            return obj is Login && ((Login)obj).User.Equals(User);
        }
    }
}
