﻿using Aeroplanes.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            int countCountriesInRepository = CountryRepository.countries.Count;
            if(countCountriesInRepository != 0 )
            {
                countryId = CountryRepository.countries.Last().countryId + 1;
            }
            else
            {
                countryId = 1;
            }
            
            countryCode = code;
            countryName = name;
            isEuropeCountry = isEUcountry;
        }
    }
}
