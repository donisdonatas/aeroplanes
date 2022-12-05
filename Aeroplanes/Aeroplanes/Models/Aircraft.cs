using Aeroplanes.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroplanes.Models
{
    public class Aircraft
    {
        public int aircraftId;
        public string aircraftRegistrationNumber;
        public int aircraftModelId;
        public int aircraftOwnerId;


        public Aircraft(string regNumber, int modelId, int ownerId)
        {
            int countAircraftsInRepository = AircraftRepository.aircrafts.Count;
            if (countAircraftsInRepository != 0)
            {
                aircraftId = AircraftRepository.aircrafts.Last().aircraftId + 1;
            }
            else
            {
                aircraftId = 1;
            }

            aircraftRegistrationNumber = regNumber;
            aircraftModelId = modelId;
            aircraftOwnerId = ownerId;
        }
    }

    
}
