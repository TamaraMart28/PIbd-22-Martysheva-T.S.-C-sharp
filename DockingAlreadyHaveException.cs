using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCruiser
{
    public class DockingAlreadyHaveException : Exception
    {
        public DockingAlreadyHaveException() : base("На стоянке доков уже есть такое судно")
        { }
    }
}
