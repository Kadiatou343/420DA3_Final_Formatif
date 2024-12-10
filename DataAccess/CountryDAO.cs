using _420DA3_Final_Formatif.Business.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Final_Formatif.DataAccess
{
    internal class CountryDAO
    {
        private MyAppDbContext context;

        public CountryDAO(MyAppDbContext context)
        {
            this.context = context;
        }

        public List<Country> Search(string filter)
        {
            return this.context.Countries.Include(c => c.Languages)
                .Where(c => c.ShortName.ToLower().Contains(filter.ToLower()) 
                || c.FullName.ToLower().Contains(filter.ToLower()))
                .ToList();

        }

        public Country CreateCountry(Country country)
        {
            _ = this.context.Countries.Add(country);
            _ = this.context.SaveChanges();

            return country;
        }

        public Country UpdateCountry(Country country)
        {
            _ = this.context.Countries.Update(country);
            _ = this.context.SaveChanges();

            return country;
        }

        public void DeleteCountry(Country country)
        {
            _ = this.context.Countries.Remove(country);
            _ = this.context.SaveChanges();
        }
    }
}
