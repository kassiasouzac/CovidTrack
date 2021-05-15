using System;
using System.Collections.Generic;
using System.Text;

namespace CovidTrack.BLL.Models
{
    public class Vacinacao
    {
        public int VacinacaoId { get; set; }
        public string Marca { get; set; }

        public DateTime DataVacinacao { get; set; }

        public string UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public bool VacinaStatus { get; set; }

        public virtual ICollection<Notificacao> Notificacoes { get; set; }

    }
}
