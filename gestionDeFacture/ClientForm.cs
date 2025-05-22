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
    public partial class ClientForm: Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void ajouterClientBtn_Click(object sender, EventArgs e)
        {
            // Création d'un nouvel item client
            ListViewItem clientListView = new ListViewItem(typeSoc_textBox.Text); // First column: Designation

            // SubItems: client ID, ... Adresse
            if (typeSoc_textBox != null && clientID_textBox != null &&
                rs_textBox != null && nom_respo_textBox != null &&
                tel_textBox != null && portable_textBox != null &&
                fax_textBox != null && email_textBox != null &&
                adresse_textBox != null)
            {


                clientListView.SubItems.Add(clientID_textBox.Text);
                clientListView.SubItems.Add(rs_textBox.Text);
                clientListView.SubItems.Add(nom_respo_textBox.Text);
                clientListView.SubItems.Add(tel_textBox.Text);
                clientListView.SubItems.Add(portable_textBox.Text);
                clientListView.SubItems.Add(fax_textBox.Text);
                clientListView.SubItems.Add(email_textBox.Text);
                clientListView.SubItems.Add(adresse_textBox.Text);
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs avant d'ajouter un client.");
                return;
            }

            MessageBox.Show("Client ajouté avec succès.");
            // Ajouter l'item au ListView
            ClientListView.Items.Add(clientListView);

            // Optionnel: Vider les TextBox après l'ajout
            emptyTextBoxFields();
        }

        private void emptyTextBoxFields()
        {
            typeSoc_textBox.Clear();
            clientID_textBox.Clear();
            rs_textBox.Clear();
            nom_respo_textBox.Clear();
            tel_textBox.Clear();
            portable_textBox.Clear();
            fax_textBox.Clear();
            email_textBox.Clear();
            adresse_textBox.Clear();

            if_textBox.Clear();
            ice_textBox.Clear();
            rc_textBox.Clear();
            patente_textBox.Clear();
            nom_textBox.Clear();
            prenom_textBox.Clear();
            pays_textBox.Clear();
            ville_comboBox.Items.Clear();
        }

        private void ClientListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verification de la ligne séléctionner 
            if (ClientListView.SelectedIndices.Count > 0)
            {
                //MessageBox.Show("Item selected");
                // indice de la ligne sélectionnée 
                int i = ClientListView.SelectedIndices[0];

                // Récuperation des données de la ListView vers les TextBox 
                typeSoc_textBox.Text = ClientListView.Items[i].SubItems[0].Text;
                clientID_textBox.Text = ClientListView.Items[i].SubItems[1].Text;
                rs_textBox.Text = ClientListView.Items[i].SubItems[2].Text;
                nom_respo_textBox.Text = ClientListView.Items[i].SubItems[3].Text;
                tel_textBox.Text = ClientListView.Items[i].SubItems[4].Text;
                portable_textBox.Text = ClientListView.Items[i].SubItems[5].Text;
                fax_textBox.Text = ClientListView.Items[i].SubItems[6].Text;
                email_textBox.Text = ClientListView.Items[i].SubItems[7].Text;
                adresse_textBox.Text = ClientListView.Items[i].SubItems[8].Text;

            }
        }

        private void modifierClientBtn_Click(object sender, EventArgs e)
        {
            // Verification de la ligne séléctionner 
            if (ClientListView.SelectedIndices.Count > 0)
            {
                //MessageBox.Show("Item selected");
                // indice de la ligne sélectionnée 
                int lv = ClientListView.SelectedIndices[0];

                ClientListView.Items[lv].SubItems[0].Text = typeSoc_textBox.Text;
                ClientListView.Items[lv].SubItems[1].Text = clientID_textBox.Text;
                ClientListView.Items[lv].SubItems[2].Text = rs_textBox.Text;
                ClientListView.Items[lv].SubItems[3].Text = nom_respo_textBox.Text;
                ClientListView.Items[lv].SubItems[4].Text = tel_textBox.Text;
                ClientListView.Items[lv].SubItems[5].Text = portable_textBox.Text;
                ClientListView.Items[lv].SubItems[6].Text = fax_textBox.Text;
                ClientListView.Items[lv].SubItems[7].Text = email_textBox.Text;
                ClientListView.Items[lv].SubItems[8].Text = adresse_textBox.Text;

                // Optionnel: Vider les TextBox après la modification
                emptyTextBoxFields();
                MessageBox.Show("Client modifié avec succès.");

            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un client à modifier.");
            }
        }
    }
}
