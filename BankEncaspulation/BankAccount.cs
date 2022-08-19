using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncaspulation
{
    public class BankAccount
    {
        private static double balance = 15_000;
        public double GetBalance()
        {
            return balance;
        }

        public static double DepositBalance(double amount)
        {
           return balance += amount;
        }

        public static bool PinVerification(bool validCheck, int pin)
        {
            if (validCheck && pin == 1234)
            {
                return true;
            }
            return false;
        }
    }
}
