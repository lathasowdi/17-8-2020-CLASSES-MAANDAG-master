using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
   public class Personen
    {
        public string Naam { get; set; }
        public DateTime GeboorteDatum { get; set; }
        public string Geslacht { get; set; }

        public Personen(string naam, DateTime geboorteDatum, string geslacht)
        {
            Naam = naam;
            GeboorteDatum = geboorteDatum;
            Geslacht = geslacht;
        }

        public override string ToString()
        {
            return Naam;
        }
    }
}
