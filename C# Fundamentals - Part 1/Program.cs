using System.ComponentModel.Design;
using System.Xml;

namespace C__Fundamentals___Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // //task-1---------EASY ----------------------------------------------------------------------------
            // String personalname = "Abdulaziz";
            // bool studentornot = false;
            // int age = 20;
            // Double height = 1.76;

            // Console.WriteLine("Name:" + personalname + " Age:" + age + " height:" + height + " student:" + studentornot);
            // //task-1--------------EASY---------------------------------------------------------------------------




            // //task-2--------------EASY-------------------------------------------------------------------------
            // Console.WriteLine(" ");

            // Console.WriteLine("Plese enter the length ");
            // Double length = double.Parse(Console.ReadLine());

            // Console.WriteLine("Plese enter the Width ");
            // Double Width = double.Parse(Console.ReadLine());

            // double Area = length * Width;
            // double Perimeter = 2 * (length + Width);

            // Console.WriteLine("the area = " + Area);
            // Console.WriteLine("the Perimeter = " + Perimeter);
            // //task-2--------------EASY-----------------------------------------------------------------------



            // //task-3--------------EASY-------------------------------------------------------------------------

            // Console.WriteLine(" To check if the number is odd or even,please enter a whole number");
            // int number = int.Parse(Console.ReadLine());

            // int remainder = number % 2;

            // if (remainder != 0)
            // {
            //     Console.WriteLine("The number is odd");
            // }
            // else
            // {
            //     Console.WriteLine("The number is even");
            // }
            // //task-3-----------EASY---------------------------------------------------------------------------


            // //task-4-----------EASY---------------------------------------------------------------------------

            // Console.WriteLine("Enter your Age plese");
            // int Age = int.Parse(Console.ReadLine());

            // Console.WriteLine("Do you have a valid national ID? yes/no in lowercase only");
            // string IdInput = Console.ReadLine();

            // bool ValidId = (IdInput == "yes");
            // if (ValidId && Age >= 18)
            // {
            //     Console.WriteLine("You are eligible to vote");
            // }
            // else
            // {
            //     Console.WriteLine("You are NOT eligible to vote");
            // }
            // //task-4------------EASY-----------------------------------------------------------------------------

            ////task-5---------------EASY------------------------------------------------------------------------

            // Console.WriteLine("Enter a character ");
            // Char character = char.Parse(Console.ReadLine());

            // switch (character)
            // { 

            //     case 'A':
            //         Console.WriteLine("EXCELLENT");
            //         break;

            //     case 'B':
            //         Console.WriteLine("VERY GOOD");
            //         break;

            //     case 'C':

            //         Console.WriteLine("GOOD");
            //         break;

            //     case 'D':

            //         Console.WriteLine(" PSS");
            //         break;

            //     case'F': 

            //         Console.WriteLine("FAILL");
            //         break;

            //     default: 

            //         Console.WriteLine("Invalid character");
            //         break;

            // }

            ////task-5---------------EASY-------------------------------------------------------------------------




            ////task-6-------MEDIUM --------------------------------------------------------------------
            //Console.WriteLine(" Enter the temperature in Celsius ");
            //double Celsius = double.Parse(Console.ReadLine());

            //double F = (Celsius * 9 / 5) + 32;

            //if (Celsius <= 10)
            //{
            //    Console.WriteLine("The temperature in Fahrenheit is " + F + " and it is cold");
            //}
            //else if (Celsius > 10 && Celsius <= 30)
            //{
            //    Console.WriteLine("The temperature in Fahrenheit is " + F + " and it is Mild");
            //}
            //else
            //{
            //    Console.WriteLine("The temperature in Fahrenheit is " + F + " and it is hot");

            //}
            ////task-6-------MEDIUM --------------------------------------------------------------------

            ////task-7-------MEDIUM --------------------------------------------------------------------

            //Console.WriteLine("Enter your Age ");
            //int Age = int.Parse(Console.ReadLine());

            //if (Age >= 0 && Age <= 12)
            //{
            //    Console.WriteLine("You are a child so your ticket price 2.000 OMR");
            //}
            //else if (Age >= 13 && Age <= 59)
            //{
            //    Console.WriteLine("You are an adult so your ticket price 5.000 OMR");

            //}
            //else
            //{
            //    Console.WriteLine("You are a senior so your ticket price 3.000 OMR");
            //}

            ////task-7-------MEDIUM --------------------------------------------------------------------


            ////task-8------MEDIUM --------------------------------------------------------------------

            //Console.WriteLine("Is this your first time here (YES/NO)? ");
            //string loyalty = Console.ReadLine().ToUpper();
            //Console.WriteLine("Enter your bill amount");
            //double billAmount = double.Parse(Console.ReadLine());

            //if (loyalty == "YES" && billAmount >= 20)
            //{

            //    Console.WriteLine("You are got a 15% discount.");
            //    Console.WriteLine("the discount will be: " + (billAmount * 15) / 100);
            //    Console.WriteLine("Your final bill amount is: " + (billAmount - ((billAmount * 15) / 100)) + " OMR");
            //}
            //else
            //{
            //    Console.WriteLine("Your final bill amount is: " + billAmount+" OMR");
            //}

            //    //task-8-------MEDIUM --------------------------------------------------------------------


            //task-9------MEDIUM --------------------------------------------------------------------


            //Console.WriteLine("Please Enter The day Number ");
            //int DayNumber = int.Parse (Console.ReadLine());


            //switch (DayNumber) 
            //{

            //case 1:
            //        Console.WriteLine("The day is Sunday");
            //        break;
            //case 2:
            //        Console.WriteLine("The day is Monday");
            //        break;
            //case 3:

            //        Console.WriteLine("The day is Tuesday");
            //        break;
            //case 4:
            //        Console.WriteLine("The day is Wednesday");
            //        break;

            //case 5:
            //        Console.WriteLine("The day is Thursday");
            //        break;

            //case 6:
            //        Console.WriteLine("The day is Friday");
            //        break;
            //case 7:
            //        Console.WriteLine("The day is Saturday");
            //        break;
            //default:
            //        Console.WriteLine("Invalid day number");
            //        break;

            //}

            ////task-9-------MEDIUM -------------------------------------------------------------------


            //task-10-------MEDIUM -------------------------------------------------------------------


            //Console.Write("Enter the first number: ");
            //Double num1 = Double.Parse(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //Double num2 = Double.Parse(Console.ReadLine());

            //Console.Write("Enter an operator ot the Operation that you want to Implemant (+, -, *, /, %): ");
            //char OperationCh = char.Parse( Console.ReadLine());

            //switch (OperationCh)
            //{
            //    case '+':
            //        Console.WriteLine("Result = " + (num1 + num2));
            //        break;

            //    case '-':
            //        Console.WriteLine("Result = " + (num1 - num2));
            //        break;

            //    case '*':
            //        Console.WriteLine("Result = " + (num1 * num2));
            //        break;

            //    case '/':
            //        if (num2 != 0)
            //            Console.WriteLine("Result = " + (num1 / (double)num2));
            //        else
            //            Console.WriteLine("Cannot divide by zero");
            //        break;

            //    case '%':
            //        if (num2 != 0)
            //            Console.WriteLine("Result = " + (num1 % num2));
            //        else
            //            Console.WriteLine("Cannot divide by zero");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid operator please use only (+, -, *, /, %) ");
            //        break;
            //}

            ////task-10-------MEDIUM -------------------------------------------------------------------

            ////task-11-------Hard -------------------------------------------------------------------


            //Console.WriteLine("Enter your Age: ");
            //int Age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your monthly income: ");
            //int Mincome = int.Parse(Console.ReadLine());

            //Console.WriteLine(" have an existing loan (yes/no): ");
            //String ExistingLoan = Console.ReadLine().ToLower();


            //if (Age>=21 && Age<= 60 && Mincome >= 400 && ExistingLoan != "yes")
            //{
            //    Console.WriteLine("You are eligible for a loan.");
            //}
            //else
            //{

            //    if (Age < 21 || Age > 60)
            //    {
            //        Console.WriteLine("You are ineligible for a loan.");
            //        Console.WriteLine("Reason: Age must be between 21 and 60.");
            //    }
            //    if (Mincome < 400)
            //    {
            //        Console.WriteLine("You are ineligible for a loan.");
            //        Console.WriteLine("Reason: Monthly income must be at least 400.");
            //    }

            //    if (ExistingLoan =="yes") 
            //    {
            //        Console.WriteLine("You are ineligible for a loan.");
            //        Console.WriteLine("Reason: You must not have an existing loan.");
            //    }
            //}

            ////task-11-------Hard -------------------------------------------------------------------


            ////task-12-------Hard -------------------------------------------------------------------



            //Console.WriteLine("the package weight (in kg) please: ");
            //double PackageWeight = double.Parse(Console.ReadLine());

            //Console.WriteLine("Where you Want to Send the package ('A' for local, 'B' for national, 'C' for international): ");
            //char regioncode = Char.Parse(Console.ReadLine().ToLower());

            //double baseCost = 0;
            //double extraCharge = 0;


            //switch (regioncode)
            //{
            //    case 'a':
            //        baseCost = 1.000;

            //        if (PackageWeight > 10)

            //        {
            //            extraCharge = 5.000;
            //        }

            //        else if (PackageWeight > 5)
            //        {
            //            extraCharge = 2.000;
            //        }

            //        Console.WriteLine("Base Cost: " + baseCost + " OMR");
            //        Console.WriteLine("Extra Charge: " + extraCharge + " OMR");
            //        Console.WriteLine("Total Cost: " + (baseCost + extraCharge) + " OMR");
            //        break;

            //    case 'b':
            //        baseCost = 3.000;

            //        if (PackageWeight > 10)

            //        {
            //            extraCharge = 5.000;
            //        }

            //        else if (PackageWeight > 5)
            //        {
            //            extraCharge = 2.000;
            //        }

            //        Console.WriteLine("Base Cost: " + baseCost + " OMR");
            //        Console.WriteLine("Extra Charge: " + extraCharge + " OMR");
            //        Console.WriteLine("Total Cost: " + (baseCost + extraCharge) + " OMR");
            //        break;


            //    case 'c':
            //        baseCost = 7.000;

            //        if (PackageWeight > 10)

            //        { 
            //            extraCharge = 5.000;
            //        }

            //        else if (PackageWeight > 5)
            //        {
            //            extraCharge = 2.000;
            //        }

            //        Console.WriteLine("Base Cost: " + baseCost + " OMR");
            //        Console.WriteLine("Extra Charge: " + extraCharge + " OMR");
            //        Console.WriteLine("Total Cost: " + (baseCost + extraCharge) + " OMR");
            //        break;


            //        default: 
            //        Console.WriteLine("Invalid region code. Please enter 'A', 'B', or 'C'.");
            //        break;
            //}

            //task-12-------Hard -------------------------------------------------------------------


            //task-13-------Hard -------------------------------------------------------------------

            Console.Write("Enter the length of the first side: ");
            double side1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the length of the second side: ");
            double side2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the length of the third side: ");
            double side3 = double.Parse(Console.ReadLine());

            if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
            {
                Console.WriteLine("Valid triangle\"");
                if (side1 == side2 && side1 == side3 && side2 == side3) 
                {
                    Console.WriteLine("the trianglr is equilateral (all sides equal)\"");
                }

                else   
                {
                    if (side1 == side2 || side1 == side3 || side2 == side3)
                    {
                        Console.WriteLine("the trianglr isIsosceles (exactly two sides equal)\"");
                    }
                    else
                    {
                        Console.WriteLine("the trianglr is Scalene (all sides different)\"");
                    }
                }



            }
            else
            {
                Console.WriteLine("Invalid triangle");
            }


            //task-13-------Hard -------------------------------------------------------------------






















































        }
    }
}
