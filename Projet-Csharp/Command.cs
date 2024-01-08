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

            string Req = "SELECT command_Table.CommandId, product_Table.Name, product_Table.Description, categorie_Table.Name AS Category, (product_Table.Price * cart_Table.Quantity) AS Price, cart_Table.Quantity, command_Table.CommandDate AS Date, command_Table.CommandStatut AS Statut " +
                         "FROM command_Table " +
                         "INNER JOIN product_Table ON command_Table.ProductId = product_Table.ProductId " +
                         "INNER JOIN categorie_Table ON product_Table.CategorieId = categorie_Table.CategorieId " +
                         "INNER JOIN cart_Table ON command_Table.ProductId = cart_Table.ProductId";

            ListeCommand.DataSource = Con.RecupererData(Req);

        }

        private void Command_Load(object sender, EventArgs e)
        {

        }

        private void btnSUPPR_Click(object sender, EventArgs e)
        {
            DataRowView selectedProductRow = ListeCommand.CurrentRow.DataBoundItem as DataRowView;

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
                MessageBox.Show("Sélectionnez un produit à supprimer du panier.");
            }
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
                if (comboBoxSupprCom.Items.Count > 0)
                {
                    comboBoxSupprCom.SelectedIndex = 0;
                }

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
                // Récupérer les données depuis la base de données pour afficher dans la comboBoxPassCom
                string Req = "SELECT cart_Table.CartId, product_Table.Name FROM product_Table INNER JOIN cart_Table ON product_Table.ProductId = cart_Table.ProductId";
                DataTable table = Con.RecupererData(Req);

                // Remplir la comboBoxPassCom avec les noms des produits
                comboBoxFacture.DataSource = table;
                comboBoxFacture.DisplayMember = "Name"; // Assurez-vous que "Name" correspond au nom de la colonne contenant les noms des produits

                // Si nécessaire, sélectionnez un élément par défaut dans la comboBoxPassCom
                if (comboBoxFacture.Items.Count > 0)
                {
                    comboBoxFacture.SelectedIndex = 0;
                }

                // Afficher le panneau de sélection de produit
                panelFacture.Size = new Size(267, 128);
                panelFacture.Visible = !panelFacture.Visible;
            }
            else
            {
                MessageBox.Show("Le panier est vide. Ajoutez des produits avant de les supprimer.");
            }
        }

        private void btnFACTURATION_Click(object sender, EventArgs e)
        {
            DataRowView selectedProductRow = comboBoxFacture.SelectedItem as DataRowView;

            if (selectedProductRow != null)
            {
                DateTime InvoiceDate = DateTime.Now; // Obtenir la date actuelle

                int UserId;
                int CartId;
                int CommandId;

                // Récupérer le UserId depuis user_Table
                string ReqSelectUser = "SELECT UserId FROM user_Table /* Mettez ici votre condition pour trouver le bon utilisateur */";
                using (SqlConnection connection = new SqlConnection(Con.ConStr))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(ReqSelectUser, connection))
                    {
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            UserId = Convert.ToInt32(result);

                            // Récupérer le CartId depuis cart_Table
                            string ReqSelectCartId = "SELECT CartId FROM cart_Table /* Mettez ici votre condition pour trouver le bon panier */";
                            using (SqlCommand cartCommand = new SqlCommand(ReqSelectCartId, connection))
                            {
                                object cartResult = cartCommand.ExecuteScalar();
                                if (cartResult != null)
                                {
                                    CartId = Convert.ToInt32(cartResult);

                                    // Récupérer le CommandId depuis command_Table
                                    string ReqSelectCommandId = "SELECT CommandId FROM command_Table /* Mettez ici votre condition pour trouver la bonne commande */";
                                    using (SqlCommand commandCommand = new SqlCommand(ReqSelectCommandId, connection))
                                    {
                                        object commandResult = commandCommand.ExecuteScalar();
                                        if (commandResult != null)
                                        {
                                            CommandId = Convert.ToInt32(commandResult);

                                            // Récupérer le prix depuis product_Table
                                            string ReqSelectPrice = "SELECT Price FROM product_Table /* Mettez ici votre condition pour trouver le bon produit */";
                                            using (SqlCommand priceCommand = new SqlCommand(ReqSelectPrice, connection))
                                            {
                                                object priceResult = priceCommand.ExecuteScalar();
                                                if (priceResult != null)
                                                {
                                                    decimal Price = Convert.ToDecimal(priceResult);

                                                    // Récupérer la quantité depuis cart_Table
                                                    string ReqSelectQuantity = "SELECT Quantity FROM cart_Table /* Mettez ici votre condition pour trouver le bon panier */";
                                                    using (SqlCommand quantityCommand = new SqlCommand(ReqSelectQuantity, connection))
                                                    {
                                                        object quantityResult = quantityCommand.ExecuteScalar();
                                                        if (quantityResult != null)
                                                        {
                                                            int Quantity = Convert.ToInt32(quantityResult);

                                                            // Calculer le Total (Price * Quantity)
                                                            decimal Total = Price * Quantity;

                                                            // Insertion dans invoices_Table
                                                            string ReqInsert = "INSERT INTO invoices_Table (UserId, CartId, CommandId, Total, InvoiceDate) " +
                                                                               "VALUES (@UserId, @CartId, @CommandId, @Total, @InvoiceDate)";
                                                            using (SqlCommand insertCommand = new SqlCommand(ReqInsert, connection))
                                                            {
                                                                insertCommand.Parameters.AddWithValue("@UserId", UserId);
                                                                insertCommand.Parameters.AddWithValue("@CartId", CartId);
                                                                insertCommand.Parameters.AddWithValue("@CommandId", CommandId);
                                                                insertCommand.Parameters.AddWithValue("@Total", Total);
                                                                insertCommand.Parameters.AddWithValue("@InvoiceDate", InvoiceDate);

                                                                int rowsAffected = insertCommand.ExecuteNonQuery();
                                                                if (rowsAffected > 0)
                                                                {
                                                                    MessageBox.Show("Commande ajouté à la facture !");
                                                                }
                                                                else
                                                                {
                                                                    MessageBox.Show("Erreur lors de l'ajout à la facture.");
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Quantité non trouvée.");
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Prix non trouvé.");
                                                }
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Commande non trouvé.");
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Panier non trouvé.");
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
                MessageBox.Show("Sélectionnez un produit avant d'ajouter à la commande.");
            }
        }
    }
}
