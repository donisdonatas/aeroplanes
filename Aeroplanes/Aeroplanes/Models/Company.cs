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


        public void GetAircraftModelsList()
        {
            if (CompanyRepository.companys.Count != 0)
            {
                for (int i = 0; i < CompanyRepository.companys.Count; i++)
                {
                    Console.WriteLine($"{CompanyRepository.companys[i].companyId}: {CompanyRepository.companys[i].companyName}");
                }
            }
            else
            {
                Console.WriteLine("Company List is Empty!");
            }
        }
    }
}
