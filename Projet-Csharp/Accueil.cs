﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet_Csharp.Class_db;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projet_Csharp
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
            Con = new Fonctions();
            AfficherProduits();
        }

        Fonctions Con;

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
            string Req = "select * from product_Table";
            ListeProduits.DataSource = Con.RecupererData(Req);
        }

        private void btnAjouter(object sender, EventArgs e)
        {
            if (NomTEXT.Text == "" || DescriptionTEXT.Text == "" || PrixTEXT.Text == "" || QuantitéTEXT.Text == "")
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
                    int Stock_Quantity = int.Parse(QuantitéTEXT.Text); // Convertir en entier


                    string Req = "INSERT INTO product_Table (Name, Description, Price, Stock_Quantity) VALUES (@Name, @Description, @Price, @Stock_Quantity)";

                    // Exécution de la requête avec les paramètres
                    Con.EnvoyerData(Req, new SqlParameter("@Name", Name), new SqlParameter("@Description", Description), new SqlParameter("@Price", Price), new SqlParameter("@Stock_Quantity", Stock_Quantity));


                    MessageBox.Show("Produit Ajouté!!!!");

                    AfficherProduits();

                    NomTEXT.Text = "";
                    DescriptionTEXT.Text = "";
                    PrixTEXT.Text = "";
                    QuantitéTEXT.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int Cle = 0;
        private void ListeProduits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NomTEXT.Text = ListeProduits.SelectedRows[0].Cells[1].Value.ToString();
            DescriptionTEXT.Text = ListeProduits.SelectedRows[0].Cells[2].Value.ToString();
            PrixTEXT.Text = ListeProduits.SelectedRows[0].Cells[3].Value.ToString();
            QuantitéTEXT.Text = ListeProduits.SelectedRows[0].Cells[4].Value.ToString();

            if (NomTEXT.Text == "")
            {
                Cle = 0;
            }
            else
            {
                Cle = Convert.ToInt32(ListeProduits.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btnModifier(object sender, EventArgs e)
        {
            if (NomTEXT.Text == "" || DescriptionTEXT.Text == "" || PrixTEXT.Text == "" || QuantitéTEXT.Text == "")
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
                    int Stock_Quantity = int.Parse(QuantitéTEXT.Text); // Convertir en entier

                    string Req = "UPDATE product_Table SET Name = '{0}', Description = '{1}', Price = '{2}', Stock_Quantity = '{3}' WHERE ProductId = {4}";

                    Req = string.Format(Req, Name, Description, Price, Stock_Quantity, Cle);
                    Con.EnvoyerData(Req);

                    MessageBox.Show("Produit Modifié!!!!");

                    AfficherProduits();

                    NomTEXT.Text = "";
                    DescriptionTEXT.Text = "";
                    PrixTEXT.Text = "";
                    QuantitéTEXT.Text = "";

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
                    string Name = NomTEXT.Text;
                    string Description = DescriptionTEXT.Text;
                    int Price = int.Parse(PrixTEXT.Text); // Convertir en décimal
                    int Stock_Quantity = int.Parse(QuantitéTEXT.Text); // Convertir en entier

                    string Req = "DELETE from product_Table WHERE ProductId = {0} ";
                    Req = string.Format(Req, Cle);

                    // Exécution de la commande
                    Con.EnvoyerData(Req);


                    AfficherProduits();
                    NomTEXT.Text = "";
                    DescriptionTEXT.Text = "";
                    PrixTEXT.Text = "";
                    QuantitéTEXT.Text = "";
                    MessageBox.Show("Produit Supprimé!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAddPanier(object sender, EventArgs e)
        {

        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        
    }

}


