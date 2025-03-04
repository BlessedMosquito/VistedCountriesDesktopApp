using MaterialSkin;
using MaterialSkin.Controls;

namespace VisitedCountries
{
    partial class DisplayDataPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CountryInformationTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddDataButton = new MaterialSkin.Controls.MaterialButton();
            this.InformationLabel = new MaterialSkin.Controls.MaterialLabel();
            this.BackButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // CountryInformationTextBox
            // 
            this.CountryInformationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CountryInformationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CountryInformationTextBox.Depth = 0;
            this.CountryInformationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CountryInformationTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CountryInformationTextBox.Location = new System.Drawing.Point(46, 182);
            this.CountryInformationTextBox.MaxLength = 100;
            this.CountryInformationTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.CountryInformationTextBox.Name = "CountryInformationTextBox";
            this.CountryInformationTextBox.Size = new System.Drawing.Size(250, 161);
            this.CountryInformationTextBox.TabIndex = 0;
            this.CountryInformationTextBox.Text = "";
            this.CountryInformationTextBox.ReadOnly = true;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(330, 200);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DateTimePicker.TabIndex = 1;
            // 
            // AddDataButton
            // 
            this.AddDataButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddDataButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddDataButton.Depth = 0;
            this.AddDataButton.HighEmphasis = true;
            this.AddDataButton.Icon = null;
            this.AddDataButton.Location = new System.Drawing.Point(560, 196);
            this.AddDataButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddDataButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddDataButton.Name = "AddDataButton";
            this.AddDataButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddDataButton.Size = new System.Drawing.Size(178, 36);
            this.AddDataButton.TabIndex = 2;
            this.AddDataButton.Text = "Add Visited Country";
            this.AddDataButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddDataButton.UseAccentColor = true;
            this.AddDataButton.UseVisualStyleBackColor = true;
            this.AddDataButton.Click += new System.EventHandler(this.AddDataButtonClick);
            // 
            // InformationLabel
            // 
            this.InformationLabel.AutoSize = true;
            this.InformationLabel.Depth = 0;
            this.InformationLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.InformationLabel.Location = new System.Drawing.Point(77, 160);
            this.InformationLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(186, 19);
            this.InformationLabel.TabIndex = 3;
            this.InformationLabel.Text = "Inforamtion about country";
            // 
            // BackButton
            // 
            this.BackButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BackButton.Depth = 0;
            this.BackButton.HighEmphasis = true;
            this.BackButton.Icon = null;
            this.BackButton.Location = new System.Drawing.Point(369, 344);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BackButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BackButton.Name = "BackButton";
            this.BackButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BackButton.Size = new System.Drawing.Size(64, 36);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "BACK";
            this.BackButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BackButton.UseAccentColor = true;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // DisplayDataPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.InformationLabel);
            this.Controls.Add(this.AddDataButton);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.CountryInformationTextBox);
            this.Name = "DisplayDataPage";
            this.Text = "Add country to your visited list";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialMultiLineTextBox CountryInformationTextBox;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private MaterialSkin.Controls.MaterialButton AddDataButton;
        private MaterialSkin.Controls.MaterialLabel InformationLabel;
        private MaterialSkin.Controls.MaterialButton BackButton;
    }
}