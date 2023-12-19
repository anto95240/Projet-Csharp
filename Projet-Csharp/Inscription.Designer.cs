namespace Projet_Csharp
{
    partial class Inscription
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
            label1 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            label2 = new Label();
            btnCONNEXION = new Button();
            btnINSCRIPTION = new Button();
            panel3 = new Panel();
            NomTEXT = new TextBox();
            PrénomText = new TextBox();
            NomTITLE = new Label();
            PrénomTITLE = new Label();
            PaysTEXT = new TextBox();
            PaysTITLE = new Label();
            CodePostalTEXT = new TextBox();
            EtatTITLE = new Label();
            EtatTEXT = new TextBox();
            CodePostalTITLE = new Label();
            VilleTEXT = new TextBox();
            VilleTITLE = new Label();
            AdresseTEXT = new TextBox();
            AdresseTITLE = new Label();
            MdpTEXT = new TextBox();
            EmailTEXT = new TextBox();
            MdpTITLE = new Label();
            EmailTITLE = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(180, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(155, 26);
            label1.TabIndex = 0;
            label1.Text = "INSCRIPTION";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSeaGreen;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(495, 80);
            panel2.TabIndex = 29;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 548);
            panel1.Name = "panel1";
            panel1.Size = new Size(495, 49);
            panel1.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(213, 466);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 23;
            label2.Text = "ou sinon";
            // 
            // btnCONNEXION
            // 
            btnCONNEXION.FlatAppearance.BorderSize = 0;
            btnCONNEXION.FlatStyle = FlatStyle.System;
            btnCONNEXION.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCONNEXION.ForeColor = Color.Crimson;
            btnCONNEXION.Location = new Point(172, 490);
            btnCONNEXION.Margin = new Padding(4, 3, 4, 3);
            btnCONNEXION.Name = "btnCONNEXION";
            btnCONNEXION.Size = new Size(131, 30);
            btnCONNEXION.TabIndex = 21;
            btnCONNEXION.Text = "Connexion";
            btnCONNEXION.UseVisualStyleBackColor = false;
            btnCONNEXION.Click += Button_connexion;
            // 
            // btnINSCRIPTION
            // 
            btnINSCRIPTION.BackColor = Color.SeaGreen;
            btnINSCRIPTION.FlatAppearance.BorderSize = 0;
            btnINSCRIPTION.FlatStyle = FlatStyle.Flat;
            btnINSCRIPTION.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnINSCRIPTION.ForeColor = Color.White;
            btnINSCRIPTION.Location = new Point(116, 393);
            btnINSCRIPTION.Margin = new Padding(4, 3, 4, 3);
            btnINSCRIPTION.Name = "btnINSCRIPTION";
            btnINSCRIPTION.Size = new Size(243, 41);
            btnINSCRIPTION.TabIndex = 22;
            btnINSCRIPTION.Text = "Je m'inscrit gratuitement";
            btnINSCRIPTION.UseVisualStyleBackColor = false;
            btnINSCRIPTION.Click += Button_Inscription;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.AutoScrollMargin = new Size(0, 20);
            panel3.AutoScrollMinSize = new Size(0, 100);
            panel3.Controls.Add(NomTEXT);
            panel3.Controls.Add(PrénomText);
            panel3.Controls.Add(NomTITLE);
            panel3.Controls.Add(PrénomTITLE);
            panel3.Controls.Add(PaysTEXT);
            panel3.Controls.Add(PaysTITLE);
            panel3.Controls.Add(CodePostalTEXT);
            panel3.Controls.Add(EtatTITLE);
            panel3.Controls.Add(EtatTEXT);
            panel3.Controls.Add(CodePostalTITLE);
            panel3.Controls.Add(VilleTEXT);
            panel3.Controls.Add(VilleTITLE);
            panel3.Controls.Add(AdresseTEXT);
            panel3.Controls.Add(AdresseTITLE);
            panel3.Controls.Add(MdpTEXT);
            panel3.Controls.Add(EmailTEXT);
            panel3.Controls.Add(MdpTITLE);
            panel3.Controls.Add(EmailTITLE);
            panel3.Location = new Point(52, 98);
            panel3.Name = "panel3";
            panel3.Size = new Size(405, 255);
            panel3.TabIndex = 34;
            // 
            // NomTEXT
            // 
            NomTEXT.AccessibleName = "";
            NomTEXT.BorderStyle = BorderStyle.FixedSingle;
            NomTEXT.Location = new Point(29, 337);
            NomTEXT.Multiline = true;
            NomTEXT.Name = "NomTEXT";
            NomTEXT.Size = new Size(305, 30);
            NomTEXT.TabIndex = 23;
            // 
            // PrénomText
            // 
            PrénomText.AccessibleName = "";
            PrénomText.BorderStyle = BorderStyle.FixedSingle;
            PrénomText.Location = new Point(29, 243);
            PrénomText.Multiline = true;
            PrénomText.Name = "PrénomText";
            PrénomText.Size = new Size(305, 30);
            PrénomText.TabIndex = 22;
            // 
            // NomTITLE
            // 
            NomTITLE.AutoSize = true;
            NomTITLE.BackColor = Color.White;
            NomTITLE.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NomTITLE.ForeColor = Color.Crimson;
            NomTITLE.Location = new Point(29, 299);
            NomTITLE.Margin = new Padding(4, 0, 4, 0);
            NomTITLE.Name = "NomTITLE";
            NomTITLE.Size = new Size(58, 26);
            NomTITLE.TabIndex = 35;
            NomTITLE.Text = "Nom";
            // 
            // PrénomTITLE
            // 
            PrénomTITLE.AutoSize = true;
            PrénomTITLE.BackColor = Color.White;
            PrénomTITLE.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrénomTITLE.ForeColor = Color.Crimson;
            PrénomTITLE.Location = new Point(29, 204);
            PrénomTITLE.Margin = new Padding(4, 0, 4, 0);
            PrénomTITLE.Name = "PrénomTITLE";
            PrénomTITLE.Size = new Size(85, 26);
            PrénomTITLE.TabIndex = 34;
            PrénomTITLE.Text = "Prénom";
            // 
            // PaysTEXT
            // 
            PaysTEXT.AccessibleName = "";
            PaysTEXT.BorderStyle = BorderStyle.FixedSingle;
            PaysTEXT.Location = new Point(29, 871);
            PaysTEXT.Multiline = true;
            PaysTEXT.Name = "PaysTEXT";
            PaysTEXT.Size = new Size(305, 30);
            PaysTEXT.TabIndex = 28;
            // 
            // PaysTITLE
            // 
            PaysTITLE.AutoSize = true;
            PaysTITLE.BackColor = Color.White;
            PaysTITLE.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PaysTITLE.ForeColor = Color.Crimson;
            PaysTITLE.Location = new Point(29, 826);
            PaysTITLE.Margin = new Padding(4, 0, 4, 0);
            PaysTITLE.Name = "PaysTITLE";
            PaysTITLE.Size = new Size(55, 26);
            PaysTITLE.TabIndex = 30;
            PaysTITLE.Text = "Pays";
            // 
            // CodePostalTEXT
            // 
            CodePostalTEXT.AccessibleName = "";
            CodePostalTEXT.BorderStyle = BorderStyle.FixedSingle;
            CodePostalTEXT.Location = new Point(29, 767);
            CodePostalTEXT.Multiline = true;
            CodePostalTEXT.Name = "CodePostalTEXT";
            CodePostalTEXT.Size = new Size(305, 30);
            CodePostalTEXT.TabIndex = 27;
            // 
            // EtatTITLE
            // 
            EtatTITLE.AutoSize = true;
            EtatTITLE.BackColor = Color.White;
            EtatTITLE.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EtatTITLE.ForeColor = Color.Crimson;
            EtatTITLE.Location = new Point(29, 609);
            EtatTITLE.Margin = new Padding(4, 0, 4, 0);
            EtatTITLE.Name = "EtatTITLE";
            EtatTITLE.Size = new Size(47, 26);
            EtatTITLE.TabIndex = 28;
            EtatTITLE.Text = "Etat";
            // 
            // EtatTEXT
            // 
            EtatTEXT.AccessibleName = "";
            EtatTEXT.BorderStyle = BorderStyle.FixedSingle;
            EtatTEXT.Location = new Point(29, 660);
            EtatTEXT.Multiline = true;
            EtatTEXT.Name = "EtatTEXT";
            EtatTEXT.Size = new Size(305, 30);
            EtatTEXT.TabIndex = 26;
            // 
            // CodePostalTITLE
            // 
            CodePostalTITLE.AutoSize = true;
            CodePostalTITLE.BackColor = Color.White;
            CodePostalTITLE.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CodePostalTITLE.ForeColor = Color.Crimson;
            CodePostalTITLE.Location = new Point(29, 720);
            CodePostalTITLE.Margin = new Padding(4, 0, 4, 0);
            CodePostalTITLE.Name = "CodePostalTITLE";
            CodePostalTITLE.Size = new Size(123, 26);
            CodePostalTITLE.TabIndex = 26;
            CodePostalTITLE.Text = "Code Postal";
            // 
            // VilleTEXT
            // 
            VilleTEXT.AccessibleName = "";
            VilleTEXT.BorderStyle = BorderStyle.FixedSingle;
            VilleTEXT.Location = new Point(29, 544);
            VilleTEXT.Multiline = true;
            VilleTEXT.Name = "VilleTEXT";
            VilleTEXT.Size = new Size(305, 30);
            VilleTEXT.TabIndex = 25;
            // 
            // VilleTITLE
            // 
            VilleTITLE.AutoSize = true;
            VilleTITLE.BackColor = Color.White;
            VilleTITLE.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VilleTITLE.ForeColor = Color.Crimson;
            VilleTITLE.Location = new Point(29, 501);
            VilleTITLE.Margin = new Padding(4, 0, 4, 0);
            VilleTITLE.Name = "VilleTITLE";
            VilleTITLE.Size = new Size(55, 26);
            VilleTITLE.TabIndex = 24;
            VilleTITLE.Text = "Ville";
            // 
            // AdresseTEXT
            // 
            AdresseTEXT.AccessibleName = "";
            AdresseTEXT.BorderStyle = BorderStyle.FixedSingle;
            AdresseTEXT.Location = new Point(29, 437);
            AdresseTEXT.Multiline = true;
            AdresseTEXT.Name = "AdresseTEXT";
            AdresseTEXT.Size = new Size(305, 30);
            AdresseTEXT.TabIndex = 24;
            // 
            // AdresseTITLE
            // 
            AdresseTITLE.AutoSize = true;
            AdresseTITLE.BackColor = Color.White;
            AdresseTITLE.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdresseTITLE.ForeColor = Color.Crimson;
            AdresseTITLE.Location = new Point(29, 396);
            AdresseTITLE.Margin = new Padding(4, 0, 4, 0);
            AdresseTITLE.Name = "AdresseTITLE";
            AdresseTITLE.Size = new Size(86, 26);
            AdresseTITLE.TabIndex = 22;
            AdresseTITLE.Text = "Adresse";
            // 
            // MdpTEXT
            // 
            MdpTEXT.AccessibleName = "";
            MdpTEXT.BorderStyle = BorderStyle.FixedSingle;
            MdpTEXT.Location = new Point(29, 142);
            MdpTEXT.Multiline = true;
            MdpTEXT.Name = "MdpTEXT";
            MdpTEXT.Size = new Size(305, 30);
            MdpTEXT.TabIndex = 21;
            // 
            // EmailTEXT
            // 
            EmailTEXT.AccessibleName = "";
            EmailTEXT.BorderStyle = BorderStyle.FixedSingle;
            EmailTEXT.Location = new Point(29, 50);
            EmailTEXT.Multiline = true;
            EmailTEXT.Name = "EmailTEXT";
            EmailTEXT.Size = new Size(305, 30);
            EmailTEXT.TabIndex = 20;
            // 
            // MdpTITLE
            // 
            MdpTITLE.AutoSize = true;
            MdpTITLE.BackColor = Color.White;
            MdpTITLE.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MdpTITLE.ForeColor = Color.Crimson;
            MdpTITLE.Location = new Point(29, 104);
            MdpTITLE.Margin = new Padding(4, 0, 4, 0);
            MdpTITLE.Name = "MdpTITLE";
            MdpTITLE.Size = new Size(134, 26);
            MdpTITLE.TabIndex = 19;
            MdpTITLE.Text = "Mot de Passe";
            // 
            // EmailTITLE
            // 
            EmailTITLE.AutoSize = true;
            EmailTITLE.BackColor = Color.White;
            EmailTITLE.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailTITLE.ForeColor = Color.Crimson;
            EmailTITLE.Location = new Point(29, 11);
            EmailTITLE.Margin = new Padding(4, 0, 4, 0);
            EmailTITLE.Name = "EmailTITLE";
            EmailTITLE.Size = new Size(65, 26);
            EmailTITLE.TabIndex = 18;
            EmailTITLE.Text = "Email";
            // 
            // Inscription
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(495, 597);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(btnCONNEXION);
            Controls.Add(btnINSCRIPTION);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Inscription";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscription";
            Load += Inscription_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private Panel panel1;
        private Label label2;
        private Button btnCONNEXION;
        private Button btnINSCRIPTION;
        private Panel panel3;
        private TextBox textBox1;
        private Label AdresseTITLE;
        private TextBox NomTEXT;
        private TextBox textBoxUsername;
        private Label MdpTITLE;
        private Label EmailTITLE;
        private TextBox textBox5;
        private Label PaysTITLE;
        private TextBox textBox4;
        private Label EtatTITLE;
        private TextBox textBox3;
        private Label CodePostalTITLE;
        private TextBox textBox2;
        private Label VilleTITLE;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label NomTITLE;
        private Label PrénomTITLE;
        private TextBox PrénomText;
        private TextBox textBoxPays;
        private TextBox CodePostalTEXT;
        private TextBox EtatTEXT;
        private TextBox VilleTEXT;
        private TextBox AdresseTEXT;
        private TextBox MdpTEXT;
        private TextBox EmailTEXT;
        private TextBox PaysTEXT;
    }
}