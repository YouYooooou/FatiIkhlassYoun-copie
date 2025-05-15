using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FatiIkhlassYoun
{
    public partial class FormTaskStatistics : Form
    {
        private string connectionString = "Data Source=DESKTOP-78OLGDN;Initial Catalog=ProjectManagementSystem;Integrated Security=True;";

        public FormTaskStatistics()
        {
            InitializeComponent();
        }

        private void FormProgressAdmin_Load(object sender, EventArgs e)
        {
            LoadTaskStatistics();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTaskStatistics();
        }

        private void LoadTaskStatistics()
        {
            int total = 0, terminée = 0, enCours = 0, enAttente = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmdTotal = new SqlCommand("SELECT COUNT(*) FROM Tasks", con);
                total = (int)cmdTotal.ExecuteScalar();

                SqlCommand cmdTerminée = new SqlCommand("SELECT COUNT(*) FROM Tasks WHERE Status = 'Terminée'", con);
                terminée = (int)cmdTerminée.ExecuteScalar();

                SqlCommand cmdEnCours = new SqlCommand("SELECT COUNT(*) FROM Tasks WHERE Status = 'En cours'", con);
                enCours = (int)cmdEnCours.ExecuteScalar();

                SqlCommand cmdEnAttente = new SqlCommand("SELECT COUNT(*) FROM Tasks WHERE Status = 'En attente'", con);
                enAttente = (int)cmdEnAttente.ExecuteScalar();
            }

            lblTotalTasks.Text = $"Total des tâches : {total}";

            if (total > 0)
            {
                int pctTerminée = terminée * 100 / total;
                int pctEnCours = enCours * 100 / total;
                int pctEnAttente = enAttente * 100 / total;

                progressTerminée.Value = pctTerminée;
                lblTerminée.Text = $"Terminée : {pctTerminée}%";

                progressEnCours.Value = pctEnCours;
                lblEnCours.Text = $"En cours : {pctEnCours}%";

                progressEnAttente.Value = pctEnAttente;
                lblEnAttente.Text = $"En attente : {pctEnAttente}%";
            }
            else
            {
                progressTerminée.Value = progressEnCours.Value = progressEnAttente.Value = 0;
                lblTerminée.Text = "Terminée : 0%";
                lblEnCours.Text = "En cours : 0%";
                lblEnAttente.Text = "En attente : 0%";
            }
        }
    }
}
