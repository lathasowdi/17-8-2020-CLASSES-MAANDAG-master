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
    public partial class oef3 : Form
    {
        public oef3()
        {
            InitializeComponent();
        }
        Rapport rapport = new Rapport();
        private void oef3_Load(object sender, EventArgs e)
        {
            foreach (var key in rapport.rapportList.Keys)
            {
                comboBox1.Items.Add(key);
            }
            comboBox1.SelectedIndex = 0;
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            rapport.rapportList[comboBox1.Text].Add(Convert.ToInt32(textBox1.Text.Trim())) ;
            //textBox1.Text = "";
            comboBox1_SelectedIndexChanged(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rapport.rapportList[comboBox1.Text].RemoveAt(listBox1.SelectedIndex);
            comboBox1_SelectedIndexChanged(sender, e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = rapport.rapportList[comboBox1.Text];
            double avg = 0, sum = 0;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sum += Convert.ToDouble(listBox1.Items[i]);
            }
            avg = sum / listBox1.Items.Count;

            label1.Text = $"Gemiddelde : {Math.Round(avg, 2)}";
        }

        //private void textBox1_Leave(object sender, EventArgs e)
        //{
        //    rapport.rapportList[comboBox1.Text].Add(Convert.ToInt32(textBox1.Text.Trim()));
        //}
    }
}
