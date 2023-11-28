namespace Projet_Csharp
{
    partial class Connexion
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
            label5 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            panel2.SuspendLayout();
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
            label1.Size = new Size(146, 26);
            label1.TabIndex = 0;
            label1.Text = "CONNEXION";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(218, 491);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 19);
            label5.TabIndex = 20;
            label5.Text = "Admin";
            label5.Click += V_Admin;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(495, 80);
            panel2.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 533);
            panel1.Name = "panel1";
            panel1.Size = new Size(495, 49);
            panel1.TabIndex = 18;
            // 
            // textBoxPassword
            // 
            textBoxPassword.AccessibleName = "";
            textBoxPassword.Location = new Point(63, 250);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(305, 28);
            textBoxPassword.TabIndex = 17;
            // 
            // textBoxUsername
            // 
            textBoxUsername.AccessibleName = "";
            textBoxUsername.Location = new Point(63, 152);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(305, 28);
            textBoxUsername.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(63, 212);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(134, 26);
            label4.TabIndex = 15;
            label4.Text = "Mot de Passe";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(63, 113);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(174, 26);
            label3.TabIndex = 14;
            label3.Text = "Nom d'Utilisateur";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(216, 403);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 13;
            label2.Text = "ou sinon";
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.System;
            button2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Crimson;
            button2.Location = new Point(175, 427);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(131, 30);
            button2.TabIndex = 11;
            button2.Text = "Inscription";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Button_inscription;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(148, 329);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(190, 41);
            button1.TabIndex = 12;
            button1.Text = "Se Connecter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button_connexion;
            // 
            // Connexion
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(495, 582);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Connexion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Connexion";
            Load += Connexion_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label5;
        private Panel panel2;
        private Panel panel1;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button button1;
    }
}