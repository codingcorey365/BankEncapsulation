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
            
            Console.WriteLine("You are at an ATM, would you like to make a deposit?");

            string? answerToDepositQuestion = Console.ReadLine();
            
            
            if (answerToDepositQuestion == null || answerToDepositQuestion == "")
            {
                Console.WriteLine("Not a valid response. Next time try to type a proper response. Have a great day!");

            }
            else if ((answerToDepositQuestion == "no") || (answerToDepositQuestion == "n"))
            {
                Console.WriteLine("Okay, maybe next time!");
            }
            else if ((answerToDepositQuestion == "yes") || (answerToDepositQuestion == "y"))
            {
                Console.WriteLine("Great! Enter in how much you would like to deposit to the account.");
                //double depositAmount = Convert.ToDouble(Console.ReadLine()); do not need

                if (double.TryParse(Console.ReadLine(), out var depositAmount))
                {
                    Console.WriteLine("I will now add the deposit amount into your account");

                    coreysBankAccount.DepositMethod(depositAmount);

                    //insert nested if statement
                    Console.WriteLine("Would you like to see your new bank balance?");
                    string? answerToGetBalanceQuestion = Console.ReadLine();
                    if (answerToGetBalanceQuestion == null || answerToGetBalanceQuestion == "")
                    {
                        Console.WriteLine("Not a valid response. Next time try to type a proper response. Have a great day!");
                    }
                    else if ((answerToGetBalanceQuestion == "yes") || (answerToGetBalanceQuestion == "y"))
                    {
                        Console.WriteLine($"Understood! Your new balance after depositing ${depositAmount} is ...{coreysBankAccount.GetBalance()}");
                                                
                    }
                    else if ((answerToDepositQuestion == "no") || (answerToDepositQuestion == "n"))
                    {
                        Console.WriteLine("Okay, maybe next time!");
                    }
                    else
                    {
                        Console.WriteLine("Not a valid response. Next time try to type a proper response. Have a great day!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Not a valid response. Next time try to type a proper response. Have a great day!");
            }
        }
    }
}
