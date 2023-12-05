namespace Projet_Csharp
{
    partial class Compte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compte));
            panel1 = new Panel();
            btnDECONNEXION = new Button();
            btnCOMPTE = new Button();
            btnPANIER = new Button();
            btnPRODUIT = new Button();
            logoDECONNEXION = new PictureBox();
            logoPRODUITS = new PictureBox();
            logoCOMPTE = new PictureBox();
            logoPANNIER = new PictureBox();
            logo = new PictureBox();
            Onglet = new TabControl();
            info = new TabPage();
            TypeAdresseTITLE = new TextBox();
            TypeAdresseTEXT = new TextBox();
            CodePostalTITLE = new TextBox();
            CodePostalTEXT = new TextBox();
            PaysTITLE = new TextBox();
            EtatTITLE = new TextBox();
            PaysTEXT = new TextBox();
            EtatTEXT = new TextBox();
            VilleTITLE = new TextBox();
            AdresseTITLE = new TextBox();
            VilleTEXT = new TextBox();
            AdresseTEXT = new TextBox();
            MdpTITLE = new TextBox();
            MailTITLE = new TextBox();
            MdpTEXT = new TextBox();
            MailTEXT = new TextBox();
            NomTITLE = new TextBox();
            PrénomTITLE = new TextBox();
            NomTEXT = new TextBox();
            PrénomTEXT = new TextBox();
            button5 = new Button();
            commande = new TabPage();
            StatusVISU_C = new TextBox();
            DateVISU_C = new TextBox();
            DescriptionVISU_C = new TextBox();
            NomVISU_C = new TextBox();
            btnANNULER_COMMANDE = new Button();
            factures = new TabPage();
            PrixTotalVISU_F = new TextBox();
            QuantitéVISU_F = new TextBox();
            DescriptionVISU_F = new TextBox();
            DateVISU_F = new TextBox();
            NomVISU_F = new TextBox();
            TITLE = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoDECONNEXION).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoPRODUITS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoCOMPTE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoPANNIER).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            Onglet.SuspendLayout();
            info.SuspendLayout();
            commande.SuspendLayout();
            factures.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(btnDECONNEXION);
            panel1.Controls.Add(btnCOMPTE);
            panel1.Controls.Add(btnPANIER);
            panel1.Controls.Add(btnPRODUIT);
            panel1.Controls.Add(logoDECONNEXION);
            panel1.Controls.Add(logoPRODUITS);
            panel1.Controls.Add(logoCOMPTE);
            panel1.Controls.Add(logoPANNIER);
            panel1.Controls.Add(logo);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(196, 582);
            panel1.TabIndex = 1;
            // 
            // btnDECONNEXION
            // 
            btnDECONNEXION.Location = new Point(50, 511);
            btnDECONNEXION.Name = "btnDECONNEXION";
            btnDECONNEXION.Size = new Size(125, 29);
            btnDECONNEXION.TabIndex = 11;
            btnDECONNEXION.Text = "Déconnexion";
            btnDECONNEXION.UseVisualStyleBackColor = true;
            btnDECONNEXION.Click += deconnexion_click;
            // 
            // btnCOMPTE
            // 
            btnCOMPTE.Location = new Point(50, 421);
            btnCOMPTE.Name = "btnCOMPTE";
            btnCOMPTE.Size = new Size(125, 29);
            btnCOMPTE.TabIndex = 10;
            btnCOMPTE.Text = "Mon Compte";
            btnCOMPTE.UseVisualStyleBackColor = true;
            // 
            // btnPANIER
            // 
            btnPANIER.Location = new Point(50, 279);
            btnPANIER.Name = "btnPANIER";
            btnPANIER.Size = new Size(125, 29);
            btnPANIER.TabIndex = 9;
            btnPANIER.Text = "Mon Panier";
            btnPANIER.UseVisualStyleBackColor = true;
            btnPANIER.Click += panier_click;
            // 
            // btnPRODUIT
            // 
            btnPRODUIT.Location = new Point(50, 167);
            btnPRODUIT.Name = "btnPRODUIT";
            btnPRODUIT.Size = new Size(125, 29);
            btnPRODUIT.TabIndex = 1;
            btnPRODUIT.Text = "Les Produits";
            btnPRODUIT.UseVisualStyleBackColor = true;
            btnPRODUIT.Click += produit_click;
            // 
            // logoDECONNEXION
            // 
            logoDECONNEXION.BackgroundImage = (Image)resources.GetObject("logoDECONNEXION.BackgroundImage");
            logoDECONNEXION.Location = new Point(16, 512);
            logoDECONNEXION.Name = "logoDECONNEXION";
            logoDECONNEXION.Size = new Size(28, 28);
            logoDECONNEXION.TabIndex = 8;
            logoDECONNEXION.TabStop = false;
            // 
            // logoPRODUITS
            // 
            logoPRODUITS.AccessibleRole = AccessibleRole.TitleBar;
            logoPRODUITS.Anchor = AnchorStyles.None;
            logoPRODUITS.BackgroundImage = (Image)resources.GetObject("logoPRODUITS.BackgroundImage");
            logoPRODUITS.Location = new Point(12, 165);
            logoPRODUITS.Name = "logoPRODUITS";
            logoPRODUITS.Size = new Size(30, 30);
            logoPRODUITS.TabIndex = 1;
            logoPRODUITS.TabStop = false;
            // 
            // logoCOMPTE
            // 
            logoCOMPTE.BackgroundImage = (Image)resources.GetObject("logoCOMPTE.BackgroundImage");
            logoCOMPTE.Location = new Point(16, 422);
            logoCOMPTE.Name = "logoCOMPTE";
            logoCOMPTE.Size = new Size(28, 28);
            logoCOMPTE.TabIndex = 7;
            logoCOMPTE.TabStop = false;
            // 
            // logoPANNIER
            // 
            logoPANNIER.BackgroundImage = (Image)resources.GetObject("logoPANNIER.BackgroundImage");
            logoPANNIER.Location = new Point(16, 280);
            logoPANNIER.Name = "logoPANNIER";
            logoPANNIER.Size = new Size(28, 28);
            logoPANNIER.TabIndex = 6;
            logoPANNIER.TabStop = false;
            // 
            // logo
            // 
            logo.BackColor = Color.White;
            logo.BackgroundImage = (Image)resources.GetObject("logo.BackgroundImage");
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(63, 10);
            logo.Name = "logo";
            logo.Size = new Size(69, 63);
            logo.TabIndex = 1;
            logo.TabStop = false;
            // 
            // Onglet
            // 
            Onglet.Appearance = TabAppearance.FlatButtons;
            Onglet.Controls.Add(info);
            Onglet.Controls.Add(commande);
            Onglet.Controls.Add(factures);
            Onglet.ItemSize = new Size(100, 40);
            Onglet.Location = new Point(217, 81);
            Onglet.Name = "Onglet";
            Onglet.Padding = new Point(40, 3);
            Onglet.SelectedIndex = 0;
            Onglet.Size = new Size(901, 489);
            Onglet.TabIndex = 2;
            // 
            // info
            // 
            info.BackColor = SystemColors.Control;
            info.BackgroundImageLayout = ImageLayout.Center;
            info.Controls.Add(TypeAdresseTITLE);
            info.Controls.Add(TypeAdresseTEXT);
            info.Controls.Add(CodePostalTITLE);
            info.Controls.Add(CodePostalTEXT);
            info.Controls.Add(PaysTITLE);
            info.Controls.Add(EtatTITLE);
            info.Controls.Add(PaysTEXT);
            info.Controls.Add(EtatTEXT);
            info.Controls.Add(VilleTITLE);
            info.Controls.Add(AdresseTITLE);
            info.Controls.Add(VilleTEXT);
            info.Controls.Add(AdresseTEXT);
            info.Controls.Add(MdpTITLE);
            info.Controls.Add(MailTITLE);
            info.Controls.Add(MdpTEXT);
            info.Controls.Add(MailTEXT);
            info.Controls.Add(NomTITLE);
            info.Controls.Add(PrénomTITLE);
            info.Controls.Add(NomTEXT);
            info.Controls.Add(PrénomTEXT);
            info.Controls.Add(button5);
            info.ImeMode = ImeMode.NoControl;
            info.Location = new Point(4, 44);
            info.Name = "info";
            info.Padding = new Padding(3);
            info.RightToLeft = RightToLeft.No;
            info.Size = new Size(893, 441);
            info.TabIndex = 0;
            info.Text = "Mes Informations";
            // 
            // TypeAdresseTITLE
            // 
            TypeAdresseTITLE.BackColor = SystemColors.Control;
            TypeAdresseTITLE.BorderStyle = BorderStyle.None;
            TypeAdresseTITLE.Location = new Point(565, 305);
            TypeAdresseTITLE.Name = "TypeAdresseTITLE";
            TypeAdresseTITLE.Size = new Size(222, 21);
            TypeAdresseTITLE.TabIndex = 67;
            TypeAdresseTITLE.Text = "Type d'Adresse : ";
            // 
            // TypeAdresseTEXT
            // 
            TypeAdresseTEXT.AccessibleName = "";
            TypeAdresseTEXT.BorderStyle = BorderStyle.FixedSingle;
            TypeAdresseTEXT.Location = new Point(565, 337);
            TypeAdresseTEXT.Name = "TypeAdresseTEXT";
            TypeAdresseTEXT.Size = new Size(222, 28);
            TypeAdresseTEXT.TabIndex = 66;
            TypeAdresseTEXT.TextAlign = HorizontalAlignment.Center;
            // 
            // CodePostalTITLE
            // 
            CodePostalTITLE.BackColor = SystemColors.Control;
            CodePostalTITLE.BorderStyle = BorderStyle.None;
            CodePostalTITLE.Location = new Point(565, 209);
            CodePostalTITLE.Name = "CodePostalTITLE";
            CodePostalTITLE.Size = new Size(222, 21);
            CodePostalTITLE.TabIndex = 65;
            CodePostalTITLE.Text = "Code Postal : ";
            // 
            // CodePostalTEXT
            // 
            CodePostalTEXT.AccessibleName = "";
            CodePostalTEXT.BorderStyle = BorderStyle.FixedSingle;
            CodePostalTEXT.Location = new Point(565, 240);
            CodePostalTEXT.Name = "CodePostalTEXT";
            CodePostalTEXT.Size = new Size(222, 28);
            CodePostalTEXT.TabIndex = 64;
            CodePostalTEXT.TextAlign = HorizontalAlignment.Center;
            // 
            // PaysTITLE
            // 
            PaysTITLE.BackColor = SystemColors.Control;
            PaysTITLE.BorderStyle = BorderStyle.None;
            PaysTITLE.Location = new Point(295, 305);
            PaysTITLE.Name = "PaysTITLE";
            PaysTITLE.Size = new Size(222, 21);
            PaysTITLE.TabIndex = 63;
            PaysTITLE.Text = "Pays : ";
            // 
            // EtatTITLE
            // 
            EtatTITLE.BackColor = SystemColors.Control;
            EtatTITLE.BorderStyle = BorderStyle.None;
            EtatTITLE.Location = new Point(27, 305);
            EtatTITLE.Name = "EtatTITLE";
            EtatTITLE.Size = new Size(222, 21);
            EtatTITLE.TabIndex = 62;
            EtatTITLE.Text = "Etat : ";
            // 
            // PaysTEXT
            // 
            PaysTEXT.AccessibleName = "";
            PaysTEXT.BorderStyle = BorderStyle.FixedSingle;
            PaysTEXT.Location = new Point(295, 337);
            PaysTEXT.Name = "PaysTEXT";
            PaysTEXT.Size = new Size(222, 28);
            PaysTEXT.TabIndex = 61;
            PaysTEXT.TextAlign = HorizontalAlignment.Center;
            // 
            // EtatTEXT
            // 
            EtatTEXT.AccessibleName = "";
            EtatTEXT.BorderStyle = BorderStyle.FixedSingle;
            EtatTEXT.Location = new Point(27, 337);
            EtatTEXT.Name = "EtatTEXT";
            EtatTEXT.Size = new Size(222, 28);
            EtatTEXT.TabIndex = 60;
            EtatTEXT.TextAlign = HorizontalAlignment.Center;
            // 
            // VilleTITLE
            // 
            VilleTITLE.BackColor = SystemColors.Control;
            VilleTITLE.BorderStyle = BorderStyle.None;
            VilleTITLE.Location = new Point(295, 209);
            VilleTITLE.Name = "VilleTITLE";
            VilleTITLE.Size = new Size(222, 21);
            VilleTITLE.TabIndex = 59;
            VilleTITLE.Text = "Ville : ";
            // 
            // AdresseTITLE
            // 
            AdresseTITLE.BackColor = SystemColors.Control;
            AdresseTITLE.BorderStyle = BorderStyle.None;
            AdresseTITLE.Location = new Point(27, 209);
            AdresseTITLE.Name = "AdresseTITLE";
            AdresseTITLE.Size = new Size(222, 21);
            AdresseTITLE.TabIndex = 58;
            AdresseTITLE.Text = "Adresse : ";
            // 
            // VilleTEXT
            // 
            VilleTEXT.AccessibleName = "";
            VilleTEXT.BorderStyle = BorderStyle.FixedSingle;
            VilleTEXT.Location = new Point(295, 240);
            VilleTEXT.Name = "VilleTEXT";
            VilleTEXT.Size = new Size(222, 28);
            VilleTEXT.TabIndex = 57;
            VilleTEXT.TextAlign = HorizontalAlignment.Center;
            // 
            // AdresseTEXT
            // 
            AdresseTEXT.AccessibleName = "";
            AdresseTEXT.BorderStyle = BorderStyle.FixedSingle;
            AdresseTEXT.Location = new Point(27, 240);
            AdresseTEXT.Name = "AdresseTEXT";
            AdresseTEXT.Size = new Size(222, 28);
            AdresseTEXT.TabIndex = 56;
            AdresseTEXT.TextAlign = HorizontalAlignment.Center;
            // 
            // MdpTITLE
            // 
            MdpTITLE.BackColor = SystemColors.Control;
            MdpTITLE.BorderStyle = BorderStyle.None;
            MdpTITLE.Location = new Point(295, 100);
            MdpTITLE.Name = "MdpTITLE";
            MdpTITLE.Size = new Size(222, 21);
            MdpTITLE.TabIndex = 55;
            MdpTITLE.Text = "Mot de Passe : ";
            // 
            // MailTITLE
            // 
            MailTITLE.BackColor = SystemColors.Control;
            MailTITLE.BorderStyle = BorderStyle.None;
            MailTITLE.Location = new Point(27, 100);
            MailTITLE.Name = "MailTITLE";
            MailTITLE.Size = new Size(222, 21);
            MailTITLE.TabIndex = 54;
            MailTITLE.Text = "Mail : ";
            // 
            // MdpTEXT
            // 
            MdpTEXT.AccessibleName = "";
            MdpTEXT.BorderStyle = BorderStyle.FixedSingle;
            MdpTEXT.Location = new Point(295, 134);
            MdpTEXT.Name = "MdpTEXT";
            MdpTEXT.Size = new Size(222, 28);
            MdpTEXT.TabIndex = 53;
            MdpTEXT.TextAlign = HorizontalAlignment.Center;
            // 
            // MailTEXT
            // 
            MailTEXT.AccessibleName = "";
            MailTEXT.BorderStyle = BorderStyle.FixedSingle;
            MailTEXT.Location = new Point(27, 134);
            MailTEXT.Name = "MailTEXT";
            MailTEXT.Size = new Size(222, 28);
            MailTEXT.TabIndex = 52;
            MailTEXT.TextAlign = HorizontalAlignment.Center;
            // 
            // NomTITLE
            // 
            NomTITLE.BackColor = SystemColors.Control;
            NomTITLE.BorderStyle = BorderStyle.None;
            NomTITLE.Location = new Point(295, 18);
            NomTITLE.Name = "NomTITLE";
            NomTITLE.Size = new Size(222, 21);
            NomTITLE.TabIndex = 51;
            NomTITLE.Text = "Nom : ";
            // 
            // PrénomTITLE
            // 
            PrénomTITLE.BackColor = SystemColors.Control;
            PrénomTITLE.BorderStyle = BorderStyle.None;
            PrénomTITLE.Location = new Point(27, 18);
            PrénomTITLE.Name = "PrénomTITLE";
            PrénomTITLE.Size = new Size(222, 21);
            PrénomTITLE.TabIndex = 50;
            PrénomTITLE.Text = "Prénom : ";
            // 
            // NomTEXT
            // 
            NomTEXT.AccessibleName = "";
            NomTEXT.BorderStyle = BorderStyle.FixedSingle;
            NomTEXT.Location = new Point(295, 51);
            NomTEXT.Name = "NomTEXT";
            NomTEXT.Size = new Size(222, 28);
            NomTEXT.TabIndex = 31;
            NomTEXT.TextAlign = HorizontalAlignment.Center;
            // 
            // PrénomTEXT
            // 
            PrénomTEXT.AccessibleName = "";
            PrénomTEXT.BorderStyle = BorderStyle.FixedSingle;
            PrénomTEXT.Location = new Point(27, 51);
            PrénomTEXT.Name = "PrénomTEXT";
            PrénomTEXT.Size = new Size(222, 28);
            PrénomTEXT.TabIndex = 29;
            PrénomTEXT.TextAlign = HorizontalAlignment.Center;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Location = new Point(737, 395);
            button5.Name = "button5";
            button5.Size = new Size(150, 40);
            button5.TabIndex = 12;
            button5.Text = "MODIFIER";
            button5.UseVisualStyleBackColor = true;
            // 
            // commande
            // 
            commande.BackgroundImageLayout = ImageLayout.Center;
            commande.Controls.Add(StatusVISU_C);
            commande.Controls.Add(DateVISU_C);
            commande.Controls.Add(DescriptionVISU_C);
            commande.Controls.Add(NomVISU_C);
            commande.Controls.Add(btnANNULER_COMMANDE);
            commande.Location = new Point(4, 44);
            commande.Name = "commande";
            commande.Padding = new Padding(3);
            commande.Size = new Size(893, 441);
            commande.TabIndex = 1;
            commande.Text = "Mes Commandes";
            commande.UseVisualStyleBackColor = true;
            // 
            // StatusVISU_C
            // 
            StatusVISU_C.AccessibleName = "";
            StatusVISU_C.BorderStyle = BorderStyle.FixedSingle;
            StatusVISU_C.Location = new Point(726, 6);
            StatusVISU_C.Name = "StatusVISU_C";
            StatusVISU_C.Size = new Size(161, 28);
            StatusVISU_C.TabIndex = 33;
            StatusVISU_C.Text = "STATUS";
            StatusVISU_C.TextAlign = HorizontalAlignment.Center;
            // 
            // DateVISU_C
            // 
            DateVISU_C.AccessibleName = "";
            DateVISU_C.BorderStyle = BorderStyle.FixedSingle;
            DateVISU_C.Location = new Point(558, 6);
            DateVISU_C.Name = "DateVISU_C";
            DateVISU_C.Size = new Size(162, 28);
            DateVISU_C.TabIndex = 32;
            DateVISU_C.Text = "DATE";
            DateVISU_C.TextAlign = HorizontalAlignment.Center;
            // 
            // DescriptionVISU_C
            // 
            DescriptionVISU_C.AccessibleName = "";
            DescriptionVISU_C.BorderStyle = BorderStyle.FixedSingle;
            DescriptionVISU_C.Location = new Point(185, 6);
            DescriptionVISU_C.Name = "DescriptionVISU_C";
            DescriptionVISU_C.Size = new Size(367, 28);
            DescriptionVISU_C.TabIndex = 31;
            DescriptionVISU_C.Text = "DESCRIPTION";
            DescriptionVISU_C.TextAlign = HorizontalAlignment.Center;
            // 
            // NomVISU_C
            // 
            NomVISU_C.AccessibleName = "";
            NomVISU_C.BorderStyle = BorderStyle.FixedSingle;
            NomVISU_C.Location = new Point(6, 6);
            NomVISU_C.Name = "NomVISU_C";
            NomVISU_C.Size = new Size(173, 28);
            NomVISU_C.TabIndex = 30;
            NomVISU_C.Text = "NOM";
            NomVISU_C.TextAlign = HorizontalAlignment.Center;
            // 
            // btnANNULER_COMMANDE
            // 
            btnANNULER_COMMANDE.Anchor = AnchorStyles.None;
            btnANNULER_COMMANDE.Location = new Point(667, 395);
            btnANNULER_COMMANDE.Name = "btnANNULER_COMMANDE";
            btnANNULER_COMMANDE.Size = new Size(220, 40);
            btnANNULER_COMMANDE.TabIndex = 13;
            btnANNULER_COMMANDE.Text = "ANNULER COMMANDE";
            btnANNULER_COMMANDE.UseVisualStyleBackColor = true;
            // 
            // factures
            // 
            factures.BackgroundImageLayout = ImageLayout.Center;
            factures.Controls.Add(PrixTotalVISU_F);
            factures.Controls.Add(QuantitéVISU_F);
            factures.Controls.Add(DescriptionVISU_F);
            factures.Controls.Add(DateVISU_F);
            factures.Controls.Add(NomVISU_F);
            factures.Location = new Point(4, 44);
            factures.Name = "factures";
            factures.Size = new Size(893, 441);
            factures.TabIndex = 2;
            factures.Text = "Mes Factures";
            factures.UseVisualStyleBackColor = true;
            // 
            // PrixTotalVISU_F
            // 
            PrixTotalVISU_F.AccessibleName = "";
            PrixTotalVISU_F.BorderStyle = BorderStyle.FixedSingle;
            PrixTotalVISU_F.Location = new Point(744, 6);
            PrixTotalVISU_F.Name = "PrixTotalVISU_F";
            PrixTotalVISU_F.Size = new Size(142, 28);
            PrixTotalVISU_F.TabIndex = 38;
            PrixTotalVISU_F.Text = "PRIX TOTAL";
            PrixTotalVISU_F.TextAlign = HorizontalAlignment.Center;
            // 
            // QuantitéVISU_F
            // 
            QuantitéVISU_F.AccessibleName = "";
            QuantitéVISU_F.BorderStyle = BorderStyle.FixedSingle;
            QuantitéVISU_F.Location = new Point(594, 6);
            QuantitéVISU_F.Name = "QuantitéVISU_F";
            QuantitéVISU_F.Size = new Size(144, 28);
            QuantitéVISU_F.TabIndex = 37;
            QuantitéVISU_F.Text = "QUANTITE";
            QuantitéVISU_F.TextAlign = HorizontalAlignment.Center;
            // 
            // DescriptionVISU_F
            // 
            DescriptionVISU_F.AccessibleName = "";
            DescriptionVISU_F.BorderStyle = BorderStyle.FixedSingle;
            DescriptionVISU_F.Location = new Point(161, 6);
            DescriptionVISU_F.Name = "DescriptionVISU_F";
            DescriptionVISU_F.Size = new Size(260, 28);
            DescriptionVISU_F.TabIndex = 35;
            DescriptionVISU_F.Text = "DESCRIPTION";
            DescriptionVISU_F.TextAlign = HorizontalAlignment.Center;
            // 
            // DateVISU_F
            // 
            DateVISU_F.AccessibleName = "";
            DateVISU_F.BorderStyle = BorderStyle.FixedSingle;
            DateVISU_F.Location = new Point(427, 6);
            DateVISU_F.Name = "DateVISU_F";
            DateVISU_F.Size = new Size(161, 28);
            DateVISU_F.TabIndex = 36;
            DateVISU_F.Text = "DATE";
            DateVISU_F.TextAlign = HorizontalAlignment.Center;
            // 
            // NomVISU_F
            // 
            NomVISU_F.AccessibleName = "";
            NomVISU_F.BorderStyle = BorderStyle.FixedSingle;
            NomVISU_F.Location = new Point(5, 6);
            NomVISU_F.Name = "NomVISU_F";
            NomVISU_F.Size = new Size(150, 28);
            NomVISU_F.TabIndex = 34;
            NomVISU_F.Text = "NOM";
            NomVISU_F.TextAlign = HorizontalAlignment.Center;
            // 
            // TITLE
            // 
            TITLE.BorderStyle = BorderStyle.None;
            TITLE.Font = new Font("Times New Roman", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            TITLE.Location = new Point(604, 25);
            TITLE.Name = "TITLE";
            TITLE.Size = new Size(125, 21);
            TITLE.TabIndex = 0;
            TITLE.Text = "MON COMPTE";
            TITLE.TextAlign = HorizontalAlignment.Center;
            // 
            // Compte
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1130, 582);
            Controls.Add(TITLE);
            Controls.Add(Onglet);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Compte";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compte";
            Load += Compte_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoDECONNEXION).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoPRODUITS).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoCOMPTE).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoPANNIER).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            Onglet.ResumeLayout(false);
            info.ResumeLayout(false);
            info.PerformLayout();
            commande.ResumeLayout(false);
            commande.PerformLayout();
            factures.ResumeLayout(false);
            factures.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnDECONNEXION;
        private Button btnCOMPTE;
        private Button btnPANIER;
        private Button btnPRODUIT;
        private PictureBox logoDECONNEXION;
        private PictureBox logoPRODUITS;
        private PictureBox logoCOMPTE;
        private PictureBox logoPANNIER;
        private PictureBox logo;
        private TabControl Onglet;
        private TabPage info;
        private TabPage commande;
        private TabPage factures;
        private TextBox TITLE;
        private Button button5;
        private Button btnANNULER_COMMANDE;
        private TextBox PrénomTITLE;
        private TextBox NomTEXT;
        private TextBox PrénomTEXT;
        private TextBox PaysTITLE;
        private TextBox EtatTITLE;
        private TextBox PaysTEXT;
        private TextBox EtatTEXT;
        private TextBox VilleTITLE;
        private TextBox AdresseTITLE;
        private TextBox VilleTEXT;
        private TextBox AdresseTEXT;
        private TextBox MdpTITLE;
        private TextBox MailTITLE;
        private TextBox MdpTEXT;
        private TextBox MailTEXT;
        private TextBox NomTITLE;
        private TextBox TypeAdresseTITLE;
        private TextBox TypeAdresseTEXT;
        private TextBox CodePostalTITLE;
        private TextBox CodePostalTEXT;
        private TextBox StatusVISU_C;
        private TextBox DateVISU_C;
        private TextBox DescriptionVISU_C;
        private TextBox NomVISU_C;
        private TextBox PrixTotalVISU_F;
        private TextBox QuantitéVISU_F;
        private TextBox DescriptionVISU_F;
        private TextBox DateVISU_F;
        private TextBox NomVISU_F;
    }
}