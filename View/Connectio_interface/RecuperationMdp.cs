using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Menu_accueil;

namespace View.Connectio_interface
{
    public partial class RecuperationMdp : Form
    {
        public RecuperationMdp()
        {
            InitializeComponent();
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
           
            Connexion_in connexion = new Connexion_in();
            connexion.Hide();

            Menu_app menuApp = new Menu_app();

            menuApp.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
