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
    public partial class Command : Form
    {
        public Command()
        {
            InitializeComponent();
        }
        private void roduit_click(object sender, EventArgs e)
        {
            // Redirection vers la page de accueil après avoir cliqué sur le bouton de deconneexion
            Accueil pageAccueil = new Accueil();
            pageAccueil.Show(); // Affiche la page de accueil
            this.Hide(); // Cache la page de command actuelle
        }

        private void panier_click(object sender, EventArgs e)
        {
            // Redirection vers la page de panier après avoir cliqué sur le bouton de deconneexion
            Panier pagePanier = new Panier();
            pagePanier.Show(); // Affiche la page de panier
            this.Hide(); // Cache la page de command actuelle
        }

        private void compte_click(object sender, EventArgs e)
        {
            // Redirection vers la page de compte après avoir cliqué sur le bouton de deconneexion
            Compte pageCompte = new Compte();
            pageCompte.Show(); // Affiche la page de compte
            this.Hide(); // Cache la page de command actuelle
        }

        private void facture_click(object sender, EventArgs e)
        {
            // Redirection vers la page de facture après avoir cliqué sur le bouton de deconneexion
            Facture pageFacture = new Facture();
            pageFacture.Show(); // Affiche la page de facture
            this.Hide(); // Cache la page de command actuelle
        }

        private void deconnexion_click(object sender, EventArgs e)
        {
            // Redirection vers la page de deconnexion après avoir cliqué sur le bouton de deconneexion
            Deconnexion pageDeconnexion = new Deconnexion();
            pageDeconnexion.Show(); // Affiche la page de déconnexion
            this.Hide(); // Cache la page de command actuelle
        }

    }
}
