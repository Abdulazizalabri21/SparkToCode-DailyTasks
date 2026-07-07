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


        static void Main(string[] args)
        {
            //Task 1 - Personalized Welcome Function----------

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            PrintWelcome(name);
            //Task 1 - Personalized Welcome Function-------




        }
    }
}
