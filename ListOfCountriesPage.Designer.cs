namespace VisitedCountries
{
    partial class ListOfCountriesPage
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
            this.CountryListView = new MaterialSkin.Controls.MaterialListView();
            this.Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // CountryListView
            // 
            this.CountryListView.AutoSizeTable = false;
            this.CountryListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CountryListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CountryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Index,
            this.Country,
            this.Date});
            this.CountryListView.Depth = 0;
            this.CountryListView.FullRowSelect = true;
            this.CountryListView.GridLines = true;
            this.CountryListView.HideSelection = false;
            this.CountryListView.Location = new System.Drawing.Point(100, 80);
            this.CountryListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.CountryListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CountryListView.MouseState = MaterialSkin.MouseState.OUT;
            this.CountryListView.Name = "materialListView1";
            this.CountryListView.OwnerDraw = true;
            this.CountryListView.Size = new System.Drawing.Size(600, 300);
            this.CountryListView.TabIndex = 0;
            this.CountryListView.UseCompatibleStateImageBehavior = false;
            this.CountryListView.View = System.Windows.Forms.View.Details;
            // 
            // Index
            // 
            this.Index.Text = "Index";
            this.Index.Width = 100;
            // 
            // Country
            // 
            this.Country.Text = "Country";
            this.Country.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Country.Width = 200;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Date.Width = 300;
            // 
            // ListOfCountriesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CountryListView);
            this.Name = "ListOfCountriesPage";
            this.Text = "ListOfCountries";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView CountryListView;
        private System.Windows.Forms.ColumnHeader Index;
        private System.Windows.Forms.ColumnHeader Country;
        private System.Windows.Forms.ColumnHeader Date;
    }
}