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
    public partial class Type : Form
    {
        private string strcon = null;
        private SqlConnection cn = null;
        private SqlDataReader dr = null;
        private SqlCommand cm = null;
        public Type()
        {
            InitializeComponent();
        }
        //Créer une fonction pour rendre rendre inutilisable les élément suivant :

        private void EnableType(bool ena)
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

        private void chargeListType()
        {
            //Connexion a la base de donnée SQL Server
           
            list_box_types.Items.Clear(); //vider la liste d'abord
            //requete pour la liste
            initreq("select * from Type");
            cn.Open();
            dr = cm.ExecuteReader(); //executer la requete

            while (dr.Read() == true)
            {
                list_box_types.Items.Add(dr["Nom"]).ToString();
            }
            dr.Close();
            cn.Close();
        }

        //inserer la liste des sites
        private void Type_Load(object sender, EventArgs e)
        {
            //lorsque la fennetre sera chargé , on vas afficher les sites
            chargeListType();
            // ensuite appeller la fonction enable  avec le parametre false ;
            EnableType(false);
            Btn_valider.Enabled = false;
        }

        //Selectionner chaque type

        private void list_box_types_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableType(true);
            Btn_valider.Enabled = false;
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestionMatos;Integrated Security=True");
            con.Open();
            string nom = list_box_types.SelectedItem.ToString();
            string sql = "select * from Type where nom ='" + nom + "'";
            SqlCommand cm = new SqlCommand(sql, con);
            SqlDataReader dr = cm.ExecuteReader();
            dr.Read();
            text_box_type_id.Text = dr["TypeID"].ToString();
            textBox_nom.Text = dr["Nom"].ToString();
            text_box_description.Text = dr["Description"].ToString();
            con.Close();
        }

        //vider les champs
        private void Btn_nouveau_Click(object sender, EventArgs e)
        {
            text_box_type_id.Text = textBox_nom.Text = text_box_description.Text = "";
            textBox_nom.Focus();
            EnableType(false);
            Btn_valider.Enabled = true;
        }

        //ajouter un nouveau type
        private void Btn_valider_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestionMatos;Integrated Security=True");
            if (textBox_nom.Text == "" && text_box_description.Text == "")
            {
                MessageBox.Show("Remplissez les champs");
            }
            else
            {
                string sql = " insert into Type values ('" + textBox_nom.Text + "','" + text_box_description.Text + "')";
                con.Open();
                SqlCommand cm = new SqlCommand(sql, con);
                cm.ExecuteNonQuery();
                chargeListType();
                con.Close();
                text_box_type_id.Text = textBox_nom.Text = text_box_description.Text = "";
                Btn_valider.Enabled = false;
            }
        }

        //supprimer type
        private void Btn_supprimer_Click(object sender, EventArgs e)
        {
            string message = " Voulez vous vraiment supprimer le  Type  '" + textBox_nom.Text + "' ? ";
            //Creer une petite fenetre d'attention qui portera les boutton oui ou Non
            DialogResult res = MessageBox.Show(message, "attention", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)//sI l'utilisateur a cliquer sur le boutton OUI (Yes)
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestionMatos;Integrated Security=True");
                try
                {

                    String sql = "delete from Type where nom = '" + textBox_nom.Text + "'";
                    con.Open();
                    SqlCommand cm = new SqlCommand(sql, con);
                    cm.ExecuteNonQuery();
                    chargeListType();  // apres supression du materiel on réaffiche les nom des type, c'est comme un rafraichissement.
                                       //nous allons vider tous les champs
                    text_box_type_id.Text = textBox_nom.Text = text_box_description.Text = "";
                    DialogResult mes = MessageBox.Show("Type supprimé", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Suppression du Type impossible", "Attention", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }


   

        //modification type
        private void Btn_modification_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestionMatos;Integrated Security=True");
            try
            {
                String sql = "update Type set Nom ='" + textBox_nom.Text + "' , Description = '" + text_box_description.Text + "' where  TypeID = '" + text_box_type_id.Text + "'";
                con.Open();
                SqlCommand cm = new SqlCommand(sql, con);
                cm.ExecuteNonQuery();
                // apres supression du materiel on réaffiche les nom des matériels , c'est comme un rafraichissement.
                chargeListType();
                //nous allons vider tous les champs
                text_box_type_id.Text = textBox_nom.Text = text_box_description.Text = "";
                DialogResult mes = MessageBox.Show("Site  Modifié", "", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Modification impossible : Lien avec la table 'materiel '", "Attention", MessageBoxButtons.OK,
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