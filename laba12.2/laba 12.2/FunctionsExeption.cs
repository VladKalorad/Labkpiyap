using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_12._2
{
    class FunctionsExeption : Exception
    {
        public FunctionsExeption(string message) : base(message) { }
    }
}
