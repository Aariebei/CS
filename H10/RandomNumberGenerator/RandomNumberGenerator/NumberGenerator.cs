using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator
{
    class NumberGenerator
    {
        private int _currentRandomNumber;
        public int CurrentRandomNumber
        {
            get { return _currentRandomNumber; }
            set { _currentRandomNumber = value; }
        }
        public NumberGenerator(int seed)
        {
            _currentRandomNumber = seed;
        }

        public int nextRandomNumber()
        {
            int nextRandomDigit = ((_currentRandomNumber * 25173) + 13849) % 65536;
            _currentRandomNumber = nextRandomDigit;
            return nextRandomDigit;
        }
    }
}
