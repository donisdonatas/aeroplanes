using Aeroplanes.Models;
using Aeroplanes.Repositories;
using System;
using System.Collections.Generic;

namespace Aeroplanes.Reports
{
    public class ReportGenerator
    {
        public List<Aircraft> aircratsDatabase = AircraftRepository.Retrieve();
        public List<AircraftModel> aircraftsModelsDatabase = AircraftModelRepository.Retrieve();
        public List<Company> companysDatabase = CompanyRepository.Retrieve();
        public List<Country> countrysDatabase = CountryRepository.Retrieve();

        public void ReadAircraftsRepository()
        {
            Console.WriteLine("AircraftRepository");
            foreach (Aircraft aircraft in aircratsDatabase)
            {
                Console.WriteLine($"{aircraft.aircraftId}. {aircraft.aircraftRegistrationNumber} - [{aircraft.aircraftModelId}] [{aircraft.aircraftOwnerId}]");
            }
            Console.WriteLine("----------------------");
        }

        public void ReadAircraftsModelRepository()
        {
            Console.WriteLine("AircraftModelRepository");
            foreach (AircraftModel model in aircraftsModelsDatabase)
            {
                Console.WriteLine($"{model.aircraftModelId}. {model.aircraftModelType} - {model.aircraftModelName}");
            }
            Console.WriteLine("----------------------");
        }

        public void ReadCompanyRepository()
        {
            Console.WriteLine("CompanyRepository");
            foreach(Company company in companysDatabase)
            {
                Console.WriteLine($"{company.companyId}. {company.companyName} [{company.companyCountryId}]");
            }
            Console.WriteLine("----------------------");
        }

        public void ReadCountrysRepository()
        {
            Console.WriteLine("CountryRepository");
            foreach(Country country in countrysDatabase)
            {
                Console.WriteLine($"{country.countryId}. {country.countryCode} - {country.countryName}");
            }
            Console.WriteLine("----------------------");
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
            string aircraftTailNumber;
            string modelNumber;
            string modelDescription;
            string ownerComapanyName;
            string companyCountryCode;
            string companyCountryName;
            bool isEuCountry;

            foreach(Aircraft aircraft in aircratsDatabase)
            {
                aircraftTailNumber = aircraft.aircraftRegistrationNumber;
                AircraftModel aircraftModelData = AircraftModelRepository.Retrieve(aircraft.aircraftModelId);
                modelNumber = aircraftModelData.aircraftModelType;
                modelDescription = aircraftModelData.aircraftModelName;
                Company companyData = CompanyRepository.Retrieve(aircraft.aircraftOwnerId);
                ownerComapanyName = companyData.companyName;
                companyCountryCode = CountryRepository.Retrieve(companyData.companyCountryId).countryCode;
                companyCountryName = CountryRepository.Retrieve(companyData.companyCountryId).countryName;
                isEuCountry = CountryRepository.Retrieve(companyData.companyCountryId).isEuropeCountry;

                ReportItemRepository.report.Add(new ReportItem(aircraftTailNumber, modelNumber, modelDescription, ownerComapanyName, companyCountryCode, companyCountryName, isEuCountry));
            }
        }
    }
}
