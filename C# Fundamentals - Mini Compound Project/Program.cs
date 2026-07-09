using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Fundamentals___Mini_Compound_Project
{
    internal class Program
    {
      static  List<string> customerNames = new List<string>();
        static List<int> accountNumbers = new List<int>();
        static  List<double> balances = new List<double>();

       
        
        // Service 1 - Add New Account  function
        public static void AddNewAccount()
        {
            Console.Write("Enter customer name: ");
            string customerName = Console.ReadLine();
            try
            {
                Console.Write("Enter new account number: ");
                int accountNumber = int.Parse(Console.ReadLine());

                if (accountNumbers.Contains(accountNumber))
                {
                    Console.WriteLine("Error: Account number already exists.");
                    return;
                }

                Console.Write("Enter initial deposit: ");
                double initialDeposit = double.Parse(Console.ReadLine());

                if (initialDeposit < 0)
                {
                    Console.WriteLine("Error: Initial deposit cannot be negative.");
                    return;
                }
           
            
            customerNames.Add(customerName);
            accountNumbers.Add(accountNumber);
            balances.Add(initialDeposit);

            Console.WriteLine("\nAccount created successfully!");
            Console.WriteLine("Customer Name : " + customerName);
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Balance       : " + initialDeposit + " OMR");
        }
            catch
            {
                Console.WriteLine("Erorr: Only you can use the number. NOT characters of sentence");
            }
        }

        //Service 2 - Deposit Money

        public static void DepositMoney()
        {
            Console.Write("Enter account number: ");
            int accountNumber = int.Parse(Console.ReadLine());

            int index = accountNumbers.IndexOf(accountNumber);

            if (index == -1)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            Console.Write("Enter deposit amount: ");

            double amount;

            try
            {
                amount = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid amount.");
                return;
            }

            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }

            balances[index] += amount;

            Console.WriteLine("Deposit successful.");
            Console.WriteLine("Updated balance: " + balances[index]);
        }


        //Service 3 - Withdraw Money

        public static void WithdrawMoney()
        {
            Console.Write("Enter account number: ");
            int accountNumber = int.Parse(Console.ReadLine());

            int index = accountNumbers.IndexOf(accountNumber);

            if (index == -1)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            Console.Write("Enter Withdraw amount: ");

            double amount;

            try
            {
                amount = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid amount.");
                return;
            }

            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be more than zero.");
                return;
            }

            if (balances[index] < amount)
            {
                Console.WriteLine("Withdrawal amount not available.");
                return;
            }

            balances[index] -= amount;

            Console.WriteLine("Withdrawal successful.");
            Console.WriteLine("Updated balance: " + balances[index]);
        }

        //Service 4 - Show Balance


        public static void ShowBalance()
        {
            Console.Write("Enter account number: ");

            int accountNumber;

            try
            {
                accountNumber = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid account number.");
                return;
            }

            int index = accountNumbers.IndexOf(accountNumber);

            if (index == -1)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            Console.WriteLine("\nAccount Details");
            Console.WriteLine("Customer Name : " + customerNames[index]);
            Console.WriteLine("Account Number: " + accountNumbers[index]);
            Console.WriteLine("Balance       : " + balances[index] + " OMR");
        }




        static void Main(string[] args)
        {

         
            bool exitApp = false;
            while (!exitApp)
            {
                Console.WriteLine("\n===== Welcome to Abdulaziz Bank =====");
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

                        AddNewAccount();

                        break;
                    case 2:

                        DepositMoney();

                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        ShowBalance();
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
    
