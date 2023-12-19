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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panier));
            TITLE = new TextBox();
            logoPASSER_COMMANDE = new Button();
            btnSUPPR = new Button();
            ListePanier = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1 = new Panel();
            panel3 = new Panel();
            btnDECONNEXION = new Button();
            Logo1 = new PictureBox();
            btnCOMPTE = new Button();
            btnPRODUIT = new Button();
            btnPANIER = new Button();
            ((System.ComponentModel.ISupportInitialize)ListePanier).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo1).BeginInit();
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
            // ListePanier
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            ListePanier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ListePanier.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ListePanier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ListePanier.ColumnHeadersHeight = 22;
            ListePanier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ListePanier.DefaultCellStyle = dataGridViewCellStyle3;
            ListePanier.GridColor = Color.Silver;
            ListePanier.Location = new Point(279, 88);
            ListePanier.Name = "ListePanier";
            ListePanier.RowHeadersVisible = false;
            ListePanier.RowHeadersWidth = 51;
            ListePanier.Size = new Size(836, 403);
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
            panel1.Controls.Add(btnDECONNEXION);
            panel1.Controls.Add(Logo1);
            panel1.Controls.Add(btnCOMPTE);
            panel1.Controls.Add(btnPRODUIT);
            panel1.Controls.Add(btnPANIER);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 582);
            panel1.TabIndex = 77;
            panel1.Paint += panel1_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Location = new Point(2, 279);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 32);
            panel3.TabIndex = 83;
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
            btnDECONNEXION.Size = new Size(164, 32);
            btnDECONNEXION.TabIndex = 82;
            btnDECONNEXION.Text = "Déconnexion";
            btnDECONNEXION.TextAlign = ContentAlignment.MiddleRight;
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
            // btnCOMPTE
            // 
            btnCOMPTE.FlatAppearance.BorderSize = 0;
            btnCOMPTE.FlatStyle = FlatStyle.Flat;
            btnCOMPTE.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCOMPTE.ForeColor = SystemColors.ControlLightLight;
            btnCOMPTE.Image = Properties.Resources.icon_compte1;
            btnCOMPTE.ImageAlign = ContentAlignment.MiddleLeft;
            btnCOMPTE.Location = new Point(16, 421);
            btnCOMPTE.Name = "btnCOMPTE";
            btnCOMPTE.Size = new Size(164, 32);
            btnCOMPTE.TabIndex = 81;
            btnCOMPTE.Text = "Mon Compte";
            btnCOMPTE.TextAlign = ContentAlignment.MiddleRight;
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
            btnPRODUIT.Location = new Point(16, 165);
            btnPRODUIT.Name = "btnPRODUIT";
            btnPRODUIT.RightToLeft = RightToLeft.No;
            btnPRODUIT.Size = new Size(164, 32);
            btnPRODUIT.TabIndex = 78;
            btnPRODUIT.Text = "Les Produits";
            btnPRODUIT.TextAlign = ContentAlignment.MiddleRight;
            btnPRODUIT.UseVisualStyleBackColor = true;
            btnPRODUIT.Click += produit_click;
            // 
            // btnPANIER
            // 
            btnPANIER.FlatAppearance.BorderSize = 0;
            btnPANIER.FlatStyle = FlatStyle.Flat;
            btnPANIER.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPANIER.ForeColor = SystemColors.ControlLightLight;
            btnPANIER.Image = Properties.Resources.icon_panier1;
            btnPANIER.ImageAlign = ContentAlignment.MiddleLeft;
            btnPANIER.Location = new Point(16, 279);
            btnPANIER.Name = "btnPANIER";
            btnPANIER.Size = new Size(164, 32);
            btnPANIER.TabIndex = 80;
            btnPANIER.Text = "Mon Panier";
            btnPANIER.TextAlign = ContentAlignment.MiddleRight;
            btnPANIER.UseVisualStyleBackColor = true;
            // 
            // Panier
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1130, 582);
            Controls.Add(panel1);
            Controls.Add(ListePanier);
            Controls.Add(btnSUPPR);
            Controls.Add(logoPASSER_COMMANDE);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TITLE;
        private Button logoPASSER_COMMANDE;
        private Button btnSUPPR;
        private Guna.UI2.WinForms.Guna2DataGridView ListePanier;
        private Panel panel1;
        private Button btnDECONNEXION;
        private PictureBox Logo1;
        private Button btnCOMPTE;
        private Button btnPRODUIT;
        private Button btnPANIER;
        private Panel panel3;
    }
}