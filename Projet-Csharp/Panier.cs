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
    public partial class Panier : Form
    {
        public Panier()
        {
            InitializeComponent();
        }

        private void Panier_Load(object sender, EventArgs e)
        {

        }

        private void produit_click(object sender, EventArgs e)
        {
            // Redirection vers la page de accueil après avoir cliqué sur le bouton de produit
            Accueil pageProduit = new Accueil();
            pageProduit.Show(); // Affiche la page de accueil
            this.Hide(); // Cache la page de panier actuelle
        }

        private void compte_click(object sender, EventArgs e)
        {
            // Redirection vers la page de compte après avoir cliqué sur le bouton de compte
            Compte pageCompte = new Compte();
            pageCompte.Show(); // Affiche la page de compte
            this.Hide(); // Cache la page de panier actuelle
        }

        private void deconnexion_click(object sender, EventArgs e)
        {
            // Redirection vers la page de deconnexion après avoir cliqué sur le bouton de deconneexion
            Deconnexion pageDeconnexion = new Deconnexion();
            pageDeconnexion.Show(); // Affiche la page de déconnexion
            this.Hide(); // Cache la page de panier actuelle
        }
    }
}
