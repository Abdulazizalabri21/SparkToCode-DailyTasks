using System.Collections;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Fundamentals___Part_5
{
    internal class Program
    {


        public static double CalculateAverage(List<int> grades)

        {
            return grades.Average();
        }


        public static int FindFirstFailing(List<int> grades)
        {
            return grades.Find(x => x < 60);
        }


        static Queue<string> RemoveJob(Queue<string> jobs, string jobToRemove)
        {
            Queue<string> updatedQueue = new Queue<string>();

            while (jobs.Count > 0)
            {
                string job = jobs.Dequeue();

                if (job != jobToRemove)
                {
                    updatedQueue.Enqueue(job);
                }
            }

            return updatedQueue;
        }
        static void Main(string[] args)
        {
            //Task 1 - Fixed Grades Array
            /*
            int[] grades = new int[5];

            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine("Enter a grade: ");
                grades[i] = int.Parse(Console.ReadLine());
            }


             Console.WriteLine("the grades: ");
            foreach (int i in grades)
            {
               
                Console.WriteLine(i);
            }


            //Task 1 - Fixed Grades Array
            

            List<string> ToDoList = new List<string>();
            Console.WriteLine("Enter your tasks for today: ");

            for (int i = 0;i < 5; i++)
            {
                
                ToDoList.Add(Console.ReadLine());
            }

            Console.WriteLine("----------------- your tasks--------------------- ");
           
            int counter = 1;
            foreach (string Tasks in ToDoList)
            {
                Console.WriteLine(counter + "==>> " +Tasks);
                counter ++;
            }
            Console.WriteLine("------------------ your tasks-------------------- ");


            //Task 3 - Browsing History Stack

             Stack <string> browserpagehistory = new Stack<string>();
             Console.WriteLine("Enter the pages you visited today: ");

            for (int i = 0; i < 3; i++)
            {
               
                browserpagehistory.Push(Console.ReadLine());
            }
          
            browserpagehistory.Pop();  // sumilating the user going back to the last page they visited

            Console.WriteLine("The last page you visited is: " + browserpagehistory.Peek());


            //Task 3 - Browsing History Stack
            

            //Task 4 - Customer Service Queue

            string CustomerL;
            Queue<string> customersLine = new Queue<string>();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Your Name");
                customersLine.Enqueue(Console.ReadLine());
            }

            customersLine.Peek();
            Console.WriteLine("\nThe first customer in line is: " + customersLine.Peek());

            string servedCustomer = customersLine.Dequeue();

      
            Console.WriteLine("\nCustomer served: " + servedCustomer);
            
            string nextCustomer = customersLine.Peek();
            Console.WriteLine("\nThe next customer in line is: " + nextCustomer);

            //Task 4 - Customer Service Queue


            //Task 5 - Array Grade Range

            double[] grades = new double[5];
            Console.WriteLine("Enter  the grades: ");

            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = double.Parse(Console.ReadLine());
            }

            Array.Sort(grades);

            double sum = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }
            Console.WriteLine("The grades results : ");
            Console.WriteLine("The average grade is: " + (sum / grades.Length));
            Console.WriteLine("The highest grade is: " + grades[grades.Length - 1]);
            Console.WriteLine("The lowest grade is: " + grades[0]);
            //Task 5 - Array Grade Range



                //Task 6 - Filtered Shopping List

            List<string> Shoppinglist = new List<string>();

            string input="";
            
           

            while (input.ToLower() !="done")
            {
                Console.Write("Enter the item you want to take or ('done' to finsh): ");
                input = Console.ReadLine();
                if (input.ToLower() != "done") 
                {
                
                Shoppinglist.Add(input);
                }
            }



            Console.WriteLine("\nShopping List:");

            if (Shoppinglist.Count > 0)
            {
                foreach (string items in Shoppinglist)
                {
                    Console.WriteLine("==> " + items);
                }
            }
            

            if (Shoppinglist.Count > 0)
            {
                Console.WriteLine("\nEnter the item you want to remove ");
                string Removinput = Console.ReadLine().ToLower();
                Shoppinglist.Remove(Removinput);

            }
           

            Console.WriteLine("\nFinal Shopping List:");
            if (Shoppinglist.Count > 0)
            {
                foreach (string items in Shoppinglist)
                {
                    Console.WriteLine("==> " + items);
                }
            }
            //Task 6 - Filtered Shopping List


           // Task 7 - High Score Podium


            List<int> score = new List<int>();

            Console.WriteLine("Enter the scores of the games: ");

            for (int i = 0; i < 5; i++) 
            {
                score.Add(int.Parse(Console.ReadLine()));

            }

            score.Sort();
            score.Reverse();
   
               Console.WriteLine("The top 3 scors: ");
               Console.WriteLine("1st place: " + score[0]);
               Console.WriteLine("2nd place: " + score[1]);
               Console.WriteLine("3rd place: " + score[2]);
            
            //Task 7 - High Score Podium



            //Task 8 - Undo Last Action

            Stack <string> undo = new Stack<string>();

            string Imput = "";

            while (Imput.ToLower() != "stop")
            {
                Console.Write("Enter an action (or type 'stop' to finish): ");
                Imput= Console.ReadLine();
                if (Imput.ToLower() != "stop")
                {
                    undo.Push(Imput);
                }

            }



           
            Console.WriteLine("\nUndo 1: " + undo.Pop());
           
            Console.WriteLine("Undo 2: " + undo.Pop());

            Console.WriteLine("\nRemaining Actions:");
            if (undo.Count > 0)
            {
                foreach (string item in undo)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("No thing remainig in the list");
            }

            //Task 8 - Undo Last Action


            //Task 9 - Grade Analyzer with Functions

            try
            {

                List<int> grades = new List<int>();

                Console.WriteLine("Enter the numbers of the grades you want to write: ");
                int num = int.Parse(Console.ReadLine());

                for (int i = 0; i < num; i++)
                {

                    Console.Write("Enter grade " + (i + 1) + ": ");
                    grades.Add(int.Parse(Console.ReadLine()));
                }

            
            


            double average = CalculateAverage(grades);
            int firstFailing = FindFirstFailing(grades);

            Console.WriteLine("\nAverage Grade: " + average);

            if (firstFailing == 0)
            {
                Console.WriteLine("No failing grades were found.");
            }
            else
            {
                Console.WriteLine("First Failing Grade: " + firstFailing);
            }

              }


            catch
            {
                Console.WriteLine("only numbers allowed to enter!!");
            }

            //Task 9 - Grade Analyzer with Functions

*/
            // Task 10 - Print Queue Manager




            Queue<string> printQueue = new Queue<string>();

            string job = "";

            while (job.ToLower() != "done")
            {
                Console.Write("Enter a print job (or type 'done' to finish): ");
                job = Console.ReadLine();

                if (job.ToLower() != "done")
                {
                    printQueue.Enqueue(job);
                }
            }

            Console.WriteLine("\nPrint Queue:");
            foreach (string item in printQueue)
            {
                Console.WriteLine(item);
            }

            Console.Write("\nEnter the job to cancel: ");
            string cancelJob = Console.ReadLine();

            printQueue = RemoveJob(printQueue, cancelJob);

            Console.WriteLine("\nUpdated Print Queue:");
            foreach (string item in printQueue)
            {
                Console.WriteLine(item);
            }





            // Task 10 - Print Queue Manager
























        }
    }
}
