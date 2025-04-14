using FatiIkhlassYoun.NewFolder;
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
    public partial class MenuDeChefEquipe : Form
    {
        public MenuDeChefEquipe()
        {
            InitializeComponent();
        }




        private void cuiButton1_Click(object sender, EventArgs e)
        {
            AjouterTache form = new AjouterTache(SessionUtilisateur.UserID);
            form.ShowDialog();

        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            ModifierTache form = new ModifierTache(SessionUtilisateur.UserID);
            form.ShowDialog();
        }

        private void cuiButton3_Click(object sender, EventArgs e)
        {
            SupprimerTache form = new SupprimerTache(SessionUtilisateur.UserID);
            form.ShowDialog();

        }
    }
}
