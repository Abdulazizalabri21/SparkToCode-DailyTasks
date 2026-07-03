namespace C__Fundamentals___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task-1---------EASY ----------------------------------------------------------------------------

            Console.WriteLine("Enter the starting number. ");
            int STnumber =int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            for (int Snumber = STnumber ; STnumber >= 1; STnumber--)
            { 
            Console.WriteLine(STnumber + "  " );
            }
            Console.WriteLine("Liftoff");
            //task-1--------------EASY---------------------------------------------------------------------------
        }
    }
}
