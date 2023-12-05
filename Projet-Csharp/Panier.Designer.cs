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
            panel1 = new Panel();
            deconnexion2 = new Button();
            compte2 = new Button();
            panier2 = new Button();
            produit2 = new Button();
            pictureBox5 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            button5 = new Button();
            button1 = new Button();
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
            panel1.Controls.Add(deconnexion2);
            panel1.Controls.Add(compte2);
            panel1.Controls.Add(panier2);
            panel1.Controls.Add(produit2);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(196, 582);
            panel1.TabIndex = 1;
            // 
            // deconnexion2
            // 
            deconnexion2.Location = new Point(50, 511);
            deconnexion2.Name = "deconnexion2";
            deconnexion2.Size = new Size(125, 29);
            deconnexion2.TabIndex = 11;
            deconnexion2.Text = "Déconnexion";
            deconnexion2.UseVisualStyleBackColor = true;
            deconnexion2.Click += deconnexion_click;
            // 
            // compte2
            // 
            compte2.Location = new Point(50, 421);
            compte2.Name = "compte2";
            compte2.Size = new Size(125, 29);
            compte2.TabIndex = 10;
            compte2.Text = "Mon Compte";
            compte2.UseVisualStyleBackColor = true;
            compte2.Click += compte_click;
            // 
            // panier2
            // 
            panier2.Location = new Point(50, 279);
            panier2.Name = "panier2";
            panier2.Size = new Size(125, 29);
            panier2.TabIndex = 9;
            panier2.Text = "Mon Panier";
            panier2.UseVisualStyleBackColor = true;
            // 
            // produit2
            // 
            produit2.Location = new Point(50, 167);
            produit2.Name = "produit2";
            produit2.Size = new Size(125, 29);
            produit2.TabIndex = 1;
            produit2.Text = "Les Produits";
            produit2.UseVisualStyleBackColor = true;
            produit2.Click += produit_click;
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
            textBox1.Location = new Point(596, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 21);
            textBox1.TabIndex = 2;
            textBox1.Text = "MON PANIER";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Location = new Point(912, 530);
            button5.Name = "button5";
            button5.Size = new Size(203, 40);
            button5.TabIndex = 16;
            button5.Text = "PASSER COMMANDE";
            button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(668, 530);
            button1.Name = "button1";
            button1.Size = new Size(221, 40);
            button1.TabIndex = 17;
            button1.Text = "SUPPRIMER DU PANIER";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox4);
            panel2.Location = new Point(269, 119);
            panel2.Name = "panel2";
            panel2.Size = new Size(786, 362);
            panel2.TabIndex = 28;
            // 
            // textBox7
            // 
            textBox7.AccessibleName = "";
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Location = new Point(689, 0);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(97, 28);
            textBox7.TabIndex = 30;
            textBox7.Text = "PRIX";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.AccessibleName = "";
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(567, 0);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(116, 28);
            textBox6.TabIndex = 29;
            textBox6.Text = "QUANTITE";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.AccessibleName = "";
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(228, 0);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(333, 28);
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
            textBox4.Size = new Size(222, 28);
            textBox4.TabIndex = 27;
            textBox4.Text = "Nom";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // Panier
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1130, 582);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Panier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panier";
            Load += Panier_Load;
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
        private Button deconnexion2;
        private Button compte2;
        private Button panier2;
        private Button produit2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button button5;
        private Button button1;
        private Panel panel2;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
    }
}