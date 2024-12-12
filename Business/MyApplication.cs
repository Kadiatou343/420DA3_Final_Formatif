using _420DA3_Final_Formatif.Business.Domain;
using _420DA3_Final_Formatif.Business.Services;
using _420DA3_Final_Formatif.DataAccess;
using _420DA3_Final_Formatif.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Final_Formatif.Business
{
    internal class MyApplication
    {
        public LanguageService LanguageService { get; private set; }

        public CountryService CountryService { get; private set; }

        private MyAppDbContext context;
        private MainMenu mainMenu;


        public MyApplication()
        {
            ApplicationConfiguration.Initialize();
            this.context = new MyAppDbContext();
            this.mainMenu = new MainMenu(this);
            this.LanguageService = new LanguageService(context);
            this.CountryService = new CountryService(context, this);
        }

        public void Start()
        {
            Application.Run(this.mainMenu);
        }
    }
}
