using System;

namespace AeroflotProjectUniversity
{
    class Airplane
    {
        public string Destination { get; set; }
        public string FlightNumber { get; set; }
        public string TypeAirplane { get; set; }
        public int[] DepartureDate { get; set; }

        public Airplane(string destination, string flightNumber, string typeAirplane, int[] departureDate)
        {
            Destination = destination;
            FlightNumber = flightNumber;
            TypeAirplane = typeAirplane;
            DepartureDate = departureDate;
        }
    }
}
