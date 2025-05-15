using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class WhatsAppForm : Form
    {
        private List<TeamMember> teamMembers;
        private List<ProjectTask> overdueTasks;
        private List<ProjectTask> upcomingDeadlineTasks;

        public WhatsAppForm(List<TeamMember> members, List<ProjectTask> tasks)
        {
            InitializeComponent();
            this.teamMembers = members;

            // Filtrer les tâches
            this.overdueTasks = tasks.Where(t => t.Status != TaskStatus.Terminee &&
                                               t.DueDate < DateTime.Now).ToList();

            this.upcomingDeadlineTasks = tasks.Where(t => t.Status != TaskStatus.Terminee &&
                                                        t.DueDate > DateTime.Now &&
                                                        t.DueDate < DateTime.Now.AddDays(2)).ToList();

            InitializeControls();
        }

        private void InitializeControls()
        {
            // Remplir la liste des membres
            foreach (var member in teamMembers)
            {
                checkedListBoxMembers.Items.Add(member.Name, false);
            }

            // Configurer les boutons radio
            radioAlert.Checked = true;
            UpdateMessagePreview();
        }

        private void UpdateMessagePreview()
        {
            var selectedMembers = GetSelectedMembers();

            if (radioAlert.Checked)
            {
                txtMessage.Text = GenerateAlertMessage(selectedMembers);
                txtMessage.Enabled = false;
            }
            else if (radioReminder.Checked)
            {
                txtMessage.Text = GenerateReminderMessage(selectedMembers);
                txtMessage.Enabled = false;
            }
            else
            {
                txtMessage.Enabled = true;
                if (string.IsNullOrEmpty(txtMessage.Text))
                {
                    txtMessage.Text = "Cher membre de l'équipe,\n\n";
                }
            }
        }

        private List<TeamMember> GetSelectedMembers()
        {
            var selected = new List<TeamMember>();
            for (int i = 0; i < checkedListBoxMembers.Items.Count; i++)
            {
                if (checkedListBoxMembers.GetItemChecked(i))
                {
                    string memberName = checkedListBoxMembers.Items[i].ToString();
                    selected.Add(teamMembers.First(m => m.Name == memberName));
                }
            }
            return selected;
        }

        private string GenerateAlertMessage(List<TeamMember> members)
        {
            if (members.Count == 0) return "Sélectionnez des membres pour générer le message d'alerte.";

            var sb = new StringBuilder();
            sb.AppendLine("🚨 *ALERTE : Tâches en retard* 🚨\n");

            foreach (var member in members)
            {
                var memberTasks = overdueTasks.Where(t => t.AssignedTo == member.Name).ToList();
                if (memberTasks.Any())
                {
                    sb.AppendLine($"*{member.Name}*, vous avez {memberTasks.Count} tâche(s) en retard:");
                    foreach (var task in memberTasks)
                    {
                        sb.AppendLine($"- {task.Name} (Échéance: {task.DueDate:dd/MM/yyyy})");
                    }
                    sb.AppendLine();
                }
            }

            sb.AppendLine("Merci de mettre à jour l'état de ces tâches dès que possible.");
            return sb.ToString();
        }

        private string GenerateReminderMessage(List<TeamMember> members)
        {
            if (members.Count == 0) return "Sélectionnez des membres pour générer le message de rappel.";

            var sb = new StringBuilder();
            sb.AppendLine("🔔 *RAPPEL : Échéances proches* 🔔\n");

            foreach (var member in members)
            {
                var memberTasks = upcomingDeadlineTasks.Where(t => t.AssignedTo == member.Name).ToList();
                if (memberTasks.Any())
                {
                    sb.AppendLine($"*{member.Name}*, vous avez {memberTasks.Count} tâche(s) approchant de leur échéance:");
                    foreach (var task in memberTasks)
                    {
                        sb.AppendLine($"- {task.Name} (Échéance: {task.DueDate:dd/MM/yyyy})");
                    }
                    sb.AppendLine();
                }
            }

            sb.AppendLine("Merci de prioriser ces tâches pour respecter les délais.");
            return sb.ToString();
        }

        // Event handlers
        private void radioAlert_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMessagePreview();
        }

        private void radioReminder_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMessagePreview();
        }

        private void radioCustom_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMessagePreview();
        }

        private void checkedListBoxMembers_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                UpdateMessagePreview();
            });
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var selectedMembers = GetSelectedMembers();
            if (selectedMembers.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner au moins un membre.", "Aucun membre sélectionné", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                MessageBox.Show("Le message ne peut pas être vide.", "Message vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var whatsappLinks = new List<string>();
            foreach (var member in selectedMembers)
            {
                if (!string.IsNullOrEmpty(member.PhoneNumber))
                {
                    string encodedMessage = Uri.EscapeDataString(txtMessage.Text.Replace("{membre}", member.Name));
                    string whatsappLink = $"https://wa.me/{member.PhoneNumber}?text={encodedMessage}";
                    whatsappLinks.Add(whatsappLink);
                }
            }

            if (whatsappLinks.Any())
            {
                foreach (var link in whatsappLinks)
                {
                    try
                    {
                        System.Diagnostics.Process.Start(link);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erreur lors de l'ouverture du lien WhatsApp : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                MessageBox.Show($"Message envoyé à {selectedMembers.Count} membre(s) via WhatsApp.", "Message envoyé", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Aucun numéro de téléphone valide trouvé pour les membres sélectionnés.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void WhatsAppForm_Load(object sender, EventArgs e)
        {
            // Initialization code if needed
        }

        public static TaskStatus ParseTaskStatusFromString(string statusFromDb)
        {
            if (string.IsNullOrWhiteSpace(statusFromDb))
                return TaskStatus.EnAttente; // Valeur par défaut

            string normalizedStatus = statusFromDb.Trim().ToLower();

            switch (normalizedStatus)
            {
                case "en attente":
                case "pending":
                    return TaskStatus.EnAttente;
                case "en cours":
                case "inprogress":
                case "in progress":
                    return TaskStatus.EnCours;
                case "terminée":
                case "terminee":
                case "terminé":
                case "termine":
                case "completed":
                    return TaskStatus.Terminee;
                default:
                    return TaskStatus.EnAttente; // Valeur par défaut si le statut est inconnu
            }
        }
    }

    public enum TaskStatus
    {
        [Description("En attente")]
        EnAttente,
        [Description("En cours")]
        EnCours,
        [Description("Terminée")]
        Terminee
    }

    public class TeamMember
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }

    public class ProjectTask
    {
        public string Name { get; set; }
        public string AssignedTo { get; set; }
        public DateTime DueDate { get; set; }
        public TaskStatus Status { get; set; }
    }
}