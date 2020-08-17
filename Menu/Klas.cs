using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    public class Klas
    {
        public string Jaar { get; set; }
        public string Richting { get; set; }
        public List<Personen> leerlingen { get; set; } = new List<Personen>();

        public Klas(string jaar, string richting)
        {
            Jaar = jaar;
            Richting = richting;
           
        }

        public override string ToString()
        {
            return $"{Jaar}: {Richting}";
        }


    }
}
