using System;
using System.Collections.Generic;
using System.Text;

namespace CovidTrack.BLL.Models
{
    public class LocalAtendimento
    {
        public int LocalAtendimentoId { get; set; }

        public string NomeLocal { get; set; }

        public int LocalizacaoId { get; set; }

        public Localizacao Localizacao { get; set; }

    }
}
