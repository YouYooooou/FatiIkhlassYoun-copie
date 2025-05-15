using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace FatiIkhlassYoun
{
    public partial class WhatsAppForm : Form
    {
        private string connectionString = "Server=DESKTOP-78OLGDN;Database=ProjectManagementSystem;Integrated Security=True;";

        public WhatsAppForm()
        {
            InitializeComponent();
        }

        private void WhatsAppForm_Load(object sender, EventArgs e)
        {
            LoadRecipients();
            InitializeMessageTypeComboBox();
        }

        private void LoadRecipients()
        {
            try
            {
                string query = @"SELECT u.UserID, u.Username, u.Role, u.PhoneNumber 
                               FROM Users u
                               WHERE u.IsActive = 1 
                               AND u.Role IN ('chef_projet', 'chef_equipe', 'membre')
                               AND u.PhoneNumber IS NOT NULL";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        clbRecipients.Items.Clear();

                        while (reader.Read())
                        {
                            string phone = reader["PhoneNumber"].ToString();
                            if (IsValidPhoneNumber(phone))
                            {
                                string displayText = $"{reader["Username"]} ({reader["Role"]}) - {FormatPhoneNumber(phone)}";
                                clbRecipients.Items.Add(displayText, false);
                            }
                        }
                    }
                }

                if (clbRecipients.Items.Count == 0)
                {
                    MessageBox.Show("Aucun destinataire valide trouvé.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de chargement: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            string cleaned = new string(phoneNumber.Where(char.IsDigit).ToArray());
            return cleaned.Length >= 10;
        }

        private string FormatPhoneNumber(string phoneNumber)
        {
            string cleaned = new string(phoneNumber.Where(char.IsDigit).ToArray());
            return cleaned.StartsWith("+") ? cleaned : $"+{cleaned}";
        }

        private void InitializeMessageTypeComboBox()
        {
            cbMessageType.Items.AddRange(new object[] { "Alert", "Reminder", "Custom" });
            cbMessageType.SelectedIndex = 0;
        }



        private void cbMessageType_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelAlert.Visible = false;
            panelReminder.Visible = false;
            panelCustom.Visible = false;

            switch (cbMessageType.SelectedItem?.ToString())
            {
                case "Alert":
                    panelAlert.Visible = true;
                    InitializeAlertTypes();
                    break;
                case "Reminder":
                    panelReminder.Visible = true;
                    InitializeReminderTypes();
                    break;
                case "Custom":
                    panelCustom.Visible = true;
                    txtCustomMessage.Text = string.Empty;
                    break;
            }

            UpdateGeneratedMessage();
        }

        private void InitializeAlertTypes()
        {
            if (cbAlertType.Items.Count == 0)
            {
                cbAlertType.Items.AddRange(new object[] {
                    "Urgent Task",
                    "System Maintenance",
                    "Security Alert",
                    "Project Deadline"
                });
            }
            cbAlertType.SelectedIndex = 0;
        }

        private void InitializeReminderTypes()
        {
            if (cbReminderType.Items.Count == 0)
            {
                cbReminderType.Items.AddRange(new object[] {
                    "Meeting",
                    "Task Deadline",
                    "Project Review",
                    "Status Update"
                });
            }
            cbReminderType.SelectedIndex = 0;
        }

        private void cbAlertType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGeneratedMessage();
        }

        private void cbReminderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGeneratedMessage();
        }

        private void txtCustomMessage_TextChanged(object sender, EventArgs e)
        {
            UpdateGeneratedMessage();
        }

        private void UpdateGeneratedMessage()
        {
            string message = string.Empty;

            switch (cbMessageType.SelectedItem?.ToString())
            {
                case "Alert":
                    message = GenerateAlertMessage();
                    break;
                case "Reminder":
                    message = GenerateReminderMessage();
                    break;
                case "Custom":
                    message = txtCustomMessage.Text;
                    break;
            }

            txtGeneratedMessage.Text = message;
        }

        private string GenerateAlertMessage()
        {
            if (cbAlertType.SelectedItem == null) return string.Empty;

            string alertType = cbAlertType.SelectedItem.ToString();
            string message = "🔔 ALERT 🔔\n\n";

            switch (alertType)
            {
                case "Urgent Task":
                    message += "Urgent task requires your immediate attention! Please check your tasks list and prioritize accordingly.";
                    break;
                case "System Maintenance":
                    message += "System maintenance scheduled for tonight at 10 PM. Please save your work and log out before this time.";
                    break;
                case "Security Alert":
                    message += "Security alert: Please change your password immediately and report any suspicious activity to IT.";
                    break;
                case "Project Deadline":
                    message += "Project deadline approaching! Please ensure all tasks are completed and reports are submitted on time.";
                    break;
            }

            return message + "\n\nThank you,\nAdmin Team";
        }

        private string GenerateReminderMessage()
        {
            if (cbReminderType.SelectedItem == null) return string.Empty;

            string reminderType = cbReminderType.SelectedItem.ToString();
            string message = "⏰ REMINDER ⏰\n\n";

            switch (reminderType)
            {
                case "Meeting":
                    message += "Friendly reminder: Team meeting tomorrow at 10 AM in Conference Room A. Please prepare your updates.";
                    break;
                case "Task Deadline":
                    message += "Reminder: Task deadline is approaching. Please ensure completion and submit your progress report.";
                    break;
                case "Project Review":
                    message += "Project review scheduled for Friday at 2 PM. Please have your materials ready for presentation.";
                    break;
                case "Status Update":
                    message += "Reminder: Status update required by end of day. Please submit your weekly progress report.";
                    break;
            }

            return message + "\n\nThank you,\nAdmin Team";
        }


        private bool OpenWhatsAppChat(string phoneNumber, string message)
        {
            try
            {
                string cleanPhone = new string(phoneNumber.Where(char.IsDigit).ToArray());
                string encodedMessage = Uri.EscapeDataString(message);

                // URL pour ouvrir la conversation WhatsApp
                string whatsappUrl = $"https://wa.me/{cleanPhone}?text={encodedMessage}";

                Process.Start(new ProcessStartInfo
                {
                    FileName = whatsappUrl,
                    UseShellExecute = true
                });

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur d'ouverture WhatsApp: {ex.Message}");
                return false;
            }
        }
        private List<Recipient> GetSelectedRecipients()
        {
            var recipients = new List<Recipient>();

            foreach (var item in clbRecipients.CheckedItems)
            {
                string itemText = item.ToString();
                string[] parts = itemText.Split('-');

                if (parts.Length >= 2)
                {
                    string phoneNumber = FormatPhoneNumber(parts.Last().Trim());
                    recipients.Add(new Recipient
                    {
                        Name = parts[0].Trim(),
                        PhoneNumber = phoneNumber
                    });
                }
            }

            return recipients;
        }
        private void LogMessages(List<Recipient> recipients, string message)
        {
            try
            {
                string query = @"INSERT INTO MessageLog 
                               (SenderID, RecipientName, RecipientPhone, Message, MessageType, SentDate, Status) 
                               VALUES 
                               (@SenderID, @RecipientName, @RecipientPhone, @Message, @MessageType, @SentDate, @Status)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    int senderId = GetCurrentUserID();

                    foreach (var recipient in recipients)
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@SenderID", senderId);
                            command.Parameters.AddWithValue("@RecipientName", recipient.Name);
                            command.Parameters.AddWithValue("@RecipientPhone", recipient.PhoneNumber);
                            command.Parameters.AddWithValue("@Message", message);
                            command.Parameters.AddWithValue("@MessageType", cbMessageType.Text);
                            command.Parameters.AddWithValue("@SentDate", DateTime.Now);
                            command.Parameters.AddWithValue("@Status", "Pending");

                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur de journalisation: {ex.Message}");


            }
        }





        private int GetCurrentUserID()
        {
            // À implémenter selon votre système d'authentification
            return 1;
        }
        private class Recipient
        {
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
        }

        
        private void clbRecipients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (clbRecipients.CheckedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner au moins un destinataire.",
                              "Avertissement",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGeneratedMessage.Text))
            {
                MessageBox.Show("Le message ne peut pas être vide.",
                              "Avertissement",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var recipients = GetSelectedRecipients();
                int successCount = 0;

                foreach (var recipient in recipients)
                {
                    if (OpenWhatsAppChat(recipient.PhoneNumber, txtGeneratedMessage.Text))
                    {
                        successCount++;
                        System.Threading.Thread.Sleep(1000); // Pause entre chaque ouverture
                    }
                }

                LogMessages(recipients, txtGeneratedMessage.Text);

                MessageBox.Show($"{successCount} conversation(s) WhatsApp ouverte(s) avec le message pré-rempli.\n" +
                               "Veuillez vérifier et envoyer manuellement chaque message.",
                              "Prêt à envoyer",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}