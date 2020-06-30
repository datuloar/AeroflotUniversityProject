using System;

namespace AeroflotProjectUniversity.Scripts
{
    class AirplaneIComparerDestination : AirplaneIComparerBase
    {
        public override int Compare(Airplane a, Airplane b)
        {
            return string.Compare(a.Destination, b.Destination);
        }
    }
}
