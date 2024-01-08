namespace Projet_Csharp
{
    partial class Command
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Command));
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
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
            ListeCommand = new Guna.UI2.WinForms.Guna2DataGridView();
            btnANNULER_COMMANDE = new Button();
            panelSupprCommand = new Panel();
            btnSUPPR = new Button();
            comboBoxSupprCom = new ComboBox();
            label3 = new Label();
            button4 = new Button();
            textBox2 = new TextBox();
            panelFacture = new Panel();
            btnFACTURATION = new Button();
            comboBoxFacture = new ComboBox();
            label1 = new Label();
            button2 = new Button();
            textBox3 = new TextBox();
            btnAVOIR_FACTURE = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ListeCommand).BeginInit();
            panelSupprCommand.SuspendLayout();
            panelFacture.SuspendLayout();
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
            textBox1.Text = "MES COMMANDES";
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
            btnCOMMAND.TabIndex = 20;
            btnCOMMAND.Text = "     Mes Commandes";
            btnCOMMAND.UseVisualStyleBackColor = true;
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
            panel3.Location = new Point(5, 371);
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
            btnPRODUIT.Click += roduit_click;
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
            // ListeCommand
            // 
            dataGridViewCellStyle13.BackColor = Color.White;
            ListeCommand.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            ListeCommand.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle14.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle14.ForeColor = Color.White;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            ListeCommand.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            ListeCommand.ColumnHeadersHeight = 22;
            ListeCommand.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.White;
            dataGridViewCellStyle15.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle15.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle15.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            ListeCommand.DefaultCellStyle = dataGridViewCellStyle15;
            ListeCommand.GridColor = Color.Silver;
            ListeCommand.Location = new Point(239, 88);
            ListeCommand.Name = "ListeCommand";
            ListeCommand.RowHeadersVisible = false;
            ListeCommand.RowHeadersWidth = 51;
            ListeCommand.Size = new Size(876, 403);
            ListeCommand.TabIndex = 114;
            ListeCommand.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            ListeCommand.ThemeStyle.AlternatingRowsStyle.Font = null;
            ListeCommand.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            ListeCommand.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            ListeCommand.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            ListeCommand.ThemeStyle.BackColor = SystemColors.Control;
            ListeCommand.ThemeStyle.GridColor = Color.Silver;
            ListeCommand.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            ListeCommand.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            ListeCommand.ThemeStyle.HeaderStyle.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListeCommand.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ListeCommand.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ListeCommand.ThemeStyle.HeaderStyle.Height = 22;
            ListeCommand.ThemeStyle.ReadOnly = false;
            ListeCommand.ThemeStyle.RowsStyle.BackColor = Color.White;
            ListeCommand.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ListeCommand.ThemeStyle.RowsStyle.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListeCommand.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            ListeCommand.ThemeStyle.RowsStyle.Height = 29;
            ListeCommand.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ListeCommand.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // btnANNULER_COMMANDE
            // 
            btnANNULER_COMMANDE.Anchor = AnchorStyles.None;
            btnANNULER_COMMANDE.Location = new Point(619, 530);
            btnANNULER_COMMANDE.Name = "btnANNULER_COMMANDE";
            btnANNULER_COMMANDE.Size = new Size(228, 40);
            btnANNULER_COMMANDE.TabIndex = 115;
            btnANNULER_COMMANDE.Text = "ANNULER COMMANDE";
            btnANNULER_COMMANDE.UseVisualStyleBackColor = true;
            btnANNULER_COMMANDE.Click += btnANNULER_COMMANDE_Click;
            // 
            // panelSupprCommand
            // 
            panelSupprCommand.Controls.Add(btnSUPPR);
            panelSupprCommand.Controls.Add(comboBoxSupprCom);
            panelSupprCommand.Controls.Add(label3);
            panelSupprCommand.Controls.Add(button4);
            panelSupprCommand.Controls.Add(textBox2);
            panelSupprCommand.Location = new Point(573, 396);
            panelSupprCommand.Name = "panelSupprCommand";
            panelSupprCommand.Size = new Size(267, 128);
            panelSupprCommand.TabIndex = 116;
            // 
            // btnSUPPR
            // 
            btnSUPPR.Anchor = AnchorStyles.None;
            btnSUPPR.Location = new Point(126, 95);
            btnSUPPR.Name = "btnSUPPR";
            btnSUPPR.Size = new Size(138, 30);
            btnSUPPR.TabIndex = 90;
            btnSUPPR.Text = "ANNULER";
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
            button4.Location = new Point(327, 174);
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
            textBox2.Text = "ANNULER LA COMMANDE";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // panelFacture
            // 
            panelFacture.Controls.Add(btnFACTURATION);
            panelFacture.Controls.Add(comboBoxFacture);
            panelFacture.Controls.Add(label1);
            panelFacture.Controls.Add(button2);
            panelFacture.Controls.Add(textBox3);
            panelFacture.Location = new Point(851, 396);
            panelFacture.Name = "panelFacture";
            panelFacture.Size = new Size(267, 128);
            panelFacture.TabIndex = 118;
            // 
            // btnFACTURATION
            // 
            btnFACTURATION.Anchor = AnchorStyles.None;
            btnFACTURATION.Location = new Point(118, 95);
            btnFACTURATION.Name = "btnFACTURATION";
            btnFACTURATION.Size = new Size(146, 30);
            btnFACTURATION.TabIndex = 90;
            btnFACTURATION.Text = "FACTURATION";
            btnFACTURATION.UseVisualStyleBackColor = true;
            btnFACTURATION.Click += btnFACTURATION_Click;
            // 
            // comboBoxFacture
            // 
            comboBoxFacture.FormattingEnabled = true;
            comboBoxFacture.Location = new Point(81, 47);
            comboBoxFacture.Name = "comboBoxFacture";
            comboBoxFacture.Size = new Size(183, 28);
            comboBoxFacture.TabIndex = 89;
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
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(360, 188);
            button2.Name = "button2";
            button2.Size = new Size(102, 30);
            button2.TabIndex = 85;
            button2.Text = "AJOUTER";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Times New Roman", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            textBox3.ForeColor = SystemColors.WindowText;
            textBox3.Location = new Point(3, 3);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(261, 24);
            textBox3.TabIndex = 0;
            textBox3.Text = "AVOIR LA FACTURE";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAVOIR_FACTURE
            // 
            btnAVOIR_FACTURE.Anchor = AnchorStyles.None;
            btnAVOIR_FACTURE.Location = new Point(897, 530);
            btnAVOIR_FACTURE.Name = "btnAVOIR_FACTURE";
            btnAVOIR_FACTURE.Size = new Size(228, 40);
            btnAVOIR_FACTURE.TabIndex = 117;
            btnAVOIR_FACTURE.Text = "AVOIR FACTURE";
            btnAVOIR_FACTURE.UseVisualStyleBackColor = true;
            btnAVOIR_FACTURE.Click += btnAVOIR_FACTURE_Click;
            // 
            // Command
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1130, 582);
            Controls.Add(panelFacture);
            Controls.Add(btnAVOIR_FACTURE);
            Controls.Add(panelSupprCommand);
            Controls.Add(btnANNULER_COMMANDE);
            Controls.Add(ListeCommand);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Command";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Command";
            Load += Command_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ListeCommand).EndInit();
            panelSupprCommand.ResumeLayout(false);
            panelSupprCommand.PerformLayout();
            panelFacture.ResumeLayout(false);
            panelFacture.PerformLayout();
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
        private Guna.UI2.WinForms.Guna2DataGridView ListeCommand;
        private Button btnANNULER_COMMANDE;
        private Panel panelSupprCommand;
        private Button btnSUPPR;
        private ComboBox comboBoxSupprCom;
        private Label label3;
        private Button button4;
        private TextBox textBox2;
        private Panel panelFacture;
        private Button btnFACTURATION;
        private ComboBox comboBoxFacture;
        private Label label1;
        private Button button2;
        private TextBox textBox3;
        private Button btnAVOIR_FACTURE;
    }
}