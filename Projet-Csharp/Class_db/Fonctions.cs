using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projet_Csharp.Class_db
{
    class Fonctions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter Sda;
        internal string ConStr;

        public Fonctions()
        {
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\ANTOINE\github\Projet-Csharp\base de donnée\e-commerce.mdf"";Integrated Security=True";
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

        public int EnvoyerData(string req, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(ConStr))
            {
                using (SqlCommand command = new SqlCommand(req, connection))
                {
                    command.Parameters.AddRange(parameters);

                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }
    }
}
