using Aeroplanes.Repositories;
using System.Linq;

namespace Aeroplanes.Models
{
    public class Country
    {
        public int countryId;
        public string countryCode;
        public string countryName;
        public bool isEuropeCountry;
        
        public Country(string code, string name, bool isEUcountry)
        {
            countryId = (CountryRepository.countries.Count > 0) ? CountryRepository.countries.Last().countryId + 1 : 1;
            countryCode = code;
            countryName = name;
            isEuropeCountry = isEUcountry;
        }
    }
}
