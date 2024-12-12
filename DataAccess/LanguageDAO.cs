using _420DA3_Final_Formatif.Business.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Final_Formatif.DataAccess
{
    internal class LanguageDAO
    {
        private MyAppDbContext context;

        public LanguageDAO(MyAppDbContext context)
        {
           this.context = context;
        }

        public List<Language> GetLanguages()
        {
            return this.context.Languages
                .ToList();
        }

        public List<Language> GetLanguagesSpokenInCountry(Country country)
        {
            return this.context.Languages
                .Where(l => l.CountriesSpoken.Contains(country))
                .ToList();
        }

        public List<Language> GetLanguagesNotSpokenInCountry(Country country)
        {
            return this.context.Languages
               .Where(l => !l.CountriesSpoken.Contains(country))
               .ToList();
        }
    }
}
