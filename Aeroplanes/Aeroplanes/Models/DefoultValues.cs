using Aeroplanes.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Aeroplanes.Models
{
    public static class DefoultValues
    {
        private static bool isDefoultCountriesAdded = false;
        private static bool isDefoultAicraftModelsAdded = false;
        private static bool isDefoultCompanysAdded = false;
        private static bool isDefoultAircraftsAdded = false;

        private static void AddDefoultCountriesToRepository()
        {
            if (!isDefoultCountriesAdded)
            {
                CountryRepository.countries.Add(new Country("CN", "China", false));
                CountryRepository.countries.Add(new Country("FI", "Finland", true));
                CountryRepository.countries.Add(new Country("HU", "Hungary", true));
                CountryRepository.countries.Add(new Country("IE", "Ireland", true));
                CountryRepository.countries.Add(new Country("LV", "Latvia", true));
                CountryRepository.countries.Add(new Country("MT", "Malta", true));
                CountryRepository.countries.Add(new Country("PL", "Poland", true));
                CountryRepository.countries.Add(new Country("TR", "Turkey", false));
                isDefoultCountriesAdded = true;
                Console.WriteLine("Defoult Country List was added to CountryRepository");
            }
            else
            {
                Console.WriteLine("Defoult Country List is already added");
            }
        }

        private static void AddDefoultAircraftModelsToRepository()
        {
            if (!isDefoultAicraftModelsAdded)
            {
                AircraftModelRepository.aircraftModels.Add(new AircraftModel("A320", "Airbus A320-232"));
                AircraftModelRepository.aircraftModels.Add(new AircraftModel("A332", "Airbus A330-243"));
                AircraftModelRepository.aircraftModels.Add(new AircraftModel("A333", "Airbus A330-302"));
                AircraftModelRepository.aircraftModels.Add(new AircraftModel("A359", "Airbus A350-941"));
                AircraftModelRepository.aircraftModels.Add(new AircraftModel("AT75", "ATR 72-500"));
                AircraftModelRepository.aircraftModels.Add(new AircraftModel("B38M", "Boeing 737 MAX 8-200"));
                AircraftModelRepository.aircraftModels.Add(new AircraftModel("B738", "Boeing 737-8AS"));
                AircraftModelRepository.aircraftModels.Add(new AircraftModel("B789", "Boeing 787-9 Dreamliner"));
                AircraftModelRepository.aircraftModels.Add(new AircraftModel("BCS3", "Airbus A220-300"));
                AircraftModelRepository.aircraftModels.Add(new AircraftModel("C404", "Cessna 404 Titan"));
                AircraftModelRepository.aircraftModels.Add(new AircraftModel("DH8D", "De Havilland Canada Dash 8-400")); 
                AircraftModelRepository.aircraftModels.Add(new AircraftModel("E190", "Embraer E190LR"));
                AircraftModelRepository.aircraftModels.Add(new AircraftModel("E75S", "Embraer E175LR"));
                isDefoultAicraftModelsAdded = true;
                Console.WriteLine("Defoult Aircrafts Model List was added to AircraftModelRepository");
            }
            else
            {
                Console.WriteLine("Defoult Aircraft Models List is already added");
            }
        }

        private static void AddDefoultCompanysToRepository()
        {
            if (!isDefoultCompanysAdded)
            {
                CompanyRepository.companys.Add(new Company("Air Baltic", 5));
                CompanyRepository.companys.Add(new Company("Air China", 1));
                CompanyRepository.companys.Add(new Company("Finnair", 2));
                CompanyRepository.companys.Add(new Company("NORRA", 2));
                CompanyRepository.companys.Add(new Company("Hainan Airlines", 1));
                CompanyRepository.companys.Add(new Company("LOT", 7));
                CompanyRepository.companys.Add(new Company("Malta Air", 6));
                CompanyRepository.companys.Add(new Company("Private owner", 5));
                CompanyRepository.companys.Add(new Company("Buzz", 7));
                CompanyRepository.companys.Add(new Company("Ryanair", 4));
                CompanyRepository.companys.Add(new Company("Wizz Air", 3));
                isDefoultCompanysAdded = true;
                Console.WriteLine("Defoult Companies List was added to CompanyRepository");
            }
            else
            {
                Console.WriteLine("Defoult Aircraft Models List is already added");
            }
        }

        private static void AddDefoultAircraftsToRepository()
        {
            if (!isDefoultAircraftsAdded)
            {
                AircraftRepository.aircrafts.Add(new Aircraft("9H-VUD", 6, 7));
                AircraftRepository.aircrafts.Add(new Aircraft("B-1540", 8, 5));
                AircraftRepository.aircrafts.Add(new Aircraft("B-6113", 2, 2));
                AircraftRepository.aircrafts.Add(new Aircraft("B-7800", 8, 2));
                AircraftRepository.aircrafts.Add(new Aircraft("EI-DWI", 7, 10));
                AircraftRepository.aircrafts.Add(new Aircraft("HA-LYD", 1, 11));
                AircraftRepository.aircrafts.Add(new Aircraft("YL-ABC", 9, 1));
                AircraftRepository.aircrafts.Add(new Aircraft("YL-ABD", 9, 1));
                AircraftRepository.aircrafts.Add(new Aircraft("YL-UFO", 10, 8));
                AircraftRepository.aircrafts.Add(new Aircraft("OH-ATJ", 5, 4));
                AircraftRepository.aircrafts.Add(new Aircraft("OH-LKH", 12, 4));
                AircraftRepository.aircrafts.Add(new Aircraft("OH-LTR", 3, 3));
                AircraftRepository.aircrafts.Add(new Aircraft("OH-LWH", 4, 3));
                AircraftRepository.aircrafts.Add(new Aircraft("SP-EQK", 11, 6));
                AircraftRepository.aircrafts.Add(new Aircraft("SP-LIO", 13, 6));
                AircraftRepository.aircrafts.Add(new Aircraft("SP-RSF", 7, 9));
                isDefoultAircraftsAdded = true;
                Console.WriteLine("Defoult Aircrafts List was added to AircraftRepository");
            }
            else
            {
                Console.WriteLine("Defoult Aircrafts List is already added");
            }
        }

        public static void AddDefoultValuesToAllRepositories()
        {
            AddDefoultCountriesToRepository();
            AddDefoultCompanysToRepository();
            AddDefoultAircraftsToRepository();
            AddDefoultAircraftModelsToRepository();
        }
    }
}
