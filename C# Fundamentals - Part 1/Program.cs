using System.ComponentModel.Design;
using System.Xml;

namespace C__Fundamentals___Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //task-1---------EASY ----------------------------------------------------------------------------
             String personalname = "Abdulaziz";
             bool studentornot = false;
             int age = 20;
             Double height = 1.76;

             Console.WriteLine("Name:" + personalname + " Age:" + age + " height:" + height + " student:" + studentornot);
             //task-1--------------EASY---------------------------------------------------------------------------




             //task-2--------------EASY-------------------------------------------------------------------------
             Console.WriteLine(" ");

             Console.WriteLine("Plese enter the length ");
             Double length = double.Parse(Console.ReadLine());

             Console.WriteLine("Plese enter the Width ");
             Double Width = double.Parse(Console.ReadLine());

             double Area = length * Width;
             double Perimeter = 2 * (length + Width);

             Console.WriteLine("the area = " + Area);
             Console.WriteLine("the Perimeter = " + Perimeter);
             //task-2--------------EASY-----------------------------------------------------------------------



             //task-3--------------EASY-------------------------------------------------------------------------

             Console.WriteLine(" To check if the number is odd or even,please enter a whole number");
             int number = int.Parse(Console.ReadLine());

             int remainder = number % 2;

             if (remainder != 0)
             {
                 Console.WriteLine("The number is odd");
             }
             else
             {
                 Console.WriteLine("The number is even");
             }
             //task-3-----------EASY---------------------------------------------------------------------------


             //task-4-----------EASY---------------------------------------------------------------------------

             Console.WriteLine("Enter your Age plese");
             int Age = int.Parse(Console.ReadLine());

             Console.WriteLine("Do you have a valid national ID? yes/no in lowercase only");
             string IdInput = Console.ReadLine();

             bool ValidId = (IdInput == "yes");
             if (ValidId && Age >= 18)
             {
                 Console.WriteLine("You are eligible to vote");
             }
             else
             {
                 Console.WriteLine("You are NOT eligible to vote");
             }
             //task-4------------EASY-----------------------------------------------------------------------------
            */
            //task-5---------------EASY------------------------------------------------------------------------
            /*
             Console.WriteLine("Enter a character ");
             Char character = char.Parse(Console.ReadLine());

             switch (character)
             { 

                 case 'A':
                     Console.WriteLine("EXCELLENT");
                     break;

                 case 'B':
                     Console.WriteLine("VERY GOOD");
                     break;

                 case 'C':

                     Console.WriteLine("GOOD");
                     break;

                 case 'D':

                     Console.WriteLine(" PSS");
                     break;

                 case'F': 

                     Console.WriteLine("FAILL");
                     break;

                 default: 

                     Console.WriteLine("Invalid character");
                     break;

             }
             */
            //task-5---------------EASY-------------------------------------------------------------------------



            /*
            //task-6-------MEDIUM --------------------------------------------------------------------
            Console.WriteLine(" Enter the temperature in Celsius ");
            double Celsius = double.Parse(Console.ReadLine());

            double F = (Celsius * 9 / 5) + 32;

            if (Celsius <= 10)
            {
                Console.WriteLine("The temperature in Fahrenheit is " + F + " and it is cold");
            }
            else if (Celsius > 10 && Celsius <= 30)
            {
                Console.WriteLine("The temperature in Fahrenheit is " + F + " and it is Mild");
            }
            else
            {
                Console.WriteLine("The temperature in Fahrenheit is " + F + " and it is hot");

            }
            //task-6-------MEDIUM --------------------------------------------------------------------

            //task-7-------MEDIUM --------------------------------------------------------------------

            Console.WriteLine("Enter your Age ");
            int Age = int.Parse(Console.ReadLine());

            if (Age >= 0 && Age <= 12)
            {
                Console.WriteLine("You are a child so your ticket price 2.000 OMR");
            }
            else if (Age >= 13 && Age <= 59)
            {
                Console.WriteLine("You are an adult so your ticket price 5.000 OMR");

            }
            else
            {
                Console.WriteLine("You are a senior so your ticket price 3.000 OMR");
            }
            */
            //task-7-------MEDIUM --------------------------------------------------------------------


            //task-8------MEDIUM --------------------------------------------------------------------

            Console.WriteLine("Is this your first time here (YES/NO)? ");
            string loyalty = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter your bill amount");
            double billAmount = double.Parse(Console.ReadLine());

            if (loyalty == "YES" && billAmount >= 20)
            {

                Console.WriteLine("You are got a 15% discount.");
                Console.WriteLine("the discount will be: " + (billAmount * 15) / 100);
                Console.WriteLine("Your final bill amount is: " + (billAmount - ((billAmount * 15) / 100)) + " OMR");
            }
            else
            {
                Console.WriteLine("Your final bill amount is: " + billAmount+" OMR");
            }



















                //task-8-------MEDIUM --------------------------------------------------------------------


































































            }
    }
}
