using System;
using System.Collections.Generic;

namespace AeroflotProjectUniversity.Scripts
{
    class BaseAirplane
    {
        protected List<Airplane> _airplanes = new List<Airplane>();

        public BaseAirplane()
        {
            _airplanes.Add(new Airplane("Vnukovo", "FD2814", "boeing-747", new int[] {31, 3, 2020 }));
            _airplanes.Add(new Airplane("Sokol", "GG3194", "boeing-777", new int[] { 11, 1, 2020 }));
            _airplanes.Add(new Airplane("Vnukovo", "ZAM312", "boeing-747", new int[] { 23, 2, 2020 }));
            _airplanes.Add(new Airplane("Burgas", "Z82915", "boeing-777", new int[] { 15, 3, 2020 }));
            _airplanes.Add(new Airplane("Vnukovo", "M28192", "boeing-737", new int[] { 06, 5, 2020 }));
            _airplanes.Add(new Airplane("Domodedovo", "MA2714", "boeing-747", new int[] { 11, 5, 2020 }));
        }

        public string[] GetListAirplanes()
        {
            string[] arrayInfo = new string[_airplanes.Count];
            int i = 0;
            foreach (Airplane e in _airplanes)
            {
                arrayInfo[i] = $"{(i + 1)}) {e.Destination,15}{e.FlightNumber,15}{e.TypeAirplane,15} DepartureDate: {e.DepartureDate[0]}.{e.DepartureDate[1]}.{e.DepartureDate[2]}";
                i++;
            }
            return arrayInfo;
        }

        public void ClearAirplanes()
        {
            _airplanes.Clear();
        }
    }
}
