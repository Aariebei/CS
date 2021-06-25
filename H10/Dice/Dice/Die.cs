using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Die
    {
        private int _digit = 1;
        private Random rnd = new Random();
        public int Digit
        {
            get { return _digit; }
        }

        public void Roll()
        {
            _digit = rnd.Next(1, 6);
        }

        public void Increment()
        {
            _digit++;
            if (_digit > 6)
            {
                _digit = 6;
            }
        }
    }
}
