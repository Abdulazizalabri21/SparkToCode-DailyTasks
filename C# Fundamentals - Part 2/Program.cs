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



            //task-2--------------EASY-------------------------------------------------------
            
            Console.WriteLine("Enter the number (positive number only). ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= number; i++) 
            {
                sum += i;
            }
            Console.WriteLine("The sum of the numbers from 1 to " + number + " is: " + sum);


            //task-2--------------EASY-------------------------------------------------------



        }
    }
}
