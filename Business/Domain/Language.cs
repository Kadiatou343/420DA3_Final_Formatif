using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Final_Formatif.Business.Domain
{
    public class Language
    {
        public const int NAME_MAX_LENGTH = 32;
        public const int ISO_CODE_MAX_LENGTH = 2;

        private string name = null!;
        private string isoCode = null!;

        public int Id { get; set; }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length > NAME_MAX_LENGTH)
                {
                    throw new Exception($"La taille ne peut depasser {NAME_MAX_LENGTH} caracteres");
                }
                this.name = value;
            }
        }

        public string IsoCode
        {
            get { return this.isoCode; }
            set
            {
                if (value.Length > ISO_CODE_MAX_LENGTH)
                {
                    throw new Exception($"La taille ne peut depasser {ISO_CODE_MAX_LENGTH} caracteres");
                }
                this.isoCode = value;
            }
        }

        public byte[] RowVersion { get; set; } = null!;

        public virtual List<Country> CountriesSpoken { get; set; } = new List<Country>();

        public Language() { }

        public Language(int id, string name, string isoCode, byte[] rowVersion)
        {
            this.Id = id;
            this.Name = name;
            this.IsoCode = isoCode;
            this.RowVersion = rowVersion;
        }
    }
}
