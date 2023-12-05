namespace Projet_Csharp
{
    partial class Panier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panier));
            btnPANIER2 = new Panel();
            btnDECONNEXION = new Button();
            btnCOMPTE = new Button();
            btnPANNIER = new Button();
            btnPRODUIT = new Button();
            LogoDECONNEXION = new PictureBox();
            logoPRODUIT = new PictureBox();
            logoCOMPTE = new PictureBox();
            logoPANIER = new PictureBox();
            logo = new PictureBox();
            TITLE = new TextBox();
            logoPASSER_COMMANDE = new Button();
            btnSUPPR = new Button();
            panel2 = new Panel();
            PrixVISU = new TextBox();
            QuantitéVISU = new TextBox();
            DescriptionVISU = new TextBox();
            NomVISU = new TextBox();
            btnPANIER2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoDECONNEXION).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoPRODUIT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoCOMPTE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoPANIER).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnPANIER2
            // 
            btnPANIER2.BackColor = Color.MediumSeaGreen;
            btnPANIER2.Controls.Add(btnDECONNEXION);
            btnPANIER2.Controls.Add(btnCOMPTE);
            btnPANIER2.Controls.Add(btnPANNIER);
            btnPANIER2.Controls.Add(btnPRODUIT);
            btnPANIER2.Controls.Add(LogoDECONNEXION);
            btnPANIER2.Controls.Add(logoPRODUIT);
            btnPANIER2.Controls.Add(logoCOMPTE);
            btnPANIER2.Controls.Add(logoPANIER);
            btnPANIER2.Controls.Add(logo);
            btnPANIER2.Location = new Point(0, 0);
            btnPANIER2.Name = "btnPANIER2";
            btnPANIER2.Size = new Size(196, 582);
            btnPANIER2.TabIndex = 1;
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
            // btnPANNIER
            // 
            btnPANNIER.Location = new Point(50, 279);
            btnPANNIER.Name = "btnPANNIER";
            btnPANNIER.Size = new Size(125, 29);
            btnPANNIER.TabIndex = 9;
            btnPANNIER.Text = "Mon Panier";
            btnPANNIER.UseVisualStyleBackColor = true;
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
            // LogoDECONNEXION
            // 
            LogoDECONNEXION.BackgroundImage = (Image)resources.GetObject("LogoDECONNEXION.BackgroundImage");
            LogoDECONNEXION.Location = new Point(16, 512);
            LogoDECONNEXION.Name = "LogoDECONNEXION";
            LogoDECONNEXION.Size = new Size(28, 28);
            LogoDECONNEXION.TabIndex = 8;
            LogoDECONNEXION.TabStop = false;
            // 
            // logoPRODUIT
            // 
            logoPRODUIT.BackgroundImage = (Image)resources.GetObject("logoPRODUIT.BackgroundImage");
            logoPRODUIT.Location = new Point(12, 165);
            logoPRODUIT.Name = "logoPRODUIT";
            logoPRODUIT.Size = new Size(30, 30);
            logoPRODUIT.TabIndex = 1;
            logoPRODUIT.TabStop = false;
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
            // logoPANIER
            // 
            logoPANIER.BackgroundImage = (Image)resources.GetObject("logoPANIER.BackgroundImage");
            logoPANIER.Location = new Point(16, 280);
            logoPANIER.Name = "logoPANIER";
            logoPANIER.Size = new Size(28, 28);
            logoPANIER.TabIndex = 6;
            logoPANIER.TabStop = false;
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
            // TITLE
            // 
            TITLE.BorderStyle = BorderStyle.None;
            TITLE.Font = new Font("Times New Roman", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            TITLE.Location = new Point(596, 25);
            TITLE.Name = "TITLE";
            TITLE.Size = new Size(125, 21);
            TITLE.TabIndex = 2;
            TITLE.Text = "MON PANIER";
            TITLE.TextAlign = HorizontalAlignment.Center;
            // 
            // logoPASSER_COMMANDE
            // 
            logoPASSER_COMMANDE.Anchor = AnchorStyles.None;
            logoPASSER_COMMANDE.Location = new Point(912, 530);
            logoPASSER_COMMANDE.Name = "logoPASSER_COMMANDE";
            logoPASSER_COMMANDE.Size = new Size(203, 40);
            logoPASSER_COMMANDE.TabIndex = 16;
            logoPASSER_COMMANDE.Text = "PASSER COMMANDE";
            logoPASSER_COMMANDE.UseVisualStyleBackColor = true;
            // 
            // btnSUPPR
            // 
            btnSUPPR.Anchor = AnchorStyles.None;
            btnSUPPR.Location = new Point(668, 530);
            btnSUPPR.Name = "btnSUPPR";
            btnSUPPR.Size = new Size(221, 40);
            btnSUPPR.TabIndex = 17;
            btnSUPPR.Text = "SUPPRIMER DU PANIER";
            btnSUPPR.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(PrixVISU);
            panel2.Controls.Add(QuantitéVISU);
            panel2.Controls.Add(DescriptionVISU);
            panel2.Controls.Add(NomVISU);
            panel2.Location = new Point(269, 119);
            panel2.Name = "panel2";
            panel2.Size = new Size(786, 362);
            panel2.TabIndex = 28;
            // 
            // PrixVISU
            // 
            PrixVISU.AccessibleName = "";
            PrixVISU.BorderStyle = BorderStyle.FixedSingle;
            PrixVISU.Location = new Point(689, 0);
            PrixVISU.Name = "PrixVISU";
            PrixVISU.Size = new Size(97, 28);
            PrixVISU.TabIndex = 30;
            PrixVISU.Text = "PRIX";
            PrixVISU.TextAlign = HorizontalAlignment.Center;
            // 
            // QuantitéVISU
            // 
            QuantitéVISU.AccessibleName = "";
            QuantitéVISU.BorderStyle = BorderStyle.FixedSingle;
            QuantitéVISU.Location = new Point(567, 0);
            QuantitéVISU.Name = "QuantitéVISU";
            QuantitéVISU.Size = new Size(116, 28);
            QuantitéVISU.TabIndex = 29;
            QuantitéVISU.Text = "QUANTITE";
            QuantitéVISU.TextAlign = HorizontalAlignment.Center;
            // 
            // DescriptionVISU
            // 
            DescriptionVISU.AccessibleName = "";
            DescriptionVISU.BorderStyle = BorderStyle.FixedSingle;
            DescriptionVISU.Location = new Point(228, 0);
            DescriptionVISU.Name = "DescriptionVISU";
            DescriptionVISU.Size = new Size(333, 28);
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
            NomVISU.Size = new Size(222, 28);
            NomVISU.TabIndex = 27;
            NomVISU.Text = "Nom";
            NomVISU.TextAlign = HorizontalAlignment.Center;
            // 
            // Panier
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1130, 582);
            Controls.Add(panel2);
            Controls.Add(btnSUPPR);
            Controls.Add(logoPASSER_COMMANDE);
            Controls.Add(TITLE);
            Controls.Add(btnPANIER2);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Panier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panier";
            Load += Panier_Load;
            btnPANIER2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LogoDECONNEXION).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoPRODUIT).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoCOMPTE).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoPANIER).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel btnPANIER2;
        private Button btnDECONNEXION;
        private Button btnCOMPTE;
        private Button btnPANNIER;
        private Button btnPRODUIT;
        private PictureBox LogoDECONNEXION;
        private PictureBox logoPRODUIT;
        private PictureBox logoCOMPTE;
        private PictureBox logoPANIER;
        private PictureBox logo;
        private TextBox TITLE;
        private Button logoPASSER_COMMANDE;
        private Button btnSUPPR;
        private Panel panel2;
        private TextBox PrixVISU;
        private TextBox QuantitéVISU;
        private TextBox DescriptionVISU;
        private TextBox NomVISU;
    }
}