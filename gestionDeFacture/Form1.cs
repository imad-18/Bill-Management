using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionDeFacture
{
    public partial class Form1: MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        
        



        private void CalculTVA()
        {

            double THTC = 0, TTVA = 0;
            //Calcul Total 
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                THTC += Convert.ToDouble(listView1.Items[i].SubItems[3].Text);
                TTVA += Convert.ToDouble(listView1.Items[i].SubItems[4].Text);
            }
            // Affichage Calcul 
            TotalHT_textBox.Text = THTC.ToString();
            TTVA_textBox.Text = TTVA.ToString();
            totalAPayer_textBox.Text = (THTC + TTVA).ToString();
        }

        private void emptyTextBoxFields()
        {
            designationTextBox.Clear();
            prixTextBox.Clear();
            quantiteTextBox.Clear();
            referenceTextBox.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verification de la ligne séléctionner 
            if (listView1.SelectedIndices.Count > 0)
            {
                //MessageBox.Show("Item selected");
                // indice de la ligne sélectionnée 
                int i = listView1.SelectedIndices[0];
               
                // Récuperation des données de la ListView vers les TextBox 
                designationTextBox.Text = listView1.Items[i].SubItems[0].Text;
                prixTextBox.Text = listView1.Items[i].SubItems[1].Text;
                quantiteTextBox.Text = listView1.Items[i].SubItems[2].Text;
                referenceTextBox.Text = listView1.Items[i].SubItems[6].Text;
                //Conditions si ligne sélectionnée représente un produit avec TVA à 20% ou 7% 
                if (Convert.ToDouble(listView1.Items[i].SubItems[4].Text) == 0.2 *
                Convert.ToDouble(listView1.Items[i].SubItems[3].Text))
                {
                    radioButton2.Checked = true;
                }
                else
                {
                    radioButton1.Checked = true;
                }

          
            }
        }


        private void AjouterButton_Click(object sender, EventArgs e)
        {
            decimal tvalue = 0.0m;
            // Always update tvalue before calculations
            if (radioButton1.Checked)
            {
                tvalue = 0.07m;
            }
            else if (radioButton2.Checked)
            {
                tvalue = 0.2m;
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un taux de TVA !");
                return;
            }
            // Création d'un nouvel item
            ListViewItem it = new ListViewItem(designationTextBox.Text); // First column: Designation

            // SubItems: Prix, Quantité, Montant HT, Montant TVA, Total TTC, Référence
            it.SubItems.Add(prixTextBox.Text); // Prix
            it.SubItems.Add(quantiteTextBox.Text); // Quantité

            if (decimal.TryParse(prixTextBox.Text, out decimal prix) &&
                int.TryParse(quantiteTextBox.Text, out int quantite))
            {
                decimal MHT = prix * quantite; // Montant HT
                decimal montantTVA = MHT * (tvalue); // Montant TVA
                decimal totalTTC = MHT + montantTVA; // Total TTC

                it.SubItems.Add(MHT.ToString());        // Montant HT
                it.SubItems.Add(montantTVA.ToString());  // Montant TVA
                it.SubItems.Add(totalTTC.ToString());    // Total TTC
            }
            else
            {
                MessageBox.Show("Erreur dans le Prix ou la Quantité !");
                return;
            }

            it.SubItems.Add(referenceTextBox.Text); // Référence

            // Ajouter l'item au ListView
            listView1.Items.Add(it);

            // Optionnel: Vider les TextBox après l'ajout
            emptyTextBoxFields();


            CalculTVA();
        }

        private void supprimer_button_Click(object sender, EventArgs e)
        {
            // Verification de la ligne séléctionner 
            if (listView1.SelectedIndices.Count > 0)
            {

                // indice de la ligne sélectionnée 
                int i = listView1.SelectedIndices[0];
                MessageBox.Show("Item " + i + " has been deleted successfully!!");

                listView1.Items[i].Remove();


                CalculTVA();
                emptyTextBoxFields();
            }
            else
            {
                MessageBox.Show("Please select an item from the list.");
            }

        }

        private void modifier_button_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                int i1 = listView1.SelectedIndices[0];
                decimal tvalue = 0.0m;

                if (radioButton1.Checked == true)
                {
                    tvalue = 0.07m;
                }
                if (radioButton2.Checked == true)
                {
                    tvalue = 0.2m;
                }
               

                if (decimal.TryParse(prixTextBox.Text, out decimal prix) &&
                    int.TryParse(quantiteTextBox.Text, out int quantite))
                {
                    listView1.Items[i1].SubItems[0].Text = designationTextBox.Text;
                    listView1.Items[i1].SubItems[1].Text = prixTextBox.Text;
                    listView1.Items[i1].SubItems[2].Text = quantiteTextBox.Text;
                    

                    decimal MHT = prix * quantite; // Montant HT
                    decimal montantTVA = MHT * (tvalue); // Montant TVA
                    decimal totalTTC = MHT + montantTVA; // Total TTC

                    listView1.Items[i1].SubItems[3].Text = MHT.ToString();
                    listView1.Items[i1].SubItems[4].Text = montantTVA.ToString();
                    listView1.Items[i1].SubItems[5].Text = totalTTC.ToString();

                    listView1.Items[i1].SubItems[6].Text = referenceTextBox.Text;

                    CalculTVA();
                    emptyTextBoxFields();
                }
                else
                {
                    MessageBox.Show("Erreur dans la modification du Prix ou de la Quantité !");
                    return;
                }
                
            }
            

        }

        private void quiter_button_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }



        private void metroButton1_Click(object sender, EventArgs e)
        {

        }


    }
}
