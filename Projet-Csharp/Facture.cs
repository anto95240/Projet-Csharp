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
    public partial class Facture : Form
    {
        public Facture()
        {
            InitializeComponent();
        }

        private void produit_click(object sender, EventArgs e)
        {
            // Redirection vers la page de Accueil après avoir cliqué sur le bouton de deconneexion
            Accueil pageAccueil = new Accueil();
            pageAccueil.Show(); // Affiche la page de Accueil
            this.Hide(); // Cache la page de Facture actuelle
        }

        private void panier_click(object sender, EventArgs e)
        {
            // Redirection vers la page de Panier après avoir cliqué sur le bouton de deconneexion
            Panier pagePanier = new Panier();
            pagePanier.Show(); // Affiche la page de Panier
            this.Hide(); // Cache la page de Facture actuelle
        }

        private void compte_click(object sender, EventArgs e)
        {
            // Redirection vers la page de Compte après avoir cliqué sur le bouton de deconneexion
            Compte pageCompte = new Compte();
            pageCompte.Show(); // Affiche la page de Compte
            this.Hide(); // Cache la page de Facture actuelle
        }

        private void command_click(object sender, EventArgs e)
        {
            // Redirection vers la page de Command après avoir cliqué sur le bouton de deconneexion
            Command pageCommand = new Command();
            pageCommand.Show(); // Affiche la page de Command
            this.Hide(); // Cache la page de Facture actuelle
        }

        private void deconnexion_click(object sender, EventArgs e)
        {
            // Redirection vers la page de deconnexion après avoir cliqué sur le bouton de deconneexion
            Deconnexion pageDeconnexion = new Deconnexion();
            pageDeconnexion.Show(); // Affiche la page de déconnexion
            this.Hide(); // Cache la page de Facture actuelle
        }

    }
}
