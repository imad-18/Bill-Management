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
            LoadClientsToListView();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void ajouterClientBtn_Click(object sender, EventArgs e)
        {
            if (typeSoc_textBox.Text == "" || rs_textBox.Text == "" || nom_respo_textBox.Text == "" ||
                tel_textBox.Text == "" || portable_textBox.Text == "" || fax_textBox.Text == "" ||
                email_textBox.Text == "" || adresse_textBox.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.");
                return;
            }

            try
            {
                // Create an instance of your TableAdapter
                var adapter = new DataSet1TableAdapters.InfosClientsTableAdapter();

                // Insert the new client using the adapter (adjust parameters as per your schema)
                adapter.Insert(
                    nom_respo_textBox.Text,
                    typeSoc_textBox.Text,
                    nom_textBox.Text,
                    prenom_textBox.Text,
                    tel_textBox.Text,
                    portable_textBox.Text,
                    fax_textBox.Text,
                    email_textBox.Text,
                    adresse_textBox.Text,
                    ville_comboBox.Text,
                    pays_textBox.Text,
                    if_textBox.Text,
                    rs_textBox.Text,
                    rc_textBox.Text,
                    patente_textBox.Text,
                    ice_textBox.Text
                );
                MessageBox.Show(adapter.Connection.ConnectionString);

                MessageBox.Show("Client inséré dans la base de données avec succès.");
                LoadClientsToListView(); // <--- Refresh the ListView
                emptyTextBoxFields(); // Optional: Clear fields after insert
                                      // Add this temporarily to see the actual database path
                MessageBox.Show("Database path: " + adapter.Connection.DataSource);
                // or
                MessageBox.Show("Connection string: " + adapter.Connection.ConnectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'insertion : " + ex.Message);
            }
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

        private void LoadClientsToListView()
        {
            ClientListView.Items.Clear(); // Clear old items

            var adapter = new DataSet1TableAdapters.InfosClientsTableAdapter();
            var data = adapter.GetData(); // Get all rows

            foreach (DataSet1.InfosClientsRow row in data)
            {
                ListViewItem item = new ListViewItem(row.TypeClient); // First column
                item.SubItems.Add(row.ClientId.ToString());
                item.SubItems.Add(row.RS);
                item.SubItems.Add(row.NomRespo);
                item.SubItems.Add(row.Tel);
                item.SubItems.Add(row.Portable);
                item.SubItems.Add(row.Fax);
                item.SubItems.Add(row.Email);
                item.SubItems.Add(row.Adresse);
                ClientListView.Items.Add(item);
            }
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

                nom_textBox.Text = ClientListView.Items[i].SubItems[2].Text; 
                prenom_textBox.Text = ClientListView.Items[i].SubItems[3].Text;

                email_textBox.Text = ClientListView.Items[i].SubItems[7].Text;
                adresse_textBox.Text = ClientListView.Items[i].SubItems[8].Text;

                // Now fetch the full client data from the database
                int clientId = int.Parse(clientID_textBox.Text);
                var adapter = new DataSet1TableAdapters.InfosClientsTableAdapter();
                var fullData = adapter.GetDataByClientId(clientId);

                if (fullData.Count > 0)
                {
                    var row = fullData[0];

                    // Fill extra fields not in the ListView
                    nom_textBox.Text = row.IsNomNull() ? "" : row.Nom;
                    prenom_textBox.Text = row.IsPrenomNull() ? "" : row.Prenom;
                    if_textBox.Text = row.IsIFClientNull() ? "" : row.IFClient;
                    ice_textBox.Text = row.IsICENull() ? "" : row.ICE;
                    rc_textBox.Text = row.IsRCNull() ? "" : row.RC;
                    patente_textBox.Text = row.IsPatenteNull() ? "" : row.Patente;
                    pays_textBox.Text = row.IsPaysNull() ? "" : row.Pays;
                    ville_comboBox.Text = row.IsVilleNull() ? "" : row.Ville;
                }

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

        private void ville_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void emptyFieldsBtn_Click(object sender, EventArgs e)
        {
            emptyTextBoxFields();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            LoadClientsToListView();
        }
    }
}
