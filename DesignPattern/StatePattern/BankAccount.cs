using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{

    public class BankAccount
    {
        public AccountState _state;
        private double _balance;
        private double _ODLimit;
        private double _maxODLimit;
        private int minBalance;

        public BankAccount()
        {
            _state = new ActiveAccountState(this);
            minBalance = 0;
            _balance = 0;
            _ODLimit = 1000;
            _maxODLimit = 1000;
        }
        public double GetMaxODLimit()
        {
            return _maxODLimit;
        }
        public double GetBalance()
        {
            return _balance;
        }
        public void SetBalance(double balance)
        {
            _balance = balance;
        }

        public int GetMinBalance()
        {
            return minBalance;
        }
        public void SetMinBalance(int _minbalance)
        {
            minBalance = _minbalance;
        }

        public double GetODLimit()
        {
            return _ODLimit;
        }
        public void SetODLimit(double odlimit)
        {
            _ODLimit = odlimit;
        }

        public void Withdraw(double Amount)
        {
            _state.HandleWithDraw(Amount);
        }
        public void Deposit(double Amount)
        {
            _state.HandleDeposit(Amount);
        }
    }
}
