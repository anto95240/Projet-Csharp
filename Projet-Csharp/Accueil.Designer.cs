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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            panel1 = new Panel();
            btnDECONNEXION = new Button();
            btnCOMPTE = new Button();
            btnPANIER = new Button();
            btnPRODUIT = new Button();
            LogoDECONNEXION = new PictureBox();
            LogoPRODUIT = new PictureBox();
            LogoCOMPTE = new PictureBox();
            LogoPANIER = new PictureBox();
            Logo1 = new PictureBox();
            TITLE = new TextBox();
            modif = new Button();
            ajouter = new Button();
            supprimer = new Button();
            addPANIER = new Button();
            DescriptionTEXT = new TextBox();
            NomTEXT = new TextBox();
            DescriptionTITLE = new Label();
            NomTITLE = new Label();
            PrixTEXT = new TextBox();
            QuantitéTEXT = new TextBox();
            PrixTITLE = new Label();
            QuantitéTITLE = new Label();
            panel2 = new Panel();
            PrixVISU = new TextBox();
            QuantitéVISU = new TextBox();
            DescriptionVISU = new TextBox();
            NomVISU = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoDECONNEXION).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoPRODUIT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoCOMPTE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoPANIER).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Logo1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(btnDECONNEXION);
            panel1.Controls.Add(btnCOMPTE);
            panel1.Controls.Add(btnPANIER);
            panel1.Controls.Add(btnPRODUIT);
            panel1.Controls.Add(LogoDECONNEXION);
            panel1.Controls.Add(LogoPRODUIT);
            panel1.Controls.Add(LogoCOMPTE);
            panel1.Controls.Add(LogoPANIER);
            panel1.Controls.Add(Logo1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(196, 582);
            panel1.TabIndex = 0;
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
            btnCOMPTE.Click += compte_click;
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
            // 
            // LogoDECONNEXION
            // 
            LogoDECONNEXION.BackgroundImage = (Image)resources.GetObject("LogoDECONNEXION.BackgroundImage");
            LogoDECONNEXION.Location = new Point(16, 512);
            LogoDECONNEXION.Name = "LogoDECONNEXION";
            LogoDECONNEXION.Size = new Size(28, 28);
            LogoDECONNEXION.TabIndex = 8;
            LogoDECONNEXION.TabStop = false;
            // 
            // LogoPRODUIT
            // 
            LogoPRODUIT.BackgroundImage = (Image)resources.GetObject("LogoPRODUIT.BackgroundImage");
            LogoPRODUIT.Location = new Point(12, 165);
            LogoPRODUIT.Name = "LogoPRODUIT";
            LogoPRODUIT.Size = new Size(30, 30);
            LogoPRODUIT.TabIndex = 1;
            LogoPRODUIT.TabStop = false;
            // 
            // LogoCOMPTE
            // 
            LogoCOMPTE.BackgroundImage = (Image)resources.GetObject("LogoCOMPTE.BackgroundImage");
            LogoCOMPTE.Location = new Point(16, 422);
            LogoCOMPTE.Name = "LogoCOMPTE";
            LogoCOMPTE.Size = new Size(28, 28);
            LogoCOMPTE.TabIndex = 7;
            LogoCOMPTE.TabStop = false;
            // 
            // LogoPANIER
            // 
            LogoPANIER.BackgroundImage = (Image)resources.GetObject("LogoPANIER.BackgroundImage");
            LogoPANIER.Location = new Point(16, 280);
            LogoPANIER.Name = "LogoPANIER";
            LogoPANIER.Size = new Size(28, 28);
            LogoPANIER.TabIndex = 6;
            LogoPANIER.TabStop = false;
            // 
            // Logo1
            // 
            Logo1.BackColor = Color.White;
            Logo1.BackgroundImage = (Image)resources.GetObject("Logo1.BackgroundImage");
            Logo1.Image = (Image)resources.GetObject("Logo1.Image");
            Logo1.Location = new Point(63, 10);
            Logo1.Name = "Logo1";
            Logo1.Size = new Size(69, 63);
            Logo1.TabIndex = 1;
            Logo1.TabStop = false;
            // 
            // TITLE
            // 
            TITLE.BorderStyle = BorderStyle.None;
            TITLE.Font = new Font("Times New Roman", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            TITLE.Location = new Point(560, 25);
            TITLE.Name = "TITLE";
            TITLE.Size = new Size(192, 21);
            TITLE.TabIndex = 3;
            TITLE.Text = "LISTE DES PRODUITS";
            TITLE.TextAlign = HorizontalAlignment.Center;
            // 
            // modif
            // 
            modif.BackColor = Color.GreenYellow;
            modif.Location = new Point(376, 418);
            modif.Name = "modif";
            modif.Size = new Size(125, 35);
            modif.TabIndex = 12;
            modif.Text = "MODIFIER";
            modif.UseVisualStyleBackColor = false;
            // 
            // ajouter
            // 
            ajouter.BackColor = Color.LimeGreen;
            ajouter.Location = new Point(227, 418);
            ajouter.Name = "ajouter";
            ajouter.Size = new Size(125, 35);
            ajouter.TabIndex = 13;
            ajouter.Text = "AJOUTER";
            ajouter.UseVisualStyleBackColor = false;
            // 
            // supprimer
            // 
            supprimer.BackColor = Color.Salmon;
            supprimer.Location = new Point(298, 478);
            supprimer.Name = "supprimer";
            supprimer.Size = new Size(125, 35);
            supprimer.TabIndex = 14;
            supprimer.Text = "SUPPRIMER";
            supprimer.UseVisualStyleBackColor = false;
            // 
            // addPANIER
            // 
            addPANIER.Anchor = AnchorStyles.None;
            addPANIER.Location = new Point(934, 530);
            addPANIER.Name = "addPANIER";
            addPANIER.Size = new Size(184, 40);
            addPANIER.TabIndex = 15;
            addPANIER.Text = "AJOUTER PANIER";
            addPANIER.UseVisualStyleBackColor = true;
            // 
            // DescriptionTEXT
            // 
            DescriptionTEXT.AccessibleName = "";
            DescriptionTEXT.BorderStyle = BorderStyle.FixedSingle;
            DescriptionTEXT.Location = new Point(341, 165);
            DescriptionTEXT.Multiline = true;
            DescriptionTEXT.Name = "DescriptionTEXT";
            DescriptionTEXT.ScrollBars = ScrollBars.Vertical;
            DescriptionTEXT.Size = new Size(160, 75);
            DescriptionTEXT.TabIndex = 21;
            // 
            // NomTEXT
            // 
            NomTEXT.AccessibleName = "";
            NomTEXT.BorderStyle = BorderStyle.FixedSingle;
            NomTEXT.Location = new Point(299, 110);
            NomTEXT.Name = "NomTEXT";
            NomTEXT.Size = new Size(202, 28);
            NomTEXT.TabIndex = 20;
            // 
            // DescriptionTITLE
            // 
            DescriptionTITLE.AutoSize = true;
            DescriptionTITLE.BackColor = Color.White;
            DescriptionTITLE.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DescriptionTITLE.ForeColor = Color.Crimson;
            DescriptionTITLE.Location = new Point(214, 166);
            DescriptionTITLE.Margin = new Padding(4, 0, 4, 0);
            DescriptionTITLE.Name = "DescriptionTITLE";
            DescriptionTITLE.Size = new Size(119, 26);
            DescriptionTITLE.TabIndex = 19;
            DescriptionTITLE.Text = "Description";
            // 
            // NomTITLE
            // 
            NomTITLE.AutoSize = true;
            NomTITLE.BackColor = Color.White;
            NomTITLE.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NomTITLE.ForeColor = Color.Crimson;
            NomTITLE.Location = new Point(214, 110);
            NomTITLE.Margin = new Padding(4, 0, 4, 0);
            NomTITLE.Name = "NomTITLE";
            NomTITLE.Size = new Size(58, 26);
            NomTITLE.TabIndex = 18;
            NomTITLE.Text = "Nom";
            // 
            // PrixTEXT
            // 
            PrixTEXT.AccessibleName = "";
            PrixTEXT.BorderStyle = BorderStyle.FixedSingle;
            PrixTEXT.Location = new Point(299, 328);
            PrixTEXT.Name = "PrixTEXT";
            PrixTEXT.Size = new Size(202, 28);
            PrixTEXT.TabIndex = 25;
            // 
            // QuantitéTEXT
            // 
            QuantitéTEXT.AccessibleName = "";
            QuantitéTEXT.BorderStyle = BorderStyle.FixedSingle;
            QuantitéTEXT.Location = new Point(341, 261);
            QuantitéTEXT.Name = "QuantitéTEXT";
            QuantitéTEXT.Size = new Size(160, 28);
            QuantitéTEXT.TabIndex = 24;
            // 
            // PrixTITLE
            // 
            PrixTITLE.AutoSize = true;
            PrixTITLE.BackColor = Color.White;
            PrixTITLE.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrixTITLE.ForeColor = Color.Crimson;
            PrixTITLE.Location = new Point(214, 328);
            PrixTITLE.Margin = new Padding(4, 0, 4, 0);
            PrixTITLE.Name = "PrixTITLE";
            PrixTITLE.Size = new Size(50, 26);
            PrixTITLE.TabIndex = 23;
            PrixTITLE.Text = "Prix";
            // 
            // QuantitéTITLE
            // 
            QuantitéTITLE.AutoSize = true;
            QuantitéTITLE.BackColor = Color.White;
            QuantitéTITLE.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuantitéTITLE.ForeColor = Color.Crimson;
            QuantitéTITLE.Location = new Point(214, 263);
            QuantitéTITLE.Margin = new Padding(4, 0, 4, 0);
            QuantitéTITLE.Name = "QuantitéTITLE";
            QuantitéTITLE.Size = new Size(91, 26);
            QuantitéTITLE.TabIndex = 22;
            QuantitéTITLE.Text = "Quantité";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(PrixVISU);
            panel2.Controls.Add(QuantitéVISU);
            panel2.Controls.Add(DescriptionVISU);
            panel2.Controls.Add(NomVISU);
            panel2.Location = new Point(526, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(591, 362);
            panel2.TabIndex = 26;
            panel2.Paint += panel2_Paint;
            // 
            // PrixVISU
            // 
            PrixVISU.AccessibleName = "";
            PrixVISU.BorderStyle = BorderStyle.FixedSingle;
            PrixVISU.Location = new Point(498, 0);
            PrixVISU.Name = "PrixVISU";
            PrixVISU.Size = new Size(93, 28);
            PrixVISU.TabIndex = 30;
            PrixVISU.Text = "PRIX";
            PrixVISU.TextAlign = HorizontalAlignment.Center;
            // 
            // QuantitéVISU
            // 
            QuantitéVISU.AccessibleName = "";
            QuantitéVISU.BorderStyle = BorderStyle.FixedSingle;
            QuantitéVISU.Location = new Point(377, 0);
            QuantitéVISU.Name = "QuantitéVISU";
            QuantitéVISU.Size = new Size(115, 28);
            QuantitéVISU.TabIndex = 29;
            QuantitéVISU.Text = "QUANTITE";
            QuantitéVISU.TextAlign = HorizontalAlignment.Center;
            // 
            // DescriptionVISU
            // 
            DescriptionVISU.AccessibleName = "";
            DescriptionVISU.BorderStyle = BorderStyle.FixedSingle;
            DescriptionVISU.Location = new Point(129, 0);
            DescriptionVISU.Name = "DescriptionVISU";
            DescriptionVISU.Size = new Size(242, 28);
            DescriptionVISU.TabIndex = 28;
            DescriptionVISU.Text = "DESCRIPTION";
            DescriptionVISU.TextAlign = HorizontalAlignment.Center;
            // 
            // NomVISU
            // 
            NomVISU.AccessibleName = "";
            NomVISU.BorderStyle = BorderStyle.FixedSingle;
            NomVISU.Location = new Point(0, 0);
            NomVISU.Name = "NomVISU";
            NomVISU.Size = new Size(123, 28);
            NomVISU.TabIndex = 27;
            NomVISU.Text = "Nom";
            NomVISU.TextAlign = HorizontalAlignment.Center;
            // 
            // Accueil
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1130, 582);
            Controls.Add(panel2);
            Controls.Add(DescriptionTEXT);
            Controls.Add(PrixTEXT);
            Controls.Add(QuantitéTEXT);
            Controls.Add(PrixTITLE);
            Controls.Add(QuantitéTITLE);
            Controls.Add(NomTEXT);
            Controls.Add(DescriptionTITLE);
            Controls.Add(NomTITLE);
            Controls.Add(addPANIER);
            Controls.Add(supprimer);
            Controls.Add(ajouter);
            Controls.Add(modif);
            Controls.Add(TITLE);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Accueil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Accueil";
            Load += Accueil_Load_1;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LogoDECONNEXION).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoPRODUIT).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoCOMPTE).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoPANIER).EndInit();
            ((System.ComponentModel.ISupportInitialize)Logo1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox Logo1;
        private PictureBox LogoPRODUIT;
        private PictureBox LogoDECONNEXION;
        private PictureBox LogoCOMPTE;
        private PictureBox LogoPANIER;
        private Button btnPANIER;
        private Button btnPRODUIT;
        private Button btnDECONNEXION;
        private Button btnCOMPTE;
        private TextBox TITLE;
        private Button modif;
        private Button ajouter;
        private Button supprimer;
        private Button addPANIER;
        private TextBox DescriptionTEXT;
        private TextBox NomTEXT;
        private Label DescriptionTITLE;
        private Label NomTITLE;
        private TextBox PrixTEXT;
        private TextBox QuantitéTEXT;
        private Label PrixTITLE;
        private Label QuantitéTITLE;
        private Panel panel2;
        private TextBox PrixVISU;
        private TextBox QuantitéVISU;
        private TextBox DescriptionVISU;
        private TextBox NomVISU;
    }
}