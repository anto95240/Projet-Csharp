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
            deconnexion1 = new Button();
            compte1 = new Button();
            panier1 = new Button();
            produit1 = new Button();
            pictureBox5 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            modif = new Button();
            ajouter = new Button();
            supprimer = new Button();
            button5 = new Button();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(deconnexion1);
            panel1.Controls.Add(compte1);
            panel1.Controls.Add(panier1);
            panel1.Controls.Add(produit1);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(196, 582);
            panel1.TabIndex = 0;
            // 
            // deconnexion1
            // 
            deconnexion1.Location = new Point(50, 511);
            deconnexion1.Name = "deconnexion1";
            deconnexion1.Size = new Size(125, 29);
            deconnexion1.TabIndex = 11;
            deconnexion1.Text = "Déconnexion";
            deconnexion1.UseVisualStyleBackColor = true;
            deconnexion1.Click += deconnexion_click;
            // 
            // compte1
            // 
            compte1.Location = new Point(50, 421);
            compte1.Name = "compte1";
            compte1.Size = new Size(125, 29);
            compte1.TabIndex = 10;
            compte1.Text = "Mon Compte";
            compte1.UseVisualStyleBackColor = true;
            compte1.Click += compte_click;
            // 
            // panier1
            // 
            panier1.Location = new Point(50, 279);
            panier1.Name = "panier1";
            panier1.Size = new Size(125, 29);
            panier1.TabIndex = 9;
            panier1.Text = "Mon Panier";
            panier1.UseVisualStyleBackColor = true;
            panier1.Click += panier_click;
            // 
            // produit1
            // 
            produit1.Location = new Point(50, 167);
            produit1.Name = "produit1";
            produit1.Size = new Size(125, 29);
            produit1.TabIndex = 1;
            produit1.Text = "Les Produits";
            produit1.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.Location = new Point(16, 512);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(28, 28);
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(12, 165);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.Location = new Point(16, 422);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(28, 28);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.Location = new Point(16, 280);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(28, 28);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(63, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 63);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Times New Roman", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(560, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 21);
            textBox1.TabIndex = 3;
            textBox1.Text = "LISTE DES PRODUITS";
            textBox1.TextAlign = HorizontalAlignment.Center;
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
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Location = new Point(934, 530);
            button5.Name = "button5";
            button5.Size = new Size(184, 40);
            button5.TabIndex = 15;
            button5.Text = "AJOUTER PANIER";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword
            // 
            textBoxPassword.AccessibleName = "";
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Location = new Point(341, 165);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.ScrollBars = ScrollBars.Vertical;
            textBoxPassword.Size = new Size(160, 75);
            textBoxPassword.TabIndex = 21;
            // 
            // textBoxUsername
            // 
            textBoxUsername.AccessibleName = "";
            textBoxUsername.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsername.Location = new Point(299, 110);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(202, 28);
            textBoxUsername.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(214, 166);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(119, 26);
            label4.TabIndex = 19;
            label4.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(214, 110);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 26);
            label3.TabIndex = 18;
            label3.Text = "Nom";
            // 
            // textBox2
            // 
            textBox2.AccessibleName = "";
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(299, 328);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(202, 28);
            textBox2.TabIndex = 25;
            // 
            // textBox3
            // 
            textBox3.AccessibleName = "";
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(341, 261);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(160, 28);
            textBox3.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(214, 328);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 26);
            label1.TabIndex = 23;
            label1.Text = "Prix";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(214, 263);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 26);
            label2.TabIndex = 22;
            label2.Text = "Quantité";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox4);
            panel2.Location = new Point(526, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(591, 362);
            panel2.TabIndex = 26;
            // 
            // textBox7
            // 
            textBox7.AccessibleName = "";
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Location = new Point(498, 0);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(93, 28);
            textBox7.TabIndex = 30;
            textBox7.Text = "PRIX";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.AccessibleName = "";
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(377, 0);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(115, 28);
            textBox6.TabIndex = 29;
            textBox6.Text = "QUANTITE";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.AccessibleName = "";
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(129, 0);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(242, 28);
            textBox5.TabIndex = 28;
            textBox5.Text = "DESCRIPTION";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.AccessibleName = "";
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(0, 0);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(123, 28);
            textBox4.TabIndex = 27;
            textBox4.Text = "Nom";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // Accueil
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1130, 582);
            Controls.Add(panel2);
            Controls.Add(textBoxPassword);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBoxUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button5);
            Controls.Add(supprimer);
            Controls.Add(ajouter);
            Controls.Add(modif);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Accueil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Accueil";
            Load += Accueil_Load_1;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Button panier1;
        private Button produit1;
        private Button deconnexion1;
        private Button compte1;
        private TextBox textBox1;
        private Button modif;
        private Button ajouter;
        private Button supprimer;
        private Button button5;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private TextBox textBox4;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
    }
}