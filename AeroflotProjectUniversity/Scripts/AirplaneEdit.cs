using System;
using System.Collections;
using System.Collections.Generic;

namespace AeroflotProjectUniversity.Scripts
{
    class AirplaneEdit : BaseAirplane
    {
        public void RemoveAirplane(int n)
        {
            _airplanes.RemoveAt(n);
        }

        public int AddAirplane(string destination, string flightNumber, string typeAirplane, int[] departureDate)
        {
            Airplane airplane = new Airplane(destination, flightNumber, typeAirplane, departureDate);
            _airplanes.Sort(new AirplaneIComparerBase());

            int airplaneIndex = _airplanes.BinarySearch(airplane, new AirplaneIComparerBase());
            
            if(airplaneIndex < 0)
            {
                _airplanes.Add(airplane);
            }
            return airplaneIndex;
        }

        public ArrayList GetListByTypeAirplane(string typeAirplane)
        {
            ArrayList ArrayString = new ArrayList();
            int i = 0;
            foreach (Airplane e in _airplanes)
            {
                if(e.TypeAirplane == typeAirplane)
                {
                    ArrayString.Add($"{(i + 1)}) {e.Destination,10}, {e.FlightNumber,7}, {e.TypeAirplane,10},  {e.DepartureDate[0]}.{e.DepartureDate[1]}.{e.DepartureDate[2]}");
                    i++;
                }
            }
            return ArrayString;
        }

        public string[] GetListByAirplanes(IComparer<Airplane> compare)
        {
            _airplanes.Sort(compare);
            return GetListAirplanes();
        }
    }
}
