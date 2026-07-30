using E_Commerce_Database.Models;

namespace E_Commerce_Database
{
    internal class Program
    {
        static ProjectContext context = new ProjectContext();
        static int loggedInUserId = 0;

        static void Main(string[] args)
        {
            bool exitApp = false;
            while (!exitApp)
            {
                Console.WriteLine("\n===== E-Commerce App =====");
                Console.WriteLine(" 1. Register New User");
                Console.WriteLine(" 2. Login");
                Console.WriteLine(" 3. Add New Category");
                Console.WriteLine(" 4. Add New Product");
                Console.WriteLine(" 5. View All Products");
                Console.WriteLine(" 6. Place an Order");
                Console.WriteLine(" 7. View My Orders");
                Console.WriteLine(" 8. View Order Details");
                Console.WriteLine(" 9. Add a Review for an Order");
                Console.WriteLine("10. View All Reviews for a Product");
                Console.WriteLine("11. Logout");
                Console.WriteLine(" 0. Exit");
                Console.Write("Enter your choice: ");
                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }
                switch (choice)
                {
                    case 1: RegisterUser(); break;
                    case 2: //Login(); break;
                    case 3: //AddCategory(); break;
                    case 4: //AddProduct(); break;
                    case 5: //ViewAllProducts(); break;
                    case 6: //PlaceOrder(); break;
                    case 7: //ViewMyOrders(); break;
                    case 8: //ViewOrderDetails(); break;
                    case 9: //AddReview(); break;
                    case 10://ViewReviewsForProduct(); break;
                    case 11://Logout(); break;
                    case 0:
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }


            }
        }


        // functions 
        // 1. Register New User
        static void RegisterUser()
        {
            Users users = new Users();

            // First Name
            while (true)
            {
                Console.Write("Enter First Name: ");
                users.Firstname = Console.ReadLine().Trim();

                if (!string.IsNullOrWhiteSpace(users.Firstname))
                    break;

                Console.WriteLine("First Name cannot be empty.");
            }

            // Last Name
            while (true)
            {
                Console.Write("Enter Last Name: ");
                users.Lastname = Console.ReadLine().Trim();

                if (!string.IsNullOrWhiteSpace(users.Lastname))
                    break;

                Console.WriteLine("Last Name cannot be empty.");
            }

            // Email
            while (true)
            {
                Console.Write("Enter Email: ");
                users.Email = Console.ReadLine().Trim();

                if (string.IsNullOrWhiteSpace(users.Email))
                {
                    Console.WriteLine("Email cannot be empty.");
                    continue;
                }

                if (!users.Email.Contains("@") || !users.Email.Contains("."))
                {
                    Console.WriteLine("Please enter a valid email.");
                    continue;
                }

                bool existsEmail = context.User.Any(u => u.Email == users.Email);

                if (existsEmail)
                {
                    Console.WriteLine("This email is already registered.");
                    continue;
                }

                break;
            }

            // Password
            while (true)
            {
                Console.Write("Enter Password: ");
                users.Password = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(users.Password))
                {
                    Console.WriteLine("Password cannot be empty.");
                    continue;
                }

                if (users.Password.Length < 6)
                {
                    Console.WriteLine("Password must be at least 6 characters.");
                    continue;
                }

                break;
            }

            context.User.Add(users);
            context.SaveChanges();

            Console.WriteLine("\nUser registered successfully!");
            Console.WriteLine($"User ID: {users.userID}");
        }

















    }
}
