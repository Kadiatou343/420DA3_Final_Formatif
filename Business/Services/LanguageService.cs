using _420DA3_Final_Formatif.Business.Domain;
using _420DA3_Final_Formatif.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Final_Formatif.Business.Services
{
    internal class LanguageService
    {
        private LanguageDAO dao;

        public LanguageService(MyAppDbContext context)
        {
            this.dao = new LanguageDAO(context);
        }

        public List<Language> GetAll()
        {
            return this.dao.GetLanguages();
        }
    }
}
