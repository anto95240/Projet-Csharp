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
            panel2 = new Panel();
            panel1 = new Panel();
            MdpTEXT = new TextBox();
            EmailTEXT = new TextBox();
            MdpTITLE = new Label();
            EmailTITLE = new Label();
            label2 = new Label();
            btnINSCRIPTION = new Button();
            btnCONNEXIOIN = new Button();
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
            // panel2
            // 
            panel2.BackColor = Color.MediumSeaGreen;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(495, 80);
            panel2.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 508);
            panel1.Name = "panel1";
            panel1.Size = new Size(495, 49);
            panel1.TabIndex = 18;
            // 
            // MdpTEXT
            // 
            MdpTEXT.AccessibleName = "";
            MdpTEXT.BorderStyle = BorderStyle.FixedSingle;
            MdpTEXT.Location = new Point(63, 250);
            MdpTEXT.Multiline = true;
            MdpTEXT.Name = "MdpTEXT";
            MdpTEXT.Size = new Size(305, 30);
            MdpTEXT.TabIndex = 17;
            // 
            // EmailTEXT
            // 
            EmailTEXT.AccessibleName = "";
            EmailTEXT.BorderStyle = BorderStyle.FixedSingle;
            EmailTEXT.Location = new Point(63, 152);
            EmailTEXT.Multiline = true;
            EmailTEXT.Name = "EmailTEXT";
            EmailTEXT.Size = new Size(305, 30);
            EmailTEXT.TabIndex = 16;
            // 
            // MdpTITLE
            // 
            MdpTITLE.AutoSize = true;
            MdpTITLE.BackColor = Color.White;
            MdpTITLE.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MdpTITLE.ForeColor = Color.Crimson;
            MdpTITLE.Location = new Point(63, 212);
            MdpTITLE.Margin = new Padding(4, 0, 4, 0);
            MdpTITLE.Name = "MdpTITLE";
            MdpTITLE.Size = new Size(134, 26);
            MdpTITLE.TabIndex = 15;
            MdpTITLE.Text = "Mot de Passe";
            // 
            // EmailTITLE
            // 
            EmailTITLE.AutoSize = true;
            EmailTITLE.BackColor = Color.White;
            EmailTITLE.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailTITLE.ForeColor = Color.Crimson;
            EmailTITLE.Location = new Point(63, 113);
            EmailTITLE.Margin = new Padding(4, 0, 4, 0);
            EmailTITLE.Name = "EmailTITLE";
            EmailTITLE.Size = new Size(65, 26);
            EmailTITLE.TabIndex = 14;
            EmailTITLE.Text = "Email";
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
            // btnINSCRIPTION
            // 
            btnINSCRIPTION.FlatAppearance.BorderSize = 0;
            btnINSCRIPTION.FlatStyle = FlatStyle.System;
            btnINSCRIPTION.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnINSCRIPTION.ForeColor = Color.Crimson;
            btnINSCRIPTION.Location = new Point(175, 427);
            btnINSCRIPTION.Margin = new Padding(4, 3, 4, 3);
            btnINSCRIPTION.Name = "btnINSCRIPTION";
            btnINSCRIPTION.Size = new Size(131, 30);
            btnINSCRIPTION.TabIndex = 11;
            btnINSCRIPTION.Text = "Inscription";
            btnINSCRIPTION.UseVisualStyleBackColor = false;
            btnINSCRIPTION.Click += Button_inscription;
            // 
            // btnCONNEXIOIN
            // 
            btnCONNEXIOIN.BackColor = Color.SeaGreen;
            btnCONNEXIOIN.FlatAppearance.BorderSize = 0;
            btnCONNEXIOIN.FlatStyle = FlatStyle.Flat;
            btnCONNEXIOIN.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCONNEXIOIN.ForeColor = Color.White;
            btnCONNEXIOIN.Location = new Point(148, 329);
            btnCONNEXIOIN.Margin = new Padding(4, 3, 4, 3);
            btnCONNEXIOIN.Name = "btnCONNEXIOIN";
            btnCONNEXIOIN.Size = new Size(190, 41);
            btnCONNEXIOIN.TabIndex = 12;
            btnCONNEXIOIN.Text = "Se Connecter";
            btnCONNEXIOIN.UseVisualStyleBackColor = false;
            btnCONNEXIOIN.Click += Button_connexion;
            // 
            // Connexion
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(495, 557);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(MdpTEXT);
            Controls.Add(EmailTEXT);
            Controls.Add(MdpTITLE);
            Controls.Add(EmailTITLE);
            Controls.Add(label2);
            Controls.Add(btnINSCRIPTION);
            Controls.Add(btnCONNEXIOIN);
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
        private Panel panel2;
        private Panel panel1;
        private TextBox MdpTEXT;
        private TextBox EmailTEXT;
        private Label MdpTITLE;
        private Label EmailTITLE;
        private Label label2;
        private Button btnINSCRIPTION;
        private Button btnCONNEXIOIN;
    }
}