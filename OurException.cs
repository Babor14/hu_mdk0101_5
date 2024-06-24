using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdk_0101__lab5_
{
    internal class OurException : Exception
    {
        public OurException(string?message ):base(message) { }
    }
}
