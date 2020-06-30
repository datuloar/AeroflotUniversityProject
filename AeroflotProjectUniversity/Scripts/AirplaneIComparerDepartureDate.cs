using System;

namespace AeroflotProjectUniversity.Scripts
{
    class AirplaneIComparerDepartureDate : AirplaneIComparerBase
    {
        public override int Compare(Airplane a, Airplane b)
        {
            if (a.DepartureDate[2] > b.DepartureDate[2])
            {
                return 1;
            }
            if (a.DepartureDate[2] < b.DepartureDate[2])
            {
                return -1;
            }
            if (a.DepartureDate[1] > b.DepartureDate[1])
            {
                return 1;
            }
            if (a.DepartureDate[1] < b.DepartureDate[1])
            {
                return -1;
            }
            if (a.DepartureDate[0] > b.DepartureDate[0])
            {
                return 1;
            }
            if (a.DepartureDate[0] < b.DepartureDate[0])
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
