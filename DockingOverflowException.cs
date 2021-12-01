using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCruiser
{
    public class DockingOverflowException : Exception
    {
        public DockingOverflowException() : base("В стоянке доков нет свободных мест")
        { }
    }
}
