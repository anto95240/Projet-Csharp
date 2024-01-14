using Projet_Csharp.Class_db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
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
            Con = new Fonctions();
            AfficherProduits();
            panelSupprCommand.Visible = false;
            panelFacture.Visible = false;
        }

        Fonctions Con;
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


        private void AfficherProduits()
        {

            string Req = "SELECT product_Table.Name, product_Table.Description, categorie_Table.Name AS Category, (product_Table.Price * cart_Table.Quantity) AS Price, cart_Table.Quantity, command_Table.CommandDate AS Date, command_Table.CommandStatut AS Statut " +
                         "FROM command_Table " +
                         "INNER JOIN product_Table ON command_Table.ProductId = product_Table.ProductId " +
                         "INNER JOIN categorie_Table ON product_Table.CategorieId = categorie_Table.CategorieId " +
                         "INNER JOIN cart_Table ON command_Table.ProductId = cart_Table.ProductId";

            ListeCommand.DataSource = Con.RecupererData(Req);

        }

        private void Command_Load(object sender, EventArgs e)
        {

        }



        private void btnANNULER_COMMANDE_Click(object sender, EventArgs e)
        {
            if (ListeCommand.Rows.Count > 0)
            {
                // Récupérer les données depuis la base de données pour afficher dans la comboBoxSupprCom
                string Req = "SELECT command_Table.CommandId, product_Table.Name FROM command_Table INNER JOIN product_Table ON command_Table.ProductId = product_Table.ProductId";
                DataTable table = Con.RecupererData(Req);

                // Remplir la comboBoxSupprCom avec les noms des produits
                comboBoxSupprCom.DataSource = table;
                comboBoxSupprCom.DisplayMember = "Name"; // Assurez-vous que "Name" correspond au nom de la colonne contenant les noms des produits

                // Si nécessaire, sélectionnez un élément par défaut dans la comboBoxSupprCom
                

                // Afficher le panneau de sélection de produit
                panelSupprCommand.Size = new Size(267, 128);
                panelSupprCommand.Visible = !panelSupprCommand.Visible;
            }
            else
            {
                MessageBox.Show("Le panier est vide. Ajoutez des produits avant de les supprimer.");
            }
        }

        private void btnAVOIR_FACTURE_Click(object sender, EventArgs e)
        {
            if (ListeCommand.Rows.Count > 0)
            {
                // Récupérer les données depuis la base de données pour afficher dans la comboBoxFacture
                string Req = "SELECT command_Table.CommandId, product_Table.ProductId, product_Table.Name " +
                             "FROM command_Table " +
                             "INNER JOIN product_Table ON command_Table.ProductId = product_Table.ProductId";
                DataTable table = Con.RecupererData(Req);

                // Remplir la comboBoxFacture avec les noms des produits
                comboBoxFacture.DataSource = table;
                comboBoxFacture.DisplayMember = "Name"; // Assurez-vous que "Name" correspond au nom de la colonne contenant les noms des produits
               
                // Si nécessaire, sélectionnez un élément par défaut dans la comboBoxFacture
                

                // Afficher le panneau de sélection de produit
                panelFacture.Size = new Size(267, 128);
                panelFacture.Visible = !panelFacture.Visible;
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
                    int CommandId = Convert.ToInt32(selectedProductRow["CommandId"]);

                    string deleteQuery = "DELETE FROM command_Table WHERE CommandId = @CommandId";

                    using (SqlConnection connection = new SqlConnection(Con.ConStr))
                    {
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@CommandId", CommandId);

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




        private void btnFACTURATION_Click(object sender, EventArgs e)
        {
            if (comboBoxFacture.SelectedIndex != -1) // Vérifie s'il y a un élément sélectionné dans la comboBox
            {
                DataRowView selectedProductRow = comboBoxFacture.SelectedItem as DataRowView;

                if (selectedProductRow != null)
                {
                    int CommandId = Convert.ToInt32(selectedProductRow["CommandId"]);
                    int UserId;

                    DateTime InvoiceDate = DateTime.Now; // Obtenir la date actuelle

                    // Récupérer le UserId depuis user_Table
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

                                decimal Price;
                                int Quantity;

                                // Récupérer le prix et la quantité du produit depuis product_Table ou cart_Table
                                string ReqSelectDetails = "SELECT command_Table.CommandId, product_Table.Price, cart_Table.Quantity " +
                                                  "FROM command_Table " +
                                                  "INNER JOIN product_Table ON command_Table.ProductId = product_Table.ProductId " +
                                                  "INNER JOIN cart_Table ON product_Table.ProductId = cart_Table.ProductId " +
                                                  "WHERE command_Table.CommandId = @CommandId";

                                using (SqlCommand detailsCommand = new SqlCommand(ReqSelectDetails, connection))
                                {
                                    detailsCommand.Parameters.AddWithValue("@CommandId", CommandId);
                                    SqlDataReader reader = detailsCommand.ExecuteReader();

                                    if (reader.Read())
                                    {
                                        Price = Convert.ToDecimal(reader["Price"]);
                                        Quantity = Convert.ToInt32(reader["Quantity"]);
                                        reader.Close();

                                        decimal Total = Price * Quantity;

                                        // Insertion dans invoices_Table
                                        string ReqInsert = "INSERT INTO invoices_Table (UserId, CommandId, Total, InvoiceDate) " +
                                                            "VALUES (@UserId, @CommandId, @Total, @InvoiceDate)";
                                        using (SqlCommand insertCommand = new SqlCommand(ReqInsert, connection))
                                        {
                                            insertCommand.Parameters.AddWithValue("@UserId", UserId);
                                            insertCommand.Parameters.AddWithValue("@CommandId", CommandId);
                                            insertCommand.Parameters.AddWithValue("@Total", Total);
                                            insertCommand.Parameters.AddWithValue("@InvoiceDate", InvoiceDate);

                                            int rowsAffected = insertCommand.ExecuteNonQuery();
                                            if (rowsAffected > 0)
                                            {
                                                MessageBox.Show("Commande ajoutée à la facture !");
                                            }
                                            else
                                            {
                                                MessageBox.Show("Erreur lors de l'ajout à la facture.");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        reader.Close();
                                        MessageBox.Show("Détails de commande non trouvés.");
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
