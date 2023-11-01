using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount //public class
    {
        private double balance = 0; //private variable

        public void DepositMethod(double depositedAmount) //public method with in BankAccount Class
        {
            balance = depositedAmount += balance;
        }

        public double GetBalance()
        {
           return balance;
        }

        public void ExitProgram()
        {            
            Console.WriteLine("Do you want to exit the program?");
            var input = Console.ReadLine();
            if(input == "y")
            {
                Console.WriteLine("exiting");
            }
            else 
            {
                Console.WriteLine("okay, continue");
            }
        }

    }
}
