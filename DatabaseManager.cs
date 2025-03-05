using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using VisitedCountries.VisitedCountriesDBDataSetTableAdapters;

namespace VisitedCountries
{
    public  sealed class DatabaseManager
    {
        private static readonly DatabaseManager _instance;
        
        public VisitedCountriesDBDataSet DataSet { get; private set; }
        public CountriesTableAdapter Adapter { get; private set; }

        private DatabaseManager()
        {
            DataSet = new VisitedCountriesDBDataSet();
            Adapter = new CountriesTableAdapter();
        }

        public static DatabaseManager Instance
        {
            get { return _instance; }
        }
    }
}
