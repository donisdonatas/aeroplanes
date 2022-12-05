using Aeroplanes.Models;
using Aeroplanes.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroplanes.Reports
{
    public class ReportGenerator
    {
        /**
         * https://www.dotnetperls.com/static-list
         */
 
        
        public List<Aircraft> aircrats_db = AircraftRepository.Retrieve();
        public List<AircraftModel> aircraftsModels_db = AircraftModelRepository.Retrieve();
        public List<Company> companys_db = CompanyRepository.Retrieve();
        public List<Country> countrys_db = CountryRepository.Retrieve();

        public void ReadAircraftsRepository()
        {
            Console.WriteLine("AircraftRepository");
            foreach (Aircraft aircraft in aircrats_db)
            {
                Console.WriteLine($"{aircraft.aircraftId}. {aircraft.aircraftRegistrationNumber} - [{aircraft.aircraftModelId}] [{aircraft.aircraftOwnerId}]");
            }
            Console.WriteLine("-----------------");
        }

        public void ReadAircraftsModelRepository()
        {
            Console.WriteLine("AircraftModelRepository");
            foreach (AircraftModel model in aircraftsModels_db)
            {
                Console.WriteLine($"{model.aircraftModelId}. {model.aircraftModelType} - {model.AircraftModelName}");
            }
            Console.WriteLine("-----------------");
        }

        public void ReadCompanyRepository()
        {
            Console.WriteLine("CompanyRepository");
            foreach(Company company in companys_db)
            {
                Console.WriteLine($"{company.companyId}. {company.companyName} [{company.companyCountryId}]");
            }
            Console.WriteLine("-----------------");
        }

        public void ReadCountrysRepository()
        {
            Console.WriteLine("CountryRepository");
            foreach(Country country in countrys_db)
            {
                Console.WriteLine($"{country.countryId}. {country.countryCode} - {country.countryName}");
            }
            Console.WriteLine("-----------------");
        }
        
        public void ReadAllRepositories()
        {
            ReadAircraftsRepository();
            ReadAircraftsModelRepository();
            ReadCompanyRepository();
            ReadCountrysRepository();
        }
        
        public void GenerateReportAircraftInEurope()
        {
            //List<ReportItem> report = new List<ReportItem>();
            string aircraftTailNumber;
            string modelNumber;
            string modelDescription;
            string ownerComapanyName;
            string companyCountryCode;
            string companyCountryName;
            bool isEuCountry;

            foreach(Aircraft aircraft in aircrats_db)
            {
                aircraftTailNumber = aircraft.aircraftRegistrationNumber;
                AircraftModel aircraftModelData = AircraftModelRepository.Retrieve(aircraft.aircraftModelId);
                modelNumber = aircraftModelData.aircraftModelType;      //   AircraftModelRepository.Retrieve(aircraft.aircraftModelId).aircraftModelType;
                modelDescription = aircraftModelData.AircraftModelName; //   AircraftModelRepository.Retrieve(aircraft.aircraftModelId).AircraftModelName;
                Company companyData = CompanyRepository.Retrieve(aircraft.aircraftOwnerId);
                ownerComapanyName = companyData.companyName;
                companyCountryCode = CountryRepository.Retrieve(companyData.companyCountryId).countryCode;
                companyCountryName = CountryRepository.Retrieve(companyData.companyCountryId).countryName;
                isEuCountry = CountryRepository.Retrieve(companyData.companyCountryId).isEuropeCountry;

                ReportItemRepository.report.Add(new ReportItem(aircraftTailNumber, modelNumber, modelDescription, ownerComapanyName, companyCountryCode, companyCountryName, isEuCountry));
            }

            //return report;
        }
        
    }
}
