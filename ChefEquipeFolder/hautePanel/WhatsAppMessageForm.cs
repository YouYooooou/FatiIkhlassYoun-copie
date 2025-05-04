using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace FatiIkhlassYoun.ChefEquipeFolder.hautePanel
{
    public partial class WhatsAppMessageForm : Form
    {
        private int chefEquipeId;
        private List<User> teamMembers;

        public WhatsAppMessageForm(int chefEquipeId)
        {
            InitializeComponent();
            this.chefEquipeId = chefEquipeId;
            LoadTeamMembers();
        }

        private void LoadTeamMembers()
        {
            string connectionString = @"Data Source=YOUNES\SQLEXPRESS;Initial Catalog=ProjectManagementSystem;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT U.UserID, U.Username, U.PhoneNumber 
                            FROM Users U
                            INNER JOIN TeamMembers TM ON U.UserID = TM.UserID
                            INNER JOIN Teams T ON TM.TeamID = T.TeamID
                            WHERE T.LeaderID = @ChefEquipeId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ChefEquipeId", chefEquipeId);

                SqlDataReader reader = cmd.ExecuteReader();
                teamMembers = new List<User>();

                while (reader.Read())
                {
                    teamMembers.Add(new User
                    {
                        UserID = reader.GetInt32(0),
                        Username = reader.GetString(1),
                        PhoneNumber = reader.IsDBNull(2) ? null : reader.GetString(2)
                    });
                }

                checkedListBoxMembers.DataSource = teamMembers;
                checkedListBoxMembers.DisplayMember = "Username";
                checkedListBoxMembers.ValueMember = "UserID";
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxMembers.Items.Count; i++)
            {
                checkedListBoxMembers.SetItemChecked(i, true);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var selectedMembers = checkedListBoxMembers.CheckedItems.Cast<User>().ToList();

            if (selectedMembers.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner au moins un membre");
                return;
            }

            var membersWithoutNumber = selectedMembers.Where(m => string.IsNullOrEmpty(m.PhoneNumber)).ToList();

            if (membersWithoutNumber.Any())
            {
                var names = string.Join(", ", membersWithoutNumber.Select(m => m.Username));
                if (MessageBox.Show($"Les membres suivants n'ont pas de numéro: {names}\nContinuer quand même?",
                                  "Numéros manquants",
                                  MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }

            string message = GenerateMessage();

            foreach (var member in selectedMembers)
            {
                if (!string.IsNullOrEmpty(member.PhoneNumber))
                {
                    SendWhatsAppMessage(member.PhoneNumber, message);
                }
            }

            MessageBox.Show("Messages envoyés avec succès!");
        }

        private string GenerateMessage()
        {
            if (rbAlert.Checked)
                return "[ALERTE] " + txtSubject.Text;
            else if (rbReminder.Checked)
                return "[RAPPEL] " + txtSubject.Text;
            else
                return txtCustomMessage.Text;
        }

        private void SendWhatsAppMessage(string phoneNumber, string message)
        {
            try
            {
                // Format international du numéro (ex: +212612345678)
                string formattedNumber = phoneNumber.StartsWith("+") ? phoneNumber : "+212" + phoneNumber.Substring(1);

                // Ouvrir WhatsApp avec le message pré-rempli
                string url = $"https://wa.me/{formattedNumber}?text={Uri.EscapeDataString(message)}";
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'envoi du message: {ex.Message}");
            }
        }

        private void rbCustom_CheckedChanged(object sender, EventArgs e)
        {
            txtCustomMessage.Visible = rbCustom.Checked;
            txtSubject.Visible = !rbCustom.Checked;
        }
    }

    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string PhoneNumber { get; set; }
    }
}