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
            button2 = new Button();
            btnCommand = new Button();
            panel3 = new Panel();
            btnDECONNEXION = new Button();
            btnCOMPTE = new Button();
            btnPANIER = new Button();
            btnPRODUIT = new Button();
            Logo1 = new PictureBox();
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
            EmailTEXT = new TextBox();
            NomTITLE = new TextBox();
            PrénomTITLE = new TextBox();
            NomTEXT = new TextBox();
            PrénomText = new TextBox();
            btnModifer = new Button();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnCommand);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnDECONNEXION);
            panel1.Controls.Add(btnCOMPTE);
            panel1.Controls.Add(btnPANIER);
            panel1.Controls.Add(btnPRODUIT);
            panel1.Controls.Add(Logo1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 582);
            panel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Image = Properties.Resources.icon_compte1;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(16, 432);
            button2.Name = "button2";
            button2.Size = new Size(192, 32);
            button2.TabIndex = 21;
            button2.Text = "Mes Factures";
            button2.UseVisualStyleBackColor = true;
            button2.Click += facture_click;
            // 
            // btnCommand
            // 
            btnCommand.FlatAppearance.BorderSize = 0;
            btnCommand.FlatStyle = FlatStyle.Flat;
            btnCommand.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCommand.ForeColor = SystemColors.ControlLightLight;
            btnCommand.Image = Properties.Resources.icon_compte1;
            btnCommand.ImageAlign = ContentAlignment.MiddleLeft;
            btnCommand.Location = new Point(16, 371);
            btnCommand.Name = "btnCommand";
            btnCommand.Size = new Size(192, 32);
            btnCommand.TabIndex = 20;
            btnCommand.Text = "     Mes Commandes";
            btnCommand.UseVisualStyleBackColor = true;
            btnCommand.Click += command_click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Location = new Point(5, 290);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 32);
            panel3.TabIndex = 19;
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
            btnDECONNEXION.TabIndex = 16;
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
            btnCOMPTE.Location = new Point(16, 292);
            btnCOMPTE.Name = "btnCOMPTE";
            btnCOMPTE.Size = new Size(192, 32);
            btnCOMPTE.TabIndex = 15;
            btnCOMPTE.Text = "Mon Compte";
            btnCOMPTE.UseVisualStyleBackColor = true;
            // 
            // btnPANIER
            // 
            btnPANIER.FlatAppearance.BorderSize = 0;
            btnPANIER.FlatStyle = FlatStyle.Flat;
            btnPANIER.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPANIER.ForeColor = SystemColors.ControlLightLight;
            btnPANIER.Image = Properties.Resources.icon_panier1;
            btnPANIER.ImageAlign = ContentAlignment.MiddleLeft;
            btnPANIER.Location = new Point(16, 213);
            btnPANIER.Name = "btnPANIER";
            btnPANIER.Size = new Size(192, 32);
            btnPANIER.TabIndex = 14;
            btnPANIER.Text = "Mon Panier";
            btnPANIER.UseVisualStyleBackColor = true;
            btnPANIER.Click += panier_click;
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
            btnPRODUIT.TabIndex = 12;
            btnPRODUIT.Text = "Les Produits";
            btnPRODUIT.UseVisualStyleBackColor = true;
            btnPRODUIT.Click += produit_click;
            // 
            // Logo1
            // 
            Logo1.BackColor = Color.White;
            Logo1.BackgroundImage = (Image)resources.GetObject("Logo1.BackgroundImage");
            Logo1.Image = (Image)resources.GetObject("Logo1.Image");
            Logo1.Location = new Point(60, 10);
            Logo1.Name = "Logo1";
            Logo1.Size = new Size(69, 63);
            Logo1.TabIndex = 13;
            Logo1.TabStop = false;
            // 
            // CodePostalTITLE
            // 
            CodePostalTITLE.BackColor = Color.White;
            CodePostalTITLE.BorderStyle = BorderStyle.None;
            CodePostalTITLE.Location = new Point(797, 301);
            CodePostalTITLE.Name = "CodePostalTITLE";
            CodePostalTITLE.Size = new Size(222, 21);
            CodePostalTITLE.TabIndex = 86;
            CodePostalTITLE.Text = "Code Postal : ";
            // 
            // CodePostalTEXT
            // 
            CodePostalTEXT.AccessibleName = "";
            CodePostalTEXT.BorderStyle = BorderStyle.FixedSingle;
            CodePostalTEXT.Location = new Point(797, 332);
            CodePostalTEXT.Name = "CodePostalTEXT";
            CodePostalTEXT.Size = new Size(222, 28);
            CodePostalTEXT.TabIndex = 85;
            // 
            // PaysTITLE
            // 
            PaysTITLE.BackColor = Color.White;
            PaysTITLE.BorderStyle = BorderStyle.None;
            PaysTITLE.Location = new Point(527, 397);
            PaysTITLE.Name = "PaysTITLE";
            PaysTITLE.Size = new Size(222, 21);
            PaysTITLE.TabIndex = 84;
            PaysTITLE.Text = "Pays : ";
            // 
            // EtatTITLE
            // 
            EtatTITLE.BackColor = Color.White;
            EtatTITLE.BorderStyle = BorderStyle.None;
            EtatTITLE.Location = new Point(259, 397);
            EtatTITLE.Name = "EtatTITLE";
            EtatTITLE.Size = new Size(222, 21);
            EtatTITLE.TabIndex = 83;
            EtatTITLE.Text = "Etat : ";
            // 
            // PaysTEXT
            // 
            PaysTEXT.AccessibleName = "";
            PaysTEXT.BorderStyle = BorderStyle.FixedSingle;
            PaysTEXT.Location = new Point(527, 429);
            PaysTEXT.Name = "PaysTEXT";
            PaysTEXT.Size = new Size(222, 28);
            PaysTEXT.TabIndex = 82;
            // 
            // EtatTEXT
            // 
            EtatTEXT.AccessibleName = "";
            EtatTEXT.BorderStyle = BorderStyle.FixedSingle;
            EtatTEXT.Location = new Point(259, 429);
            EtatTEXT.Name = "EtatTEXT";
            EtatTEXT.Size = new Size(222, 28);
            EtatTEXT.TabIndex = 81;
            // 
            // VilleTITLE
            // 
            VilleTITLE.BackColor = Color.White;
            VilleTITLE.BorderStyle = BorderStyle.None;
            VilleTITLE.Location = new Point(527, 301);
            VilleTITLE.Name = "VilleTITLE";
            VilleTITLE.Size = new Size(222, 21);
            VilleTITLE.TabIndex = 80;
            VilleTITLE.Text = "Ville : ";
            // 
            // AdresseTITLE
            // 
            AdresseTITLE.BackColor = Color.White;
            AdresseTITLE.BorderStyle = BorderStyle.None;
            AdresseTITLE.Location = new Point(259, 301);
            AdresseTITLE.Name = "AdresseTITLE";
            AdresseTITLE.Size = new Size(222, 21);
            AdresseTITLE.TabIndex = 79;
            AdresseTITLE.Text = "Adresse : ";
            // 
            // VilleTEXT
            // 
            VilleTEXT.AccessibleName = "";
            VilleTEXT.BorderStyle = BorderStyle.FixedSingle;
            VilleTEXT.Location = new Point(527, 332);
            VilleTEXT.Name = "VilleTEXT";
            VilleTEXT.Size = new Size(222, 28);
            VilleTEXT.TabIndex = 78;
            // 
            // AdresseTEXT
            // 
            AdresseTEXT.AccessibleName = "";
            AdresseTEXT.BorderStyle = BorderStyle.FixedSingle;
            AdresseTEXT.Location = new Point(259, 332);
            AdresseTEXT.Name = "AdresseTEXT";
            AdresseTEXT.Size = new Size(222, 28);
            AdresseTEXT.TabIndex = 77;
            // 
            // MdpTITLE
            // 
            MdpTITLE.BackColor = Color.White;
            MdpTITLE.BorderStyle = BorderStyle.None;
            MdpTITLE.Location = new Point(527, 192);
            MdpTITLE.Name = "MdpTITLE";
            MdpTITLE.Size = new Size(222, 21);
            MdpTITLE.TabIndex = 76;
            MdpTITLE.Text = "Mot de Passe : ";
            // 
            // MailTITLE
            // 
            MailTITLE.BackColor = Color.White;
            MailTITLE.BorderStyle = BorderStyle.None;
            MailTITLE.Location = new Point(259, 192);
            MailTITLE.Name = "MailTITLE";
            MailTITLE.Size = new Size(222, 21);
            MailTITLE.TabIndex = 75;
            MailTITLE.Text = "Mail : ";
            // 
            // MdpTEXT
            // 
            MdpTEXT.AccessibleName = "";
            MdpTEXT.BorderStyle = BorderStyle.FixedSingle;
            MdpTEXT.Location = new Point(527, 226);
            MdpTEXT.Name = "MdpTEXT";
            MdpTEXT.Size = new Size(222, 28);
            MdpTEXT.TabIndex = 74;
            // 
            // EmailTEXT
            // 
            EmailTEXT.AccessibleName = "";
            EmailTEXT.BorderStyle = BorderStyle.FixedSingle;
            EmailTEXT.Location = new Point(259, 226);
            EmailTEXT.Name = "EmailTEXT";
            EmailTEXT.Size = new Size(222, 28);
            EmailTEXT.TabIndex = 73;
            // 
            // NomTITLE
            // 
            NomTITLE.BackColor = Color.White;
            NomTITLE.BorderStyle = BorderStyle.None;
            NomTITLE.Location = new Point(527, 110);
            NomTITLE.Name = "NomTITLE";
            NomTITLE.Size = new Size(222, 21);
            NomTITLE.TabIndex = 72;
            NomTITLE.Text = "Nom : ";
            // 
            // PrénomTITLE
            // 
            PrénomTITLE.BackColor = Color.White;
            PrénomTITLE.BorderStyle = BorderStyle.None;
            PrénomTITLE.Location = new Point(259, 110);
            PrénomTITLE.Name = "PrénomTITLE";
            PrénomTITLE.Size = new Size(222, 21);
            PrénomTITLE.TabIndex = 71;
            PrénomTITLE.Text = "Prénom : ";
            // 
            // NomTEXT
            // 
            NomTEXT.AccessibleName = "";
            NomTEXT.BorderStyle = BorderStyle.FixedSingle;
            NomTEXT.Location = new Point(527, 143);
            NomTEXT.Name = "NomTEXT";
            NomTEXT.Size = new Size(222, 28);
            NomTEXT.TabIndex = 70;
            // 
            // PrénomText
            // 
            PrénomText.AccessibleName = "";
            PrénomText.BorderStyle = BorderStyle.FixedSingle;
            PrénomText.Location = new Point(259, 143);
            PrénomText.Name = "PrénomText";
            PrénomText.Size = new Size(222, 28);
            PrénomText.TabIndex = 69;
            // 
            // btnModifer
            // 
            btnModifer.Anchor = AnchorStyles.None;
            btnModifer.Location = new Point(960, 520);
            btnModifer.Name = "btnModifer";
            btnModifer.Size = new Size(150, 40);
            btnModifer.TabIndex = 68;
            btnModifer.Text = "MODIFIER";
            btnModifer.UseVisualStyleBackColor = true;
            btnModifer.Click += btnModifier;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Times New Roman", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(546, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 21);
            textBox1.TabIndex = 89;
            textBox1.Text = "MES INFORMATIONS";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Compte
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1130, 582);
            Controls.Add(textBox1);
            Controls.Add(CodePostalTITLE);
            Controls.Add(CodePostalTEXT);
            Controls.Add(PaysTITLE);
            Controls.Add(EtatTITLE);
            Controls.Add(PaysTEXT);
            Controls.Add(EtatTEXT);
            Controls.Add(VilleTITLE);
            Controls.Add(AdresseTITLE);
            Controls.Add(VilleTEXT);
            Controls.Add(AdresseTEXT);
            Controls.Add(MdpTITLE);
            Controls.Add(MailTITLE);
            Controls.Add(MdpTEXT);
            Controls.Add(EmailTEXT);
            Controls.Add(NomTITLE);
            Controls.Add(PrénomTITLE);
            Controls.Add(NomTEXT);
            Controls.Add(PrénomText);
            Controls.Add(btnModifer);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Compte";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compte";
            Load += Compte_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnDECONNEXION;
        private Button btnCOMPTE;
        private Button btnPANIER;
        private Button btnPRODUIT;
        private PictureBox Logo1;
        private Panel panel3;
        private Button button2;
        private Button btnCommand;
        private TextBox CodePostalTITLE;
        private TextBox CodePostalTEXT;
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
        private TextBox EmailTEXT;
        private TextBox NomTITLE;
        private TextBox PrénomTITLE;
        private TextBox NomTEXT;
        private TextBox PrénomText;
        private Button btnModifer;
        private TextBox textBox1;
    }
}