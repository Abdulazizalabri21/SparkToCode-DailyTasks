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


        // Task 3 - Celsius to Fahrenheit Function

        public static double CelsiusToFahrenheit(double celsius)
        {
            double F = (celsius * 9 / 5) + 32;
            return F;
        }


        // Task 4 - Fixed Menu Display Function

        public static void DisplayMenu()
        {
            Console.WriteLine("1. Start");
            Console.WriteLine("2. Help");
            Console.WriteLine("4. Exit");
        }

        //Task 5 - Even or Odd Function
        public static bool IsEven(int number)

        {
            return (number % 2 == 0);
        }

        //Task 6 - Rectangle Area & Perimeter Functions

        public static double CalculateArea(double length, double width)
        {
            return length * width;
        }

        public static double CalculatePerimeter(double length, double width)
        {
            return 2 * (length + width);

        }

        //Task 7 - Grade Letter Function

        public static string GetGradeLetter(int score)
        {
          
                if (score >= 90)
                {
                    return "A";
                }
                else if (score >= 80)
                {
                    return "B";
                }
                else if (score >= 70)
                {
                    return "C";
                }
                else if (score >= 60)
                {
                    return "D";
                }
                else
                {
                    return "F";
                }
        }

        //Task 8 - Countdown Function
        public static void Countdown(int start)
        {
            for (int i = start; i >= 1; i--)
            {
                Console.WriteLine(i);
               
            }
        }

        //Task 9 - Overloaded Multiply Function
         
        public static int Multiply(int a, int b)// --1
        {
            return a * b;
        }

        public static double Multiply(double a, double b)//--2
        {
            return a * b;
        }
        public static int Multiply(int a, int b, int c)//--3
        {
            return a * b * c;
        }

        //Task 10 - Overloaded Area Calculator

        public static double Area(double length, double width) // for rectangle
        {
            return length * width;
        }
        public static double Area(double a) // for square
        {
         return Math.Pow( a , 2);        
        }




        static void Main(string[] args)
            {
            /*          //Task 1 - Personalized Welcome Function----------

                      Console.WriteLine("Enter your name: ");
                      string name = Console.ReadLine();
                      PrintWelcome(name);
                      //Task 1 - Personalized Welcome Function-------

                      //Task 2 - Square Number Function-----------
                      Console.WriteLine("Enter the Number: ");
                      int Number = int.Parse(Console.ReadLine());
                      Console.WriteLine("the square =" + SquareNumber(Number));

                      //Task 2 - Square Number Function----------

                      // Task 3 - Celsius to Fahrenheit Function
                      Console.WriteLine("Enter the Celsius degree: ");
                      double Celsius = double.Parse(Console.ReadLine());

                      double ConvertedDegree = CelsiusToFahrenheit(Celsius);
                      Console.WriteLine("The converted degree in Fahrenheit is: " + ConvertedDegree);

                      // Task 3 - Celsius to Fahrenheit Function

                      // Task 4 - Fixed Menu Display Function

                      DisplayMenu(); // clall the DisplayMenu function to show the menu options

                      //Task 4 - Fixed Menu Display Function


                      //Task 5 - Even or Odd Function
                      Console.WriteLine("Enter the Number: ");
                      int Num = int.Parse(Console.ReadLine());

                      bool Result = IsEven(Num);
                      if (Result == true)
                      {
                          Console.WriteLine("The number is Even");
                      }
                      else
                      {
                          Console.WriteLine("The number is Odd");
                      }
                          //Task 5 - Even or Odd Function


                     //Task 6 - Rectangle Area & Perimeter Functions


                     Console.WriteLine("enter the length:");
                     double length= double.Parse(Console.ReadLine());

                     Console.WriteLine("Enter the width");
                     double width = double.Parse(Console.ReadLine());

                     Console.WriteLine("the area = "+CalculateArea(length , width));
                     Console.WriteLine("the Perimeter = " + CalculatePerimeter(length, width));

                    //Task 6 - Rectangle Area & Perimeter Functions


         

            //Task 7 - Grade Letter Function

            Console.WriteLine("Enter your exam score: ");
                int score = int.Parse(Console.ReadLine());

                Console.WriteLine("Your Grade => " + (GetGradeLetter(score)));

            //Task 7 - Grade Letter Function



            //Task 8 - Countdown Function

            Console.WriteLine("Enter the starting number for countdown: ");
            int StartingNumber = int.Parse(Console.ReadLine());

           Program.Countdown(StartingNumber);



            //Task 8 - Countdown Function






            //Task 9 - Overloaded Multiply Function

            Console.WriteLine("Multiply(int, int) = " + Multiply(1, 2));
            Console.WriteLine("Multiply(double, double) = " +Multiply(2.5, 3.3));
            Console.WriteLine("Multiply(int, int, int) = " +   Multiply (1,6,5));


            //Task 9 - Overloaded Multiply Function
*/

            //Task 10 - Overloaded Area Calculator


            Console.WriteLine(  Area(5, 10)); // for rectangle
            Console.WriteLine(Area(10));      // for square



            //Task 10 - Overloaded Area Calculator

























        }

    }
}
