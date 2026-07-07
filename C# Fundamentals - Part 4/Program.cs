using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Fundamentals___Part_4
{
    internal class Program
    {

        //Task 1 - Personalized Welcome Function
        public static void PrintWelcome(string name)
        {
            Console.WriteLine($"Welcome Mr/Ms "+ name);
        }

        // Task 2 - Square Number Function

        public static int SquareNumber(int number)
        {
            return number * number;
        }



        static void Main(string[] args)
        {
            //Task 1 - Personalized Welcome Function----------

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            PrintWelcome(name);
            //Task 1 - Personalized Welcome Function-------

            //Task 2 - Square Number Function-----------
            Console.WriteLine("Enter the Number: ");
            int Number = int.Parse(Console.ReadLine());
            Console.WriteLine("the square =" + SquareNumber(Number));

            //Task 2 - Square Number Function----------




        }
    }
}
