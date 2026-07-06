using System.ComponentModel;

namespace C__Fundamentals___Part_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////task-1---------EASY ------------------------------------------------------------------------
            //Console.WriteLine("Enter the first number: ");
            //double Num1 = double.Parse(Console.ReadLine());


            //Console.WriteLine("Enter the first number: ");
            //double Num2 = double.Parse(Console.ReadLine());


            //double subtraction = Math.Abs(Num1 - Num2);
            //Console.WriteLine("the result of subtaction of "+Num1 +"-" + Num2 + "= " + subtraction);

            ////task-1---------EASY ------------------------------------------------------------------------

            ////task-2---------EASY ------------------------------------------------------------------------


            //Console.WriteLine("Enter the number: ");
            //int number = int.Parse(Console.ReadLine());

            //double squar = Math.Pow(number, 2);
            //double squareRoot = Math.Sqrt(number);

            
            //Console.WriteLine("the square of " + number + " = " + squar);
            //Console.WriteLine("the square root of " + number + " = " + squareRoot);
            ////task-2---------EASY ------------------------------------------------------------------------

            ////task-3---------EASY ------------------------------------------------------------------------
            
            //Console.WriteLine("Enter you full name: ");
            //string fullName = Console.ReadLine();

            //Console.WriteLine("The lower case style of "+ fullName +" => " + fullName.ToLower());
            //Console.WriteLine("The upper case style of " + fullName + " => "+ fullName.ToUpper());


            //int length =  fullName.Length;
            //Console.WriteLine("The length of "+ fullName +" is "+ length +" characters");

            ////task-3---------EASY ------------------------------------------------------------------------

            ////task-4---------EASY ------------------------------------------------------------------------


           
            //Console.WriteLine("Enter the number of days for the trial period: ");
            //int trailDays = int.Parse(Console.ReadLine());


            //DateTime currentDate = DateTime.Now;
            //DateTime endDate = currentDate.AddDays(trailDays);

           
            //Console.WriteLine("The trial period will Start on: "+ currentDate.ToString("dd/MM/yyyy") 
            //    + "\n The trial period will end on: " + endDate.ToString("dd/MM/yyyy"));


            ////task-4---------EASY ------------------------------------------------------------------------

            //task-5---------MEDIUM ------------------------------------------------------------------------
            
            Console.WriteLine("Enter your Exam score: ");
            float Score = float.Parse(Console.ReadLine());

            double RaundedScore = Math.Round(Score,0);
            
            if (RaundedScore >= 60)
            { 
                Console.WriteLine("Congratulations! You passed the exam with a score of " + RaundedScore);
            }
            else
            {
                Console.WriteLine("Sorry, you failed the exam with a score of " + RaundedScore);
            }

            //task-5---------MEDIUM ------------------------------------------------------------------------















        }
    }
}
