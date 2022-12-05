using Aeroplanes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroplanes.Repositories
{
    internal static class AircraftRepository
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
