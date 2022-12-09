using Aeroplanes.Models;
using System.Collections.Generic;

namespace Aeroplanes.Repositories
{
    public static class CompanyRepository
    {
        public static List<Company> companys = new List<Company>();

        
        public static List<Company> Retrieve()
        {
            return companys;
        }

        public static Company Retrieve(int id)
        {
            foreach (Company company in companys)
            {
                if (company.companyId == id)
                {
                    return company;
                }
            }
            return null;
        }
    }
}
