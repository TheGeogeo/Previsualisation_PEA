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
    public partial class Tableau : UserControl
    {
        public static Tableau instance;
        public static ListView ltv;
        public Tableau()
        {
            InitializeComponent();
            instance = this;
            ltv = listView1;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Tableau_Load(object sender, EventArgs e)
        {
            /*
             * Année
             * cumul ajout année
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             */
        }
    }
}
