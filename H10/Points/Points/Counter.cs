using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points
{
    class Counter
    {
        private int _count = 0;
        public int Count 
        { 
            get { return _count; }
        }
        public void Reset()
        {
            _count = 0;
        }
        
        public void Increment()
        {
            _count++;
        }

        public void Decrement()
        {
            _count--;
        }
    }
}
