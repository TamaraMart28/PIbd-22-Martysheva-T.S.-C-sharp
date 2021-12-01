using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCruiser
{
    public class DockingOccupiedPlaceException : Exception
    {
        public DockingOccupiedPlaceException() : base("Данное место занято")
        { }
    }
}
