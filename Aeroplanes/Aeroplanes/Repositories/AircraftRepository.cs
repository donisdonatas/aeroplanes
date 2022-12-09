using Aeroplanes.Models;
using System.Collections.Generic;

namespace Aeroplanes.Repositories
{
    public static class AircraftRepository
    {
        public static List<Aircraft> aircrafts = new List<Aircraft>();

        public static List<Aircraft> Retrieve()
        {
            return aircrafts;
        }

        public static Aircraft Retrieve(int id)
        {
            foreach (Aircraft aircraft in aircrafts)
            {
                if (aircraft.aircraftId == id)
                {
                    return aircraft;
                }
            }
            return null;
        }
    }
}
