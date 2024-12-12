using _420DA3_Final_Formatif.Business;
using _420DA3_Final_Formatif.Business.Domain;
using _420DA3_Final_Formatif.DataAccess;
using _420DA3_Final_Formatif.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _420DA3_Final_Formatif.Presentation
{
    internal partial class MainMenu : Form
    {
        private MyApplication myApp;
        public MainMenu(MyApplication myApp)
        {
            this.myApp = myApp;
            this.InitializeComponent();
        }

        private void ActivateCountryActionButtons()
        {
            this.seeDetailsButton.Enabled = true;
            this.updateButton.Enabled = true;
            this.button1.Enabled = true;
        }

        private void DeactivateCountryActionButtons()
        {
            this.seeDetailsButton.Enabled = false;
            this.updateButton.Enabled = false;
            this.button1.Enabled = false;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Country? createdcountry = this.myApp.CountryService.OpenViewFor(ViewAction.Creation);

            if (createdcountry != null)
            {
                this.countryListtBox.Items.Add(createdcountry);
                this.countryListtBox.SelectedItem = createdcountry;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Country? selectedcountry = this.countryListtBox.SelectedItem as Country;

            if (selectedcountry != null)
            {
                _ = this.myApp.CountryService.OpenViewFor(ViewAction.Edition,
              selectedcountry);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Country? selectedcountry = this.countryListtBox.SelectedItem as Country;

            if (selectedcountry != null)
            {
                this.myApp.CountryService.OpenViewFor(ViewAction.Deletion,
                selectedcountry);
            }
        }

        private void seeDetailsButton_Click(object sender, EventArgs e)
        {
            Country? selectedcountry = this.countryListtBox.SelectedItem as Country;

            if (selectedcountry != null)
            {
                this.myApp.CountryService.OpenViewFor(ViewAction.Visualization,
                selectedcountry);
            }
        }

        private void countryListtBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Country? selectedCountry = this.countryListtBox.SelectedItem as Country;

            if (selectedCountry != null)
            {
                this.ActivateCountryActionButtons();
            }
            else
            {
                this.DeactivateCountryActionButtons();
            }
        }

        private void LoadInCountryListBox(List<Country> countries)
        {
            this.countryListtBox.Items.Clear();
            this.countryListtBox.SelectedItem = null;
            this.countryListtBox.SelectedIndex = -1;

            foreach (Country country in countries)
            {
                this.countryListtBox.Items.Add(country);
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string filter = this.searchTextBox.Text.Trim();
            this.LoadInCountryListBox(this.myApp.CountryService.Search(filter));
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
