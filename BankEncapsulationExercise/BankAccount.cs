using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulationExercise
{
    public class BankAccount
    {
        private double Balance;

        public void Deposit(double depositAmount)
        {
            Console.WriteLine($"Depositing an amount of {depositAmount, 0:c} into your account");
            Balance = depositAmount;
        }

        public double GetBalance()
        {
            return Balance;
        }
       
    }
}
