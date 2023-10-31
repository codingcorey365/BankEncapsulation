using static System.Formats.Asn1.AsnWriter;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;

namespace BankEncapsulation
{
    //DONE: Create a new public class named BankAccount
    //DONE: In your BankAccount class, create the following:
    //DONE: A private field of type double named ** balance ** with a value of 0
    //DONE: Define a method named Deposit that will accept a double and store that value in the balance field
    //Define a method named GetBalance that will return the amount stored in the balance field
    //In the main method of your application, create a new instance of the BankAccount class.
    //Allow the user of the application to Deposit money and retrieve their balance through the console.
    //Once finished save, commit, and push back to Github
    public class Program
    {
        static void Main(string[] args)
        {

            BankAccount coreysBankAccount = new BankAccount();

            Console.WriteLine("you are at an atm, would you like to make a deposit?");
            string? answerToDepositQuestion = Console.ReadLine();

            if (answerToDepositQuestion == null || answerToDepositQuestion == "")
            {
                Console.WriteLine("Not a valid response. next time try to type a proper response.Have a great day!");
            }
           
            if ((answerToDepositQuestion == "yes") || (answerToDepositQuestion == "y"))
            {
                Console.WriteLine("Great! Enter in how much you would like to deposit to the account.");
                double depositAmount = Convert.ToDouble(Console.ReadLine());

                if ( depositAmount == "")
                {
                    Console.WriteLine("Not a valid response. next time try to type a proper response.Have a great day!");
                }

                Console.WriteLine("I will now put that amount into your account");

                coreysBankAccount.DepositMethod(depositAmount);

                Console.WriteLine("Would you like to see your new balance?");


                string? answerToGetBalanceQuestion = Console.ReadLine();
                if (answerToGetBalanceQuestion == null || answerToGetBalanceQuestion == "")
                {
                    Console.WriteLine("Not a valid response. next time try to type a proper response.Have a great day!");
                }
                
                if ((answerToGetBalanceQuestion == "yes") || (answerToGetBalanceQuestion == "y"))
                {
                    Console.WriteLine($"Great! your new balance after depositing ${depositAmount} is");
                    //enter method
                    Console.WriteLine(coreysBankAccount.GetBalance());
                }
                else
                {
                    Console.WriteLine("Have a great day!");
                }
            }
            
        }
    }
}
