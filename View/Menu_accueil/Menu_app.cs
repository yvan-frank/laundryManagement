using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Menu_accueil
{
    public partial class Menu_app : Form
    {
        public Menu_app()
        {
            InitializeComponent();
        }

        private void btnDeconn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {

        }
    }
}
