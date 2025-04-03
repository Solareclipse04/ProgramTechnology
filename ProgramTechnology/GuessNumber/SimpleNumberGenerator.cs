using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//класс SimpleNumberGenerator для генерации случайного числа.
namespace GuessNumber
{
    internal class SimpleNumberGenerator : INumberGenerator
    {
        private int _min = 0;
        private int _max = 10;
        public SimpleNumberGenerator(int minVal, int maxVal)
        {
            _min = minVal;
            _max = maxVal;
        }
        public int Value
        {
            get
            {
                Random random = new Random();
                return random.Next(_min, _max);
            }
        }
        public int MinValue { get => _min; set { _min = value; } }
        public int MaxValue { get => _max; set { _max = value; } }
    }
}
