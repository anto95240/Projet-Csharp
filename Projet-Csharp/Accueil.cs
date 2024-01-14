using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using Projet_Csharp.Class_db;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projet_Csharp
{
    public partial class Accueil : Form
    {
        Fonctions Con;
        private int Cle = 0;

        public Accueil()
        {
            InitializeComponent();
            Con = new Fonctions();
            AfficherProduits();
            panelAddPanier.Visible = false;
            panelAfficheCat.Visible = false;
            comboBoxProduits.SelectedIndexChanged += comboBoxProduits_SelectedIndexChanged;
            AfficheCategorie();
        }

        private void btnCAT_Click(object sender, EventArgs e)
        {
            if (CatTEXT.Text == "")
            {
                MessageBox.Show("Info Incomplète!!!");
            }
            else
            {
                try
                {
                    string Name = CatTEXT.Text;


                    string Req = "INSERT INTO categorie_Table (Name) VALUES (@Name)";

                    // Exécution de la requête avec les paramètres
                    Con.EnvoyerData(Req, new SqlParameter("@Name", Name));


                    MessageBox.Show("Catégorie Ajouté!!!!");

                    CatTEXT.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnAfficheCAT_Click(object sender, EventArgs e)
        {
            // Afficher le panneau de sélection de produit
            panelAfficheCat.Size = new Size(392, 86);
            panelAfficheCat.Visible = !panelAfficheCat.Visible;
        }

        private void panier_click(object sender, EventArgs e)
        {
            // Redirection vers la page de panier après avoir cliqué sur le bouton de panier
            Panier pagePanier = new Panier();
            pagePanier.Show(); // Affiche la page de panier
            this.Hide(); // Cache la page de accueil actuelle
        }

        private void compte_click(object sender, EventArgs e)
        {
            // Redirection vers la page de compte après avoir cliqué sur le bouton de compte
            Compte pageCompte = new Compte();
            pageCompte.Show(); // Affiche la page de compte
            this.Hide(); // Cache la page de accueil actuelle
        }
       
        private void command_click(object sender, EventArgs e)
        {
            // Redirection vers la page de Command après avoir cliqué sur le bouton de compte
            Command pageCommand = new Command();
            pageCommand.Show(); // Affiche la page de commande
            this.Hide(); // Cache la page de accueil actuelle
        }

        private void facture_click(object sender, EventArgs e)
        {
            // Redirection vers la page de Facture après avoir cliqué sur le bouton de compte
            Facture pageFacture = new Facture();
            pageFacture.Show(); // Affiche la page de facture
            this.Hide(); // Cache la page de accueil actuelle
        }

        private void deconnexion_click(object sender, EventArgs e)
        {
            // Redirection vers la page de deconnexion après avoir cliqué sur le bouton de deconneexion
            Deconnexion pageDeconnexion = new Deconnexion();
            pageDeconnexion.Show(); // Affiche la page de déconnexion
            this.Hide(); // Cache la page de accueil actuelle
        }


        private void AfficherProduits()
        {
            string Req = "SELECT product_Table.ProductId, product_Table.Name, product_Table.Description, categorie_Table.Name AS Category, product_Table.Price, product_Table.stock_Quantity AS Quantity " +
                "FROM product_Table " +
                "INNER JOIN categorie_Table ON product_Table.CategorieId = categorie_Table.CategorieId";

            ListeProduits.DataSource = Con.RecupererData(Req);

            ListeProduits.Columns["ProductId"].Visible = false;

        }

        private void btnAjouter(object sender, EventArgs e)
        {
            if (NomTEXT.Text == "" || DescriptionTEXT.Text == "" || PrixTEXT.Text == "" || QuantitéTEXT.Text == "" || comboBoxCat.SelectedItem == null)
            {
                MessageBox.Show("Info Incomplète!!!");
            }
            else
            {
                try
                {
                    string Name = NomTEXT.Text;
                    string Description = DescriptionTEXT.Text;

                    int Price = int.Parse(PrixTEXT.Text); // Convertir en décimal
                    int stock_Quantity = int.Parse(QuantitéTEXT.Text); // Convertir en entier

                    // Récupérer la catégorie sélectionnée dans la ComboBox
                    DataRowView selectedCategory = (DataRowView)comboBoxCat.SelectedItem;
                    int CategorieId = Convert.ToInt32(selectedCategory["CategorieId"]);

                    string InsertReq = "INSERT INTO product_Table (CategorieId, Name, Description, Price, stock_Quantity) VALUES (@CategorieId, @Name, @Description, @Price, @stock_Quantity)";

                    using (SqlConnection connection = new SqlConnection(Con.ConStr))
                    {
                        connection.Open();

                        using (SqlCommand insertCommand = new SqlCommand(InsertReq, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@CategorieId", CategorieId);
                            insertCommand.Parameters.AddWithValue("@Name", Name);
                            insertCommand.Parameters.AddWithValue("@Description", Description);
                            insertCommand.Parameters.AddWithValue("@Price", Price);
                            insertCommand.Parameters.AddWithValue("@stock_Quantity", stock_Quantity);

                            int rowsAffected = insertCommand.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Produit Ajouté!!!!");

                                AfficherProduits();

                                NomTEXT.Text = "";
                                DescriptionTEXT.Text = "";
                                PrixTEXT.Text = "";
                                QuantitéTEXT.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Erreur lors de l'ajout au commande.");
                            }
                        }
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void AfficheCategorie()
        {
            // Récupérer les données depuis la base de données pour afficher dans la ComboBox
            string Req = "SELECT CategorieId, Name FROM categorie_Table";
            DataTable table = Con.RecupererData(Req);

            // Remplir la ComboBox avec les noms des produits
            comboBoxCat.DataSource = table;
            comboBoxCat.DisplayMember = "Name"; // Assurez-vous que "Name" correspond au nom de la colonne contenant les noms des produits

            // Si nécessaire, sélectionnez un élément par défaut dans la ComboBox
            if (comboBoxCat.Items.Count > 0)
            {
                comboBoxCat.SelectedIndex = 0;
            }
        }


        private void ListeProduits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < ListeProduits.Rows.Count)
            {
                DataGridViewRow selectedRow = ListeProduits.Rows[e.RowIndex];

                NomTEXT.Text = selectedRow.Cells["Name"].Value?.ToString() ?? "";
                DescriptionTEXT.Text = selectedRow.Cells["Description"].Value?.ToString() ?? "";
                CatTEXT.Text = selectedRow.Cells["Category"].Value?.ToString() ?? "";
                PrixTEXT.Text = selectedRow.Cells["Price"].Value?.ToString() ?? "";
                QuantitéTEXT.Text = selectedRow.Cells["Quantity"].Value?.ToString() ?? "";

                if (int.TryParse(selectedRow.Cells["ProductId"].Value?.ToString(), out int productId))
                {
                    Cle = productId;
                }
                else
                {
                    Cle = 0;
                }
            }
        }




        private void btnModifier(object sender, EventArgs e)
        {
            if (NomTEXT.Text == "" || DescriptionTEXT.Text == "" || PrixTEXT.Text == "" || QuantitéTEXT.Text == "" || comboBoxCat.SelectedItem == null)
            {
                MessageBox.Show("Info Incomplète!!!");
            }
            else
            {
                try
                {
                    string Name = NomTEXT.Text;
                    string Description = DescriptionTEXT.Text;
                    int Price = int.Parse(PrixTEXT.Text);
                    int stock_Quantity = int.Parse(QuantitéTEXT.Text);

                    DataRowView selectedCategory = (DataRowView)comboBoxCat.SelectedItem;
                    int CategorieId = Convert.ToInt32(selectedCategory["CategorieId"]);

                    using (SqlConnection connection = new SqlConnection(Con.ConStr))
                    {
                        connection.Open();

                        string Req = "UPDATE product_Table SET CategorieId = '{0}', Name = '{1}', Description = '{2}', Price = '{3}', stock_Quantity = '{4}' WHERE ProductId = {5}";

                        Req = string.Format(Req, CategorieId, Name, Description, Price, stock_Quantity, Cle);
                        Con.EnvoyerData(Req);

                        AfficherProduits();

                        NomTEXT.Text = "";
                        DescriptionTEXT.Text = "";
                        PrixTEXT.Text = "";
                        QuantitéTEXT.Text = "";
                        comboBoxCat.SelectedItem = selectedCategory;

                        MessageBox.Show("Produit Modifié!!!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }




        private void btnSupprimer(object sender, EventArgs e)
        {
            if (Cle == 0)
            {
                MessageBox.Show("Selectionner Un Produit!!!");
            }
            else
            {
                try
                {
                    string Req = "DELETE from product_Table WHERE ProductId = @ProductId";

                    using (SqlConnection connection = new SqlConnection(Con.ConStr))
                    {
                        connection.Open();

                        using (SqlCommand deleteCommand = new SqlCommand(Req, connection))
                        {
                            deleteCommand.Parameters.AddWithValue("@ProductId", Cle);

                            // Exécution de la commande
                            int rowsAffected = deleteCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                AfficherProduits();
                                NomTEXT.Text = "";
                                DescriptionTEXT.Text = "";
                                PrixTEXT.Text = "";
                                QuantitéTEXT.Text = "";
                                MessageBox.Show("Produit Supprimé!!!");
                            }
                            else
                            {
                                MessageBox.Show("Erreur lors de la suppression du produit.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxProduits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProduits.SelectedItem != null)
            {
                DataRowView selectedProductRow = comboBoxProduits.SelectedItem as DataRowView;
                int ProductId = Convert.ToInt32(selectedProductRow["ProductId"]);

                // Utilisez ces valeurs si nécessaire, par exemple pour affichage ou ajout au panier
            }
        }


        private void btnAfficheProduitAddPanier(object sender, EventArgs e)
        {
            // Récupérer les données depuis la base de données pour afficher dans la ComboBox
            string Req = "SELECT ProductId, Name FROM product_Table";
            DataTable table = Con.RecupererData(Req);

            // Remplir la ComboBox avec les noms des produits
            comboBoxProduits.DataSource = table;
            comboBoxProduits.DisplayMember = "Name"; // Assurez-vous que "Name" correspond au nom de la colonne contenant les noms des produits

            // Si nécessaire, sélectionnez un élément par défaut dans la ComboBox
            if (comboBoxProduits.Items.Count > 0)
            {
                comboBoxProduits.SelectedIndex = 0;
            }

            // Afficher le panneau de sélection de produit
            panelAddPanier.Size = new Size(333, 165);
            panelAddPanier.Visible = !panelAddPanier.Visible;
        }

        private void btnAddPanier(object sender, EventArgs e)
        {
            DataRowView selectedProductRow = comboBoxProduits.SelectedItem as DataRowView;

            if (selectedProductRow != null)
            {
                int ProductId = Convert.ToInt32(selectedProductRow["ProductId"]);

                string Quantity = QuantityProduit.Text;
                string Statut = "Reserved";

                // Obtenir le UserId à partir de user_Table
                int UserId;

                using (SqlConnection connection = new SqlConnection(Con.ConStr))
                {
                    connection.Open();

                    string ReqSelect = "SELECT UserId FROM user_Table /* Mettez ici votre condition pour trouver le bon utilisateur */";
                    
                    using (SqlCommand command = new SqlCommand(ReqSelect, connection))
                    {
                        // Execute la requête SELECT pour obtenir le UserId
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            UserId = Convert.ToInt32(result);

                            // Insérer le produit sélectionné dans la table cart_Table
                            string ReqInsert = "INSERT INTO cart_Table (UserId, ProductId, Quantity, Statut) " +
                                               "VALUES (@UserId, @ProductId, @Quantity, @Statut)";

                            using (SqlCommand insertCommand = new SqlCommand(ReqInsert, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@UserId", UserId);
                                insertCommand.Parameters.AddWithValue("@ProductId", ProductId);
                                insertCommand.Parameters.AddWithValue("@Quantity", Quantity);
                                insertCommand.Parameters.AddWithValue("@Statut", Statut);

                                int rowsAffected = insertCommand.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Produit ajouté au panier!");
                                }
                                else
                                {
                                    MessageBox.Show("Erreur lors de l'ajout au panier.");
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
                MessageBox.Show("Sélectionnez un produit avant d'ajouter au panier.");
            }
        }

    }
}


