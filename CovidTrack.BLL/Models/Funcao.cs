﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CovidTrack.BLL.Models
{
    public class Funcao : IdentityRole<string>
    {
        public string Descricao { get; set; }
    }
}
