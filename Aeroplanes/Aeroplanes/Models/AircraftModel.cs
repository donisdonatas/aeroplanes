using Aeroplanes.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroplanes.Models
{
    public class AircraftModel
    {
        public int aircraftModelId;
        public string aircraftModelType;
        public string AircraftModelName;
        

        public AircraftModel(string type, string name)
        {
            int countAircraftTypesInRepository = AircraftModelRepository.aircraftModels.Count;
            if (countAircraftTypesInRepository != 0)
            {
                aircraftModelId = AircraftModelRepository.aircraftModels.Last().aircraftModelId + 1;
            }
            else
            {
                aircraftModelId = 1;
            }

            aircraftModelType = type;
            AircraftModelName = name;
        }
        
        public void GetAircraftModelsList()
        {
            if (AircraftModelRepository.aircraftModels.Count != 0)
            {
                for (int i = 0; i < AircraftModelRepository.aircraftModels.Count; i++)
                {
                    Console.WriteLine($"{AircraftModelRepository.aircraftModels[i].aircraftModelId}: {AircraftModelRepository.aircraftModels[i].aircraftModelType} - {AircraftModelRepository.aircraftModels[i].AircraftModelName}");
                }
            }
            else
            {
                Console.WriteLine("Aircraft Models List is Empty!");
            }
        }
    }
}
