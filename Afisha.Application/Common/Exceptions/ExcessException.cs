using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afisha.Application.Common.Exceptions
{
    public class ExcessException : Exception
    {
        public ExcessException(string name, int key)
           : base($"Maximum - {key} number of {name} sold") { }
    }
}
