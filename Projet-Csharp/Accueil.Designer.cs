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
            btnDECONNEXION = new Button();
            btnCOMPTE = new Button();
            btnPANIER = new Button();
            btnPRODUIT = new Button();
            LogoDECONNEXION = new PictureBox();
            LogoPRODUIT = new PictureBox();
            LogoCOMPTE = new PictureBox();
            LogoPANIER = new PictureBox();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoDECONNEXION).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoPRODUIT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoCOMPTE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoPANIER).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Logo1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ListeProduits).BeginInit();
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
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 582);
            panel1.TabIndex = 71;
            // 
            // btnDECONNEXION
            // 
            btnDECONNEXION.Location = new Point(50, 511);
            btnDECONNEXION.Name = "btnDECONNEXION";
            btnDECONNEXION.Size = new Size(113, 29);
            btnDECONNEXION.TabIndex = 11;
            btnDECONNEXION.Text = "Déconnexion";
            btnDECONNEXION.UseVisualStyleBackColor = true;
            btnDECONNEXION.Click += deconnexion_click;
            // 
            // btnCOMPTE
            // 
            btnCOMPTE.Location = new Point(50, 421);
            btnCOMPTE.Name = "btnCOMPTE";
            btnCOMPTE.Size = new Size(113, 29);
            btnCOMPTE.TabIndex = 10;
            btnCOMPTE.Text = "Mon Compte";
            btnCOMPTE.UseVisualStyleBackColor = true;
            btnCOMPTE.Click += compte_click;
            // 
            // btnPANIER
            // 
            btnPANIER.Location = new Point(50, 279);
            btnPANIER.Name = "btnPANIER";
            btnPANIER.Size = new Size(113, 29);
            btnPANIER.TabIndex = 9;
            btnPANIER.Text = "Mon Panier";
            btnPANIER.UseVisualStyleBackColor = true;
            btnPANIER.Click += panier_click;
            // 
            // btnPRODUIT
            // 
            btnPRODUIT.Location = new Point(50, 167);
            btnPRODUIT.Name = "btnPRODUIT";
            btnPRODUIT.Size = new Size(113, 29);
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
            // ajouter
            // 
            ajouter.BackColor = Color.LimeGreen;
            ajouter.Location = new Point(203, 417);
            ajouter.Name = "ajouter";
            ajouter.Size = new Size(106, 35);
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
            supprimer.Location = new Point(260, 477);
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
            NomTITLE.Location = new Point(192, 110);
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
            // 
            // modif
            // 
            modif.BackColor = Color.GreenYellow;
            modif.Location = new Point(330, 418);
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
            PrixTITLE.Location = new Point(192, 270);
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
            NomTEXT.Location = new Point(261, 109);
            NomTEXT.Name = "NomTEXT";
            NomTEXT.Size = new Size(191, 28);
            NomTEXT.TabIndex = 80;
            // 
            // DescriptionTITLE
            // 
            DescriptionTITLE.AutoSize = true;
            DescriptionTITLE.BackColor = Color.White;
            DescriptionTITLE.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DescriptionTITLE.ForeColor = Color.Crimson;
            DescriptionTITLE.Location = new Point(192, 175);
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
            ListeProduits.Location = new Point(474, 109);
            ListeProduits.Name = "ListeProduits";
            ListeProduits.RowHeadersVisible = false;
            ListeProduits.RowHeadersWidth = 51;
            ListeProduits.Size = new Size(644, 403);
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
            QuantitéTITLE.Location = new Point(192, 329);
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
            DescriptionTEXT.Location = new Point(302, 165);
            DescriptionTEXT.Multiline = true;
            DescriptionTEXT.Name = "DescriptionTEXT";
            DescriptionTEXT.ScrollBars = ScrollBars.Vertical;
            DescriptionTEXT.Size = new Size(150, 75);
            DescriptionTEXT.TabIndex = 81;
            // 
            // PrixTEXT
            // 
            PrixTEXT.AccessibleName = "";
            PrixTEXT.BorderStyle = BorderStyle.FixedSingle;
            PrixTEXT.Location = new Point(261, 270);
            PrixTEXT.Name = "PrixTEXT";
            PrixTEXT.Size = new Size(120, 28);
            PrixTEXT.TabIndex = 85;
            // 
            // QuantitéTEXT
            // 
            QuantitéTEXT.AccessibleName = "";
            QuantitéTEXT.BorderStyle = BorderStyle.FixedSingle;
            QuantitéTEXT.Location = new Point(286, 323);
            QuantitéTEXT.Name = "QuantitéTEXT";
            QuantitéTEXT.Size = new Size(95, 28);
            QuantitéTEXT.TabIndex = 84;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 50;
            // 
            // Accueil
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1130, 582);
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
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LogoDECONNEXION).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoPRODUIT).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoCOMPTE).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoPANIER).EndInit();
            ((System.ComponentModel.ISupportInitialize)Logo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ListeProduits).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnDECONNEXION;
        private Button btnCOMPTE;
        private Button btnPANIER;
        private Button btnPRODUIT;
        private PictureBox LogoDECONNEXION;
        private PictureBox LogoPRODUIT;
        private PictureBox LogoCOMPTE;
        private PictureBox LogoPANIER;
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
    }
}