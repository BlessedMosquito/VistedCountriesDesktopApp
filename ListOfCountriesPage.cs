using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace VisitedCountries
{
    public partial class ListOfCountriesPage : MaterialForm
    {
        public ListOfCountriesPage()
        {
            InitializeComponent();
        }

        public void InitList(List<KeyValuePair<Country, DateTime>> _list)
        {
            try
            {
                _list = DatabaseManager.Instance.GetData();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

            CountryListView.Items.Clear();

            //int index;
            string countryName;
            DateTime date;

            foreach(var item in _list)
            {
                CountryListView.Items.Add(Convert.ToString(CountryListView.Items.GetEnumerator().Current));
                CountryListView.Items.Add(countryName = item.Key.Name.Official.ToString());
                CountryListView.Items.Add(Convert.ToString(date = item.Value));
            }
        }

        public void AddToList(List<Country> country, DateTime date)
        {

        }
    }
}
