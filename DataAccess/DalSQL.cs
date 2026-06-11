using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Reisbureau.DataAccess
{
    public class DalSQL
    {
        private string serverName;
        private string databaseName;
        private string connection;

        //Contructor
        public DalSQL(string serverName, string dbName)
        {
            this.serverName = serverName;
            databaseName = dbName;

            connection = $"Server={serverName};Database={databaseName};Trusted_Connection=True;TrustServerCertificate=True;";
        }

        public string OphalenKlant(int id)
        {
            //Query -> Welke data ga je opvragen?
            string query = $"SELECT klantnummer, naam FROM KLANT WHERE Klantnummer = {id}";

            //Variabelen om de gegevens in te stoppen:
            int klantnummer = 0;
            string naam = "";
                              
            using var conn = new SqlConnection(connection);
            using var cmd = new SqlCommand(query, conn);
            conn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                klantnummer = reader.GetInt32(0);
                naam = reader.GetString(1);
            }
            
            return $"klant: {klantnummer}, naam: {naam}";
        }

    }
}

