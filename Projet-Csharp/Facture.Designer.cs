namespace Projet_Csharp
{
    partial class Facture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facture));
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            textBox1 = new TextBox();
            btnFACTURE = new Button();
            btnCOMMAND = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            btnDECONNEXION = new Button();
            btnCOMPTE = new Button();
            btnPANIER = new Button();
            btnPRODUIT = new Button();
            Logo1 = new PictureBox();
            ListeFacture = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ListeFacture).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Times New Roman", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(546, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 21);
            textBox1.TabIndex = 113;
            textBox1.Text = "MES FACTURES";
            textBox1.TextAlign = HorizontalAlignment.Center;
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
            btnFACTURE.TabIndex = 21;
            btnFACTURE.Text = "Mes Factures";
            btnFACTURE.UseVisualStyleBackColor = true;
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
            btnCOMMAND.TabIndex = 20;
            btnCOMMAND.Text = "     Mes Commandes";
            btnCOMMAND.UseVisualStyleBackColor = true;
            btnCOMMAND.Click += command_click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(btnFACTURE);
            panel1.Controls.Add(btnCOMMAND);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnDECONNEXION);
            panel1.Controls.Add(btnCOMPTE);
            panel1.Controls.Add(btnPANIER);
            panel1.Controls.Add(btnPRODUIT);
            panel1.Controls.Add(Logo1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 582);
            panel1.TabIndex = 91;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Location = new Point(5, 434);
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
            // ListeFacture
            // 
            dataGridViewCellStyle16.BackColor = Color.White;
            ListeFacture.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            ListeFacture.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle17.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle17.ForeColor = Color.White;
            dataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            ListeFacture.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            ListeFacture.ColumnHeadersHeight = 22;
            ListeFacture.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = Color.White;
            dataGridViewCellStyle18.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle18.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle18.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle18.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.False;
            ListeFacture.DefaultCellStyle = dataGridViewCellStyle18;
            ListeFacture.GridColor = Color.Silver;
            ListeFacture.Location = new Point(279, 88);
            ListeFacture.Name = "ListeFacture";
            ListeFacture.RowHeadersVisible = false;
            ListeFacture.RowHeadersWidth = 51;
            ListeFacture.Size = new Size(836, 403);
            ListeFacture.TabIndex = 114;
            ListeFacture.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            ListeFacture.ThemeStyle.AlternatingRowsStyle.Font = null;
            ListeFacture.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            ListeFacture.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            ListeFacture.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            ListeFacture.ThemeStyle.BackColor = SystemColors.Control;
            ListeFacture.ThemeStyle.GridColor = Color.Silver;
            ListeFacture.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            ListeFacture.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            ListeFacture.ThemeStyle.HeaderStyle.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListeFacture.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ListeFacture.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ListeFacture.ThemeStyle.HeaderStyle.Height = 22;
            ListeFacture.ThemeStyle.ReadOnly = false;
            ListeFacture.ThemeStyle.RowsStyle.BackColor = Color.White;
            ListeFacture.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ListeFacture.ThemeStyle.RowsStyle.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListeFacture.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            ListeFacture.ThemeStyle.RowsStyle.Height = 29;
            ListeFacture.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ListeFacture.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Facture
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1130, 582);
            Controls.Add(ListeFacture);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Facture";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Facture";
            Load += Facture_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ListeFacture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnFACTURE;
        private Button btnCOMMAND;
        private Panel panel1;
        private Panel panel3;
        private Button btnDECONNEXION;
        private Button btnCOMPTE;
        private Button btnPANIER;
        private Button btnPRODUIT;
        private PictureBox Logo1;
        private Guna.UI2.WinForms.Guna2DataGridView ListeFacture;
    }
}