﻿using System;
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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }

        private void Button_connexion(object sender, EventArgs e)
        {
            // Vérifie si les champs nom d'utilisateur et mot de passe sont vides
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Veuillez saisir un nom d'utilisateur et un mot de passe.");
            }
            else
            {
                // Redirection vers la page d'accueil si les champs sont remplis
                Accueil pageAccueil = new Accueil();
                pageAccueil.Show(); // Affiche la page d'accueil
                this.Hide(); // Cache la page de connexion actuelle
            }
        }

        private void Button_inscription(object sender, EventArgs e)
        {
            // Redirection vers la page d'accueil après avoir cliqué sur le bouton de connexion
            Inscription pageInscription = new Inscription();
            pageInscription.Show(); // Affiche la page d'accueil
            this.Hide(); // Cache la page de connexion actuelle
        }

        private void V_Admin(object sender, EventArgs e)
        {
            
        }
    }
}