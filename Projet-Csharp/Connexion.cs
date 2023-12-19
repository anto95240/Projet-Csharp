using Guna.UI2.WinForms.Suite;
using Projet_Csharp.Class_db;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Projet_Csharp
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
            Con = new Fonctions();
        }

        Fonctions Con;
        private void Button_connexion(object sender, EventArgs e)
        {
            // Vérifie si les champs nom d'utilisateur et mot de passe sont vides
            if (string.IsNullOrEmpty(EmailTEXT.Text) || string.IsNullOrEmpty(MdpTEXT.Text))
            {
                MessageBox.Show("Veuillez saisir un email et un mot de passe.");
            }
            else
            {
                try
                {
                    string Email = EmailTEXT.Text;
                    string Password_hash = MdpTEXT.Text;

                    // Création d'une instance de la classe Fonctions pour utiliser la chaîne de connexion
                    Fonctions fonctions = new Fonctions();

                    // Vérification si l'utilisateur existe avec l'email et le mot de passe fournis
                    string verifyQuery = "SELECT UserId FROM user_Table WHERE Email = @Email AND Password_hash = @Password_hash";

                    using (SqlConnection connection = new SqlConnection(fonctions.ConStr))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(verifyQuery, connection);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Password_hash", Password_hash);

                        object userId = command.ExecuteScalar();

                        if (userId != null)
                        {
                            MessageBox.Show("Connexion réussie !");
                            Accueil pageAccueil = new Accueil();
                            pageAccueil.Show(); // Affiche la page d'accueil
                            this.Hide(); // Cache la page de connexion actuelle
                        }
                        else
                        {
                            MessageBox.Show("Identifiants incorrects. Veuillez vérifier votre email et votre mot de passe.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }


        private void Button_inscription(object sender, EventArgs e)
        {
            // Redirection vers la page d'inscription après avoir cliqué sur le bouton d'inscription
            Inscription pageInscription = new Inscription();
            pageInscription.Show(); // Affiche la page d'inscription
            this.Hide(); // Cache la page de connexion actuelle
        }

        private void Connexion_Load(object sender, EventArgs e)
        {
            // Code d'initialisation
        }
    }
}
