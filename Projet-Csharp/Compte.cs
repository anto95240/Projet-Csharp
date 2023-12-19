using Microsoft.VisualBasic.ApplicationServices;
using Projet_Csharp.Class_db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projet_Csharp
{
    public partial class Compte : Form
    {

        public Compte()
        {
            InitializeComponent();
            LoadUser_AddressData();
            Con = new Fonctions();
        }

        Fonctions Con;

        private void Compte_Load(object sender, EventArgs e)
        {
            // Charge les données lors du chargement de la forme
        }

        private void LoadUser_AddressData()
        {
            string Email = EmailTEXT.Text ?? string.Empty;
            string Password_hash = MdpTEXT.Text ?? string.Empty;
            string FirstName = PrénomText.Text ?? string.Empty;
            string LastName = NomTEXT.Text ?? string.Empty;
            string StreetAddress = AdresseTEXT.Text ?? string.Empty;
            string City = VilleTEXT.Text ?? string.Empty;
            string State = EtatTEXT.Text ?? string.Empty;
            string PostalCode = CodePostalTEXT.Text ?? string.Empty;
            string Country = PaysTEXT.Text ?? string.Empty;

            Fonctions fonctions = new Fonctions();
            user_Table user = new user_Table();
            address_Table address = new address_Table();

            using (SqlConnection connection = new SqlConnection(fonctions.ConStr))
            {
                string query = "SELECT user_Table.Email, user_Table.Password_hash, address_Table.FirstName, address_Table.LastName, address_Table.StreetAddress, address_Table.City, address_Table.State, address_Table.PostalCode, address_Table.Country " +
                               "FROM user_Table " +
                               "INNER JOIN address_Table ON user_Table.UserId = address_Table.UserId " +
                               "WHERE user_Table.UserId = address_Table.UserId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        user.Email = reader["Email"].ToString();
                        user.Password_hash = reader["Password_hash"].ToString();
                        address.FirstName = reader["FirstName"].ToString();
                        address.LastName = reader["LastName"].ToString();
                        address.StreetAddress = reader["StreetAddress"].ToString();
                        address.City = reader["City"].ToString();
                        address.State = reader["State"].ToString();
                        address.PostalCode = reader["PostalCode"].ToString();
                        address.Country = reader["Country"].ToString();

                        // Assigner les valeurs aux champs correspondants dans l'interface utilisateur
                        EmailTEXT.Text = user.Email;
                        MdpTEXT.Text = user.Password_hash;
                        PrénomText.Text = address.FirstName;
                        NomTEXT.Text = address.LastName;
                        AdresseTEXT.Text = address.StreetAddress;
                        VilleTEXT.Text = address.City;
                        EtatTEXT.Text = address.State;
                        CodePostalTEXT.Text = address.PostalCode.ToString();
                        PaysTEXT.Text = address.Country;
                    }

                    reader.Close();
                }
            }
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

        private void command_click(object sender, EventArgs e)
        {
            // Redirection vers la page de command après avoir cliqué sur le bouton de panier
            Command pageCommand = new Command();
            pageCommand.Show(); // Affiche la page de command
            this.Hide(); // Cache la page de compte actuelle
        }

        private void facture_click(object sender, EventArgs e)
        {
            // Redirection vers la page de facture après avoir cliqué sur le bouton de panier
            Facture pageFacture = new Facture();
            pageFacture.Show(); // Affiche la page de facture
            this.Hide(); // Cache la page de compte actuelle
        }

        private void deconnexion_click(object sender, EventArgs e)
        {
            // Redirection vers la page de deconnexion après avoir cliqué sur le bouton de deconneexion
            Deconnexion pageDeconnexion = new Deconnexion();
            pageDeconnexion.Show(); // Affiche la page de déconnexion
            this.Hide(); // Cache la page de compte actuelle
        }

        private void btnModifier(object sender, EventArgs e)
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

                    // Création d'une instance de la classe Fonctions pour utiliser la chaîne de connexion
                    Fonctions fonctions = new Fonctions();

                    using (SqlConnection connection = new SqlConnection(fonctions.ConStr))
                    {
                        connection.Open();

                        // Récupérer l'ID de l'utilisateur existant depuis la table user_Table
                        string getUserIdQuery = "SELECT UserId FROM user_Table WHERE Email = @Email;";
                        SqlCommand getUserIdCommand = new SqlCommand(getUserIdQuery, connection);
                        getUserIdCommand.Parameters.AddWithValue("@Email", Email); // Utilisez l'email pour identifier l'utilisateur

                        object userIdResult = getUserIdCommand.ExecuteScalar();
                        int userId = userIdResult != null ? Convert.ToInt32(userIdResult) : -1; // Si l'utilisateur n'est pas trouvé, userId sera -1

                        if (userId > 0)
                        {
                            // Mettre à jour les données de l'utilisateur dans la table user_Table
                            string updateUserQuery = "UPDATE user_Table SET Email = @Email, Password_hash = @Password_hash WHERE UserId = @UserId;";
                            SqlCommand updateUserCommand = new SqlCommand(updateUserQuery, connection);
                            updateUserCommand.Parameters.AddWithValue("@UserId", userId);
                            updateUserCommand.Parameters.AddWithValue("@Email", Email);
                            updateUserCommand.Parameters.AddWithValue("@Password_hash", Password_hash);

                            int userRowsAffected = updateUserCommand.ExecuteNonQuery();

                            // Mettre à jour les informations d'adresse dans la table address_Table
                            string updateAddressQuery = "UPDATE address_Table SET FirstName = @FirstName, LastName = @LastName, " +
                                                        "StreetAddress = @StreetAddress, City = @City, State = @State, " +
                                                        "PostalCode = @PostalCode, Country = @Country WHERE UserId = @UserId;";
                            SqlCommand updateAddressCommand = new SqlCommand(updateAddressQuery, connection);
                            updateAddressCommand.Parameters.AddWithValue("@UserId", userId);
                            updateAddressCommand.Parameters.AddWithValue("@FirstName", FirstName);
                            updateAddressCommand.Parameters.AddWithValue("@LastName", LastName);
                            updateAddressCommand.Parameters.AddWithValue("@StreetAddress", StreetAddress);
                            updateAddressCommand.Parameters.AddWithValue("@City", City);
                            updateAddressCommand.Parameters.AddWithValue("@State", State);
                            updateAddressCommand.Parameters.AddWithValue("@PostalCode", PostalCode);
                            updateAddressCommand.Parameters.AddWithValue("@Country", Country);

                            int addressRowsAffected = updateAddressCommand.ExecuteNonQuery();

                            if (userRowsAffected > 0 && addressRowsAffected > 0)
                            {
                                MessageBox.Show("Informations mises à jour avec succès !");
                            }
                            else
                            {
                                MessageBox.Show("Erreur lors de la mise à jour des informations.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Utilisateur non trouvé. Veuillez vérifier l'adresse e-mail.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
