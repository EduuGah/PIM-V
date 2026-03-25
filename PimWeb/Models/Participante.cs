using System;

namespace PimWeb.Models
{
    public class Participante : EntidadeBase, IValidavel
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public void Validar()
        {
            if (string.IsNullOrEmpty(Nome))
                throw new Exception("Nome obrigatório");

            if (string.IsNullOrEmpty(Email) || !Email.Contains("@"))
                throw new Exception("Email inválido");
        }
    }
}