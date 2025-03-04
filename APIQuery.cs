using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace VisitedCountries
{
    internal sealed class APIQuery
    {
        private static readonly string APIUrl = "https://restcountries.com/v3.1";

        private static readonly APIQuery _instance = new APIQuery();

        private readonly HttpClient _httpClient;
        private APIQuery() 
        {
            _httpClient = new HttpClient();
        }

        public static APIQuery Instance => _instance;

        public async Task<List<Country>> GetAllCountriesAsync()
        {
            string url = $"{APIUrl}/all";

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();
                List<Country> countries = JsonConvert.DeserializeObject<List<Country>>(json);

                return countries;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occured while loading data: {ex.Message}");
                return new List<Country>();
            }
        }

        public async Task<Country> SearchCountryByNameAsync(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return null;

            string url = $"{APIUrl}/name/{Uri.EscapeDataString(name)}";

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();
                List<Country> countries = JsonConvert.DeserializeObject<List<Country>>(json);

                return countries.Count > 0 ? countries[0] : null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd podczas wyszukiwania kraju: {ex.Message}");
                return null;
            }
        }
    }
}
