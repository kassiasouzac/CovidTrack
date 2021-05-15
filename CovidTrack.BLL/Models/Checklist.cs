using System;
using System.Collections.Generic;
using System.Text;

namespace CovidTrack.BLL.Models
{
    public class Checklist
    {
        public int ChecklistId { get; set; }

        public bool IsCheck { get; set; }

        public int ItemId { get; set; }

        public ChecklistItem ChecklistItem { get; set; }

        public string UsuarioId { get; set; }

        public Usuario Usuario { get; set; }

       
    }
}
