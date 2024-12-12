using _420DA3_Final_Formatif.Business.Domain;
using _420DA3_Final_Formatif.DataAccess;
using _420DA3_Final_Formatif.Presentation;
using _420DA3_Final_Formatif.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Final_Formatif.Business.Services
{
    internal class CountryService
    {
        private CountryDAO dao;
        private CountryView view;

        public CountryService(MyAppDbContext context, MyApplication myapp)
        {
            this.dao = new CountryDAO(context);
            this.view = new CountryView(myapp);
        }

        public Country Create(Country country)
        {
            return this.dao.CreateCountry(country);
        }

        public Country Update(Country country)
        {
            return this.dao.UpdateCountry(country);
        }

        public void Delete(Country country)
        {
            this.dao.DeleteCountry(country);
        }

        public List<Country> Search(string filter)
        {
            return this.dao.Search(filter);
        }

        public Country? OpenViewFor(ViewAction action, Country country = null!)
        {
            try
            {
                DialogResult result = this.view.OpenFor(action, country);
                if (result == DialogResult.OK)
                {
                    switch (action)
                    {
                        case ViewAction.Creation:
                        case ViewAction.Edition:
                            _ = this.OpenViewFor(ViewAction.Visualization, this.view.GetCurrentCountry());
                            break;
                    }
                }
                return this.view.GetCurrentCountry();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
