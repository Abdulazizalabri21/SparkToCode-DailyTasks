using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

namespace OOP_Part_1
{


   public class BankAccount
    {
        // properties
       public int AccountNumber { get; set; }
          public string HolderName { get; set; }
         public Double Balance { get; set; }

        // Default constructor for previous cases to avoid the conflact
        public BankAccount()
        {

        }

        // Parameterized Constructor

        public BankAccount (int accountNumber, string holderName, Double Balance1) 
        
        {

            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = Balance1;

        }

        // methodes 

        public void Deposit(double amount)
        {
            Balance += amount;
            PrintInformation();
            SendEmail();
        }
           
        public void Withdraw(double amount)
        {
           

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

        //- Case 17 - Total Students Counter [Static Fields & Methods]


        public static int StudentCount = 0;

        public Student() //--> non static methode it can used with static properties ( public static int StudentCount = 0;)
        {
            StudentCount++;
        }

        public static int GetStudentCount() //--> static methode only can used with class properties and only ( public static int StudentCount = 0;)
        {

            return StudentCount;
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

        //static BankAccount B1 = new BankAccount ();

        //B1.AccountNumber = 1677;
        //    B1.HolderName = "KRIMO";
        //    B1.Balance = 95;

        //static BankAccount B2 = new BankAccount();
        //B2.AccountNumber = 1677;
        //    B2.HolderName = "KRIMO";
        //    B2.Balance = 95;

        static BankAccount B1 = new BankAccount()
        {
            AccountNumber = 1677,
            HolderName = "KRIMO",
            Balance = 95
        };

        static BankAccount B2 = new BankAccount()
        {
            AccountNumber = 15203,
            HolderName = "Ali",
            Balance = 63
        };
        //------------------------


        //static Student student1 = new Student();
        //student1.Name = "Ali";
        //    student1.Address = "Muscat";
        //    student1.Grade = 65;
        //static Student student2 = new Student();
        //student2.Name = "Ahmed";
        //    student2.Address = "Muscat";
        //    student2.Grade = 70;

        static Student student1 = new Student()
        {
            Name = "Ali",
            Address = "Muscat",
            Grade = 65
        };

        static Student student2 = new Student()
        {
            Name = "Ahmed",
            Address = "Muscat",
            Grade = 70
        };

        //--------------------------

        //static Products Product1 = new Products();
        //Product1.ProductName = "Wireless Mouse";
        //    Product1.Price = 5.500;
        //    Product1.StockQuantity = 50;

        //static Products Product2 = new Products();
        //Product2.ProductName = "Mechanical Keyboard";
        //    Product2.Price = 15.750;
        //    Product2.StockQuantity = 20;

        static Products Product1 = new Products()
        {
            ProductName = "Wireless Mouse",
            Price = 5.500,
            StockQuantity = 50
        };

        static Products Product2 = new Products()
        {
            ProductName = "Mechanical Keyboard",
            Price = 15.750,
            StockQuantity = 20
        };





        //-----------helper-------------

        static BankAccount ChooseAccount()
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
         static Student ChooseStudent()
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

         static Products ChooseProduct()
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
         static void ViewAccountDetails()
        {
            BankAccount account = ChooseAccount();

            if (account != null)
            {
                account.CheckBalance();
            }
         
        }

         static void UpdateStudentAddress()
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
         static void MakeDeposit()
        {
            BankAccount Account = ChooseAccount();

            if (Account != null)
            {
                Console.WriteLine("Enter the amount you want to diposit");
                double amount = Convert.ToDouble(Console.ReadLine());

              Account.Deposit(amount);
                
                Console.WriteLine("Updated Balance: " + Account.Balance);
            }
           
        }

         static void MakeWithdrawal()
        {
            BankAccount Account = ChooseAccount();
            if (Account != null)
            {
                Console.WriteLine("Enter the amount you want to Withdraw");
                double amount = Convert.ToDouble(Console.ReadLine());
                Account.Withdraw(amount);

                Console.WriteLine("Holder Name is: " +Account.HolderName);
                Console.WriteLine("Updated Balance: " + Account.Balance);

            }
           
        }

        public static void ViewProductDetails()
        {
            Products product = ChooseProduct();

            if (product != null)
            {
                double inventoryValue = product.GetInventoryValue();

                Console.WriteLine("Inventory Value: " + inventoryValue);
            }
        }

        public static void RegisterStudent()
        {
            Student student = ChooseStudent();

            if (student != null)
            {
                Console.Write("Enter email: ");
                string email = Console.ReadLine();

                student.Register(email);

                Console.WriteLine(student.Name + " has been registered successfully.");
            }
        }

        public static void CompareAccountBalances()
        {
            if (B1.Balance > B2.Balance)
            {
                Console.WriteLine(B1.HolderName + " has more money");
                Console.WriteLine("Balance: " + B1.Balance);
            }
            else if (B2.Balance > B1.Balance)
            {
                Console.WriteLine(B2.HolderName + " has more money");
                Console.WriteLine("Balance: " + B2.Balance);
            }
            else
            {
                Console.WriteLine("Both accounts have the same balance");
                Console.WriteLine("Balance: " + B1.Balance);
            }
        }


        public static void RestockProduct()
        {
            Products product = ChooseProduct();

            if (product != null)
            {
                Console.Write("Enter quantity to add: ");
                int quantity = Convert.ToInt32(Console.ReadLine());

                product.Restock(quantity);

                Console.WriteLine("Current Stock: " + product.StockQuantity);

                if (product.StockQuantity < 10)
                {
                    Console.WriteLine("Stock Level: Low");
                }
                else if (product.StockQuantity >= 10 && product.StockQuantity <= 49)
                {
                    Console.WriteLine("Stock Level: Moderate");
                }
                else
                {
                    Console.WriteLine("Stock Level: Well Stocked");
                }
            }

          
        }


        public static void TransferBetweenAccounts()
        {
            Console.WriteLine("Select the source account:");
            BankAccount source = ChooseAccount();

            if (source != null)
            {
                Console.WriteLine("Select the destination account:");
                BankAccount destination = ChooseAccount();

                if (destination != null)
                {

                if (source == destination)
                {
                    Console.WriteLine("Source and destination accounts cannot be the same.");
                    return;
                }

                Console.Write("Enter transfer amount: ");
                double amount = Convert.ToDouble(Console.ReadLine());

                if (amount <= 0)
                {
                    Console.WriteLine("Invalid amount.");
                    return;
                }

                if (source.Balance >= amount)
                 {
                    source.Withdraw(amount);
                    destination.Deposit(amount);
                    Console.WriteLine("Transfer completed successfully.");
                 }
                else
                 {
                     Console.WriteLine("Transfer failed. Insufficient balance.");
                 }

                }
            }
        }


        public static void UpdateStudentGrade()
        {
            Student student = ChooseStudent();

            if (student != null)
            {
                try
                {
                    Console.Write("Enter the new grade (0-100): ");
                    int newGrade = int.Parse(Console.ReadLine());



                    if (newGrade < 0 || newGrade > 100)
                    {
                        Console.WriteLine("Invalid grade. Grade must be between 0 and 100.");
                        return;
                    }

                    student.Grade = newGrade;
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }


                Console.WriteLine("Grade updated successfully.");
                Console.WriteLine(student.Name + "'s new grade is: " + student.Grade);
            }
        }


        public static void StudentReportCard()
        {
            Student student = ChooseStudent();

            if (student != null)
            {
                string result;

                if (student.Grade >= 60)
                {
                    result = "Pass";
                }
                else
                {
                    result = "Fail";
                }

                Console.WriteLine("Student Report Card :::: ");
                Console.WriteLine("Name: " + student.Name);
                Console.WriteLine("Address: " + student.Address);
                Console.WriteLine("Grade: " + student.Grade);
                Console.WriteLine("Result: " + result);
            }
            else
            {
                Console.WriteLine("Student not found");

            }

        }


        public static void AccountHealthStatus()
        {
            BankAccount account = ChooseAccount();

            if (account != null)
            {



                string status;

                if (account.Balance < 50)
                {
                    status = "Low Balance";
                }
                else if (account.Balance <= 1000)
                {
                    status = "Healthy";
                }
                else
                {
                    status = "Premium";
                }

                Console.WriteLine("Account Health Status =====");
                Console.WriteLine("Account Holder: " + account.HolderName);
                Console.WriteLine("Account Number: " + account.AccountNumber);
                Console.WriteLine("Balance: " + account.Balance);
                Console.WriteLine("Status: " + status);
            }
            else
            {
                Console.WriteLine("Account not found ");
                return;
            }
        }



        public static void BulkSaleWithRevenue()
        {
            Products product = ChooseProduct();

            if (product == null)
            {
                Console.WriteLine("Product not found.");
                return;
            }

            Console.Write("Enter quantity to sell: ");

            if (!int.TryParse(Console.ReadLine(), out int quantity))
            {
                Console.WriteLine("Invalid quantity.");
                return;
            }

            if (quantity <= 0)
            {
                Console.WriteLine("Quantity must be greater than zero.");
                return;
            }

            if (product.StockQuantity < quantity)
            {
                int additionalUnits = quantity - product.StockQuantity;

                Console.WriteLine("Not enough stock.");
                Console.WriteLine("You need " + additionalUnits + " more units.");
                return;
            }

            product.sell(quantity);

        
            Console.WriteLine("Sale completed successfully.");
            Console.WriteLine("Product:       " + product.ProductName);
            Console.WriteLine("Quantity sold: " + quantity);
            Console.WriteLine("Total revenue: " + quantity * product.Price);
        }


        public static void ScholarshipEligibilityCheck()
        {
            Student student = ChooseStudent();

            if (student == null)
            {
                Console.WriteLine("Student not found");
                return;
            }

            BankAccount account = ChooseAccount();

            if (account == null)
            {
                Console.WriteLine("Account not found");
                return;
            }

            bool gradeCondition = student.Grade >= 80;
            bool balanceCondition = account.Balance >= 100;

            if (gradeCondition && balanceCondition)
            {
                Console.WriteLine("Eligible for Scholarship");
            }
            else
            {
                Console.WriteLine("Not Eligible: ");

                if (!gradeCondition)
                {
                    Console.WriteLine("--> Student grade must be 80 or above");
                }

                if (!balanceCondition)
                {
                    Console.WriteLine("-->Account balance must be 100 or above");
                }
            }
        }


        public static void FullBalanceTopUpFlow()
        {
            BankAccount account = ChooseAccount();

            if (account == null)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            double balanceBefore = account.Balance;

            if (account.Balance < 50)
            {
                double topUpAmount = 100 - account.Balance;

                account.Deposit(topUpAmount);

                Console.WriteLine("Top-up completed successfully.");
                Console.WriteLine("Balance before: " + balanceBefore);
                Console.WriteLine("Top-up amount: " + topUpAmount);
                Console.WriteLine("Balance after: " + account.Balance);
            }
            else
            {
                Console.WriteLine("No top-up is needed.");
                Console.WriteLine("Current balance: " + account.Balance);
            }
        }


        //16--QuickAccountOpening
        public static void QuickAccountOpening()
        {
            Console.Write("Enter account number: ");
            int accountNumber =int.Parse(Console.ReadLine()) ;

            Console.Write("Enter holder name: ");
            string holderName = Console.ReadLine();

            Console.Write("Enter starting balance: ");
            double Balance1 = double.Parse(Console.ReadLine());

            if (Balance1 < 0 || Balance1 == null)
            {

                Console.WriteLine("Invalid balance.");
            }


            // Create object using ONLY the constructor
             BankAccount account = new BankAccount(accountNumber, holderName, Balance1);
           
            
            Console.WriteLine("\nAccount created successfully.");
            Console.WriteLine("Account Number: " + account.AccountNumber);
            Console.WriteLine("Holder Name: " + account.HolderName);
            Console.WriteLine("Balance: " + account.Balance);
        }


        public static void TotalStudentsCounter()
        {
            Console.WriteLine("Total students: " + Student.GetStudentCount());
        }
        static void Main(string[] args)
        {
           



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
                    case 1:  ViewAccountDetails(); break;
                    case 2:  UpdateStudentAddress(); break;
                    case 3:  MakeDeposit(); break;
                    case 4:  MakeWithdrawal(); break;
                    case 5:  ViewProductDetails(); break;
                    case 6:  RegisterStudent(); break;
                    case 7:  CompareAccountBalances(); break;
                    case 8:  RestockProduct(); break;
                    case 9:  TransferBetweenAccounts(); break;
                    case 10: UpdateStudentGrade(); break;
                    case 11: StudentReportCard(); break;
                    case 12: AccountHealthStatus(); break;
                    case 13: BulkSaleWithRevenue(); break;
                    case 14: ScholarshipEligibilityCheck(); break;
                    case 15: FullBalanceTopUpFlow(); break;
                    case 16: QuickAccountOpening(); break;
                    case 17: TotalStudentsCounter(); break;
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

