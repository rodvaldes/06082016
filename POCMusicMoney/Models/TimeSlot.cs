using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POCMusicMoney.Models
{
    public class TimeSlot
    {
        public Guid IdTimeslot { get; set; }
        public Local Establecimiento { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }
        public ListaMaestra listaMedia { get; set; }

    }
}