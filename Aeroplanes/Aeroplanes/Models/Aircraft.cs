using Aeroplanes.Repositories;
using System.Linq;

namespace Aeroplanes.Models
{
    public class Aircraft
    {
        public int aircraftId { get; }
        public string aircraftRegistrationNumber;
        public int aircraftModelId;
        public int aircraftOwnerId;

        public Aircraft(string regNumber, int modelId, int ownerId)
        {
            aircraftId = (AircraftRepository.aircrafts.Count > 0) ? AircraftRepository.aircrafts.Last().aircraftId + 1 : 1;
            aircraftRegistrationNumber = regNumber;
            aircraftModelId = modelId;
            aircraftOwnerId = ownerId;
        }
    }
}
