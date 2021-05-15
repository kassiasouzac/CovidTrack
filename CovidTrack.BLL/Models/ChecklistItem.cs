using System;
using System.Collections.Generic;
using System.Text;

namespace CovidTrack.BLL.Models
{
    public class ChecklistItem
    {
        public int ItemId { get; set; }
        public string Conteudo { get; set; }

        public virtual ICollection<Checklist> Checklists { get; set; }
    }
}
