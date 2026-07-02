namespace C__Fundamentals___Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task-1---------------------------------------------------------------------------------------------
            String personalname = "Abdulaziz";
            bool studentornot = false;
            int age = 20;
            Double height = 1.76;

            Console.WriteLine("Name:" + personalname + " Age:" + age + " height:" + height + " student:" + studentornot);
            //task-1---------------------------------------------------------------------------------------------




            //task-2---------------------------------------------------------------------------------------------
            Console.WriteLine(" ");

            Console.WriteLine("Plese enter the length ");
            Double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Plese enter the Width ");
            Double Width = double.Parse(Console.ReadLine());

            double Area = length * Width;
            double Perimeter = 2 * (length + Width);

            Console.WriteLine("the area = " + Area);
            Console.WriteLine("the Perimeter = " + Perimeter);
            //task-2---------------------------------------------------------------------------------------------



            //task-3---------------------------------------------------------------------------------------------

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
            //task-3---------------------------------------------------------------------------------------------


            //task-4---------------------------------------------------------------------------------------------

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
            //task-4---------------------------------------------------------------------------------------------
        }
    }
}
