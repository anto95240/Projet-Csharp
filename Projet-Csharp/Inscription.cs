using Guna.UI2.WinForms.Suite;
using Projet_Csharp.Class_db;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Projet_Csharp
{
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
            Con = new Fonctions();
        }

        Fonctions Con;

        private void Button_Inscription(object sender, EventArgs e)
        {
            // Vérifie si les champs nom d'utilisateur et mot de passe sont vides
            if (string.IsNullOrWhiteSpace(EmailTEXT.Text) ||
                string.IsNullOrWhiteSpace(MdpTEXT.Text) ||
                string.IsNullOrWhiteSpace(PrénomText.Text) ||
                string.IsNullOrWhiteSpace(NomTEXT.Text) ||
                string.IsNullOrWhiteSpace(AdresseTEXT.Text) ||
                string.IsNullOrWhiteSpace(VilleTEXT.Text) ||
                string.IsNullOrWhiteSpace(EtatTEXT.Text) ||
                string.IsNullOrWhiteSpace(CodePostalTEXT.Text) ||
                string.IsNullOrWhiteSpace(PaysTEXT.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
            }
            else
            {
                try
                {
                    string Email = EmailTEXT.Text;
                    string Password_hash = MdpTEXT.Text;
                    string FirstName = PrénomText.Text;
                    string LastName = NomTEXT.Text;
                    string StreetAddress = AdresseTEXT.Text;
                    string City = VilleTEXT.Text;
                    string State = EtatTEXT.Text;
                    string PostalCode = CodePostalTEXT.Text;
                    string Country = PaysTEXT.Text;

                    // Insérer d'abord dans la table user_Table sans spécifier UserId (car c'est une colonne IDENTITY)
                    string insertUserQuery = "INSERT INTO user_Table (Email, Password_hash) VALUES (@Email, @Password_hash); SELECT SCOPE_IDENTITY();";

                    using (SqlConnection connection = new SqlConnection(Con.ConStr)) // Utilise la chaîne de connexion ici
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(insertUserQuery, connection);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Password_hash", Password_hash);

                        int UserId = Convert.ToInt32(command.ExecuteScalar());

                        if (UserId > 0)
                        {
                            // Ensuite, insérer dans la table address_Table avec l'ID utilisateur récupéré
                            string insertAddressQuery = "INSERT INTO address_Table (UserId, FirstName, LastName, StreetAddress, City, State, PostalCode, Country) VALUES (@UserId, @FirstName, @LastName, @StreetAddress, @City, @State, @PostalCode, @Country)";

                            SqlCommand addressCommand = new SqlCommand(insertAddressQuery, connection);
                            addressCommand.Parameters.AddWithValue("@UserId", UserId);
                            addressCommand.Parameters.AddWithValue("@FirstName", FirstName);
                            addressCommand.Parameters.AddWithValue("@LastName", LastName);
                            addressCommand.Parameters.AddWithValue("@StreetAddress", StreetAddress);
                            addressCommand.Parameters.AddWithValue("@City", City);
                            addressCommand.Parameters.AddWithValue("@State", State);
                            addressCommand.Parameters.AddWithValue("@PostalCode", PostalCode);
                            addressCommand.Parameters.AddWithValue("@Country", Country);

                            int rowsAffected = addressCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Utilisateur ajouté avec succès !");
                                Accueil pageAccueil = new Accueil();
                                pageAccueil.Show(); // Affiche la page d'accueil
                                this.Hide(); // Cache la page d'inscription actuelle
                            }
                            else
                            {
                                MessageBox.Show("Erreur lors de l'insertion dans address_Table.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Erreur lors de l'insertion dans user_Table.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Button_connexion(object sender, EventArgs e)
        {
            // Redirection vers la page d'accueil après avoir cliqué sur le bouton de inscription
            Connexion pageConnexion = new Connexion();
            pageConnexion.Show(); // Affiche la page d'accueil
            this.Hide(); // Cache la page de inscription actuelle
        }

        private void Inscription_Load(object sender, EventArgs e)
        {

        }
    }
}
