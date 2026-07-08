namespace C__Fundamentals___Part_5
{
    internal class Program
    {
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

*/
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





        }
    }
}
