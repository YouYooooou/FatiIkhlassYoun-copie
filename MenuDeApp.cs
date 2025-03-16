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
    public partial class MenuDeApp : Form
    {
        formDashboard dashboard;
        formGestionDesEquipes gestionDesEquipes;
        formGestionDesProjets gestionDesProjets;
        formGestionDesUtilisateurs gestionDesUtilisateurs;
        public MenuDeApp()
        {
            InitializeComponent();
            

        }

        private void OpenChildForm(Form childForm)
        {
            // Ferme l'ancien form ouvert s'il y en a un
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            // Configuration du form enfant
            childForm.MdiParent = this;
            childForm.Dock = DockStyle.Fill; // Remplit tout l'espace disponible
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.TopLevel = false;  // Important pour éviter les erreurs MDI
            childForm.ControlBox = false; // Cache la barre du haut
            childForm.Show();
        }
        private void MenuDeApp_Load(object sender, EventArgs e)
        {
            OpenChildForm(new formDashboard()); // Affiche automatiquement le Dashboard
        }
        private void OpenGestionDesProjets()
        {
            if (gestionDesProjets == null)
            {
                gestionDesProjets = new formGestionDesProjets();
                gestionDesProjets.FormClosed += (s, e) => gestionDesProjets = null;
                OpenChildForm(gestionDesProjets);
            }
            else
            {
                gestionDesProjets.Activate();
            }
        }

        private void OpenGestionDesEquipes()
        {
            if (gestionDesEquipes == null)
            {
                gestionDesEquipes = new formGestionDesEquipes();
                gestionDesEquipes.FormClosed += (s, e) => gestionDesEquipes = null;
                OpenChildForm(gestionDesEquipes);
            }
            else
            {
                gestionDesEquipes.Activate();
            }
        }

        private void OpenGestionDesUtilisateurs()
        {
            if (gestionDesUtilisateurs == null)
            {
                gestionDesUtilisateurs = new formGestionDesUtilisateurs();
                gestionDesUtilisateurs.FormClosed += (s, e) => gestionDesUtilisateurs = null;
                OpenChildForm(gestionDesUtilisateurs);
            }
            else
            {
                gestionDesUtilisateurs.Activate();
            }
        }

        private void cuiButton2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        bool sidebarExpand = true;


        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 89)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 365)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void pnDashboard_Click(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                dashboard = new formDashboard();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }
        }
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnGestionDesProjets_Click(object sender, EventArgs e)
        {
            OpenGestionDesProjets();

        }

        private void pnGestionDesEquipes_Click(object sender, EventArgs e)
        {
            OpenGestionDesEquipes();
        }

        private void pnGestionDesUtilisateurs_Click(object sender, EventArgs e)
        {
            OpenGestionDesUtilisateurs();
        }
    }
}
