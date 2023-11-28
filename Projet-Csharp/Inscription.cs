using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Projet_Csharp
{
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }

        private void Button_Inscription(object sender, EventArgs e)
        {
            // Vérifie si les champs nom d'utilisateur et mot de passe sont vides
            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) || 
                string.IsNullOrWhiteSpace(textBoxLastName.Text) || 
                string.IsNullOrWhiteSpace(textBoxEmail.Text)|| 
                string.IsNullOrWhiteSpace(textBoxPassword.Text) || 
                string.IsNullOrWhiteSpace(textBoxAddress.Text) || 
                string.IsNullOrWhiteSpace(textBoxCity.Text) || 
                string.IsNullOrWhiteSpace(textBoxEtat.Text) || 
                string.IsNullOrWhiteSpace(textBoxPostalCode.Text) ||
                string.IsNullOrWhiteSpace(textBoxCountry.Text) ||
                string.IsNullOrWhiteSpace(textBoxAddressType.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
            }
            else
            {
                // Redirection vers la page d'accueil si les champs sont remplis
                Accueil pageAccueil = new Accueil();
                pageAccueil.Show(); // Affiche la page d'accueil
                this.Hide(); // Cache la page de inscription actuelle
            }
        }

        private void Button_connexion(object sender, EventArgs e)
        {
            // Redirection vers la page d'accueil après avoir cliqué sur le bouton de inscription
            Connexion pageConnexion = new Connexion();
            pageConnexion.Show(); // Affiche la page d'accueil
            this.Hide(); // Cache la page de inscription actuelle
        }
    }
}
