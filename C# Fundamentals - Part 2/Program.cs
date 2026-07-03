namespace C__Fundamentals___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////task-1---------EASY ----------------------------------------------------------------------------

            //Console.WriteLine("Enter the starting number. ");
            //int STnumber =int.Parse(Console.ReadLine());
            //Console.WriteLine(" ");

            //for (int Snumber = STnumber ; STnumber >= 1; STnumber--)
            //{ 
            //Console.WriteLine(STnumber + "  " );
            //}
            //Console.WriteLine("Liftoff");
            ////task-1--------------EASY---------------------------------------------------------------------------



            ////task-2--------------EASY-------------------------------------------------------

            //Console.WriteLine("Enter the number (positive number only). ");
            //int number = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; i <= number; i++) 
            //{
            //    sum += i;
            //}
            //Console.WriteLine("The sum of the numbers from 1 to " + number + " is: " + sum);

            ////task-2--------------EASY-------------------------------------------------------


            ////task-3--------------EASY-------------------------------------------------------

            //Console.WriteLine("Enter the number");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(number + " x " + i + " = " + (number * i));
            //}

            ////task-3--------------EASY-------------------------------------------------------


            ////task-4--------------EASY-------------------------------------------------------



            //string password = "Spark2026";
            //string Pass = "";

            //while (Pass != password)
            //{
            //    Console.WriteLine("Enter the Password ");
            //    Pass = Console.ReadLine();
            //    Console.WriteLine(" ");

            //    if (Pass != password)
            //    {
            //        Console.WriteLine("Incorrect password. Please try again. ");
            //    }

            //}
            //Console.WriteLine("Access Granted ");


            ////task-4--------------EASY-------------------------------------------------------


            ////task-5--------------MEDIUM-------------------------------------------------------

            //int number= 55;
            //int guess = 0;
            //int attemptsCounter = 0;

            //do 
            //{ 
            //    Console.WriteLine("Guess the number ");
            //    guess = int.Parse(Console.ReadLine());
            //    attemptsCounter++;

            //    if (guess < number)
            //    {
            //        Console.WriteLine("Too low. Try again.");

            //    }
            //    else if (guess > number)
            //    {
            //        Console.WriteLine("Too high. Try again.");

            //    }

            //    else
            //    {
            //        Console.WriteLine("Congratulations, You guessed the number correctly ");
            //        Console.WriteLine("You attempts: " + attemptsCounter++);

            //    }


            //}

            //while ( guess < number || guess > number);



            ////task-5--------------MEDIUM-------------------------------------------------------


            //task-6--------------MEDIUM-------------------------------------------------------
            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());



            try
            {
                Console.WriteLine("Enter Second number");

                int num2 = int.Parse(Console.ReadLine());
                int result = num1 / num2;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Invalid input. you can not divide by zero.");
                Console.WriteLine(ex.Message);
            }
            

                //task-6--------------MEDIUM-------------------------------------------------------




















            }
        }
}
