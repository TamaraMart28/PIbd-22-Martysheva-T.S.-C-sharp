using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCruiser
{
    public class DockingNotFoundException : Exception
    {
        public DockingNotFoundException(int i) : base("Не найден корабль по месту " + i)
        { }
    }
}
