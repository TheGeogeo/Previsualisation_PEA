using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Previsualisation_PEA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tableau1.Hide();
            config1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            config1.Show();
            config1.BringToFront();
            tableau1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableau1.Show();
            tableau1.BringToFront();
            config1.Hide();
        }
    }
}
