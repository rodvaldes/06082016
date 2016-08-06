using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POCMusicMoney.Models
{
    public class ListaMaestra
    {
        public Guid Id { get; set; }
        public DateTime Fecha { get; set; }
        public Local Establecimiento   { get; set; }
        public List<Espacio> ListaVariable { get; set; }


    }
}