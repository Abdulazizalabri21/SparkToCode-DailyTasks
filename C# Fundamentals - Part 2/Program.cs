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


            //task-4--------------EASY-------------------------------------------------------

          

            string password = "Spark2026";
            string Pass = "";

            while (Pass != password)
            {
                Console.WriteLine("Enter the Password ");
                Pass = Console.ReadLine();
                Console.WriteLine(" ");

                if (Pass != password)
                {
                    Console.WriteLine("Incorrect password. Please try again. ");
                }

            }
            Console.WriteLine("Access Granted ");


            //task-4--------------EASY-------------------------------------------------------
























        }
    }
}
