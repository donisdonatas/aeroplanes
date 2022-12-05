using Aeroplanes.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroplanes.Models
{
    public class Company
    {
        public int companyId;
        public string companyName;
        public int companyCountryId;

        public Company(string name, int countryId)
        {
            int countCompanysInRepository = CompanyRepository.companys.Count;
            if (countCompanysInRepository != 0)
            {
                companyId = CompanyRepository.companys.Last().companyId + 1;
            }
            else
            {
                companyId = 1;
            }

            companyName = name;
            companyCountryId = countryId;
        }
    }
}
