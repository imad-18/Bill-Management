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
    public partial class MenuForm: Form
    {
        public MenuForm()
        {
            InitializeComponent();
            //btnClientDashboard.Click += btnClientDashboard_Click;
            //btnFactureDashboard.Click += btnFactureDashboard_Click;
        }

        private void btnClientDashboard_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm.Show();
        }

        private void btnFactureDashboard_Click(object sender, EventArgs e)
        {
            Form1 factureForm = new Form1();
            factureForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
