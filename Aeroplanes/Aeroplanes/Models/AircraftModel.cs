using Aeroplanes.Repositories;
using System.Linq;

namespace Aeroplanes.Models
{
    public class AircraftModel
    {
        public int aircraftModelId;
        public string aircraftModelType;
        public string aircraftModelName;

        public AircraftModel(string type, string name)
        {
            aircraftModelId = (AircraftModelRepository.aircraftModels.Count > 0) ? AircraftModelRepository.aircraftModels.Last().aircraftModelId + 1 : 1;
            aircraftModelType = type;
            aircraftModelName = name;
        }
    }
}
