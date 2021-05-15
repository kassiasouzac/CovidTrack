using System;
using System.Collections.Generic;
using System.Text;

namespace CovidTrack.BLL.Models
{
    public class LocalUsuario
    {
        public int LocalId { get; set; }

        public string NomeLocal { get; set; }

        public int LocalizacaoId { get; set; }

        public Localizacao Localizacao { get; set; }

        public string UsuarioId { get; set; }

        public Usuario Usuario { get; set; }
    }
}
