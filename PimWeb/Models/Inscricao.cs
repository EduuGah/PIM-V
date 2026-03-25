using System;

namespace PimWeb.Models
{
    public class Inscricao : EntidadeBase, IValidavel
    {
        public Participante Participante { get; set; }
        public Evento Evento { get; set; }

        public void Validar()
        {
            if (Participante == null)
                throw new Exception("Participante obrigatório");

            if (Evento == null)
                throw new Exception("Evento obrigatório");
        }
    }
}