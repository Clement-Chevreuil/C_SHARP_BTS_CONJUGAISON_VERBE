using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verbe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        List<String> listGroupe = new List<String>();
        String verbe, personne;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                listGroupe.Add("tenir");
                listGroupe.Add("venir");
                listGroupe.Add("acquérir");
                listGroupe.Add("sentir");
                listGroupe.Add("vêtir");
                listGroupe.Add("ouvrir");
                listGroupe.Add("cueillir");
                listGroupe.Add("assaillir");
                listGroupe.Add("faillir");
                listGroupe.Add("bouillir");
                listGroupe.Add("dormir");
                listGroupe.Add("courir");
                listGroupe.Add("mourir");
                listGroupe.Add("servir");
                listGroupe.Add("fuir");
                listGroupe.Add("gésir");
                listGroupe.Add("recevoir");
                listGroupe.Add("voir");
                listGroupe.Add("aller");

            
        }

        private void cbVerbe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbPersonne_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAleatoire_Click(object sender, EventArgs e)
        {
            Random aleatoire = new Random();
            int temps = aleatoire.Next(1, 3); 
            int verbe = aleatoire.Next(1, 10);
            int personne = aleatoire.Next(1, 7);

            if (temps == 1)
            {
                cbTemps.Text = "Présent Indicatif";
            }
            else if (temps == 2)
            {
                cbTemps.Text = "Présent Impératif";
            }

            if (verbe == 1)
            {
                cbVerbe.Text = "Conjuguer";
            }
            else if (verbe == 2)
            {
                cbVerbe.Text = "Gagner";
            }
            else if (verbe == 3)
            {
                cbVerbe.Text = "Sécher";
            }
            else if (verbe == 4)
            {
                cbVerbe.Text = "Finir";
            }
            else if (verbe == 5)
            {
                cbVerbe.Text = "Choisir";
            }
            else if (verbe == 6)
            {
                cbVerbe.Text = "Frémir";
            }
            else if (verbe == 7)
            {
                cbVerbe.Text = "Prendre";
            }
            else if (verbe == 8)
            {
                cbVerbe.Text = "Peindre";
            }
            else if (verbe == 9)
            {
                cbVerbe.Text = "Rendre";
            }
             if (personne == 1)
            {
                cbPersonne.Text = "Je";
            }
            else if (personne == 2)
            {
                cbPersonne.Text = "Tu";
            }

            else if (personne == 3)
            {
                cbPersonne.Text = "Il/Elle/On";
            }
            else if (personne == 4)
            {
                cbPersonne.Text = "Nous";
            }
            else if (personne == 5)
            {
                cbPersonne.Text = "Vous";
            }
            else if (personne == 6)
            {
                cbPersonne.Text = "Ils/Elles/Ont";
            }



        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            verbe = cbVerbe.Text;
            personne = cbPersonne.Text;
            listGroupe.Contains(verbe);

            if (personne == "Je")
            {
                if (verbe == "etre" || verbe == "avoir")
                {
                    MessageBox.Show(verbe + " est un verbe un auxilaire");

                }
                else if (verbe.EndsWith("er"))
                {
                    MessageBox.Show(verbe + "e");

                }
                else if (listGroupe.Contains(verbe) || verbe.EndsWith("oir") || verbe.EndsWith("re"))
                {
                    MessageBox.Show(verbe + "s");
                }
                else if (verbe.EndsWith("ir"))
                {
                    MessageBox.Show(verbe + "is");
                }
            }
            else if (personne == "Tu")
            {
                if (verbe == "etre" || verbe == "avoir")
                {
                    MessageBox.Show(verbe + " est un verbe un auxilaire");

                }
                else if (verbe.EndsWith("er"))
                {
                    MessageBox.Show(verbe + "es");
                }
                else if (listGroupe.Contains(verbe) || verbe.EndsWith("oir") || verbe.EndsWith("re"))
                {
                    MessageBox.Show(verbe + "s");
                }
                else if (verbe.EndsWith("ir"))
                {
                    MessageBox.Show(verbe + "is");
                }
            }
            else if (personne == "Il/Elle/On")
            {
                if (verbe == "etre" || verbe == "avoir")
                {
                    MessageBox.Show(verbe + " est un verbe un auxilaire");

                }
                else if (verbe.EndsWith("er"))
                {
                    MessageBox.Show(verbe + "e");
                }
                else if (listGroupe.Contains(verbe) || verbe.EndsWith("oir") || verbe.EndsWith("re"))
                {
                    MessageBox.Show(verbe + "t");
                }
                else if (verbe.EndsWith("ir"))
                {
                    MessageBox.Show(verbe + "it");
                }
            }
            else if (personne == "Vous")
            {
                if (verbe == "etre" || verbe == "avoir")
                {
                    MessageBox.Show(verbe + " est un verbe un auxilaire");

                }
                else if (verbe.EndsWith("er"))
                {
                    MessageBox.Show(verbe + "ons");
                }
                else if (listGroupe.Contains(verbe) || verbe.EndsWith("oir") || verbe.EndsWith("re"))
                {
                    MessageBox.Show(verbe + "ons");
                }
                else if (verbe.EndsWith("ir"))
                {
                    MessageBox.Show(verbe + "issons");
                }
            }
            else if (personne == "Nous")
            {
                if (verbe == "etre" || verbe == "avoir")
                {
                    MessageBox.Show(verbe + " est un verbe un auxilaire");

                }
                else if (verbe.EndsWith("er"))
                {
                    MessageBox.Show(verbe + "ez");
                }
                else if (listGroupe.Contains(verbe) || verbe.EndsWith("oir") || verbe.EndsWith("re"))
                {
                    MessageBox.Show(verbe + "ez");
                }
                else if (verbe.EndsWith("ir"))
                {
                    MessageBox.Show(verbe + "issez");
                }
            }
            else if (personne == "Ils/Elles/Ont")
            {
                if (verbe == "etre" || verbe == "avoir")
                {
                    MessageBox.Show(verbe + " est un verbe un auxilaire");

                }
                else if (verbe.EndsWith("er"))
                {
                    MessageBox.Show(verbe + "ent");
                }
                else if (listGroupe.Contains(verbe) || verbe.EndsWith("oir") || verbe.EndsWith("re"))
                {
                    MessageBox.Show(verbe + "ent");
                }
                else if (verbe.EndsWith("ir"))
                {
                    MessageBox.Show(verbe + "issent");
                }
            }
        }
    }
}
