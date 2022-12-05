using Aeroplanes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
