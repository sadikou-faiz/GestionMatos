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

namespace GestionMatos_Matos
{
    public partial class Client : Form
    {
        private string strcon = null;
        private SqlConnection cn = null;
        private SqlDataReader dr = null;
        private SqlCommand cm = null;
      
        public Client()
        {
            InitializeComponent();
        }



        //Créer une fonction pour rendre rendre inutilisable les élément suivant :

        private void EnableClient(bool ena)
        {
            Btn_modification.Enabled = ena;
            Btn_supprimer.Enabled = ena;

        }
        //initialiser les requetes

        private void initreq(string sql)
        {
            cn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=GestionMatos;Trusted_connection=True;");
            cm = new SqlCommand(sql, cn);
        }

        //Fonction pour afficher la liste des clients

        private void chargeListclients()
        {
            //Connexion a la base de donnée SQL Server
            strcon = @".\SQLEXPRESS;Database=GestionMatos;Trusted_connection=True;";
            list_box_client.Items.Clear(); //vider la liste d'abord
            //requete pour la liste
            initreq("select * from client");
            cn.Open();
            dr = cm.ExecuteReader(); //executer la requete

            while (dr.Read() == true)
            {
                list_box_client.Items.Add(dr["Nom"]).ToString();
            }
            dr.Close();
            cn.Close();
        }

        private void client_Load(object sender, EventArgs e)
        {
            //lorsque la fennetre sera chargé , on vas afficher les clients
            chargeListclients();
            // ensuite appeller la fonction enable client avec le parametre true ;
            EnableClient(false);
            Btn_valider.Enabled = false;
        }

        //Selectionner les clients
        private void list_box_client_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableClient(true);
            Btn_valider.Enabled = false;
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestionMatos;Integrated Security=True");
            con.Open();
            string nom = list_box_client.SelectedItem.ToString();
            string sql = "select * from CLIENT where nom ='" + nom + "'";
            SqlCommand cm = new SqlCommand(sql, con);
            SqlDataReader dr = cm.ExecuteReader();
            dr.Read();
            text_box_client_id.Text = dr["ClientID"].ToString();
            textBox_nom.Text = dr["Nom"].ToString();
            text_box_mail.Text = dr["Mail"].ToString();
            textBox_tel.Text = dr["Tel"].ToString();
            con.Close();

        }
        //vider les champs pour ajouter un client

        private void Btn_nouveau_Click(object sender, EventArgs e)
        {

            text_box_client_id.Text = textBox_nom.Text = text_box_mail.Text = textBox_tel.Text = "";
            textBox_nom.Focus();
            EnableClient(false);
            Btn_valider.Enabled = true;


        }
        //ajouter un client après avoir cliquer sur Nouveu
        private void Btn_valider_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestionMatos;Integrated Security=True");
            if (textBox_nom.Text == "" && text_box_mail.Text == "" && textBox_tel.Text == "")
            {
                MessageBox.Show("Remplissez les champs");
            }
            else
            {
                string sql = " insert into Client values ('" + textBox_nom.Text + "','" + text_box_mail.Text + "','" + textBox_tel.Text + "')";
                con.Open();
                SqlCommand cm = new SqlCommand(sql, con);
                cm.ExecuteNonQuery();
                chargeListclients();
                con.Close();
                Btn_valider.Enabled = false;
            }

        }
        
        //Supprimer un client
        private void Btn_supprimer_Click(object sender, EventArgs e)
        {
            string message = " Voulez vous vraiment supprimer le  Client  '" + textBox_nom.Text + "' ? ";
            //Creer une petite fenetre d'attention qui portera les boutton oui ou Non
            DialogResult res = MessageBox.Show(message, "attention", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)//sI l'utilisateur a cliquer sur le boutton OUI (Yes)
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestionMatos;Integrated Security=True");
                try
                {
                   
                    String sql = "delete from Client where nom = '" + textBox_nom.Text + "'";
                    con.Open();
                    SqlCommand cm = new SqlCommand(sql, con);
                    cm.ExecuteNonQuery();
                    chargeListclients(); ; // apres supression du materiel on réaffiche les nom des matériels , c'est comme un rafraichissement.
                                           //nous allons vider tous les champs
                    textBox_nom.Text = text_box_client_id.Text = text_box_mail.Text = textBox_tel.Text = "";
                    DialogResult mes = MessageBox.Show("Client supprimé", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Suppression du client impossible", "Attention", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }

            
            }
        }
        //Modifier un client 
        private void Btn_modification_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestionMatos;Integrated Security=True");

           try
            {
                String sql = "update Client set Nom ='" + textBox_nom.Text + "' , Tel = '" + textBox_tel.Text + "' ,Mail = '" + text_box_mail.Text + "'  where ClientID = '" + text_box_client_id.Text + "'";
                con.Open();
                SqlCommand cm = new SqlCommand(sql, con);
                cm.ExecuteNonQuery();
                // apres supression du materiel on réaffiche les nom des matériels , c'est comme un rafraichissement.
                chargeListclients();
                //nous allons vider tous les champs
                textBox_nom.Text = text_box_client_id.Text = text_box_mail.Text = textBox_tel.Text = "";
                DialogResult mes = MessageBox.Show("Client  Modifié", "", MessageBoxButtons.OK);
              
            }
            catch(Exception ex)
            {
                MessageBox.Show("Modification impossible", "Attention", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }


    }
}
