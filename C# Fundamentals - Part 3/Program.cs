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

            ////task-5---------MEDIUM ------------------------------------------------------------------------

            //Console.WriteLine("Enter your Exam score: ");
            //float Score = float.Parse(Console.ReadLine());

            //double RaundedScore = Math.Round(Score,0);

            //if (RaundedScore >= 60)
            //{ 
            //    Console.WriteLine("Congratulations! You passed the exam with a score of " + RaundedScore);
            //}
            //else
            //{
            //    Console.WriteLine("Sorry, you failed the exam with a score of " + RaundedScore);
            //}

            ////task-5---------MEDIUM ------------------------------------------------------------------------

            //task - 6-------- - MEDIUM------------------------------------------------------------------------



            //string NotAllowed = "password";
            //Console.WriteLine("Enter the password: ");
            //string Password = Console.ReadLine();


            //int passLength = Password.Length;
            //if (!Password.ToLower().Contains("password") && passLength >= 8)
            //{
            //    Console.WriteLine("Password is strong");
            //}
            //else
            //{
            //    Console.WriteLine("Weak password");

            //    if (Password.Length < 8)
            //    {
            //        Console.WriteLine("Reason: Password must be at least 8 characters long.");
            //    }

            //    if (Password.ToLower().Contains("password"))
            //    {
            //        Console.WriteLine("Reason: Password must not contain the word \"password\".");
            //    }
            //}


            //task - 6-------- - MEDIUM------------------------------------------------------------------------

            // //task-7---------MEDIUM ------------------------------------------------------------------------

            // Console.WriteLine("enter the username: ");
            // string username = Console.ReadLine();

            // Console.WriteLine("enter the username again: ");
            // string username2 = Console.ReadLine();

            //string trimedusername = username.Trim().ToLower();
            //string trimedusername2 = username2.Trim().ToLower();


            // if (trimedusername == trimedusername2)
            // {
            //     Console.WriteLine("Match");
            // }
            // else
            // {
            //     Console.WriteLine("No Match");
            // }


            // //task-7---------MEDIUM ------------------------------------------------------------------------

            //   //task-8---------MEDIUM ------------------------------------------------------------------------
            //   try 
            //   { 
            //   Console.WriteLine("enter their membership start date ");
            //   DateTime MembershipDate = DateTime.Parse(Console.ReadLine());

            //   Console.WriteLine(MembershipDate);
            //   Console.WriteLine("enter the number of valid membership days ");
            //   int validDays = int.Parse(Console.ReadLine());

            //   DateTime ExpirationDate = MembershipDate.AddDays(validDays);

            //       if (ExpirationDate >= DateTime.Today)
            //       {
            //           Console.WriteLine("Active");
            //       }
            //       else
            //       {
            //           Console.WriteLine("Expired");
            //       }

            //   }

            //catch
            //   { 
            //   Console.WriteLine("Invalid input. Please enter a valid date and number of days.");
            //   }

            //   //task-8---------MEDIUM ------------------------------------------------------------------------



            //// task - 9--------- HARD------------------------------------------------------------------------

            //Console.WriteLine("Enter decimal number to round it ");
            //double decNumber = double.Parse(Console.ReadLine());

            //Console.WriteLine("the rounding up of " + decNumber +" = " + Math.Ceiling(decNumber));
            //Console.WriteLine("the rounding down of " + decNumber + " = " + Math.Floor(decNumber));
            //Console.WriteLine("the rounding to the nearest whole number  " + decNumber + " = " + Math.Round(decNumber));


            //// task - 9-------- - HARD------------------------------------------------------------------------



             // task - 10-------- - HARD------------------------------------------------------------------------
           
            Console.WriteLine("Enter a sentence: ");
            string Sentence = Console.ReadLine();


            Console.Write("Enter a word to search for: ");
            string word = Console.ReadLine();

            int FirstAppear =Sentence.IndexOf(word);
            int LastAppear =Sentence.LastIndexOf(word);



            if (FirstAppear == -1 || LastAppear == -1)
            {
                Console.WriteLine("Word not found.");
            }
            else
            {
                Console.WriteLine("\nThe first occurrence of the word is at index: " + FirstAppear);
                Console.WriteLine("\nThe Last occurrence of the word is at index:" + LastAppear);

            }





            // task - 10-------- - HARD------------------------------------------------------------------------





        }
    }
}
