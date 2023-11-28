namespace Projet_Csharp
{
    partial class Chargement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chargement));
            label1 = new Label();
            progressBar1 = new ProgressBar();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(237, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 23);
            label1.TabIndex = 0;
            label1.Text = "Gestion de stock";
            label1.Click += label1_Click;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = SystemColors.Window;
            progressBar1.Location = new Point(76, 268);
            progressBar1.Name = "progressBar1";
            progressBar1.RightToLeft = RightToLeft.No;
            progressBar1.Size = new Size(459, 16);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 4;
            progressBar1.Click += progressBar1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(224, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 165);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_2;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Crimson;
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(183, 302);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(268, 19);
            label2.TabIndex = 5;
            label2.Text = "Créer par Antoine, Yvenlee, Amadis";
            // 
            // Chargement
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(621, 343);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Chargement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chargement";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar progressBar1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
    }
}
