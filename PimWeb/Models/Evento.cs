using System;
using System.Collections.Generic;

namespace PimWeb.Models
{
    public class Evento : EntidadeBase
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        public List<string> Atividades { get; set; } = new List<string>();

        public void Validar()
        {
            if (string.IsNullOrEmpty(Nome))
                throw new Exception("Nome obrigatório");

            if (DataFim < DataInicio)
                throw new Exception("Data inválida");
        }
    }
}