using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisKata
{
    public class ImpossibleGameException : Exception
    {
        public ImpossibleGameException(string message) : base(message) { }
    }
}
