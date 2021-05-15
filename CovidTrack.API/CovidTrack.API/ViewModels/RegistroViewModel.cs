using System;
using System.Collections.Generic;
using System.Text;

namespace CovidTrack.BLL.Models
{
    public class RegistroViewModel
    {
        public string Sobrenome { get; set; }
        public string Nome { get; set; }
        public byte[] Foto { get; set; }
        public DateTime DataDeNascimento { get; set; }

        public int ComorbidadeId { get; set; }

        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
