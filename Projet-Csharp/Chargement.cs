namespace Projet_Csharp
{
    public partial class Chargement : Form
    {

        private const int MAX_PROGRESS = 1000; // Maximum de la barre de progression
        private const int LOAD_TIME_IN_SECONDS = 5; // Temps de chargement simulé en secondes
        private const int TIMER_INTERVAL = 40; // Intervalle du timer en millisecondes

        public Chargement()
        {
            InitializeComponent();
            timer1.Interval = TIMER_INTERVAL; // Définit l'intervalle du timer
            progressBar1.Maximum = MAX_PROGRESS; // Définit le maximum de la barre de progression
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10); // Augmente la barre de progression

            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop(); // Arrête le timer une fois le chargement terminé
                RedirigerVersPageConnexion();
            }
        }

        private void RedirigerVersPageConnexion()
        {
            Connexion pageConnexion = new Connexion();
            pageConnexion.Show();
            this.Hide();
        }
    }
}
