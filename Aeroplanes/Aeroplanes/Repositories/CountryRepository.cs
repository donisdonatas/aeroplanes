using Aeroplanes.Models;
using System.Collections.Generic;

namespace Aeroplanes.Repositories
{
    public static class CountryRepository
    {
        public static List<Country> countries = new List<Country>();

        public static List<Country> Retrieve()
        {
            return countries;
        }

        public static Country Retrieve(int countryId)
        {
            foreach (Country country in countries)
            {
                if (country.countryId == countryId)
                {
                    return country;
                }
            }
            return null;
        }
    }
}
