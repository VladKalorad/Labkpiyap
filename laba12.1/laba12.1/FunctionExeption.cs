using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba12._1
{
    class FunctionExeption : Exception
    {
        public FunctionExeption(string message) : base(message) { }
    }
}
