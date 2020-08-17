using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public class Teller
    {
        private int Mijnteller = 0;
        public Teller()
        {

        }
        public void Bekijk()
        {
            MessageBox.Show(Mijnteller.ToString());
        }
        public void Verhoog()
        {
            Mijnteller++;
        }
        public void Verminder()
        {
            Mijnteller--;
        }
        public void Reset()
        {
            Mijnteller = 0; ;
        }

    }
}
