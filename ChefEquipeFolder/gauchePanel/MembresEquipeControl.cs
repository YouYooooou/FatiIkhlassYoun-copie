using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FatiIkhlassYoun.ChefEquipeFolder.hautePanel;
using System.Data.SqlClient;

namespace FatiIkhlassYoun
{
    public partial class MembresEquipeControl: UserControl
    {
        private string connectionString = @"Data Source=YOUNES\SQLEXPRESS;Initial Catalog=ProjectManagementSystem;Integrated Security=True";
        private int chefEquipeId;

        public MembresEquipeControl()
        {
            InitializeComponent();
            chefEquipeId = SessionUtilisateur.UserID;

            // Configurer le DataGridView avant de charger les données
            ConfigurerDataGridView();

            // Charger les données automatiquement
            ChargerMembresEquipe();
        }

        private void ConfigurerDataGridView()
        {
            // Configuration de base du DataGridView
            dataGridViewMembres.AutoGenerateColumns = false;
            dataGridViewMembres.AllowUserToAddRows = false;
            dataGridViewMembres.ReadOnly = true;
            dataGridViewMembres.RowHeadersVisible = false;
            dataGridViewMembres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Créer les colonnes manuellement pour plus de contrôle
            dataGridViewMembres.Columns.Clear();

            dataGridViewMembres.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "UserID",
                HeaderText = "ID",
                DataPropertyName = "UserID",
                Visible = false // On cache l'ID car pas besoin de l'afficher
            });

            dataGridViewMembres.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Username",
                HeaderText = "Nom d'utilisateur",
                DataPropertyName = "Username",
                Width = 150
            });

            dataGridViewMembres.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Email",
                HeaderText = "Email",
                DataPropertyName = "Email",
                Width = 200
            });

            // Remplacez la colonne Role par PhoneNumber
            dataGridViewMembres.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "PhoneNumber",
                HeaderText = "Téléphone",
                DataPropertyName = "PhoneNumber",
                Width = 100
            });
        }

        private void ChargerMembresEquipe()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Debug: Afficher l'ID du chef d'équipe
                    Console.WriteLine($"ID du chef d'équipe: {chefEquipeId}");

                    int teamId = GetTeamId(conn);
                    Console.WriteLine($"ID de l'équipe trouvé: {teamId}");

                    if (teamId == 0)
                    {
                        MessageBox.Show("Vous n'êtes chef d'aucune équipe", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    DataTable dtMembres = GetMembresEquipe(conn, teamId);

                    // Debug: Vérifier le contenu du DataTable
                    if (dtMembres.Rows.Count == 0)
                    {
                        MessageBox.Show($"Aucun membre trouvé pour l'équipe ID: {teamId}\n" +
                                       $"Vérifiez la table TeamMembers dans la base de données.",
                                       "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    dataGridViewMembres.DataSource = dtMembres;
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Erreur SQL: {sqlEx.Message}\nDétails: {sqlEx.StackTrace}",
                               "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}\nDétails: {ex.StackTrace}",
                               "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetTeamId(SqlConnection conn)
        {
            string query = "SELECT TeamID FROM Teams WHERE LeaderID = @ChefID";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ChefID", chefEquipeId);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

        private DataTable GetMembresEquipe(SqlConnection conn, int teamId)
        {
            // Requête modifiée pour récupérer le numéro de téléphone
            string query = @"SELECT 
            U.UserID,
            U.Username,
            U.Email,
            U.PhoneNumber  
        FROM Users U
        INNER JOIN TeamMembers TM ON U.UserID = TM.UserID
        WHERE TM.TeamID = @TeamID
        ORDER BY U.Username";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@TeamID", teamId);

                DataTable dt = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }

                // Debug: Afficher le nombre de membres récupérés
                Console.WriteLine($"Nombre de membres trouvés: {dt.Rows.Count}");

                return dt;
            }
        }

        // Optionnel: Ajouter un bouton de rafraîchissement
        private void btnRafraichir_Click(object sender, EventArgs e)
        {
            ChargerMembresEquipe();
        }

    }
}
