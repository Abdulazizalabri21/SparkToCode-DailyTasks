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

            Console.WriteLine("Balance       : " + balances[index] + " OMR");
        }

        //Service 5 - Transfer Amount

        public static void TransferAmount()
        {
            Console.Write("Enter sender account number: ");

            int senderAccount;

            try
            {
                senderAccount = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid account number.");
                return;
            }

            int senderIndex = accountNumbers.IndexOf(senderAccount);

            if (senderIndex == -1)
            {
                Console.WriteLine("Sender account not found.");
                return;
            }

            Console.Write("Enter receiver account number: ");

            int receiverAccount;

            try
            {
                receiverAccount = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid account number.");
                return;
            }

            int receiverIndex = accountNumbers.IndexOf(receiverAccount);

            if (receiverIndex == -1)
            {
                Console.WriteLine("Receiver account not found.");
                return;
            }

            Console.Write("Enter transfer amount: ");

            double amount;

            try
            {
                amount = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid amount.");
                return;
            }

            if (amount <= 0)
            {
                Console.WriteLine("Transfer amount must be greater than zero.");
                return;
            }

            if (balances[senderIndex] < amount)
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }

            balances[senderIndex] -= amount;
            balances[receiverIndex] += amount;

            Console.WriteLine("Transfer successful.");
            Console.WriteLine("Sender Balance  : " + balances[senderIndex] + " OMR");
            Console.WriteLine("Receiver Balance: " + balances[receiverIndex] + " OMR");
        }

        //--service 6 -List All Accounts
        public static void ListAllAccounts()
        {
            if (accountNumbers.Count == 0)
            {
                Console.WriteLine("No accounts found.");
                return;
            }

            Console.WriteLine("\n===== All Accounts =====");

            for (int i = 0; i < accountNumbers.Count; i++)
            {
                Console.WriteLine("Account " + (i + 1));
                Console.WriteLine("Customer Name : " + customerNames[i]);
                Console.WriteLine("Account Number: " + accountNumbers[i]);
                Console.WriteLine("Balance       : " + balances[i] + " OMR");
                Console.WriteLine("---------------------------------------------");
            }
        }
       // 
     
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
                Console.WriteLine("6. List All Accounts");    
                Console.WriteLine("7. change acount name");
                
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
                        TransferAmount();
                        break;
                    case 6:
                         ListAllAccounts();
                        break;
                    case 7:
                        // ChangeAccountName
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
    
