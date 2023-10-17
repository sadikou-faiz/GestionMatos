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

namespace Gestion_Matos
{
    public partial class site : Form
    {
        private string strcon = null;
        private SqlConnection cn = null;
        private SqlDataReader dr = null;
        private SqlCommand cm = null;
        public site()
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

        //function pour afficher la liste des sites

        private void chargeListSites()
        {
            //Connexion a la base de donnée SQL Server
            strcon = @".\SQLEXPRESS;Database=GestionMatos;Trusted_connection=True;";
            list_box_sites.Items.Clear(); //vider la liste d'abord
            //requete pour la liste
            initreq("select * from site");
            cn.Open();
            dr = cm.ExecuteReader(); //executer la requete

            while (dr.Read() == true)
            {
                list_box_sites.Items.Add(dr["Nom"]).ToString();
            }
            dr.Close();
            cn.Close();
        }

        private void site_Load(object sender, EventArgs e)
        {
            //lorsque la fennetre sera chargé , on vas afficher les clients
            chargeListSites();
            // ensuite appeller la fonction enable client avec le parametre true ;
            EnableClient(false);
            Btn_valider.Enabled = false;
        }


        //Select index change(selectionner les sites)
        private void list_box_sites_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableClient(true);
            Btn_valider.Enabled = false;
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestionMatos;Integrated Security=True");
            con.Open();
            string nom = list_box_sites.SelectedItem.ToString();
            string sql = "select * from Site where nom ='" + nom + "'";
            SqlCommand cm = new SqlCommand(sql, con);
            SqlDataReader dr = cm.ExecuteReader();
            dr.Read();
            text_box_site_id.Text = dr["SiteID"].ToString();
            textBox_nom.Text = dr["Nom"].ToString();
            text_box_adresse.Text = dr["Adresse"].ToString();
            con.Close();
        }

        //vider les champs pour ajouter un site
        private void Btn_nouveau_Click(object sender, EventArgs e)
        {
            text_box_site_id.Text = textBox_nom.Text = text_box_adresse.Text = "";
            textBox_nom.Focus();
            EnableClient(false);
            Btn_valider.Enabled = true;
        }
        //ajouter un client après avoir cliquer sur Nouveau
        private void Btn_valider_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestionMatos;Integrated Security=True");
            if (textBox_nom.Text == "" && text_box_adresse.Text == "")
            {
                MessageBox.Show("Remplissez les champs");
            }
            else
            {
                string sql = " insert into Site values ('" + textBox_nom.Text + "','" + text_box_adresse.Text + "')";
                con.Open();
                SqlCommand cm = new SqlCommand(sql, con);
                cm.ExecuteNonQuery();
                chargeListSites();
                con.Close();
                Btn_valider.Enabled = false;
            }
        }

        private void Btn_supprimer_Click(object sender, EventArgs e)
        {
            string message = " Voulez vous vraiment supprimer le  Site  '" + textBox_nom.Text + "' ? ";
            //Creer une petite fenetre d'attention qui portera les boutton oui ou Non
            DialogResult res = MessageBox.Show(message, "attention", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)//sI l'utilisateur a cliquer sur le boutton OUI (Yes)
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestionMatos;Integrated Security=True");
                try
                {

                    String sql = "delete from Site where nom = '" + textBox_nom.Text + "'";
                    con.Open();
                    SqlCommand cm = new SqlCommand(sql, con);
                    cm.ExecuteNonQuery();
                    chargeListSites();  // apres supression du materiel on réaffiche les nom des matériels , c'est comme un rafraichissement.
                                        //nous allons vider tous les champs
                    text_box_site_id.Text = textBox_nom.Text = text_box_adresse.Text = "";
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

        private void Btn_modification_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestionMatos;Integrated Security=True");
           try
            {
                String sql = "update Site set Nom ='" + textBox_nom.Text + "' , Adresse = '" + text_box_adresse.Text + "' where  SiteID = '" + text_box_site_id.Text + "'";
                con.Open();
                SqlCommand cm = new SqlCommand(sql, con);
                cm.ExecuteNonQuery();
                // apres supression du materiel on réaffiche les nom des matériels , c'est comme un rafraichissement.
                chargeListSites();
                //nous allons vider tous les champs
                text_box_site_id.Text = textBox_nom.Text = text_box_adresse.Text = "";
                DialogResult mes = MessageBox.Show("Site  Modifié", "", MessageBoxButtons.OK);
         
            }
            catch (Exception ex)
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

//Fin