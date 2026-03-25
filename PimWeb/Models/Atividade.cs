using System;

namespace PimWeb.Models
{
    public class Atividade : EntidadeBase, IValidavel
    {
        public string Titulo { get; set; }
        public string Palestrante { get; set; }
        public DateTime Horario { get; set; }

        public void Validar()
        {
            if (string.IsNullOrEmpty(Titulo))
                throw new Exception("Título é obrigatório");
        }
    }
}