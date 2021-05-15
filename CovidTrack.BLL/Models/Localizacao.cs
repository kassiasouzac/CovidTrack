using System;
using System.Collections.Generic;
using System.Text;

namespace CovidTrack.BLL.Models
{
    public class Localizacao
    {
        public int LocalizacaoId { get; set; }

        public float Latidude { get; set; }

        public float Longitude { get; set; }

        public virtual ICollection<LocalAtendimento> LocalAtendimentos { get; set; }
        public virtual ICollection<LocalUsuario> LocalUsuarios { get; set; }
    }
}
