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
    public partial class oef4 : Form
    {
        public oef4()
        {
            InitializeComponent();
        }
        public Zwembad zwem = new Zwembad();
        
        private void button1_Click(object sender, EventArgs e)
        {
            zwem.Lengte = Convert.ToDouble(textBox1.Text);
            zwem.Breedte = Convert.ToDouble(textBox2.Text);
            zwem.Diepte = Convert.ToDouble(textBox3.Text);

            if (textBox1.Text != "0" && textBox2.Text != "0" && textBox3.Text != "0")
                zwem.Calculate(zwem.Lengte, zwem.Breedte, zwem.Diepte);
                

             
        }

        private void oef4_Load(object sender, EventArgs e)
        {

        }
    }
}
