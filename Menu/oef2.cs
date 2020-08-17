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
    public partial class oef2 : Form
    {
        public oef2()
        {
            InitializeComponent();
        }
        Televisie televisie = new Televisie();
        private void oef2_Load(object sender, EventArgs e)
        {

            label1.Text = televisie.ToString();
            }

           
        private void button1_Click(object sender, EventArgs e)
        {
            televisie.Volumeincrease();
            label1.Text = televisie.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            televisie.Volumedecrease();
            label1.Text = televisie.ToString();
        }

      
        private void button3_Click_1(object sender, EventArgs e)
        {
            televisie.kanaalincrease();
            label1.Text = televisie.ToString();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            televisie.kanaaldecrease();
            label1.Text = televisie.ToString();
        }
    }
    }

