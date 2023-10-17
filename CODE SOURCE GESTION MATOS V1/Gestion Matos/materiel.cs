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
    public partial class materiel : Form
    {

        private string strcon = null;
        private SqlConnection cn = null;
        private SqlDataReader dr = null;
        private SqlCommand cm = null;
        public materiel()
        {
            InitializeComponent();
        }

        private void EnableMateriel(bool ena)
        {
            button_supprimer.Enabled = ena;
            button_modifier.Enabled = ena;

        }
        private void initreq(string sql)
        {
            cn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=GestionMatos;Trusted_connection=True;");
            cm = new SqlCommand(sql, cn);
        }
        //Les listes déroulantes

        private void afficher_client(string req1)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestionMatos;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(req1, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table1 = new DataTable();
            da.Fill(table1);
            comboBox_clients.DataSource = table1;
            comboBox_clients.ValueMember = "ClientID";
            comboBox_clients.DisplayMember = "Nom";
        }
        private void afficher_site(string req2)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestionMatos;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(req2, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table2 = new DataTable();
            da.Fill(table2);
            comboBox_sites.DataSource = table2;
            comboBox_sites.ValueMember = "SiteID";
            comboBox_sites.DisplayMember = "Nom";
        }
        private void afficher_type(string req3)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestionMatos;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(req3, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table3 = new DataTable();
            da.Fill(table3);
            comboBox_types.DataSource = table3;
            comboBox_types.ValueMember = "TypeID";
            comboBox_types.DisplayMember = "Nom";
        }

        //Générer la liste des materiels 


        private void list_des_clients_combobox(string req4)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestionMatos;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(req4, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table4 = new DataTable();
            da.Fill(table4);
            DataRow itemrow = table4.NewRow();
            itemrow[1] = "Choissisez le Client";
            table4.Rows.InsertAt(itemrow, 0);
            comboBox_clients.DataSource = table4;
            comboBox_clients.DisplayMember = "Nom";
            comboBox_clients.ValueMember = "ClientID";
            con.Close();
        }
        private void list_des_sites_combobox(string req5)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestionMatos;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(req5, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table5 = new DataTable();
            da.Fill(table5);
            DataRow itemrow = table5.NewRow();
            itemrow[1] = "Choissisez le site";
            table5.Rows.InsertAt(itemrow, 0);
            comboBox_sites.DataSource = table5;
            comboBox_sites.DisplayMember = "Nom";
            comboBox_sites.ValueMember = "SiteID";
            con.Close();
        }
        private void list_des_types_combobox(string req6)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestionMatos;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(req6, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table6 = new DataTable();
            da.Fill(table6);
            DataRow itemrow = table6.NewRow();
            itemrow[1] = "Choissisez le type";
            table6.Rows.InsertAt(itemrow, 0);
            comboBox_types.DataSource = table6;
            comboBox_types.DisplayMember = "Nom";
            comboBox_types.ValueMember = "TypeID";
            con.Close();
        }


        //Crer une fonction qui affiche la liste noms des materiels

        private void Chargeliste_materiel()
        {
            //Connexion a la base de donnée SQL Server
            strcon = @".\SQLEXPRESS;Database=GestionMatos;Trusted_connection=True;";
            liste_materiels.Items.Clear(); //vider la liste d'abord
            //requete pour la liste
            initreq("select * from Materiel");
            cn.Open();
            dr = cm.ExecuteReader(); //executer la requete

            while (dr.Read() == true)
            {
                liste_materiels.Items.Add(dr["Nom"]).ToString();
            }
            dr.Close();
            cn.Close();
        }
       
       

        //Liste des matériels
        private void materiel_Load(object sender, EventArgs e)
        {
            //lorsque la fennetre sera chargé , on vas afficher les clients
            Chargeliste_materiel();
            // ensuite appeller la fonction enable client avec le parametre true ;
            EnableMateriel(false);
            button_valider.Enabled = false;

        }

       
        

       
        

       
        // Selected INdex CHnage qui nous permet de selectionner chaque element ayant raport au nom dans les text box
        private void liste_materiels_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableMateriel(true);
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestionMatos;Integrated Security=True");
            con.Open();
            button_valider.Enabled = false;
            string nom = liste_materiels.SelectedItem.ToString();
            string sql = "select * from MATERIEL where nom ='"+ nom +"'";
            SqlCommand cm = new SqlCommand(sql, con);
            SqlDataReader dr = cm.ExecuteReader();
            dr.Read();
            textBox_nom_materiel.Text = dr["Nom"].ToString();
            textBox_num_serie.Text = dr["NoSerie"].ToString();
            textBox_date_install.Text = dr["DateInstallation"].ToString();
            textBox_description.Text = dr["Description"].ToString();
            textBox_mtbf.Text = dr["MTBF"].ToString();
            textBox_materiel_id.Text = dr["MaterielID"].ToString();
            textBox_siteID.Text = dr["SiteID"].ToString();
            textBox_typeID.Text = dr["TypeID"].ToString();
            textBox_clientID.Text = dr["ClientID"].ToString();
            //afficher client
            String id_client = dr["ClientID"].ToString();
            string req1 = "Select Nom , ClientID  from Client where ClientID='" + id_client + "'";
            afficher_client(req1);
            //afficher site
            String id_site = dr["SiteID"].ToString();
            string req2 = "Select Nom , SiteID  from Site where SiteID='" + id_site + "'";
            afficher_site(req2);
            //afficher client
            String id_type = dr["TypeID"].ToString();
            string req3 = "Select Nom , TypeID  from Type where TypeID='" + id_type + "'";
            afficher_type(req3);
            con.Close();
        }
    
      




        
        

        private void nouveau_btn_Click(object sender, EventArgs e)
        {
            //vider les text box pour crere un nouveau materiel

            textBox_clientID.Text = textBox_typeID.Text = textBox_siteID.Text= textBox_nom_materiel.Text = textBox_num_serie.Text = textBox_materiel_id.Text = textBox_date_install.Text = textBox_description.Text = textBox_mtbf.Text = "";
            textBox_nom_materiel.Focus();
            EnableMateriel(false);
            button_valider.Enabled = true;
            // fonction pour remplir la combobox avec le nom des clients , sites et types
            string req4 = "Select * from Client";
            list_des_clients_combobox(req4);
            string req5 = "Select * from Site";
            list_des_sites_combobox(req5);
            string req6 = "Select * from Type";
            list_des_types_combobox(req6);

        }
        //Ajouter le matériel





        //suprimer un materiel
        private void button_supprimer_Click(object sender, EventArgs e)
        {
            string message = " Voulez vous vraiment supprimer le materiel '" + textBox_nom_materiel.Text + "' ? ";
            //Creer une petite fenetre d'attention qui portera les boutton oui ou Non
            DialogResult res = MessageBox.Show(message, "Attention", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)//sI l'utilisateur a cliquer sur le boutton OUI (Yes)
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestionMatos;Integrated Security=True");
                try
                {
                    String sql = "delete from MATERIEL where nom = '" + textBox_nom_materiel.Text + "'";
                    con.Open();
                    SqlCommand cm = new SqlCommand(sql, con);
                    cm.ExecuteNonQuery();
                    Chargeliste_materiel(); // apres supression du materiel on réaffiche les nom des matériels , c'est comme un rafraichissement.
                                            //nous allons vider tous les champs
                  comboBox_sites.Text = comboBox_types.Text= textBox_clientID.Text = textBox_typeID.Text = textBox_siteID.Text = textBox_nom_materiel.Text = textBox_num_serie.Text = textBox_materiel_id.Text = textBox_date_install.Text = textBox_description.Text = textBox_mtbf.Text = "";
                    DialogResult mes = MessageBox.Show("Matériel supprimer", "Succes", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    button_valider.Enabled = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Suppression Impossible", "Echec", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
                
            }
        }

        private void button_valider_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestionMatos;Integrated Security=True");
            try
           {
                
                string sql = " insert into MATERIEL values ('" + textBox_nom_materiel.Text + "',' " + textBox_num_serie.Text + "','" + textBox_date_install.Text + "','" + textBox_mtbf.Text + "','" + textBox_description.Text + "','" + textBox_siteID.Text + "','" + textBox_clientID.Text + "','" + textBox_typeID.Text + "')";
          
               
                con.Open();
                SqlCommand cm = new SqlCommand(sql, con);
                cm.ExecuteNonQuery();
                Chargeliste_materiel();

                MessageBox.Show("Matériel ajouté !", "Succes", MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Insertion Impossible", "Echec", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
           }
           finally{
                con.Close();
           }
           
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestionMatos;Integrated Security=True");
            try
            {
              
                String sql = "update Materiel set Nom ='" + textBox_nom_materiel.Text + "' , NoSerie = '" + textBox_num_serie.Text + "' ,DateInstallation = '" + textBox_date_install.Text + "' , MTBF = '" + textBox_mtbf.Text + "' , Description = '" + textBox_description.Text + "' , SiteID = '" + textBox_siteID.Text + "' , ClientID = '" + textBox_clientID.Text + "' ,  TypeID = '" + textBox_typeID.Text + "'   where MaterielID = '" + textBox_materiel_id.Text + "'";
                con.Open();
                SqlCommand cm = new SqlCommand(sql, con);
                cm.ExecuteNonQuery();
                // apres supression du materiel on réaffiche les nom des matériels , c'est comme un rafraichissement.
                Chargeliste_materiel();
                //nous allons vider tous les champs
                comboBox_clients.Text = comboBox_sites.Text = comboBox_types.Text = textBox_clientID.Text = textBox_typeID.Text = textBox_siteID.Text = textBox_nom_materiel.Text = textBox_num_serie.Text = textBox_materiel_id.Text = textBox_date_install.Text = textBox_description.Text = textBox_mtbf.Text = "";
                DialogResult mes = MessageBox.Show(" Materiel Modifier", "", MessageBoxButtons.OK , MessageBoxIcon.Information);
             
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

        private void comboBox_clients_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox_clientID.Text = comboBox_clients.SelectedValue.ToString();
        }

        private void comboBox_sites_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox_siteID.Text = comboBox_sites.SelectedValue.ToString();
        }

        private void comboBox_types_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox_typeID.Text = comboBox_types.SelectedValue.ToString();
        }
        //quand on clique sur les combobox
        private void comboBox_clients_MouseClick(object sender, MouseEventArgs e)
        {
            // fonction pour remplir la combobox avec le nom des clients , sites et types
            string req4 = "Select * from Client";
            list_des_clients_combobox(req4);
        }

        private void comboBox_sites_MouseClick(object sender, MouseEventArgs e)
        {
            string req5 = "Select * from Site";
            list_des_sites_combobox(req5);
            
        }

        private void comboBox_types_MouseClick(object sender, MouseEventArgs e)
        {
            string req6 = "Select * from Type";
            list_des_types_combobox(req6);
        }
    }
}
