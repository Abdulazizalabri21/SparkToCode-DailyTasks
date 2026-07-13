using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

namespace OOP_Part_1
{


   public class BankAccount() 
    {
        // properties
        public int AccountNumber { get; set; }
         public string HolderName { get; set; }
         public Double Balance { get; set; }

        // methodes 
      
        public void Deposit(double amount)
        {
            Balance += amount;
            PrintInformation();
            SendEmail();
        }
           
        public void Withdraw(double amount)
        {
            Console.WriteLine("Enter the amount you want to Withdraw");
            int Amount = int.Parse(Console.ReadLine());

            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount.");
                return;
            }

            if (Balance >= amount)
            {
                Balance -= amount;
                SendEmail();

            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }

        public double CheckBalance()
        {
          
            PrintInformation();

            return Balance;
        }

        private void PrintInformation()
        {
            Console.WriteLine("Name : " + HolderName);
            Console.WriteLine("Balance: " + Balance);
        }

        private void SendEmail()
        {
            Console.WriteLine("Email notification sent.");
        }

      

    }


    public class Student
    {
        //properties 
        public int Grade { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        private string email { get; set; } 
        int age { get; set; } 

        //methods 
        public void Register(string Email)
        {
            email = Email;

            SendEmail();
        }

        private void SendEmail()
        {
            Console.WriteLine("Email notification sent.");

        }
    }


    public class Products() 
    {
        public string ProductName { get; set; }
        public int StockQuantity { get; set; }
        public double Price { get; set; }

        //Methodes

        public void sell(int SoldQuantity)
        {
            
                if (StockQuantity >= SoldQuantity)
                {
                    StockQuantity -= SoldQuantity;
                }
            
                else
                  {
                      Console.WriteLine("Stock quantity not enough ");
                  }
        }

        public void Restock(int quantity)
        {
            StockQuantity += quantity;
            LogTransaction();
        }

        private void LogTransaction()
        {
            Console.WriteLine("Transaction logged ");
        }

        public double GetInventoryValue()
        {
            PrintDetails();
            return Price * StockQuantity;
        }

       
        private void PrintDetails()
        {
            Console.WriteLine($"Product Name: {ProductName}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Stock Quantity: {StockQuantity}");
        }

    }


    internal class Program
    {
        static BankAccount B1 = new BankAccount();
        static BankAccount B2 = new BankAccount();
        //------------------------
        static Student student1 = new Student();
        static Student student2 = new Student();

        //--------------------------
        static Products Product1 = new Products();
        static Products Product2 = new Products();
        //-----------helper-------------

        public static BankAccount ChooseAccount()
        {
            Console.WriteLine("Choose an account (1 or 2):");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                return B1;
            }
            else if (choice == 2)
            {
                return B2;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                return null;
            }
        }
        public static Student ChooseStudent()
        {
            Console.WriteLine("Choose the student (1 or 2):");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                return student1;
            }
            else if (choice == 2)
            {
                return student2;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                return null;
            }
        }

        public static Products ChooseProduct()
        {
            Console.WriteLine("Choose th Product (1 or 2):");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                return Product1;
            }
            else if (choice == 2)
            {
                return Product2;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                return null;
            }
        }

        //----------------------------
        public static void ViewAccountDetails()
        {
            BankAccount account = ChooseAccount();

            if (account != null)
            {
                account.CheckBalance();
            }
        }

        public static void UpdateStudentAddress()
        {

            Student student = ChooseStudent();
            if (student != null)
            {
                Console.WriteLine("Enter the new address: ");
                student.Address = Console.ReadLine();
                Console.WriteLine("Address updated successfully.");
                Console.WriteLine(student.Name + "'s new address is: " + student.Address);
            }
        
        }
        public static void MakeDeposit()
        {
            BankAccount Account = ChooseAccount();

            if (Account != null)
            {
                Console.WriteLine("Enter the amount you want to diposit");
                double amount = Convert.ToDouble(Console.ReadLine());
                Account.Deposit(amount);
                
            }
        }

        static void Main(string[] args)
        {
            //==============================================

            B1.AccountNumber = 1234;
            B1.HolderName = "AZIZ";
            B1.Balance = 120;


            B2.AccountNumber = 1677;
            B2.HolderName = "KRIMO";
            B2.Balance = 95;
            //==============================================
            student1.Name = "Ali";
            student1.Address = "Muscat";
            student1.Grade = 65;

            student2.Name = "Ahmed";
            student2.Address = "Muscat";
            student2.Grade = 70;
            //==============================================
            Product1.ProductName = "Wireless Mouse";
            Product1.Price = 5.500;
            Product1.StockQuantity = 50;


            Product2.ProductName = "Mechanical Keyboard";
            Product2.Price = 15.750;
            Product2.StockQuantity = 20;

            //==============================================



            bool exitApp = false;

            while (exitApp == false)
            {
                Console.WriteLine("\n===== OOP Part 1 - Bank / Student / Product Manager =====");
                Console.WriteLine(" 1. View Account Details");
                Console.WriteLine(" 2. Update Student Address");
                Console.WriteLine(" 3. Make a Deposit");
                Console.WriteLine(" 4. Make a Withdrawal");
                Console.WriteLine(" 5. View Product Details");
                Console.WriteLine(" 6. Register a Student");
                Console.WriteLine(" 7. Compare Two Account Balances");
                Console.WriteLine(" 8. Restock Product & Stock Level Check");
                Console.WriteLine(" 9. Transfer Between Accounts");
                Console.WriteLine("10. Update Student Grade (Validated)");
                Console.WriteLine("11. Student Report Card");
                Console.WriteLine("12. Account Health Status");
                Console.WriteLine("13. Bulk Sale With Revenue Calculation");
                Console.WriteLine("14. Scholarship Eligibility Check");
                Console.WriteLine("15. Full Balance Top-Up Flow");
                Console.WriteLine("16. Quick Account Opening (Parameterized Constructor)");
                Console.WriteLine("17. Total Students Counter (Static Field & Method)");
                Console.WriteLine("18. Overdrawn Account Check (Read-Only Property)");
                Console.WriteLine("19. Set Student Security PIN (Write-Only Property)");
                Console.WriteLine("20. Exit");
                Console.Write("Choose an option: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 20.");
                    continue;
                }

                switch (choice)
                {
                    case 1: ViewAccountDetails(); break;
                    case 2: UpdateStudentAddress(); break;
                    case 3:  MakeDeposit(); break;
                    case 4: //MakeWithdrawal(); break;
                    case 5: //ViewProductDetails(); break;
                    case 6: //RegisterStudent(); break;
                    case 7: //CompareAccountBalances(); break;
                    case 8: //RestockProduct(); break;
                    case 9: //TransferBetweenAccounts(); break;
                    case 10:// UpdateStudentGrade(); break;
                    case 11:// StudentReportCard(); break;
                    case 12: //AccountHealthStatus(); break;
                    case 13:// BulkSaleWithRevenue(); break;
                    case 14: //ScholarshipEligibilityCheck(); break;
                    case 15: //FullBalanceTopUpFlow(); break;
                    case 16: //QuickAccountOpening(); break;
                    case 17: //TotalStudentsCounter(); break;
                    case 18: //OverdrawnAccountCheck(); break;
                    case 19: //SetStudentSecurityPin(); break;
                    case 20:
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 20.");
                        break;
                }
                Console.WriteLine("Press any key");
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
