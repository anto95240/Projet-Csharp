namespace Projet_Csharp
{
    public partial class Chargement : Form
    {

        private const int MAX_PROGRESS = 1000; // Maximum de la barre de progression
        private const int LOAD_TIME_IN_SECONDS = 5; // Temps de chargement simul� en secondes
        private const int TIMER_INTERVAL = 40; // Intervalle du timer en millisecondes

        public Chargement()
        {
            InitializeComponent();
            timer1.Interval = TIMER_INTERVAL; // D�finit l'intervalle du timer
            ProgressBar.Maximum = MAX_PROGRESS; // D�finit le maximum de la barre de progression
            
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            ProgressBar.Increment(10); // Augmente la barre de progression



            if (ProgressBar.Value >= ProgressBar.Maximum)
            {
                timer1.Stop(); // Arr�te le timer une fois le chargement termin�
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
