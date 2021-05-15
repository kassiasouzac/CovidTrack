using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CovidTrack.BLL.Models
{
    public class Usuario : IdentityUser<string>
    {
        public DateTime DataDeNascimento { get; set; }
        public string Sobrenome { get; set; }
        public string Nome { get; set; }
        public byte[] Foto { get; set; }

        public int ComorbidadeId { get; set; }

        public CategoriaComorbidade CategoriaComorbidade { get; set; }

        public virtual ICollection<Checklist> Checklists { get; set; }
        public virtual ICollection<LocalUsuario> LocalUsuarios { get; set; }
        public virtual ICollection<Notificacao> Notificacoes { get; set; }
        public virtual ICollection<Questionario> Questionarios { get; set; }
        
        public virtual ICollection<Vacinacao> Vacinacoes { get; set; }

    }
}
