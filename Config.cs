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
    public partial class Config : UserControl
    {
        public static Config instance;
        public Config()
        {
            InitializeComponent();
            instance = this;
        }

        private void calculButton_Click(object sender, EventArgs e)
        {
            calculButton.Enabled = false;
            Tableau.ltv.Items.Clear();

            DateTime now = DateTime.Now;
            Random random = new Random();
            int rand;
            float rendAnneeMoyen, profitAnnee, anneePrecedente;
            float pea = (float)montantInitNumericUpDown.Value;


            for (int annee = now.Year; annee < now.Year + anneeTrackBar.Value; annee++)
            {
                if (!rendementAnnuelMoyenCheckBox.Checked && rendementTrackBar.Value == 0) rand = random.Next(6, 11);
                else if (rendementAnnuelMoyenCheckBox.Checked && rendementTrackBar.Value == 0) rand = 8;
                else rand = rendementTrackBar.Value;

                if (annee == now.Year && !premiereAnneeCheckBox.Checked)
                {
                    rand /= 2;
                    rendAnneeMoyen = (rand / 100f) + 1f;// on considere qu'on a commencé en cour d'année
                    anneePrecedente = (float)montantInitNumericUpDown.Value;
                }
                else
                {
                    anneePrecedente = pea;
                    pea += (float)ajoutMensuelNumericUpDown.Value * 12f;
                    rendAnneeMoyen = (rand / 100f) + 1f;
                }

                pea *= rendAnneeMoyen;
                profitAnnee = pea - anneePrecedente;


                ListViewItem item = new ListViewItem(annee.ToString());
                item.SubItems.Add(String.Format("{0:0.00}", pea) + '€');
                item.SubItems.Add(rand.ToString() + '%');
                item.SubItems.Add(String.Format("{0:0.00}", profitAnnee - (float)ajoutMensuelNumericUpDown.Value * 12f) + '€');
                Tableau.ltv.Items.Add(item);

            }

            string[] tabTmp = new string[Tableau.ltv.Items.Count + 1];
            for (int i = 0; i < Tableau.ltv.Items.Count; i++)
            {
                if (Tableau.ltv.Items.Count - 1 == i)
                {
                    Tableau.ltv.Items[i].SubItems[3].Text = "";
                    break;
                }
                tabTmp[i] = Tableau.ltv.Items[i+1].SubItems[3].Text;
                Tableau.ltv.Items[i].SubItems[3].Text = tabTmp[i];
            }

            for (int i = 0; i < Tableau.ltv.Columns.Count; i++)
            {
                //Tableau.ltv.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
                Tableau.ltv.Columns[i].TextAlign = HorizontalAlignment.Center;
            }
            calculButton.Enabled = true;
        }

        private void montantInitNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            montantTotalLabel.Text = "Montant ton total injecté sur " + anneeTrackBar.Value.ToString() + " ans : " + MontantTotalCalcul().ToString() + "€";
        }

        private void ajoutMensuelNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            montantTotalLabel.Text = "Montant ton total injecté sur " + anneeTrackBar.Value.ToString() + " ans : " + MontantTotalCalcul().ToString() + "€";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            anneeLabel.Text = "Durée du PEA : " + anneeTrackBar.Value.ToString() + " ans.";
            montantTotalLabel.Text = "Montant ton total injecté sur " + anneeTrackBar.Value.ToString() + " ans : " + MontantTotalCalcul().ToString() + "€";
        }

        private void Config_Load(object sender, EventArgs e)
        {
            montantTotalLabel.Text = "Montant ton total injecté sur " + anneeTrackBar.Value.ToString() + " ans : " + MontantTotalCalcul().ToString() + "€";
        }

        private void rendementTrackBar_Scroll(object sender, EventArgs e)
        {
            if (rendementTrackBar.Value == 0)
            {
                rendementLabel.Text = "Rendement annuel en % : Aléatoire";
                rendementAnnuelMoyenCheckBox.Enabled = true;
            }
            else
            {
                rendementLabel.Text = "Rendement annuel en % : " + rendementTrackBar.Value.ToString() + "%";
                rendementAnnuelMoyenCheckBox.Enabled = false;
                rendementAnnuelMoyenCheckBox.Checked = false;
            }
        }

        private long MontantTotalCalcul()
        {
            return (long)(montantInitNumericUpDown.Value + ajoutMensuelNumericUpDown.Value * 12 * anneeTrackBar.Value);
        }
    }
}
