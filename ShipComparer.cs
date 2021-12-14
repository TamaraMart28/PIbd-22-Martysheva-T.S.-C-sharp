using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCruiser
{
    public class ShipComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x is Ship && y is Cruiser) return -1;
            
            if (x is Cruiser && y is Ship) return 1;

            if (x is Ship && y is Ship)
            {
                return ComparerShip((Ship)x, (Ship)y);
            }

            if (x is Cruiser && y is Cruiser)
            {
                return ComparerCruiser((Cruiser)x, (Cruiser)y);
            }

            return 0;
        }

        private int ComparerShip(Ship x, Ship y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }

        private int ComparerCruiser(Cruiser x, Cruiser y)
        {
            var res = ComparerShip(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.Helipad != y.Helipad)
            {
                return x.Helipad.CompareTo(y.Helipad);
            }
            if (x.Radar != y.Radar)
            {
                return x.Radar.CompareTo(y.Radar);
            }
            if (x.Gun != y.Gun)
            {
                return x.Gun.CompareTo(y.Gun);
            }
            return 0;
        }
    }
}
