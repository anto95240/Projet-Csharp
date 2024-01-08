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
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panier));
            TITLE = new TextBox();
            btnAFFICHEPassCommand = new Button();
            btnAfficheSupprPanier = new Button();
            ListePanier = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1 = new Panel();
            panel3 = new Panel();
            btnFACTURE = new Button();
            btnCOMMAND = new Button();
            btnCOMPTE = new Button();
            btnPANIER = new Button();
            btnDECONNEXION = new Button();
            Logo1 = new PictureBox();
            btnPRODUIT = new Button();
            comboBoxPassCom = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            panelAddCommande = new Panel();
            btnPassCommand = new Button();
            textBox1 = new TextBox();
            panelSupprPanier = new Panel();
            btnSUPPR = new Button();
            comboBoxSupprCom = new ComboBox();
            label3 = new Label();
            button4 = new Button();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ListePanier).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo1).BeginInit();
            panelAddCommande.SuspendLayout();
            panelSupprPanier.SuspendLayout();
            SuspendLayout();
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
            // btnAFFICHEPassCommand
            // 
            btnAFFICHEPassCommand.Anchor = AnchorStyles.None;
            btnAFFICHEPassCommand.Location = new Point(912, 530);
            btnAFFICHEPassCommand.Name = "btnAFFICHEPassCommand";
            btnAFFICHEPassCommand.Size = new Size(203, 40);
            btnAFFICHEPassCommand.TabIndex = 16;
            btnAFFICHEPassCommand.Text = "PASSER COMMANDE";
            btnAFFICHEPassCommand.UseVisualStyleBackColor = true;
            btnAFFICHEPassCommand.Click += btnAfficheProduitAddCommande;
            // 
            // btnAfficheSupprPanier
            // 
            btnAfficheSupprPanier.Anchor = AnchorStyles.None;
            btnAfficheSupprPanier.Location = new Point(619, 530);
            btnAfficheSupprPanier.Name = "btnAfficheSupprPanier";
            btnAfficheSupprPanier.Size = new Size(221, 40);
            btnAfficheSupprPanier.TabIndex = 17;
            btnAfficheSupprPanier.Text = "SUPPRIMER DU PANIER";
            btnAfficheSupprPanier.UseVisualStyleBackColor = true;
            btnAfficheSupprPanier.Click += btnAfficheSupprPanier_Click;
            // 
            // ListePanier
            // 
            dataGridViewCellStyle16.BackColor = Color.White;
            ListePanier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            ListePanier.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle17.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle17.ForeColor = Color.White;
            dataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            ListePanier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            ListePanier.ColumnHeadersHeight = 22;
            ListePanier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = Color.White;
            dataGridViewCellStyle18.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle18.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle18.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle18.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.False;
            ListePanier.DefaultCellStyle = dataGridViewCellStyle18;
            ListePanier.GridColor = Color.Silver;
            ListePanier.Location = new Point(239, 88);
            ListePanier.Name = "ListePanier";
            ListePanier.RowHeadersVisible = false;
            ListePanier.RowHeadersWidth = 51;
            ListePanier.Size = new Size(876, 403);
            ListePanier.TabIndex = 76;
            ListePanier.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            ListePanier.ThemeStyle.AlternatingRowsStyle.Font = null;
            ListePanier.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            ListePanier.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            ListePanier.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            ListePanier.ThemeStyle.BackColor = SystemColors.Control;
            ListePanier.ThemeStyle.GridColor = Color.Silver;
            ListePanier.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            ListePanier.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            ListePanier.ThemeStyle.HeaderStyle.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListePanier.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ListePanier.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ListePanier.ThemeStyle.HeaderStyle.Height = 22;
            ListePanier.ThemeStyle.ReadOnly = false;
            ListePanier.ThemeStyle.RowsStyle.BackColor = Color.White;
            ListePanier.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ListePanier.ThemeStyle.RowsStyle.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListePanier.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            ListePanier.ThemeStyle.RowsStyle.Height = 29;
            ListePanier.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ListePanier.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnFACTURE);
            panel1.Controls.Add(btnCOMMAND);
            panel1.Controls.Add(btnCOMPTE);
            panel1.Controls.Add(btnPANIER);
            panel1.Controls.Add(btnDECONNEXION);
            panel1.Controls.Add(Logo1);
            panel1.Controls.Add(btnPRODUIT);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 582);
            panel1.TabIndex = 77;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Location = new Point(5, 214);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 32);
            panel3.TabIndex = 78;
            // 
            // btnFACTURE
            // 
            btnFACTURE.FlatAppearance.BorderSize = 0;
            btnFACTURE.FlatStyle = FlatStyle.Flat;
            btnFACTURE.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFACTURE.ForeColor = SystemColors.ControlLightLight;
            btnFACTURE.Image = Properties.Resources.icon_compte1;
            btnFACTURE.ImageAlign = ContentAlignment.MiddleLeft;
            btnFACTURE.Location = new Point(16, 432);
            btnFACTURE.Name = "btnFACTURE";
            btnFACTURE.Size = new Size(192, 32);
            btnFACTURE.TabIndex = 86;
            btnFACTURE.Text = "Mes Factures";
            btnFACTURE.UseVisualStyleBackColor = true;
            btnFACTURE.Click += facture_click;
            // 
            // btnCOMMAND
            // 
            btnCOMMAND.FlatAppearance.BorderSize = 0;
            btnCOMMAND.FlatStyle = FlatStyle.Flat;
            btnCOMMAND.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCOMMAND.ForeColor = SystemColors.ControlLightLight;
            btnCOMMAND.Image = Properties.Resources.icon_compte1;
            btnCOMMAND.ImageAlign = ContentAlignment.MiddleLeft;
            btnCOMMAND.Location = new Point(16, 371);
            btnCOMMAND.Name = "btnCOMMAND";
            btnCOMMAND.Size = new Size(192, 32);
            btnCOMMAND.TabIndex = 85;
            btnCOMMAND.Text = "     Mes Commandes";
            btnCOMMAND.UseVisualStyleBackColor = true;
            btnCOMMAND.Click += command_click;
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
            btnCOMPTE.TabIndex = 84;
            btnCOMPTE.Text = "Mon Compte";
            btnCOMPTE.UseVisualStyleBackColor = true;
            btnCOMPTE.Click += compte_click;
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
            btnPANIER.TabIndex = 83;
            btnPANIER.Text = "Mon Panier";
            btnPANIER.UseVisualStyleBackColor = true;
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
            btnDECONNEXION.TabIndex = 82;
            btnDECONNEXION.Text = "Déconnexion";
            btnDECONNEXION.UseVisualStyleBackColor = true;
            btnDECONNEXION.Click += deconnexion_click;
            // 
            // Logo1
            // 
            Logo1.BackColor = Color.White;
            Logo1.BackgroundImage = (Image)resources.GetObject("Logo1.BackgroundImage");
            Logo1.Image = (Image)resources.GetObject("Logo1.Image");
            Logo1.Location = new Point(60, 10);
            Logo1.Name = "Logo1";
            Logo1.Size = new Size(69, 63);
            Logo1.TabIndex = 79;
            Logo1.TabStop = false;
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
            btnPRODUIT.TabIndex = 78;
            btnPRODUIT.Text = "Les Produits";
            btnPRODUIT.UseVisualStyleBackColor = true;
            btnPRODUIT.Click += produit_click;
            // 
            // comboBoxPassCom
            // 
            comboBoxPassCom.FormattingEnabled = true;
            comboBoxPassCom.Location = new Point(81, 47);
            comboBoxPassCom.Name = "comboBoxPassCom";
            comboBoxPassCom.Size = new Size(183, 28);
            comboBoxPassCom.TabIndex = 89;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(4, 49);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 22);
            label1.TabIndex = 87;
            label1.Text = "Nom";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(261, 146);
            button1.Name = "button1";
            button1.Size = new Size(102, 30);
            button1.TabIndex = 85;
            button1.Text = "AJOUTER";
            button1.UseVisualStyleBackColor = true;
            // 
            // panelAddCommande
            // 
            panelAddCommande.Controls.Add(btnPassCommand);
            panelAddCommande.Controls.Add(comboBoxPassCom);
            panelAddCommande.Controls.Add(label1);
            panelAddCommande.Controls.Add(button1);
            panelAddCommande.Controls.Add(textBox1);
            panelAddCommande.Location = new Point(848, 396);
            panelAddCommande.Name = "panelAddCommande";
            panelAddCommande.Size = new Size(267, 128);
            panelAddCommande.TabIndex = 85;
            // 
            // btnPassCommand
            // 
            btnPassCommand.Anchor = AnchorStyles.None;
            btnPassCommand.Location = new Point(126, 95);
            btnPassCommand.Name = "btnPassCommand";
            btnPassCommand.Size = new Size(138, 30);
            btnPassCommand.TabIndex = 90;
            btnPassCommand.Text = "COMMANDER";
            btnPassCommand.UseVisualStyleBackColor = true;
            btnPassCommand.Click += btnPassCommand_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Times New Roman", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(3, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 24);
            textBox1.TabIndex = 0;
            textBox1.Text = "PASSER LA COMMANDE";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // panelSupprPanier
            // 
            panelSupprPanier.Controls.Add(btnSUPPR);
            panelSupprPanier.Controls.Add(comboBoxSupprCom);
            panelSupprPanier.Controls.Add(label3);
            panelSupprPanier.Controls.Add(button4);
            panelSupprPanier.Controls.Add(textBox2);
            panelSupprPanier.Location = new Point(573, 396);
            panelSupprPanier.Name = "panelSupprPanier";
            panelSupprPanier.Size = new Size(267, 128);
            panelSupprPanier.TabIndex = 91;
            // 
            // btnSUPPR
            // 
            btnSUPPR.Anchor = AnchorStyles.None;
            btnSUPPR.Location = new Point(126, 95);
            btnSUPPR.Name = "btnSUPPR";
            btnSUPPR.Size = new Size(138, 30);
            btnSUPPR.TabIndex = 90;
            btnSUPPR.Text = "SUPPRIMMER";
            btnSUPPR.UseVisualStyleBackColor = true;
            btnSUPPR.Click += btnSUPPR_Click;
            // 
            // comboBoxSupprCom
            // 
            comboBoxSupprCom.FormattingEnabled = true;
            comboBoxSupprCom.Location = new Point(81, 47);
            comboBoxSupprCom.Name = "comboBoxSupprCom";
            comboBoxSupprCom.Size = new Size(183, 28);
            comboBoxSupprCom.TabIndex = 89;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(4, 49);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 22);
            label3.TabIndex = 87;
            label3.Text = "Nom";
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Location = new Point(294, 160);
            button4.Name = "button4";
            button4.Size = new Size(102, 30);
            button4.TabIndex = 85;
            button4.Text = "AJOUTER";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Times New Roman", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.WindowText;
            textBox2.Location = new Point(3, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(261, 24);
            textBox2.TabIndex = 0;
            textBox2.Text = "SUPPRIMER LA COMMANDE";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // Panier
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1130, 582);
            Controls.Add(panelSupprPanier);
            Controls.Add(panelAddCommande);
            Controls.Add(panel1);
            Controls.Add(ListePanier);
            Controls.Add(btnAfficheSupprPanier);
            Controls.Add(btnAFFICHEPassCommand);
            Controls.Add(TITLE);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Panier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panier";
            Load += Panier_Load;
            ((System.ComponentModel.ISupportInitialize)ListePanier).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo1).EndInit();
            panelAddCommande.ResumeLayout(false);
            panelAddCommande.PerformLayout();
            panelSupprPanier.ResumeLayout(false);
            panelSupprPanier.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TITLE;
        private Button btnAFFICHEPassCommand;
        private Guna.UI2.WinForms.Guna2DataGridView ListePanier;
        private Panel panel1;
        private Button btnDECONNEXION;
        private PictureBox Logo1;
        private Button btnPRODUIT;
        private Button btnFACTURE;
        private Button btnCOMMAND;
        private Button btnCOMPTE;
        private Button btnPANIER;
        private Panel panel3;
        private Button btnAfficheSupprPanier;
        public ComboBox comboBoxPassCom;
        private Label label2;
        private Label label1;
        private TextBox QuantityProduit;
        private Button button1;
        private Panel panelAddCommande;
        private TextBox textBox1;
        private Button btnPassCommand;
        private Panel panelSupprPanier;
        private Button btnSUPPR;
        private ComboBox comboBoxSupprCom;
        private Label label3;
        private Button button4;
        private TextBox textBox2;
    }
}