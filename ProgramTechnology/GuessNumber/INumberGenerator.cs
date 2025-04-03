using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    interface INumberGenerator
    {
        int Value { get; }
        int MinValue { get; set; }
        int MaxValue { get; set; }
    }
}
