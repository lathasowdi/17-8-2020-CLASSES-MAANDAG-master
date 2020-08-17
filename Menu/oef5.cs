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
    public partial class oef5 : Form
    {
        public oef5()
        {
            InitializeComponent();
        }

        School school = new School();
        private void oef5_Load(object sender, EventArgs e)
        {
            school.klassenlijst.Add (new Klas("TweedeMiddelbaar", "Informatica"));
            school.klassenlijst.Add(new Klas("DerdeMiddelbaar", "Wiskude"));
            school.klassenlijst.Add(new Klas("vierdeMiddelbaar", "Wetenscappen"));
            school.klassenlijst.Add( new Klas("FifdeMiddelbaar", "Talen"));
            comboBox1.DataSource = school.klassenlijst;
            comboBox1.SelectedIndex = 0;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = school.klassenlijst[comboBox1.SelectedIndex].leerlingen;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string geslacht = ""; 
            foreach(var item in groupBox1.Controls.OfType<RadioButton>())
            {
                if (item.Checked)
                    geslacht = item.Text;
            }
            Personen leerling = new Personen(textBox1.Text, dateTimePicker1.Value, geslacht);
           school.klassenlijst[comboBox1.SelectedIndex].leerlingen.Add(leerling);
            listBox1.DataSource = null;
            listBox1.DataSource = school.klassenlijst[comboBox1.SelectedIndex].leerlingen;
        }

        
    }
}
