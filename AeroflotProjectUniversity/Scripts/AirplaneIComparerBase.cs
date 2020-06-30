using System;
using System.Collections.Generic;

namespace AeroflotProjectUniversity.Scripts
{
    class AirplaneIComparerBase : IComparer<Airplane>
    {
        public virtual int Compare(Airplane a, Airplane b)
        {
            return string.Compare(a.FlightNumber, b.FlightNumber);
        }
    }
}
