using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Projet_Csharp
{
    class Fonctions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter Sda;
        private string ConStr;

        public Fonctions()
        {
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\richa\Documents\e-commerce.mdf;Integrated Security=True;Connect Timeout=30;";
            Con = new SqlConnection(ConStr);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
        }

        public DataTable RecupererData(string Req)
        {
            dt = new DataTable();
            Sda = new SqlDataAdapter(Req, ConStr); // Utilisation de la connexion Con, pas ConStr
            Sda.Fill(dt);
            return dt;
        }

        public int EnvoyerData(string Req)
        {
            int Cnt = 0;
            
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            Cmd.CommandText = Req;
            Cnt = Cmd.ExecuteNonQuery();
            Con.Close();
            // Utilisation de 'using' pour s'assurer que la connexion est fermée
            return Cnt;
        }
    }
}
