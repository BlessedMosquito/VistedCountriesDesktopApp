using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace VisitedCountries
{
    public class DatabaseManager
    {
        private static DatabaseManager _instance;
        private static readonly object _lock = new object();
        private readonly string _connectionString;


        private DatabaseManager()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["VisitedCountriesDB"].ConnectionString;
        }

        public static DatabaseManager Instance
        {
            get
            {
                lock (_lock) // Zapewnia bezpieczeństwo wielowątkowe
                {
                    if (_instance == null)
                    {
                        _instance = new DatabaseManager();
                    }
                    return _instance;
                }
            }
        }

        //TODO: Zmienic aby odpwiadała zmianom w Counry będzie kilka tabeli z relacją do tabeli COuntires lub przechowywanie JSONA w bazie
        public void AddData(Country country, DateTime date)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO Countries 
                         (NAME, CAPITAL, POPULATION, REGION, SUBREGION, Date) 
                         VALUES 
                         (@Name, @Capital, @Population, @Region, @Subregion, @Date)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Dodajemy parametry zapytania
                    string capital = country.CapitalListToString();

                    
                    cmd.Parameters.AddWithValue("@Name", country.Name.Official);
                    cmd.Parameters.AddWithValue("@Capital", capital);
                    cmd.Parameters.AddWithValue("@Population", country.Population);
                    cmd.Parameters.AddWithValue("@Region", country.Region);
                    cmd.Parameters.AddWithValue("@Subregion", country.SubRegion);
                    cmd.Parameters.AddWithValue("@Date", date);

                    // Otwieramy połączenie
                    con.Open();

                    // Wykonujemy zapytanie
                    cmd.ExecuteNonQuery();
                }
            }
        }



    }
}
