using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FatiIkhlassYoun
{
    public partial class formGestionDesEquipes : Form
    {
        public formGestionDesEquipes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void formGestionDesEquipes_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            
            DemanderAuthentification("ajouter");
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            
            DemanderAuthentification("modifier");
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            
            DemanderAuthentification("supprimer");
        }

        private void DemanderAuthentification(string action)

        {
            

            formAuthentification authForm = new formAuthentification(action);
            if (authForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show($"Action {action} autorisée !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Ici, ajoute la logique pour ajouter/modifier/supprimer une équipe
            }
            else
            {
                MessageBox.Show("Authentification refusée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


