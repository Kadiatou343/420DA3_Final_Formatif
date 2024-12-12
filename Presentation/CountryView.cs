using _420DA3_Final_Formatif.Business;
using _420DA3_Final_Formatif.Business.Domain;
using _420DA3_Final_Formatif.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _420DA3_Final_Formatif.Presentation
{
    internal partial class CountryView : Form
    {
        private MyApplication myApp;
        private Country currentCountry = null!;
        private ViewAction action;
        private bool isInialized = false;
        public CountryView(MyApplication myApp)
        {
            this.myApp = myApp;
            this.InitializeComponent();
            this.shortNameTextBox.MaxLength = Country.SHORT_NAME_MAX_LENGTH;
            this.fullNameTextBox.MaxLength = Country.FULL_NAME_MAX_LENGTH;
        }

        public Country GetCurrentCountry()
        {
            return this.currentCountry;
        }

        private void EnableEditableControls()
        {
            this.shortNameTextBox.Enabled = true;
            this.fullNameTextBox.Enabled = true;
            this.langageListbox.Enabled = true;
        }

        private void DisableEditableControls()
        {
            this.shortNameTextBox.Enabled = false;
            this.fullNameTextBox.Enabled = false;
            //this.langageListbox.Enabled = false;
        }

        private void LoadInstanceInControls(Country country)
        {
            if (country is not null) 
            {
                this.idNumUpDown.Value = country.Id;
                this.shortNameTextBox.Text = country.ShortName;
                this.fullNameTextBox.Text = country.FullName;

                this.langageListbox.SelectedItem = null;
                this.langageListbox.SelectedIndex = -1;
                this.langageListbox.SelectedItems.Clear();

                foreach (Language lan in country.Languages)
                {
                    this.langageListbox.SelectedItems.Add(lan);
                }
            }
        }

        public DialogResult OpenFor(ViewAction action, Country country)
        {
            this.action = action;
            this.LoadInstanceInControls(country);
            switch (action)
            {
                case ViewAction.Creation:
                    this.InitializeLanguages();
                    this.viewModeLabel.Text = "Creation";
                    this.actionButton.Text = "Créer";
                    this.EnableEditableControls();
                    break;
                case ViewAction.Visualization:
                    this.InitializeLanguages();
                    this.viewModeLabel.Text = "Visualisation";
                    this.actionButton.Text = "OK";
                    this.DisableEditableControls();
                    break;
                case ViewAction.Edition:
                    this.InitializeLanguages();
                    this.viewModeLabel.Text = "Modification";
                    this.actionButton.Text = "Modifier";
                    this.EnableEditableControls();
                    break;
                case ViewAction.Deletion:
                    this.InitializeLanguages();
                    this.viewModeLabel.Text = "Suppression";
                    this.actionButton.Text = "Supprimer";
                    this.DisableEditableControls();
                    break;
                default:
                    throw new Exception($"View action [{this.action}] unkmown");
            }

            return this.ShowDialog();
        }

        private void InitializeLanguages()
        {
            if (!this.isInialized)
            {
                List<Language> languages = this.myApp.LanguageService.GetAll();
                foreach (Language language in languages)
                {
                    this.langageListbox.Items.Add(language);
                }
                isInialized = true;
            }
        }

        public void ProcessAction()
        {
            switch (this.action)
            {
                case ViewAction.Creation:
                    Country newCountry = new Country();

                    newCountry.ShortName = this.shortNameTextBox.Text.Trim();
                    newCountry.FullName = this.fullNameTextBox.Text.Trim();

                    newCountry.Languages = this.langageListbox.SelectedItems.Cast<Language>().ToList();

                    this.currentCountry = this.myApp.CountryService.Create(newCountry);

                    break;
                case ViewAction.Visualization:
                    break;
                case ViewAction.Edition:
                    this.currentCountry.ShortName = this.shortNameTextBox.Text.Trim();
                    this.currentCountry.FullName = this.fullNameTextBox.Text.Trim();

                    this.currentCountry.Languages.Clear();

                    this.currentCountry.Languages = this.langageListbox.SelectedItems.Cast<Language>().ToList();

                    this.currentCountry = this.myApp.CountryService.Update(this.currentCountry);

                    break;
                case ViewAction.Deletion:
                    this.myApp.CountryService.Delete(this.currentCountry);
                    this.currentCountry = new Country();
                    break;
                default:
                    throw new Exception($"View action [{action}] unkmown");
            }
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ProcessAction();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }
    }
}
