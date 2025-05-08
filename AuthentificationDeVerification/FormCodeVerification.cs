namespace FatiIkhlassYoun.NewFolder
{
    public partial class FormCodeVerification : Form
    {
        private int codeEnvoye;
        private string action;
        private int taskId;
        private int tentativesRestantes = 3; // Compteur de tentatives

        public bool IsCodeValid { get; private set; }

        public FormCodeVerification(int code, string actionType, int taskId)
        {
            InitializeComponent();
            codeEnvoye = code;
            action = actionType;
            this.taskId = taskId;
            lblEmailInfo.Text = $"Un code a été envoyé à votre adresse email";
            UpdateTentativesLabel(); // Mettre à jour l'affichage des tentatives
        }

        private void UpdateTentativesLabel()
        {
            lblTentatives.Text = $"Tentatives restantes : {tentativesRestantes}";
        }

        private void btnVerifier_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Trim() == codeEnvoye.ToString())
            {
                IsCodeValid = true;
                MessageBox.Show("Code vérifié avec succès !");

                // Fermer ce formulaire ET le formulaire parent (authentification)
                this.DialogResult = DialogResult.OK; // Important pour le flux de contrôle
                this.Close();
            }
            else
            {
                tentativesRestantes--;
                UpdateTentativesLabel();

                if (tentativesRestantes > 0)
                {
                    MessageBox.Show($"Code incorrect. Il vous reste {tentativesRestantes} tentative(s).");
                    txtCode.Clear();
                    txtCode.Focus();
                }
                else
                {
                    MessageBox.Show("Nombre maximum de tentatives atteint. L'action est annulée.");
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            IsCodeValid = false;
            this.Close();
        }

        private void txtCode_Enter(object sender, EventArgs e)
        {
            txtCode.BackColor = Color.White;
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            txtCode.BackColor = Color.WhiteSmoke;
        }
    }
}