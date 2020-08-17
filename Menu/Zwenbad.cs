using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public class Zwembad
    {
        public double Lengte { get; set; }
        public double Breedte { get; set; }
        public double Diepte { get; set; }
        public double volume { get; set; }

        public Zwembad()
        {
        }

        public void Calculate(double lengte,double breedte,double diepte)
        {
            volume= lengte * breedte * diepte;
            MessageBox.Show($"Zwembad kan {Math.Round(volume)} cubic feet water");
        }
    }
}
