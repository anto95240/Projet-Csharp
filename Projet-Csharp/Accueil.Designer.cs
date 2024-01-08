namespace Projet_Csharp
{
    partial class Accueil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnAfficheCAT = new Button();
            btnFACTURE = new Button();
            panel3 = new Panel();
            btnCOMMAND = new Button();
            btnDECONNEXION = new Button();
            btnCOMPTE = new Button();
            btnPRODUIT = new Button();
            btnPANIER = new Button();
            Logo1 = new PictureBox();
            ajouter = new Button();
            TITLE = new TextBox();
            supprimer = new Button();
            NomTITLE = new Label();
            addPANIER = new Button();
            modif = new Button();
            PrixTITLE = new Label();
            NomTEXT = new TextBox();
            DescriptionTITLE = new Label();
            ListeProduits = new Guna.UI2.WinForms.Guna2DataGridView();
            QuantitéTITLE = new Label();
            DescriptionTEXT = new TextBox();
            PrixTEXT = new TextBox();
            QuantitéTEXT = new TextBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panelAddPanier = new Panel();
            comboBoxProduits = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            QuantityProduit = new TextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            comboBoxCat = new ComboBox();
            producttableBindingSource = new BindingSource(components);
            panelAfficheCat = new Panel();
            button2 = new Button();
            CatTEXT = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ListeProduits).BeginInit();
            panelAddPanier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)producttableBindingSource).BeginInit();
            panelAfficheCat.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(btnAfficheCAT);
            panel1.Controls.Add(btnFACTURE);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnCOMMAND);
            panel1.Controls.Add(btnDECONNEXION);
            panel1.Controls.Add(btnCOMPTE);
            panel1.Controls.Add(btnPRODUIT);
            panel1.Controls.Add(btnPANIER);
            panel1.Controls.Add(Logo1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 582);
            panel1.TabIndex = 71;
            // 
            // btnAfficheCAT
            // 
            btnAfficheCAT.FlatAppearance.BorderSize = 0;
            btnAfficheCAT.FlatStyle = FlatStyle.Flat;
            btnAfficheCAT.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAfficheCAT.ForeColor = SystemColors.ControlLightLight;
            btnAfficheCAT.Image = Properties.Resources.icon_panier1;
            btnAfficheCAT.ImageAlign = ContentAlignment.MiddleLeft;
            btnAfficheCAT.Location = new Point(16, 195);
            btnAfficheCAT.Name = "btnAfficheCAT";
            btnAfficheCAT.Size = new Size(192, 32);
            btnAfficheCAT.TabIndex = 88;
            btnAfficheCAT.Text = "   Les Catégories";
            btnAfficheCAT.UseVisualStyleBackColor = true;
            btnAfficheCAT.Click += btnAfficheCAT_Click;
            // 
            // btnFACTURE
            // 
            btnFACTURE.FlatAppearance.BorderSize = 0;
            btnFACTURE.FlatStyle = FlatStyle.Flat;
            btnFACTURE.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFACTURE.ForeColor = SystemColors.ControlLightLight;
            btnFACTURE.Image = Properties.Resources.icon_compte1;
            btnFACTURE.ImageAlign = ContentAlignment.MiddleLeft;
            btnFACTURE.Location = new Point(16, 440);
            btnFACTURE.Name = "btnFACTURE";
            btnFACTURE.Size = new Size(192, 32);
            btnFACTURE.TabIndex = 87;
            btnFACTURE.Text = "Mes Factures";
            btnFACTURE.UseVisualStyleBackColor = true;
            btnFACTURE.Click += facture_click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Location = new Point(3, 135);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 32);
            panel3.TabIndex = 20;
            // 
            // btnCOMMAND
            // 
            btnCOMMAND.FlatAppearance.BorderSize = 0;
            btnCOMMAND.FlatStyle = FlatStyle.Flat;
            btnCOMMAND.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCOMMAND.ForeColor = SystemColors.ControlLightLight;
            btnCOMMAND.Image = Properties.Resources.icon_compte1;
            btnCOMMAND.ImageAlign = ContentAlignment.MiddleLeft;
            btnCOMMAND.Location = new Point(16, 380);
            btnCOMMAND.Name = "btnCOMMAND";
            btnCOMMAND.Size = new Size(192, 32);
            btnCOMMAND.TabIndex = 86;
            btnCOMMAND.Text = "     Mes Commandes";
            btnCOMMAND.UseVisualStyleBackColor = true;
            btnCOMMAND.Click += command_click;
            // 
            // btnDECONNEXION
            // 
            btnDECONNEXION.FlatAppearance.BorderSize = 0;
            btnDECONNEXION.FlatStyle = FlatStyle.Flat;
            btnDECONNEXION.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDECONNEXION.ForeColor = SystemColors.ControlLightLight;
            btnDECONNEXION.Image = Properties.Resources.icon_deconnexion1;
            btnDECONNEXION.ImageAlign = ContentAlignment.MiddleLeft;
            btnDECONNEXION.Location = new Point(16, 511);
            btnDECONNEXION.Name = "btnDECONNEXION";
            btnDECONNEXION.Size = new Size(192, 32);
            btnDECONNEXION.TabIndex = 11;
            btnDECONNEXION.Text = "Déconnexion";
            btnDECONNEXION.UseVisualStyleBackColor = true;
            btnDECONNEXION.Click += deconnexion_click;
            // 
            // btnCOMPTE
            // 
            btnCOMPTE.FlatAppearance.BorderSize = 0;
            btnCOMPTE.FlatStyle = FlatStyle.Flat;
            btnCOMPTE.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCOMPTE.ForeColor = SystemColors.ControlLightLight;
            btnCOMPTE.Image = Properties.Resources.icon_compte1;
            btnCOMPTE.ImageAlign = ContentAlignment.MiddleLeft;
            btnCOMPTE.Location = new Point(16, 320);
            btnCOMPTE.Name = "btnCOMPTE";
            btnCOMPTE.Size = new Size(192, 32);
            btnCOMPTE.TabIndex = 85;
            btnCOMPTE.Text = "Mon Compte";
            btnCOMPTE.UseVisualStyleBackColor = true;
            btnCOMPTE.Click += compte_click;
            // 
            // btnPRODUIT
            // 
            btnPRODUIT.FlatAppearance.BorderSize = 0;
            btnPRODUIT.FlatStyle = FlatStyle.Flat;
            btnPRODUIT.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPRODUIT.ForeColor = SystemColors.ControlLightLight;
            btnPRODUIT.Image = Properties.Resources.Icon_produit1;
            btnPRODUIT.ImageAlign = ContentAlignment.MiddleLeft;
            btnPRODUIT.Location = new Point(16, 135);
            btnPRODUIT.Name = "btnPRODUIT";
            btnPRODUIT.RightToLeft = RightToLeft.No;
            btnPRODUIT.Size = new Size(192, 32);
            btnPRODUIT.TabIndex = 1;
            btnPRODUIT.Text = "Les Produits";
            btnPRODUIT.UseVisualStyleBackColor = true;
            // 
            // btnPANIER
            // 
            btnPANIER.FlatAppearance.BorderSize = 0;
            btnPANIER.FlatStyle = FlatStyle.Flat;
            btnPANIER.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPANIER.ForeColor = SystemColors.ControlLightLight;
            btnPANIER.Image = Properties.Resources.icon_panier1;
            btnPANIER.ImageAlign = ContentAlignment.MiddleLeft;
            btnPANIER.Location = new Point(16, 256);
            btnPANIER.Name = "btnPANIER";
            btnPANIER.Size = new Size(192, 32);
            btnPANIER.TabIndex = 84;
            btnPANIER.Text = "Mon Panier";
            btnPANIER.UseVisualStyleBackColor = true;
            btnPANIER.Click += panier_click;
            // 
            // Logo1
            // 
            Logo1.BackColor = Color.White;
            Logo1.BackgroundImage = (Image)resources.GetObject("Logo1.BackgroundImage");
            Logo1.Image = (Image)resources.GetObject("Logo1.Image");
            Logo1.Location = new Point(60, 10);
            Logo1.Name = "Logo1";
            Logo1.Size = new Size(69, 63);
            Logo1.TabIndex = 1;
            Logo1.TabStop = false;
            // 
            // ajouter
            // 
            ajouter.BackColor = Color.LimeGreen;
            ajouter.Location = new Point(217, 418);
            ajouter.Name = "ajouter";
            ajouter.Size = new Size(109, 35);
            ajouter.TabIndex = 74;
            ajouter.Text = "AJOUTER";
            ajouter.UseVisualStyleBackColor = false;
            ajouter.Click += btnAjouter;
            // 
            // TITLE
            // 
            TITLE.BorderStyle = BorderStyle.None;
            TITLE.Font = new Font("Times New Roman", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            TITLE.Location = new Point(568, 24);
            TITLE.Name = "TITLE";
            TITLE.Size = new Size(197, 21);
            TITLE.TabIndex = 72;
            TITLE.Text = "LISTE DES PRODUITS";
            TITLE.TextAlign = HorizontalAlignment.Center;
            // 
            // supprimer
            // 
            supprimer.BackColor = Color.Salmon;
            supprimer.Location = new Point(271, 477);
            supprimer.Name = "supprimer";
            supprimer.Size = new Size(121, 35);
            supprimer.TabIndex = 76;
            supprimer.Text = "SUPPRIMER";
            supprimer.UseVisualStyleBackColor = false;
            supprimer.Click += btnSupprimer;
            // 
            // NomTITLE
            // 
            NomTITLE.AutoSize = true;
            NomTITLE.BackColor = Color.White;
            NomTITLE.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NomTITLE.ForeColor = Color.Crimson;
            NomTITLE.Location = new Point(218, 110);
            NomTITLE.Margin = new Padding(4, 0, 4, 0);
            NomTITLE.Name = "NomTITLE";
            NomTITLE.Size = new Size(48, 22);
            NomTITLE.TabIndex = 78;
            NomTITLE.Text = "Nom";
            // 
            // addPANIER
            // 
            addPANIER.Anchor = AnchorStyles.None;
            addPANIER.Location = new Point(929, 530);
            addPANIER.Name = "addPANIER";
            addPANIER.Size = new Size(189, 40);
            addPANIER.TabIndex = 77;
            addPANIER.Text = "AJOUTER PANIER";
            addPANIER.UseVisualStyleBackColor = true;
            addPANIER.Click += btnAfficheProduitAddPanier;
            // 
            // modif
            // 
            modif.BackColor = Color.GreenYellow;
            modif.Location = new Point(341, 418);
            modif.Name = "modif";
            modif.Size = new Size(109, 35);
            modif.TabIndex = 73;
            modif.Text = "MODIFIER";
            modif.UseVisualStyleBackColor = false;
            modif.Click += btnModifier;
            // 
            // PrixTITLE
            // 
            PrixTITLE.AutoSize = true;
            PrixTITLE.BackColor = Color.White;
            PrixTITLE.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrixTITLE.ForeColor = Color.Crimson;
            PrixTITLE.Location = new Point(218, 302);
            PrixTITLE.Margin = new Padding(4, 0, 4, 0);
            PrixTITLE.Name = "PrixTITLE";
            PrixTITLE.Size = new Size(43, 22);
            PrixTITLE.TabIndex = 83;
            PrixTITLE.Text = "Prix";
            // 
            // NomTEXT
            // 
            NomTEXT.AccessibleName = "";
            NomTEXT.BorderStyle = BorderStyle.FixedSingle;
            NomTEXT.Location = new Point(300, 109);
            NomTEXT.Multiline = true;
            NomTEXT.Name = "NomTEXT";
            NomTEXT.Size = new Size(137, 30);
            NomTEXT.TabIndex = 80;
            // 
            // DescriptionTITLE
            // 
            DescriptionTITLE.AutoSize = true;
            DescriptionTITLE.BackColor = Color.White;
            DescriptionTITLE.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DescriptionTITLE.ForeColor = Color.Crimson;
            DescriptionTITLE.Location = new Point(218, 168);
            DescriptionTITLE.Margin = new Padding(4, 0, 4, 0);
            DescriptionTITLE.Name = "DescriptionTITLE";
            DescriptionTITLE.Size = new Size(103, 22);
            DescriptionTITLE.TabIndex = 79;
            DescriptionTITLE.Text = "Description";
            // 
            // ListeProduits
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            ListeProduits.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ListeProduits.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ListeProduits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ListeProduits.ColumnHeadersHeight = 22;
            ListeProduits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ListeProduits.DefaultCellStyle = dataGridViewCellStyle3;
            ListeProduits.GridColor = Color.Silver;
            ListeProduits.Location = new Point(456, 109);
            ListeProduits.Name = "ListeProduits";
            ListeProduits.RowHeadersVisible = false;
            ListeProduits.RowHeadersWidth = 51;
            ListeProduits.Size = new Size(662, 403);
            ListeProduits.TabIndex = 75;
            ListeProduits.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            ListeProduits.ThemeStyle.AlternatingRowsStyle.Font = null;
            ListeProduits.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            ListeProduits.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            ListeProduits.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            ListeProduits.ThemeStyle.BackColor = SystemColors.Control;
            ListeProduits.ThemeStyle.GridColor = Color.Silver;
            ListeProduits.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            ListeProduits.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            ListeProduits.ThemeStyle.HeaderStyle.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListeProduits.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ListeProduits.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ListeProduits.ThemeStyle.HeaderStyle.Height = 22;
            ListeProduits.ThemeStyle.ReadOnly = false;
            ListeProduits.ThemeStyle.RowsStyle.BackColor = Color.White;
            ListeProduits.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ListeProduits.ThemeStyle.RowsStyle.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListeProduits.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            ListeProduits.ThemeStyle.RowsStyle.Height = 29;
            ListeProduits.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ListeProduits.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            ListeProduits.CellContentClick += ListeProduits_CellContentClick;
            // 
            // QuantitéTITLE
            // 
            QuantitéTITLE.AutoSize = true;
            QuantitéTITLE.BackColor = Color.White;
            QuantitéTITLE.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuantitéTITLE.ForeColor = Color.Crimson;
            QuantitéTITLE.Location = new Point(218, 361);
            QuantitéTITLE.Margin = new Padding(4, 0, 4, 0);
            QuantitéTITLE.Name = "QuantitéTITLE";
            QuantitéTITLE.Size = new Size(76, 22);
            QuantitéTITLE.TabIndex = 82;
            QuantitéTITLE.Text = "Quantité";
            // 
            // DescriptionTEXT
            // 
            DescriptionTEXT.AccessibleName = "";
            DescriptionTEXT.BorderStyle = BorderStyle.FixedSingle;
            DescriptionTEXT.Location = new Point(328, 158);
            DescriptionTEXT.Multiline = true;
            DescriptionTEXT.Name = "DescriptionTEXT";
            DescriptionTEXT.ScrollBars = ScrollBars.Vertical;
            DescriptionTEXT.Size = new Size(109, 75);
            DescriptionTEXT.TabIndex = 81;
            // 
            // PrixTEXT
            // 
            PrixTEXT.AccessibleName = "";
            PrixTEXT.BorderStyle = BorderStyle.FixedSingle;
            PrixTEXT.Location = new Point(284, 302);
            PrixTEXT.Multiline = true;
            PrixTEXT.Name = "PrixTEXT";
            PrixTEXT.Size = new Size(95, 30);
            PrixTEXT.TabIndex = 82;
            // 
            // QuantitéTEXT
            // 
            QuantitéTEXT.AccessibleName = "";
            QuantitéTEXT.BorderStyle = BorderStyle.FixedSingle;
            QuantitéTEXT.Location = new Point(300, 355);
            QuantitéTEXT.Multiline = true;
            QuantitéTEXT.Name = "QuantitéTEXT";
            QuantitéTEXT.Size = new Size(79, 30);
            QuantitéTEXT.TabIndex = 83;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 50;
            // 
            // panelAddPanier
            // 
            panelAddPanier.Controls.Add(comboBoxProduits);
            panelAddPanier.Controls.Add(label2);
            panelAddPanier.Controls.Add(label1);
            panelAddPanier.Controls.Add(QuantityProduit);
            panelAddPanier.Controls.Add(button1);
            panelAddPanier.Controls.Add(textBox1);
            panelAddPanier.Location = new Point(785, 361);
            panelAddPanier.Name = "panelAddPanier";
            panelAddPanier.Size = new Size(333, 163);
            panelAddPanier.TabIndex = 84;
            // 
            // comboBoxProduits
            // 
            comboBoxProduits.FormattingEnabled = true;
            comboBoxProduits.Location = new Point(131, 47);
            comboBoxProduits.Name = "comboBoxProduits";
            comboBoxProduits.Size = new Size(183, 28);
            comboBoxProduits.TabIndex = 89;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(18, 89);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 22);
            label2.TabIndex = 88;
            label2.Text = "Quantity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(18, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 22);
            label1.TabIndex = 87;
            label1.Text = "Nom";
            // 
            // QuantityProduit
            // 
            QuantityProduit.AccessibleName = "";
            QuantityProduit.BorderStyle = BorderStyle.FixedSingle;
            QuantityProduit.Location = new Point(131, 88);
            QuantityProduit.Multiline = true;
            QuantityProduit.Name = "QuantityProduit";
            QuantityProduit.Size = new Size(183, 30);
            QuantityProduit.TabIndex = 86;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(228, 131);
            button1.Name = "button1";
            button1.Size = new Size(102, 30);
            button1.TabIndex = 85;
            button1.Text = "AJOUTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAddPanier;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Times New Roman", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(3, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(327, 24);
            textBox1.TabIndex = 0;
            textBox1.Text = "PRODUIT A AJOUTER";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(218, 254);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 22);
            label3.TabIndex = 85;
            label3.Text = "Catégorie";
            // 
            // comboBoxCat
            // 
            comboBoxCat.FormattingEnabled = true;
            comboBoxCat.Items.AddRange(new object[] { "" });
            comboBoxCat.Location = new Point(312, 252);
            comboBoxCat.Name = "comboBoxCat";
            comboBoxCat.Size = new Size(125, 28);
            comboBoxCat.TabIndex = 90;
            // 
            // producttableBindingSource
            // 
            producttableBindingSource.DataSource = typeof(product_table);
            // 
            // panelAfficheCat
            // 
            panelAfficheCat.BackColor = Color.White;
            panelAfficheCat.Controls.Add(button2);
            panelAfficheCat.Controls.Add(CatTEXT);
            panelAfficheCat.Controls.Add(label4);
            panelAfficheCat.Controls.Add(textBox2);
            panelAfficheCat.Location = new Point(214, 168);
            panelAfficheCat.Name = "panelAfficheCat";
            panelAfficheCat.Size = new Size(13, 86);
            panelAfficheCat.TabIndex = 89;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(97, 53);
            button2.Name = "button2";
            button2.Size = new Size(102, 30);
            button2.TabIndex = 90;
            button2.Text = "AJOUTER";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnCAT_Click;
            // 
            // CatTEXT
            // 
            CatTEXT.AccessibleName = "";
            CatTEXT.BorderStyle = BorderStyle.FixedSingle;
            CatTEXT.Location = new Point(59, 30);
            CatTEXT.Multiline = true;
            CatTEXT.Name = "CatTEXT";
            CatTEXT.Size = new Size(183, 30);
            CatTEXT.TabIndex = 90;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(4, 34);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(48, 22);
            label4.TabIndex = 91;
            label4.Text = "Nom";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Times New Roman", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.WindowText;
            textBox2.Location = new Point(35, 1);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(327, 24);
            textBox2.TabIndex = 90;
            textBox2.Text = "CREATION DES CATEGORIES";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // Accueil
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1130, 582);
            Controls.Add(panelAfficheCat);
            Controls.Add(comboBoxCat);
            Controls.Add(label3);
            Controls.Add(panelAddPanier);
            Controls.Add(panel1);
            Controls.Add(ajouter);
            Controls.Add(TITLE);
            Controls.Add(supprimer);
            Controls.Add(NomTITLE);
            Controls.Add(addPANIER);
            Controls.Add(modif);
            Controls.Add(PrixTITLE);
            Controls.Add(NomTEXT);
            Controls.Add(DescriptionTITLE);
            Controls.Add(ListeProduits);
            Controls.Add(QuantitéTITLE);
            Controls.Add(DescriptionTEXT);
            Controls.Add(PrixTEXT);
            Controls.Add(QuantitéTEXT);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Accueil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Accueil";
            Load += Accueil_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ListeProduits).EndInit();
            panelAddPanier.ResumeLayout(false);
            panelAddPanier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)producttableBindingSource).EndInit();
            panelAfficheCat.ResumeLayout(false);
            panelAfficheCat.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnDECONNEXION;
        private Button btnPRODUIT;
        private PictureBox Logo1;
        private Button ajouter;
        private TextBox TITLE;
        private Button supprimer;
        private Label NomTITLE;
        private Button addPANIER;
        private Button modif;
        private Label PrixTITLE;
        private TextBox NomTEXT;
        private Label DescriptionTITLE;
        private Guna.UI2.WinForms.Guna2DataGridView ListeProduits;
        private Label QuantitéTITLE;
        private TextBox DescriptionTEXT;
        private TextBox PrixTEXT;
        private TextBox QuantitéTEXT;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Panel panel3;
        private Button btnFACTURE;
        private Button btnCOMMAND;
        private Button btnCOMPTE;
        private Button btnPANIER;
        private Panel panelAddPanier;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox QuantityProduit;
        private ComboBox comboBoxProduits;
        private Label label3;
        private ComboBox comboBoxCat;
        private BindingSource producttableBindingSource;
        private Button btnAfficheCAT;
        private Panel panelAfficheCat;
        private Button button2;
        private TextBox CatTEXT;
        private Label label4;
        private TextBox textBox2;
    }
}