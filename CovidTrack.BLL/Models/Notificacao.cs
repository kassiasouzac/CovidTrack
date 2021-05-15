using System;
using System.Collections.Generic;
using System.Text;

namespace CovidTrack.BLL.Models
{
    public class Notificacao
    { 

        public int NotificacaoId { get; set; }

        public DateTime DataSegundaDose { get; set; }

        public int VacinacaoId { get; set; }
        public Vacinacao Vacinacao { get; set; }

        public string UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public bool Status { get; set; }
    }
}
