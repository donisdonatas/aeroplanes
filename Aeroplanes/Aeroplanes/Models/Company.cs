using Aeroplanes.Repositories;
using System.Linq;

namespace Aeroplanes.Models
{
    public class Company
    {
        public int companyId;
        public string companyName;
        public int companyCountryId;

        public Company(string name, int countryId)
        {
            companyId = (CompanyRepository.companys.Count > 0) ? CompanyRepository.companys.Last().companyId + 1 : 1;
            companyName = name;
            companyCountryId = countryId;
        }
    }
}
