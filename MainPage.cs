using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace VisitedCountries
{
    public partial class MainPage : MaterialForm
    {
        public MainPage()
        {
            InitializeComponent();
            InitializeMaterialSkin();
            CustomizeUI();     
        }

        private void InitializeMaterialSkin()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Blue500,    // Główny kolor
                MaterialSkin.Primary.Blue700,    // Cięższy cień
                MaterialSkin.Primary.BlueGrey500, // Akcent
                MaterialSkin.Accent.LightBlue200,
                MaterialSkin.TextShade.WHITE);
        }
        private void CustomizeUI()
        {
            this.Paint += (s, e) =>
            {
                LinearGradientBrush gradient = new LinearGradientBrush(this.ClientRectangle,
                    Color.FromArgb(3, 169, 244), Color.FromArgb(0, 150, 136), 90F);
                e.Graphics.FillRectangle(gradient, this.ClientRectangle);
            };
        }

        private async void SearchButtonClick(object sender, EventArgs e)
        {
            string countryName = CountryNameTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(countryName))
            {
                MessageBox.Show("Wpisz nazwę kraju!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var country = await APIQuery.Instance.SearchCountryByNameAsync(countryName);

            if (country != null)
            {
                DisplayDataPage page = new DisplayDataPage(country);
                page.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nie znaleziono kraju!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearTextField()
        {
            CountryNameTextBox.Clear();
        }

        private void QuitTabPageEnter(object sender, EventArgs e)
        { 
            Application.Exit();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'visitedCountriesDBDataSet.Countries' . Możesz go przenieść lub usunąć.
            this.countriesTableAdapter.Fill(this.visitedCountriesDBDataSet.Countries);

        }
    }
}
