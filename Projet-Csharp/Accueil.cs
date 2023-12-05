isusing System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Csharp
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }


        private void Accueil_Load_1(object sender, EventArgs e)
        {

        }

        private void panier_click(object sender, EventArgs e)
        {
            // Redirection vers la page de panier après avoir cliqué sur le bouton de panier
            Panier pagePanier = new Panier();
            pagePanier.Show(); // Affiche la page de panier
            this.Hide(); // Cache la page de accueil actuelle
        }

        private void compte_click(object sender, EventArgs e)
        {
            // Redirection vers la page de compte après avoir cliqué sur le bouton de compte
            Compte pageCompte = new Compte();
            pageCompte.Show(); // Affiche la page de compte
            this.Hide(); // Cache la page de accueil actuelle
        }

        private void deconnexion_click(object sender, EventArgs e)
        {
            // Redirection vers la page de deconnexion après avoir cliqué sur le bouton de deconneexion
            Deconnexion pageDeconnexion = new Deconnexion();
            pageDeconnexion.Show(); // Affiche la page de déconnexion
            this.Hide(); // Cache la page de accueil actuelle
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}


