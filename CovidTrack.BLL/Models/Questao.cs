using System;
using System.Collections.Generic;
using System.Text;

namespace CovidTrack.BLL.Models
{
    public class Questao
    {
        public int QuestaoId { get; set; }
        public string Pergunta { get; set; }

        public virtual ICollection<Questionario> Questionarios { get; set; }
    }
}
