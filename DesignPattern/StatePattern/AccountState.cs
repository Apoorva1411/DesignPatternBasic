using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public abstract class AccountState
    {
        protected BankAccount _owner;

        protected AccountState(BankAccount owneracct)
        {
            _owner = owneracct;
        }
        public abstract void HandleWithDraw(double amount);
        public abstract void HandleDeposit(double amount);
    }


    public class ActiveAccountState : AccountState
    {
        public ActiveAccountState(BankAccount _owner) : base(_owner)
        {
            Console.WriteLine("Account in active state");
        }
        public override void HandleDeposit(double amount)
        {
            double balance = _owner.GetBalance() + amount;
            _owner.SetBalance(balance);
        }

        public override void HandleWithDraw(double amount)
        {
            double balance = _owner.GetBalance();
            if (balance >= amount)
            {
                balance = balance - amount;
                _owner.SetBalance(balance);
            }
            else if (balance + _owner.GetODLimit() >= amount)
            {
                amount = amount - balance;
                var odlimit = _owner.GetODLimit() - amount;
                _owner.SetBalance(0);
                _owner.SetODLimit(odlimit);
                if(odlimit > 0)
                  _owner._state = new ODAccountState(_owner);
                else
                {
                    _owner._state = new SuspendedAccountState(_owner);
                }
            }
            else
            {
               Console.WriteLine("Balance InSufficient");
            }
        }
    }
    public class ODAccountState : AccountState
    {
        public ODAccountState(BankAccount owneracct) : base(owneracct)
        {
            Console.WriteLine("Account in OD state");
        }

        public override void HandleDeposit(double amount)
        {
            double odlimit = _owner.GetODLimit();
            double maxod = _owner.GetMaxODLimit();
            double fine = 0;
            if (odlimit + amount > maxod)
            {
                var diff = maxod - odlimit;
                odlimit = maxod;
                double balance = amount - diff;
                fine = 0.01 * balance;
                if (fine < balance && balance - fine > _owner.GetMinBalance())
                {
                    balance = balance - fine;
                    _owner.SetBalance(balance);
                    _owner.SetODLimit(odlimit);
                    _owner._state = new ActiveAccountState(_owner);
                }
                else
                {
                    odlimit = odlimit - fine;
                    _owner.SetODLimit(odlimit);
                }
            }
            else
            {
                odlimit = odlimit + amount;
            }
        }

        public override void HandleWithDraw(double amount)
        {
            if (amount <= _owner.GetODLimit())
            {
                var odlimit = _owner.GetODLimit() - amount;
                _owner.SetODLimit(odlimit);
                if (odlimit == 0)
                {
                    _owner._state = new SuspendedAccountState(_owner);
                }
            }
            else
            {
                Console.WriteLine("Balance Insufficient");
            }
        }
    }
    public class SuspendedAccountState : AccountState
    {
        public SuspendedAccountState(BankAccount owneracct) : base(owneracct)
        {
            Console.WriteLine("Account in suspended state");
        }

        public override void HandleDeposit(double amount)
        {
            double odlimit = _owner.GetODLimit();
            double maxod = _owner.GetMaxODLimit();
            double fine = 0;
            if (odlimit + amount >= maxod)
            {
                var diff = maxod - odlimit;
                odlimit = maxod;
                double balance = amount - diff;
                fine = 0.01 * balance;
                if (fine < balance && balance - fine > _owner.GetMinBalance())
                {
                    balance = balance - fine;
                    _owner.SetBalance(balance);
                    _owner.SetODLimit(odlimit);
                    _owner._state = new ActiveAccountState(_owner);
                }
                else
                {
                    odlimit = odlimit - fine;
                    _owner.SetODLimit(odlimit);
                    _owner._state = new ODAccountState(_owner);
                }
            }
            else
            {
                odlimit = odlimit + amount;
            }
        }

        public override void HandleWithDraw(double amount)
        {
            Console.WriteLine("Account in suspended state , cannot withdraw");
        }
    }
}
