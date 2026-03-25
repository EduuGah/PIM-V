namespace PimWeb.Models
{
    public class UsuarioAdministrador : EntidadeBase
    {
        public string Login { get; set; }
        public string Senha { get; set; }

        public bool Autenticar(string login, string senha)
        {
            return Login == login && Senha == senha;
        }
    }
}