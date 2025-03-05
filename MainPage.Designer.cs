
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.SearchButton = new MaterialSkin.Controls.MaterialButton();
            this.CountryNameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.QuitTabPage = new System.Windows.Forms.TabPage();
            this.CountriesTabPage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEGIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AREA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitedCountriesDBDataSet = new VisitedCountries.VisitedCountriesDBDataSet();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.HomeTabPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTabPage = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.countriesTableAdapter = new VisitedCountries.VisitedCountriesDBDataSetTableAdapters.CountriesTableAdapter();
            this.CountriesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitedCountriesDBDataSet)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.HomeTabPage.SuspendLayout();
            this.SearchTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SearchButton.Depth = 0;
            this.SearchButton.HighEmphasis = true;
            this.SearchButton.Icon = null;
            this.SearchButton.Location = new System.Drawing.Point(334, 180);
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
            // CountryNameTextBox
            // 
            this.CountryNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CountryNameTextBox.AnimateReadOnly = false;
            this.CountryNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CountryNameTextBox.Depth = 0;
            this.CountryNameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CountryNameTextBox.Hint = "Enter country name...";
            this.CountryNameTextBox.LeadingIcon = null;
            this.CountryNameTextBox.Location = new System.Drawing.Point(180, 100);
            this.CountryNameTextBox.Margin = new System.Windows.Forms.Padding(100);
            this.CountryNameTextBox.MaxLength = 50;
            this.CountryNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.CountryNameTextBox.Multiline = false;
            this.CountryNameTextBox.Name = "CountryNameTextBox";
            this.CountryNameTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.CountryNameTextBox.Size = new System.Drawing.Size(400, 50);
            this.CountryNameTextBox.TabIndex = 1;
            this.CountryNameTextBox.Text = "";
            this.CountryNameTextBox.TrailingIcon = null;
            // 
            // QuitTabPage
            // 
            this.QuitTabPage.ImageKey = "power_off_icon_195127.png";
            this.QuitTabPage.Location = new System.Drawing.Point(4, 39);
            this.QuitTabPage.Name = "QuitTabPage";
            this.QuitTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.QuitTabPage.Size = new System.Drawing.Size(780, 484);
            this.QuitTabPage.TabIndex = 1;
            this.QuitTabPage.Text = "Quit";
            this.QuitTabPage.UseVisualStyleBackColor = true;
            this.QuitTabPage.Enter += new System.EventHandler(this.QuitTabPageEnter);
            // 
            // CountriesTabPage
            // 
            this.CountriesTabPage.BackColor = System.Drawing.Color.DimGray;
            this.CountriesTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CountriesTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CountriesTabPage.Controls.Add(this.dataGridView1);
            this.CountriesTabPage.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CountriesTabPage.ImageKey = "globe_hemisphere_west_thin_icon_171742.png";
            this.CountriesTabPage.Location = new System.Drawing.Point(4, 39);
            this.CountriesTabPage.Name = "CountriesTabPage";
            this.CountriesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CountriesTabPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CountriesTabPage.Size = new System.Drawing.Size(780, 484);
            this.CountriesTabPage.TabIndex = 0;
            this.CountriesTabPage.Text = "Countries";
            this.CountriesTabPage.UseVisualStyleBackColor = true;
            this.CountriesTabPage.Enter += new System.EventHandler(this.LoadDataToTable);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nAMEDataGridViewTextBoxColumn,
            this.dATEDataGridViewTextBoxColumn,
            this.rEGIONDataGridViewTextBoxColumn,
            this.AREA});
            this.dataGridView1.DataSource = this.countriesBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(6, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(766, 474);
            this.dataGridView1.TabIndex = 0;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.NullValue = null;
            this.nAMEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "Country name";
            this.nAMEDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATEDataGridViewTextBoxColumn
            // 
            this.dATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dATEDataGridViewTextBoxColumn.DataPropertyName = "DATE";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle9.NullValue = null;
            this.dATEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.dATEDataGridViewTextBoxColumn.HeaderText = "Visitation date";
            this.dATEDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.dATEDataGridViewTextBoxColumn.Name = "dATEDataGridViewTextBoxColumn";
            this.dATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rEGIONDataGridViewTextBoxColumn
            // 
            this.rEGIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rEGIONDataGridViewTextBoxColumn.DataPropertyName = "REGION";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle10.NullValue = null;
            this.rEGIONDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.rEGIONDataGridViewTextBoxColumn.HeaderText = "Region";
            this.rEGIONDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.rEGIONDataGridViewTextBoxColumn.Name = "rEGIONDataGridViewTextBoxColumn";
            this.rEGIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AREA
            // 
            this.AREA.DataPropertyName = "AREA";
            this.AREA.HeaderText = "AREA";
            this.AREA.Name = "AREA";
            this.AREA.ReadOnly = true;
            this.AREA.Visible = false;
            // 
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "Countries";
            this.countriesBindingSource.DataSource = this.visitedCountriesDBDataSet;
            // 
            // visitedCountriesDBDataSet
            // 
            this.visitedCountriesDBDataSet.DataSetName = "VisitedCountriesDBDataSet";
            this.visitedCountriesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.HomeTabPage);
            this.materialTabControl1.Controls.Add(this.CountriesTabPage);
            this.materialTabControl1.Controls.Add(this.SearchTabPage);
            this.materialTabControl1.Controls.Add(this.QuitTabPage);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(6, 67);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(820, 527);
            this.materialTabControl1.TabIndex = 3;
            // 
            // HomeTabPage
            // 
            this.HomeTabPage.Controls.Add(this.label2);
            this.HomeTabPage.Controls.Add(this.label1);
            this.HomeTabPage.ImageKey = "home_icon_259667.png";
            this.HomeTabPage.Location = new System.Drawing.Point(4, 39);
            this.HomeTabPage.Name = "HomeTabPage";
            this.HomeTabPage.Size = new System.Drawing.Size(812, 484);
            this.HomeTabPage.TabIndex = 3;
            this.HomeTabPage.Text = "Home";
            this.HomeTabPage.Enter += new System.EventHandler(this.CalculateArea);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(806, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(806, 135);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // SearchTabPage
            // 
            this.SearchTabPage.Controls.Add(this.CountryNameTextBox);
            this.SearchTabPage.Controls.Add(this.SearchButton);
            this.SearchTabPage.ImageKey = "search_icon_259103.png";
            this.SearchTabPage.Location = new System.Drawing.Point(4, 39);
            this.SearchTabPage.Name = "SearchTabPage";
            this.SearchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SearchTabPage.Size = new System.Drawing.Size(780, 484);
            this.SearchTabPage.TabIndex = 2;
            this.SearchTabPage.Text = "Search";
            this.SearchTabPage.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "search_engine_optimization_web_development_icon_260991.png");
            this.imageList1.Images.SetKeyName(1, "earth_globe_planet_icon_149815.ico");
            this.imageList1.Images.SetKeyName(2, "search_icon_259103.png");
            this.imageList1.Images.SetKeyName(3, "home_icon_259667.png");
            this.imageList1.Images.SetKeyName(4, "globe_hemisphere_west_thin_icon_171742.png");
            this.imageList1.Images.SetKeyName(5, "power_off_icon_195127.png");
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 602);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visited Countries 🌍";
            this.Load += new System.EventHandler(this.LoadDataToTable);
            this.CountriesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitedCountriesDBDataSet)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.HomeTabPage.ResumeLayout(false);
            this.SearchTabPage.ResumeLayout(false);
            this.SearchTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        private void HomeTabPage_Enter(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton SearchButton;
        private MaterialSkin.Controls.MaterialTextBox CountryNameTextBox;
        private TabPage QuitTabPage;
        private TabPage CountriesTabPage;
        private MaterialTabControl materialTabControl1;
        private TabPage SearchTabPage;
        private DataGridView dataGridView1;
        private VisitedCountriesDBDataSet visitedCountriesDBDataSet;
        private BindingSource countriesBindingSource;
        private VisitedCountriesDBDataSetTableAdapters.CountriesTableAdapter countriesTableAdapter;
        private TabPage HomeTabPage;
        private ImageList imageList1;
        private DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dATEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rEGIONDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn AREA;
        private Label label1;
        private Label label2;
    }
}

