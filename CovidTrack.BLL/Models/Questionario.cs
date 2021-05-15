using System;
using System.Collections.Generic;
using System.Text;

namespace CovidTrack.BLL.Models
{
    public class Questionario
    {
        public int QuestionarioId { get; set; }

        public string Resposta { get; set; }

        public int QuestaoId { get; set; }

        public Questao Questao { get; set; }

        public string UsuarioId { get; set; }

        public Usuario Usuario { get; set; }
    }
}
