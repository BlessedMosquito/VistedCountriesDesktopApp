﻿using System;
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

        /*private void LoadData()
        {
            try
            {
                DatabaseManager.Instance.Adapter.Fill(dataSet.Countries);
                dataGridView1.DataSource = dataSet.Countries;
                System.Console.WriteLine("Table refreshed");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured while loading data: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        private async void SearchButtonClick(object sender, EventArgs e)
        {
            string countryName = CountryNameTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(countryName))
            {
                MessageBox.Show("Enter country name!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var country = await APIQuery.Instance.SearchCountryByNameAsync(countryName);

                if (country != null)
                {
                    CountryInformationPage page = new CountryInformationPage(country);
                    page.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Could not  find given country!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error has occured: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CountryNameTextBox.Clear();
            
        }

        private void QuitTabPageEnter(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit application?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LoadDataToTable(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'visitedCountriesDBDataSet.Countries' . Możesz go przenieść lub usunąć.
            this.countriesTableAdapter.Fill(this.visitedCountriesDBDataSet.Countries);

        }

        private void CalculateArea(object sender, EventArgs e)
        {
            const long TOTAL_AREA = 148_000_000; // 148 mln km^2
            var data = this.countriesTableAdapter.GetData();

            HashSet<KeyValuePair<string, int>> countries = new HashSet<KeyValuePair<string, int>>(
                data.Select(row => new KeyValuePair<string, int>(row.NAME, row.AREA))
            );

            long total = countries.Sum(x => x.Value);

            double percentage = (double)total / TOTAL_AREA * 100;

            string information = $"You have seen: {percentage:F2}% of the world :)";


            label1.Text = information;


        }

    }
}
