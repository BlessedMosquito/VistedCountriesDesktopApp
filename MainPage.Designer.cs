
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace VisitedCountries
{
    partial class MainPage
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.SearchButton = new MaterialSkin.Controls.MaterialButton();
            this.ListOfCountiresButton = new MaterialSkin.Controls.MaterialButton();
            this.CountryNameTextBox = new MaterialSkin.Controls.MaterialTextBox();


            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SearchButton.Depth = 0;
            this.SearchButton.HighEmphasis = true;
            this.SearchButton.Icon = null;
            this.SearchButton.Location = new System.Drawing.Point(270, 230);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(20);
            this.SearchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SearchButton.Size = new System.Drawing.Size(78, 36);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SearchButton.UseAccentColor = true;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButtonClick);
            // 
            // ListOfCountiresButton
            // 
            this.ListOfCountiresButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ListOfCountiresButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ListOfCountiresButton.Depth = 0;
            this.ListOfCountiresButton.HighEmphasis = true;
            this.ListOfCountiresButton.Icon = null;
            this.ListOfCountiresButton.Location = new System.Drawing.Point(225, 300);
            this.ListOfCountiresButton.Margin = new System.Windows.Forms.Padding(20);
            this.ListOfCountiresButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ListOfCountiresButton.Name = "ListOfCountiresButton";
            this.ListOfCountiresButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ListOfCountiresButton.Size = new System.Drawing.Size(156, 36);
            this.ListOfCountiresButton.TabIndex = 2;
            this.ListOfCountiresButton.Text = "List of countries";
            this.ListOfCountiresButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ListOfCountiresButton.UseAccentColor = true;
            this.ListOfCountiresButton.Click += new System.EventHandler(this.ListOfCountiresButton_Click);
            // 
            // CountryNameTextBox
            // 
            this.CountryNameTextBox.AnimateReadOnly = false;
            this.CountryNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CountryNameTextBox.Depth = 0;
            this.CountryNameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CountryNameTextBox.Hint = "Enter country name...";
            this.CountryNameTextBox.LeadingIcon = null;
            this.CountryNameTextBox.Location = new System.Drawing.Point(150, 120);
            this.CountryNameTextBox.MaxLength = 50;
            this.CountryNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.CountryNameTextBox.Multiline = false;
            this.CountryNameTextBox.Name = "CountryNameTextBox";
            this.CountryNameTextBox.Size = new System.Drawing.Size(300, 50);
            this.CountryNameTextBox.TabIndex = 1;
            this.CountryNameTextBox.Text = "";
            this.CountryNameTextBox.TrailingIcon = null;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 439);
            this.Controls.Add(this.CountryNameTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ListOfCountiresButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visited Countries";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton SearchButton;
        private MaterialSkin.Controls.MaterialButton ListOfCountiresButton;
        private MaterialSkin.Controls.MaterialTextBox CountryNameTextBox;
        private MaterialDrawer materialDrawer1;
    }
}

