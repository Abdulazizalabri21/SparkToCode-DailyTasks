namespace C__Fundamentals___Mini_Compound_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool exitApp = false;
            while (!exitApp)
            {
                Console.WriteLine("\n===== Welcome to Spark Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. Account Information");
                Console.WriteLine("7. Change Account Name");
                Console.WriteLine("8. Exit");
                Console.Write("Choose the service you want to implement: ");
                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                    continue; // skip the rest of this loop pass, show the menu again
                }
                switch (choice)
                {
                    case 1:
                        //AddAccount();
                        break;
                    case 2:
                        //DepositMoney();
                        break;
                    case 3:
                        //WithdrawMoney();
                        break;
                    case 4:
                        //ShowBalance();
                        break;
                    case 5:
                        //TransferAmount();
                        break;
                    case 6:
                        // Account Information"
                        break;
                    case 7:
                        // Change Account Name
                        break;
                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for banking with Abdulaziz Bank. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 8.");
                        break;

                }
            }
       
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        }
    }
}
    
