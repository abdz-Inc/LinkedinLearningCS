using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedinLearning.DelegatesEventsLambdas
{

    public class MyEventArgs : EventArgs
    {
        public int balance;
    }

    internal class BankEvent
    {
        private int _balance;
        private int _limit;
        public event EventHandler<MyEventArgs> BalanceChanged = delegate { };


        public int Balance
        {
            get { return _balance; }
            set
            {
                _balance = value;
                BalanceChanged(this, new MyEventArgs()
                {
                    balance = _balance
                });
            }
        }

        public int Limit
        {
            get; set;
        }

        public BankEvent(int balance = 0, int limit = 500)
        {
            Balance = balance;
            Limit = limit;
        }

    }
}
