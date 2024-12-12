using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Final_Formatif.Business.Domain
{
    public class Country
    {
        public const int SHORT_NAME_MAX_LENGTH = 32;
        public const int FULL_NAME_MAX_LENGTH = 128;

        private string shortName = null!;
        private string fullName = null!;
        public int Id { get; set; }

        public string ShortName
        {
            get { return this.shortName; }
            set
            {
                if (value.Length > SHORT_NAME_MAX_LENGTH)
                {
                    throw new Exception($"La taille ne peut depasser {SHORT_NAME_MAX_LENGTH} caracteres");
                }
                this.shortName = value;
            }
        }

        public string FullName
        {
            get { return this.fullName; }
            set
            {
                if (value.Length > FULL_NAME_MAX_LENGTH)
                { 
                    throw new Exception($"La taille ne peut depasser {FULL_NAME_MAX_LENGTH} caracteres"); 
                }
                this.fullName = value;
            }
        }

        public byte[] RowVersion { get; set; } = null!;

        public virtual List<Language> Languages { get; set; } = new List<Language>();

        public Country() { }
        protected Country(int id, string shortName, string fullName, byte[] rowVersion)
        {
            this.Id = id;
            this.ShortName = shortName;
            this.FullName = fullName;
            this.RowVersion = rowVersion;
        }

        public override string ToString()
        {
            return $"#{this.Id} - {this.ShortName} - {this.FullName}";
        }
    }
}
