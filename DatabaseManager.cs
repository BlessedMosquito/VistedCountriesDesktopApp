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

        public List<KeyValuePair<Country, DateTime>> GetData()
        {
            List<KeyValuePair<Country, DateTime>> list = new List<KeyValuePair<Country, DateTime>>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = @"SELECT NAME, CAPITAL, POPULATION, REGION, SUBREGION, Date FROM Countries";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            NameInfo nameInfo = new NameInfo
                            {
                                Official = reader["NAME"].ToString()
                            };

                            List<string> capitals = new List<string> { reader["CAPITAL"].ToString() };

                            Country country = new Country(
                                nameInfo,
                                capitals,
                                Convert.ToInt32(reader["POPULATION"]),
                                reader["REGION"].ToString(),
                                reader["SUBREGION"].ToString()
                            );
                            DateTime date = Convert.ToDateTime(reader["DATE"]);

                            list.Add(new KeyValuePair<Country, DateTime>(country, date));
                        }
                    }
                }
            }

            return list;
        }





    }
}
