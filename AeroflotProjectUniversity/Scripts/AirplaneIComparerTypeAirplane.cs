using System;

namespace AeroflotProjectUniversity.Scripts
{
    class AirplaneIComparerTypeAirplane : AirplaneIComparerBase
    {
        public override int Compare(Airplane a, Airplane b)
        {
            return string.Compare(a.TypeAirplane, b.TypeAirplane);
        }
    }
}
