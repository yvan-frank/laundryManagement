using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Connectio_interface;
using View.Menu_accueil;

namespace View
{
    public partial class Connexion_in : Form
    {
        public Connexion_in()
        {
            InitializeComponent();
        }


        private void Connexion_Load(object sender, EventArgs e)
        {
            if (chkMdp.Checked)
            {
                RecuperationMdp recuperation = new RecuperationMdp();
                recuperation.ShowDialog();
            }
        }

        public void afficherForm(object panele,object form)
        {
            Panel pan = panele as Panel;
            if(pan.Controls.Count > 0)
                pan.Controls.RemoveAt(0);
            Form formulaire = form as Form;
            formulaire.TopLevel = false;
            formulaire.Dock = DockStyle.Fill;
            pan.Controls.Add(formulaire);
            pan.Tag = formulaire;
            formulaire.Show();
        }


        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            panAdmin.Visible = true;
            //btnQuit.Location = new Point(600,380);
            //btnAdmin.Visible = false;
            //afficherForm(panAdmin,new Admin());
            //panGerant.Visible = false;
            if (panAdmin.Visible)
            {
                //btnAdmin.Location = new Point(128, 12);
                //btnGerant.Location = new Point(128, 213);
                //btnQuit.Location = new Point(128, 412);
                lblId.Text = "Identifiant:";
                label1.Visible = false;
                gunaPictureBox1.Visible = true;
                picGerant.Visible = false;
                chkMdp.Visible = false;
                txtMdp.Clear();
                txtId.Clear();
            }
        }

        private void btnQuit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGerant_Click(object sender, EventArgs e)
        {
            panAdmin.Visible = true;
            if (panAdmin.Visible)
            {
                lblId.Text = "Nom d'utilisateur:";
                gunaPictureBox1.Visible = false;
                picGerant.Visible = true;
                txtId.Clear();
                txtMdp.Clear();
                chkMdp.Visible = true;
            }
        }

        private void chkMdp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMdp.Checked)
            {
                RecuperationMdp recuperation = new RecuperationMdp();
                recuperation.ShowDialog();
            }
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "gerant" && txtMdp.Text == "gerant")
            {
                this.Hide();
                Menu_app menuApp = new Menu_app();
                menuApp.Show();
            }
            else if(txtId.Text == "admin" && txtMdp.Text == "admin")
            {
                MessageBox.Show("vous etes connecte en tant que admin");
            }
        }
    }
}
