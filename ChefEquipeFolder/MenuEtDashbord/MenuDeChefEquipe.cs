using FatiIkhlassYoun.ChefEquipeFolder.hautePanel;
using FatiIkhlassYoun.NewFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FatiIkhlassYoun
{
    public partial class MenuDeChefEquipe : Form
    {
        public MenuDeChefEquipe()
        {
            InitializeComponent();
            LoadContent(new DashboardControl()); // Charger le contenu par défaut
            RemplirInfosUtilisateur(); // Remplir les infos de l'utilisateur après le chargement du formulaire
        }

        private void RemplirInfosUtilisateur()
        {
            // Exemple : supposons que tu as un UserID dans la session utilisateur
            int userID = SessionUtilisateur.UserID;  // Ou récupère l'ID de l'utilisateur connecté

            // Requête SQL pour récupérer le nom d'utilisateur et le rôle de l'utilisateur
            string query = "SELECT Username, Role FROM Users WHERE UserID = @UserID";

            // Connexion à la base de données
            using (SqlConnection conn = new SqlConnection(@"Data Source=YOUNES\SQLEXPRESS;Initial Catalog=ProjectManagementSystem;Integrated Security=True;"))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userID);

                // Exécution de la requête et récupération des données
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string username = reader.GetString(0);  // Récupère le nom d'utilisateur
                    string role = reader.GetString(1);      // Récupère le rôle

                    // Vérification si le nom d'utilisateur contient un espace
                    if (username.Contains(" "))
                    {
                        // Si oui, on divise le nom et le prénom
                        string[] usernameParts = username.Split(' ');
                        labelNom.Text = usernameParts[0].ToUpper();  // Premier élément comme nom
                        labelPrenom.Text = usernameParts[1];         // Deuxième élément comme prénom
                    }
                    else
                    {
                        // Sinon, on affiche uniquement le nom et on laisse le prénom vide
                        labelNom.Text = username.ToUpper();  // Afficher tout le username comme nom
                        labelPrenom.Text = "";              // Laisser le prénom vide
                    }

                    // Afficher le rôle dans le labelRole
                    labelRole.Text = "(" + role.Replace('_', ' ') + ")";
                }
                else
                {
                    MessageBox.Show("Utilisateur non trouvé");
                }
            }
        }
        public void LoadContent(UserControl control)
        {
            panelContenu.Controls.Clear();       // Vider le contenu précédent
            control.Dock = DockStyle.Fill;       // Prendre toute la place
            panelContenu.Controls.Add(control);  // Afficher le nouveau contenu
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }


        private void cuiButton1_Click(object sender, EventArgs e)
        {
            AjouterTache form = new AjouterTache(SessionUtilisateur.UserID);
            form.ShowDialog();

        }

       

      

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cuiButton5_Click(object sender, EventArgs e)
        {
            LoadContent(new DashboardControl());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadContent(new MesEquipesControl());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadContent(new MembresEquipeControl());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadContent(new SuiviAvancementControl());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadContent(new CalendrierControl());

        }

        private void panelContenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panelDernieresTaches_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
