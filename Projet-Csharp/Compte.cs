using System;
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
    public partial class Compte : Form
    {
        public Compte()
        {
            InitializeComponent();
        }

        private void Compte_Load(object sender, EventArgs e)
        {

        }

        private void produit_click(object sender, EventArgs e)
        {
            // Redirection vers la page de accueil après avoir cliqué sur le bouton de produit
            Accueil pageProduit = new Accueil();
            pageProduit.Show(); // Affiche la page de accueil
            this.Hide(); // Cache la page de compte actuelle
        }

        private void panier_click(object sender, EventArgs e)
        {
            // Redirection vers la page de panier après avoir cliqué sur le bouton de panier
            Panier pagePanier = new Panier();
            pagePanier.Show(); // Affiche la page de panier
            this.Hide(); // Cache la page de compte actuelle
        }

        private void deconnexion_click(object sender, EventArgs e)
        {
            // Redirection vers la page de deconnexion après avoir cliqué sur le bouton de deconneexion
            Deconnexion pageDeconnexion = new Deconnexion();
            pageDeconnexion.Show(); // Affiche la page de déconnexion
            this.Hide(); // Cache la page de compte actuelle
        }

        private void factures_Click(object sender, EventArgs e)
        {

        }
    }
}
