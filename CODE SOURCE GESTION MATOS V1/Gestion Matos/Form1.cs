using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GestionMatos_Matos;

namespace Gestion_Matos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_materiel_Click(object sender, EventArgs e)
        {
            materiel frm = new materiel();
            frm.ShowDialog();
        }

        //quitter la fennetre

        private void button_quitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        //ouvrir la fennetre client
       
        //ouvrir la fennetre intervention
        private void Btn_interventions_Click(object sender, EventArgs e)
        {
             interventions frm = new interventions();
            frm.ShowDialog();
        }

        private void client_btn_Click(object sender, EventArgs e)
        {
                Client frm = new Client();
                frm.ShowDialog();
            
        }

        private void button_site_Click(object sender, EventArgs e)
        {
            site frm = new site();
            frm.ShowDialog();
        }

        private void button_type_Click(object sender, EventArgs e)
        {
            Type frm = new Type();
            frm.ShowDialog();
        }

       
    }
}
