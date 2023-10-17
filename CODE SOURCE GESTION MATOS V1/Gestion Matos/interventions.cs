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
    public partial class interventions : Form
    {
        private string strcon = null;
        private SqlConnection cn = null;
        private SqlDataReader dr = null;
        private SqlCommand cm = null;
        private bool nouv = true;
        public interventions()
        {
            InitializeComponent();
        }

        //Créer une fonction pour rendre rendre inutilisable les élément suivant :

        private void EnableInterventions(bool ena)
        {
            Btn_modification.Enabled = ena;
            Btn_supprimer.Enabled = ena;

        }

        //Fonction pour afficher la liste des clients

        private void ChargeListInterventions()
        {
            //Connexion a la base de donnée SQL Server
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestionMatos;Integrated Security=True");
            list_box_interventions.Items.Clear(); //vider la liste d'abord
            //requete pour la liste
            string sql = "select * from Interventions";
            con.Open();
            SqlCommand cm = new SqlCommand(sql, con);
            dr = cm.ExecuteReader(); //executer la requete

            while (dr.Read() == true)
            {
                list_box_interventions.Items.Add(dr["InterID"]).ToString();
            }
            dr.Close();
            con.Close();
        }

        private void interventions_Load(object sender, EventArgs e)
        {
            //lorsque la fennetre sera chargé , on vas afficher les clients
            ChargeListInterventions();
            // ensuite appeller la fonction enable client avec le parametre true ;
            EnableInterventions(false);
            Btn_valider.Enabled = false;
        }
        //Générer la liste des materiels 


        private void list_des_materiels_combobox(string req)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestionMatos;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(req, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table = new DataTable();
            da.Fill(table);
            DataRow itemrow = table.NewRow();
            itemrow[1] = "Choissisez le Materiel";
            table.Rows.InsertAt(itemrow, 0);
            list_materiel.DataSource = table;
            list_materiel.ValueMember = "MaterielID";
            list_materiel.DisplayMember = "Nom"; 
        }
        private void afficher_le_nom_materiel(string req)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestionMatos;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(req, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table = new DataTable();
            da.Fill(table);
            list_materiel.DataSource = table;
            list_materiel.ValueMember = "MaterielID";
            list_materiel.DisplayMember = "Nom";
        }




        //selectionner une intervention
        private void list_box_interventions_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableInterventions(true);
            Btn_valider.Enabled = false;
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestionMatos;Integrated Security=True");
            con.Open();
            string id = list_box_interventions.SelectedItem.ToString();
            string sql = "select * from Interventions where InterID ='" + id + "'";




            //fonction pour remplir la combobox avec le nom du materiel
            
            SqlCommand cm = new SqlCommand(sql, con);
            SqlDataReader dr = cm.ExecuteReader();
            dr.Read();
            String id_materiel = dr["MaterielID"].ToString();
            string req = "Select Nom , MaterielID  from Materiel where MaterielID='" + id_materiel + "'";
            afficher_le_nom_materiel(req);
            Text_box_intervention_id.Text = dr["InterID"].ToString();
            Text_box_intervention_materiel_id.Text = dr["MaterielID"].ToString();
            Text_box_intervention_date.Text = dr["Date"].ToString();
            Text_box_intervention_comment.Text = dr["Description"].ToString();
            con.Close();
        }
        
        //Supprimer une intervention
        private void Btn_supprimer_Click(object sender, EventArgs e)
        {
            string message = " Voulez vous vraiment supprimer l'intervention  du Materiel  '" + Text_box_intervention_materiel_id.Text + "' réalisée le'" + Text_box_intervention_date.Text + "' ? ";
            //Creer une petite fenetre d'attention qui portera les boutton oui ou Non
            DialogResult res = MessageBox.Show(message, "attention", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)//sI l'utilisateur a cliquer sur le boutton OUI (Yes)
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestionMatos;Integrated Security=True");
                try
                {
                    String sql = "delete from Interventions where InterID = '" + Text_box_intervention_id.Text + "'";
                    con.Open();
                    SqlCommand cm = new SqlCommand(sql, con);
                    cm.ExecuteNonQuery();
                    ChargeListInterventions();  // apres supression du materiel on réaffiche les nom des matériels , c'est comme un rafraichissement.
                                                //nous allons vider tous les champs
                    Text_box_intervention_id.Text = Text_box_intervention_materiel_id.Text = Text_box_intervention_date.Text = Text_box_intervention_comment.Text = "";
                    DialogResult mes = MessageBox.Show("Intervention supprimé !", "", MessageBoxButtons.OK);
                     interventions frm = new interventions();
            frm.ShowDialog();
                   
                }catch(Exception ex)
                {
                    MessageBox.Show("Suppression de l'intervention impossible", "Attention", MessageBoxButtons.OK,
                         MessageBoxIcon.Error);

                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void Btn_nouveau_Click(object sender, EventArgs e)
        {
            list_materiel.Text = Text_box_intervention_id.Text = Text_box_intervention_materiel_id.Text = Text_box_intervention_date.Text = Text_box_intervention_comment.Text = "";
            Text_box_intervention_materiel_id.Focus();
            EnableInterventions(false);
            Btn_valider.Enabled = true;
            //fonction pour remplir la combobox avec le nom du materiel
            string req = "Select * from Materiel";
            list_des_materiels_combobox(req);
            
        }

        private void Btn_valider_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestionMatos;Integrated Security=True");
            if (Text_box_intervention_materiel_id.Text == "" && Text_box_intervention_date.Text == "" && Text_box_intervention_comment.Text == "")
            {
                MessageBox.Show("Renseignez tous les champs", "Erreur", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string sql = " insert into Interventions values ('" + Text_box_intervention_date.Text + "','" + Text_box_intervention_comment.Text + "','" + Text_box_intervention_materiel_id.Text + "')";
                    con.Open();
                    SqlCommand cm = new SqlCommand(sql, con);
                    cm.ExecuteNonQuery();
                    ChargeListInterventions();
                    Btn_valider.Enabled = false;
                    MessageBox.Show("Intervention ajouté!","Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur , Veillez réessayé", "Echec", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        //Modification
        private void Btn_modification_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestionMatos;Integrated Security=True");
             try
             {
                string id = list_box_interventions.SelectedItem.ToString();
                String sql = "update Interventions set Date ='" + Text_box_intervention_date.Text + "' , Description = '" + Text_box_intervention_comment.Text + "' , MaterielID = '" + Text_box_intervention_materiel_id.Text + "' where InterID= '" + Text_box_intervention_id.Text + "'";
                con.Open();
                SqlCommand cm = new SqlCommand(sql, con);
                cm.ExecuteNonQuery();
                // apres supression du materiel on réaffiche les nom des matériels , c'est comme un rafraichissement.
                ChargeListInterventions();
                DialogResult mes = MessageBox.Show("Intervention  Modifié", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Modification Imposible | verifiez la date | les caractères suivants ne sont pas autorisé : (') ou (é)!", "Attention", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
           }
        }

        private void ButtonQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void list_materiel_SelectedValueChanged(object sender, EventArgs e)
        {
            Text_box_intervention_materiel_id.Text = list_materiel.SelectedValue.ToString();
        }
    }
}
