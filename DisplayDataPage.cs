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
    public partial class DisplayDataPage : MaterialForm
    {
        Country country;
        public DisplayDataPage(Country _country)
        {
            InitializeComponent();
            InitializeMaterialSkin();
            CustomizeUI();
            country = _country;
            CountryInformationTextBox.Text = country.PrintCountry();
            
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

        private void AddDataButtonClick(object sender, EventArgs e)
        {
            try
            {
                DatabaseManager.Instance.AddData(country, DateTimePicker.Value.Date);
            } catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
            System.Console.WriteLine(country.PrintCountry());
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            this.Close();

            MainPage main = Application.OpenForms.OfType<MainPage>().FirstOrDefault();
            if (main != null)
            {
                main.Show();
                main.ClearTextField();
            }
        }
    }
}
