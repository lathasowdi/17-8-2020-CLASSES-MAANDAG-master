using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class oef1 : Form
    {
        public oef1()
        {
            InitializeComponent();
        }
        private Teller mijnteller = new Teller();
        private void button1_Click(object sender, EventArgs e)
        {
            mijnteller.Bekijk();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mijnteller.Verhoog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mijnteller.Verminder();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mijnteller.Reset();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void oef1_Load(object sender, EventArgs e)
        {

        }
    }
}
