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

namespace Projet_Csharp
{
    public partial class Panier : Form
    {
        public Panier()
        {
            InitializeComponent();
            Con = new Fonctions();
            AfficherProduits();
            panelSupprPanier.Visible = false;
            panelAddCommande.Visible = false;
        }

        Fonctions Con;



        // Utilisez une instance statique pour accéder à Panier depuis Accueil

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

        private void command_click(object sender, EventArgs e)
        {
            // Redirection vers la page de command après avoir cliqué sur le bouton de compte
            Command pageCommand = new Command();
            pageCommand.Show(); // Affiche la page de command
            this.Hide(); // Cache la page de panier actuelle
        }

        private void facture_click(object sender, EventArgs e)
        {
            // Redirection vers la page de facture après avoir cliqué sur le bouton de compte
            Facture pageFacture = new Facture();
            pageFacture.Show(); // Affiche la page de facture
            this.Hide(); // Cache la page de panier actuelle
        }

        private void deconnexion_click(object sender, EventArgs e)
        {
            // Redirection vers la page de deconnexion après avoir cliqué sur le bouton de deconneexion
            Deconnexion pageDeconnexion = new Deconnexion();
            pageDeconnexion.Show(); // Affiche la page de déconnexion
            this.Hide(); // Cache la page de panier actuelle
        }

        private void AfficherProduits()
        {
            string Req = "SELECT product_Table.Name, product_Table.Description, categorie_Table.Name AS Category, (product_Table.Price * cart_Table.Quantity) AS Price, cart_Table.Quantity, cart_Table.Statut " +
                         "FROM product_Table " +
                         "INNER JOIN cart_Table ON product_Table.ProductId = cart_Table.ProductId " +
                         "INNER JOIN categorie_Table ON product_Table.CategorieId = categorie_Table.CategorieId";

            ListePanier.DataSource = Con.RecupererData(Req);
        }


        private void btnAfficheProduitAddCommande(object sender, EventArgs e)
        {
            if (ListePanier.Rows.Count > 0)
            {
                // Récupérer les données depuis la base de données pour afficher dans la comboBoxPassCom
                string Req = "SELECT cart_Table.CartId, product_Table.ProductId, product_Table.Name " +
                             "FROM product_Table " +
                             "INNER JOIN cart_Table ON product_Table.ProductId = cart_Table.ProductId";
                DataTable table = Con.RecupererData(Req);

                // Remplir la comboBoxPassCom avec les noms des produits
                comboBoxPassCom.DataSource = table;
                comboBoxPassCom.DisplayMember = "Name"; // Assurez-vous que "Name" correspond au nom de la colonne contenant les noms des produits

                // Si nécessaire, sélectionnez un élément par défaut dans la comboBoxPassCom
                if (comboBoxPassCom.Items.Count > 0)
                {
                    comboBoxPassCom.SelectedIndex = 0;
                }

                // Afficher le panneau de sélection de produit
                panelAddCommande.Size = new Size(267, 128);
                panelAddCommande.Visible = !panelAddCommande.Visible;
            }
            else
            {
                MessageBox.Show("Le panier est vide. Ajoutez des produits avant de les supprimer.");
            }
        }

        private void btnAfficheSupprPanier_Click(object sender, EventArgs e)
        {
            if (ListePanier.Rows.Count > 0)
            {
                // Récupérer les données depuis la base de données pour afficher dans la comboBoxSupprCom
                string Req = "SELECT cart_Table.CartId, product_Table.Name FROM product_Table " +
                              "INNER JOIN cart_Table ON product_Table.ProductId = cart_Table.ProductId";
                DataTable table = Con.RecupererData(Req);

                // Remplir la comboBoxSupprCom avec les noms des produits
                comboBoxSupprCom.DataSource = table;
                comboBoxSupprCom.DisplayMember = "Name"; // Assurez-vous que "Name" correspond au nom de la colonne contenant les noms des produits
                
                // Si nécessaire, sélectionnez un élément par défaut dans la comboBoxSupprCom
                if (comboBoxSupprCom.Items.Count > 0)
                {
                    comboBoxSupprCom.SelectedIndex = 0;
                }

                // Afficher le panneau de sélection de produit
                panelSupprPanier.Size = new Size(267, 128);
                panelSupprPanier.Visible = !panelSupprPanier.Visible;
            }
            else
            {
                MessageBox.Show("Le panier est vide. Ajoutez des produits avant de les supprimer.");
            }
        }

        private void btnSUPPR_Click(object sender, EventArgs e)
        {
            if (comboBoxSupprCom.SelectedIndex != -1)
            {
                DataRowView selectedProductRow = comboBoxSupprCom.SelectedItem as DataRowView;

                if (selectedProductRow != null)
                {
                    int cartId = Convert.ToInt32(selectedProductRow["CartId"]);

                    string deleteQuery = "DELETE FROM cart_Table WHERE CartId = @CartId";

                    using (SqlConnection connection = new SqlConnection(Con.ConStr))
                    {
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@CartId", cartId);

                            try
                            {
                                connection.Open();
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    AfficherProduits(); // Rafraîchir l'affichage après la suppression
                                    MessageBox.Show("Produit retiré du panier!");
                                }
                                else
                                {
                                    MessageBox.Show("Aucun produit trouvé dans le panier.");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erreur lors de la suppression : " + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Aucun produit sélectionné.");
                }
            }
            else
            {
                MessageBox.Show("Sélectionnez un produit avant de passer une commande.");
            }
        }

        private void btnPassCommand_Click(object sender, EventArgs e)
        {
            if (comboBoxPassCom.SelectedIndex != -1)
            {
                DataRowView selectedProductRow = comboBoxPassCom.SelectedItem as DataRowView;

                if (selectedProductRow != null)
                {
                    int ProductId = Convert.ToInt32(selectedProductRow["ProductId"]);
                        
                    DateTime CommandDate = DateTime.Now; // Obtenir la date actuelle
                    string CommandStatut = "Factured";

                    int UserId;
                    // Récupérer l'ID de l'utilisateur à partir de user_Table
                    string ReqSelectUser = "SELECT UserId FROM user_Table /* Mettez ici votre condition pour trouver le bon utilisateur */";

                    using (SqlConnection connection = new SqlConnection(Con.ConStr))
                    {
                        connection.Open();

                        using (SqlCommand userCommand = new SqlCommand(ReqSelectUser, connection))
                        {
                            object userResult = userCommand.ExecuteScalar();
                            if (userResult != null)
                            {
                                UserId = Convert.ToInt32(userResult);

                                // Insérer le produit sélectionné dans la table command_Table
                                string ReqInsert = "INSERT INTO command_Table (UserId, ProductId, CommandDate, CommandStatut) " +
                                                    "VALUES (@UserId, @ProductId, @CommandDate, @CommandStatut)";

                                using (SqlCommand insertCommand = new SqlCommand(ReqInsert, connection))
                                {
                                    insertCommand.Parameters.AddWithValue("@UserId", UserId);
                                    insertCommand.Parameters.AddWithValue("@ProductId", ProductId);
                                    insertCommand.Parameters.AddWithValue("@CommandDate", CommandDate);
                                    insertCommand.Parameters.AddWithValue("@CommandStatut", CommandStatut);

                                    int rowsAffected = insertCommand.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Produit ajouté à la commande!");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Erreur lors de l'ajout à la commande.");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Utilisateur non trouvé.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Aucun produit sélectionné.");
                }
            }
            else
            {
                MessageBox.Show("Sélectionnez un produit avant de passer une commande.");
            }
        }



    }
}
