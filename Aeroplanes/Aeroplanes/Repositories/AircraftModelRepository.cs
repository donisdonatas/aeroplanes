using Aeroplanes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroplanes.Repositories
{
    public static class AircraftModelRepository
    {
        public static List<AircraftModel> aircraftModels = new List<AircraftModel>();

        public static List<AircraftModel> Retrieve()
        {
            return aircraftModels;
        }

        public static AircraftModel Retrieve(int id)
        {
            foreach (AircraftModel aircraftModel in aircraftModels)
            {
                if (aircraftModel.aircraftModelId == id)
                {
                    return aircraftModel;
                }
            }
            return null;
        }
    }
}
