using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POCMusicMoney.Models
{
    public class Credito
    {
        public Usuario cuenta { get; set; }
        public int Saldo { get; set; }

    }
}