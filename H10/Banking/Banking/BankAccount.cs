using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class BankAccount
    {
        private double _currentvalue;

        public double CurrentValue
        {
            get { return _currentvalue;  }
            set { _currentvalue = value;  }
        }

        public void Deposit(double amount)
        {
            _currentvalue += amount;
        }
        public void WithDraw(double amount)
        {
            _currentvalue -= amount;
        }
        public BankAccount()
        {
            _currentvalue = 0;
        }
    }
}
