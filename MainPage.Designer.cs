﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.SearchButton = new MaterialSkin.Controls.MaterialButton();
            this.CountryNameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.QuitTabPage = new System.Windows.Forms.TabPage();
            this.CountriesTabPage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitedCountriesDBDataSet = new VisitedCountries.VisitedCountriesDBDataSet();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.HomeTabPage = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SearchTabPage = new System.Windows.Forms.TabPage();
            this.countriesTableAdapter = new VisitedCountries.VisitedCountriesDBDataSetTableAdapters.CountriesTableAdapter();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEGIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.QuitTabPage.Location = new System.Drawing.Point(4, 22);
            this.QuitTabPage.Name = "QuitTabPage";
            this.QuitTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.QuitTabPage.Size = new System.Drawing.Size(780, 474);
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
            this.CountriesTabPage.Location = new System.Drawing.Point(4, 22);
            this.CountriesTabPage.Name = "CountriesTabPage";
            this.CountriesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CountriesTabPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CountriesTabPage.Size = new System.Drawing.Size(780, 501);
            this.CountriesTabPage.TabIndex = 0;
            this.CountriesTabPage.Text = "Countries";
            this.CountriesTabPage.UseVisualStyleBackColor = true;
            this.CountriesTabPage.Enter += new System.EventHandler(this.LoadDataToTable);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nAMEDataGridViewTextBoxColumn,
            this.dATEDataGridViewTextBoxColumn,
            this.rEGIONDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.countriesBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(6, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(766, 491);
            this.dataGridView1.TabIndex = 0;
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
            this.materialTabControl1.Location = new System.Drawing.Point(6, 67);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(788, 527);
            this.materialTabControl1.TabIndex = 3;
            // 
            // HomeTabPage
            // 
            this.HomeTabPage.Controls.Add(this.materialLabel1);
            this.HomeTabPage.Location = new System.Drawing.Point(4, 22);
            this.HomeTabPage.Name = "HomeTabPage";
            this.HomeTabPage.Size = new System.Drawing.Size(780, 501);
            this.HomeTabPage.TabIndex = 3;
            this.HomeTabPage.Text = "Home";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(329, 50);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(300, 50, 300, 50);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(81, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Welcome!\r\n";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SearchTabPage
            // 
            this.SearchTabPage.Controls.Add(this.CountryNameTextBox);
            this.SearchTabPage.Controls.Add(this.SearchButton);
            this.SearchTabPage.Location = new System.Drawing.Point(4, 22);
            this.SearchTabPage.Name = "SearchTabPage";
            this.SearchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SearchTabPage.Size = new System.Drawing.Size(780, 474);
            this.SearchTabPage.TabIndex = 2;
            this.SearchTabPage.Text = "Search";
            this.SearchTabPage.UseVisualStyleBackColor = true;
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.NullValue = null;
            this.nAMEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "Country name";
            this.nAMEDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATEDataGridViewTextBoxColumn
            // 
            this.dATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dATEDataGridViewTextBoxColumn.DataPropertyName = "DATE";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.NullValue = null;
            this.dATEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.dATEDataGridViewTextBoxColumn.HeaderText = "Visitation date";
            this.dATEDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.dATEDataGridViewTextBoxColumn.Name = "dATEDataGridViewTextBoxColumn";
            this.dATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rEGIONDataGridViewTextBoxColumn
            // 
            this.rEGIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rEGIONDataGridViewTextBoxColumn.DataPropertyName = "REGION";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.NullValue = null;
            this.rEGIONDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.rEGIONDataGridViewTextBoxColumn.HeaderText = "Region";
            this.rEGIONDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.rEGIONDataGridViewTextBoxColumn.Name = "rEGIONDataGridViewTextBoxColumn";
            this.rEGIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visited Countries";
            this.Load += new System.EventHandler(this.LoadDataToTable);
            this.CountriesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitedCountriesDBDataSet)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.HomeTabPage.ResumeLayout(false);
            this.HomeTabPage.PerformLayout();
            this.SearchTabPage.ResumeLayout(false);
            this.SearchTabPage.PerformLayout();
            this.ResumeLayout(false);

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
        private MaterialLabel materialLabel1;
        private DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dATEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rEGIONDataGridViewTextBoxColumn;
    }
}

