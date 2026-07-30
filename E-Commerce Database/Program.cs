using E_Commerce_Database.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
                    case 2: Login(); break;
                    case 3: AddCategory(); break;
                    case 4: AddProduct(); break;
                    case 5: ViewAllProducts(); break;
                    case 6: PlaceOrder(); break;
                    case 7: ViewMyOrders(); break;
                    case 8: ViewOrderDetails(); break;
                    case 9: AddReview(); break;
                    case 10:ViewReviewsForProduct(); break;
                    case 11://Logout(); break;
                    case 0:
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

                Console.WriteLine("Press any KEY");
                Console.ReadKey();
                Console.Clear();

            }
        }


        // functions
        //-------------------------------------
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

        // 2.Login
        static void Login()
        {
            Console.Write("Enter Email: ");
            string email = Console.ReadLine().Trim();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            Users user = context.User.FirstOrDefault(u => u.Email == email && u.Password == password);

            if (user != null)
            {
                loggedInUserId = user.userID;

                Console.WriteLine("\nLogin successful.");
                Console.WriteLine($"Welcome " + user.Firstname + user.Lastname);
            }
            else
            {
                Console.WriteLine("\nInvalid email or password.");
            }
        }

        // 3.add new Category
        public static void AddCategory()
        {
            Category category = new Category();

            while (true)
            {
                Console.Write("Enter Category Name: ");
                category.CategoryName = Console.ReadLine().Trim();

                if (string.IsNullOrWhiteSpace(category.CategoryName))
                {
                    Console.WriteLine("Category name cannot be empty.");
                    continue;
                }

                bool exists = context.Category.Any(c => c.CategoryName.ToLower() == category.CategoryName.ToLower());

                if (exists)
                {
                    Console.WriteLine("Category already exists.");
                    continue;
                }

                break;
            }

            context.Category.Add(category);
            context.SaveChanges();

            Console.WriteLine("\nCategory added successfully.");
            Console.WriteLine($"Category ID: {category.CategoryId}");
        }


        // 4.add Product
        static void AddProduct()
        {
            Console.WriteLine("Enter Product Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Product Price:");
            decimal price = decimal.Parse(Console.ReadLine());


            // Display existing categories
            var categories = context.Category.ToList();

            Console.WriteLine("\nAvailable Categories:");

            foreach (var category in categories)
            {
                Console.WriteLine(+category.CategoryId + " - " + category.CategoryName);
            }


            Console.WriteLine("\nChoose Category ID:");
            int categoryId = int.Parse(Console.ReadLine());


            // Find selected category
            var selectedCategory = context.Category.FirstOrDefault(c => c.CategoryId == categoryId);


            if (selectedCategory == null)
            {
                Console.WriteLine("Category not found!");
                return;
            }


            // Create new product
            Product product = new Product()
            {
                ProductName = name,
                Price = price,

                // Link product with category
                C = selectedCategory
            };


            // Save to database
            context.Product.Add(product);
            context.SaveChanges();


            Console.WriteLine("Product added successfully!");
        }

        // 5.view all products

        static void ViewAllProducts()
        {
            Console.WriteLine("Do you want to filter by category? (y/n)");
            string choice = Console.ReadLine();


            var products = context.Product.ToList();



            if (choice.ToLower() == "y")
            {
                Console.WriteLine("Enter Category ID:");
                int categoryId = int.Parse(Console.ReadLine());

                products = products.Where(p => p.CategoryId == categoryId).ToList();

            }

            if (products.Count == 0)
            {
                Console.WriteLine("No products found!");
                return;
            }


            Console.WriteLine("\nProduct List:");
            Console.WriteLine("--------------------------------");


            foreach (var product in products)
            {
                Console.WriteLine($"Name     : {product.ProductName}");
                Console.WriteLine($"Price    : {product.Price} OMR");
                Console.WriteLine($"Category : {product.C.CategoryName}");
                Console.WriteLine("--------------------------------");
            }
        }

        //6.place an Order

        static void PlaceOrder()
        {

            decimal totalAmount = 0;


            if (loggedInUserId == 0)
            {
                Console.WriteLine("Error: Please login first!");
                return;
            }


            List<Order_Product> orderProducts = new List<Order_Product>();


            while (true)
            {

                // showing the products
                var products = context.Product.ToList();

                Console.WriteLine("\nAvailable Products:");

                foreach (var product in products)
                {
                    Console.WriteLine(+product.ProductId + "-" + product.ProductName + "-" + product.Price + " OMR");
                    Console.WriteLine("-----------------------------------------");
                }


                // selecting the products
                Console.WriteLine("\nEnter Product ID:");
                int productId = int.Parse(Console.ReadLine());


                var selectedProduct = context.Product.FirstOrDefault(p => p.ProductId == productId);


                if (selectedProduct == null)
                {
                    Console.WriteLine("Product not found!");
                    continue;
                }

                // adding the quantity
                Console.WriteLine("Enter Quantity:");
                int quantity = int.Parse(Console.ReadLine());

                totalAmount += selectedProduct.Price * quantity;

                Order_Product orderProduct = new Order_Product()
                {
                    ProductId = selectedProduct.ProductId,
                    Quantity = quantity,

                };



                orderProducts.Add(orderProduct);

                // asking the user if he wants more products
                Console.WriteLine("Add another product? (y/n)");
                string answer = Console.ReadLine();


                if (answer.ToLower() != "y")
                {
                    break;
                }
            }

            // adding the order
            Order order = new Order()
            {
                UserID = loggedInUserId,
                OrderDate = DateTime.Now,
                TotalAmount = totalAmount.ToString(),


                // Linking Order with Order_Product
                P = orderProducts
            };



            context.Order.Add(order);
            context.SaveChanges();


            Console.WriteLine("Order placed successfully!");
        }

        // 7. View My Orders  
        //with the products that user ordred through {product-order} table 
        static void ViewMyOrders()
        {

            if (loggedInUserId == 0)
            {
                Console.WriteLine("Error: Please login first!");
                return;
            }

            var products = context.Product.ToList();

            var orders = context.Order.Where(o => o.UserID == loggedInUserId).ToList();

            if (orders.Count == 0)
            {
                Console.WriteLine("No orders found.");
                return;
            }

            Console.WriteLine("\nMy Orders");


            foreach (var order in orders)
            {
                Console.WriteLine("Order ID     : " + order.OrderId);
                Console.WriteLine("Order Date   : " + order.OrderDate);
                Console.WriteLine("Total Amount : " + order.TotalAmount);
                Console.WriteLine("--------------------------------");

                var orderProducts = context.Order_Product.Where(op => op.OrderId == order.OrderId).ToList();

                foreach (var op in orderProducts)
                {
                    var product = context.Product.FirstOrDefault(p => p.ProductId == op.ProductId);

                    if (product != null)
                    {
                        Console.WriteLine("Product: " + product.ProductName);
                        Console.WriteLine("Price   : " + product.Price);
                        Console.WriteLine("Quantity: " + op.Quantity);
                        Console.WriteLine("---------------------------");
                    }
                }
            }

        }

        // 8.View Order Details

        static void ViewOrderDetails()
        {
            Console.WriteLine("Enter Order ID:");
            int orderId = int.Parse(Console.ReadLine());

            // Find the order
            var order = context.Order.FirstOrDefault(o => o.OrderId == orderId);

            if (order == null)
            {
                Console.WriteLine("Order not found!");
                return;
            }

            Console.WriteLine("\nOrder Details");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Order ID     : " + order.OrderId);
            Console.WriteLine("Order Date   : " + order.OrderDate);
            Console.WriteLine("Total Amount : " + order.TotalAmount);

            Console.WriteLine("\nProducts:");
            Console.WriteLine("--------------------------------");

            // Get all products in the order
            var orderProducts = context.Order_Product.Where(op => op.OrderId == orderId).ToList();

            foreach (var op in orderProducts)
            {
                var product = context.Product .FirstOrDefault(p => p.ProductId == op.ProductId);

                if (product != null)
                {
                    Console.WriteLine("Product  : " + product.ProductName);
                    Console.WriteLine("Price    : " + product.Price);
                    Console.WriteLine("Quantity : " + op.Quantity);
                    Console.WriteLine("--------------------------------");
                }
            }

            // Check if the order has a review
            var review = context.Reviews.FirstOrDefault(r => r.OrderId == orderId);

            Console.WriteLine("\nReview:");
            if (review != null)
            {
                Console.WriteLine(review.Comment);
                // If your Review class has a Rating property:
                // Console.WriteLine("Rating: " + review.Rating);
            }
            else
            {
                Console.WriteLine("No review for this order.");
            }
        }

        // 9.Add Reviews

        static void AddReview()
        {
            // Check if user is logged in
            if (loggedInUserId == 0)
            {
                Console.WriteLine("Please login first!");
                return;
            }

            Console.WriteLine("Enter Order ID:");
            int orderId = int.Parse(Console.ReadLine());

            // Check if the order belongs to the logged-in user
            var order = context.Order.FirstOrDefault(o => o.OrderId == orderId && o.UserID == loggedInUserId);

            if (order == null)
            {
                Console.WriteLine("This order does not belong to you.");
                return;
            }

            // Check if the order already has a review
            var review = context.Reviews
                                .FirstOrDefault(r => r.OrderId == orderId);

            if (review != null)
            {
                Console.WriteLine("This order already has a review.");
                return;
            }

            Console.WriteLine("Enter Rating (1 -> 5):");
            int rating = int.Parse(Console.ReadLine());

            if (rating < 1 || rating > 5)
            {
                Console.WriteLine("Rating must be between 1 and 5 ");
                return;
            }

            Console.WriteLine("Enter Comment:");
            string comment = Console.ReadLine();

            Review newReview = new Review()
            {
                Ratings = rating,
                Comment = comment,
                OrderId = orderId,
                userID = loggedInUserId
            };

            context.Reviews.Add(newReview);
            context.SaveChanges();

            Console.WriteLine("Review added successfully!");
        }

        // 10.View Reviews For the Product

        static void ViewReviewsForProduct()
        {
            Console.WriteLine("Enter Product ID:");
            int productId = int.Parse(Console.ReadLine());

            // Check if the product exists
            var product = context.Product.FirstOrDefault(p => p.ProductId == productId);

            if (product == null)
            {
                Console.WriteLine("Product not found!");
                return;
            }

            Console.WriteLine("\nProduct: " + product.ProductName);
            Console.WriteLine("--------------------------------");

            // Get all orders that contain this product
            var orderProducts = context.Order_Product .Where(op => op.ProductId == productId).ToList();

            if (orderProducts.Count == 0)
            {
                Console.WriteLine("This product has never been ordered.");
                return;
            }

            bool hasReviews = false;

            foreach (var op in orderProducts)
            {
                // Find the review for this order
                var review = context.Reviews  .FirstOrDefault(r => r.OrderId == op.OrderId);

                if (review != null)
                {
                    hasReviews = true;

                    Console.WriteLine("Rating   : " + review.Ratings);
                    Console.WriteLine("Comment  : " + review.Comment);
                    Console.WriteLine("--------------------------------");
                }
            }

            if (!hasReviews)
            {
                Console.WriteLine("No reviews found for this product.");
            }
        }






























    }
}
