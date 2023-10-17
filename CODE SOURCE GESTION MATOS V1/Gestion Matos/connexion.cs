using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Matos
{
    public partial class connexion : Form
    {
        public connexion()
        {
            InitializeComponent();
        } 

        private void button_connexion_Click(object sender, EventArgs e)
        {
            if(textBox_pseudo.Text == "faiz@gmail.com" && textBox_mdp.Text == "faiz")
            {
                Form1 frm = new Form1();
                frm.ShowDialog();
                Close();

            }
            else
            {
                error.Text = "Identifiant ou Mot de passe incorrecte(s)";
                
            }
        }
    }
}
