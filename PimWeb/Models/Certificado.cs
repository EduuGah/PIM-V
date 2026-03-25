using System;

namespace PimWeb.Models
{
    public class Certificado : EntidadeBase
    {
        public Participante Participante { get; set; }
        public Evento Evento { get; set; }
        public DateTime DataEmissao { get; set; } = DateTime.Now;

        public string GerarTexto()
        {
            return $"Certificamos que {Participante.Nome} participou do evento {Evento.Nome}.";
        }
    }
}