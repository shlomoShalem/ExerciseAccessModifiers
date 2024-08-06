using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseAccessModifiers
{
    public class Account
    {
        private protected int Balance { get; set; }
        public Account() { }
        public int GetBalance() { return Balance; }
    }

    public class SavingsAccount : Account
    {
        public SavingsAccount(int balance)
        {
            Balance = balance;
        }
    }
}
