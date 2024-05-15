using System.Transactions;

namespace Quetion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Two numbers");
            Console.WriteLine("Enter first Number");
            int num1 =Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int num2 =Convert.ToInt32( Console.ReadLine());

            

            Console.WriteLine("Choose one of the following Operation");
            Console.WriteLine("1.Addition 2.Substraction 3.Division 4.Multiplication");
            int choice = Convert.ToInt32( Console.ReadLine());
            switch (choice)
            {
                case 1:

                    Console.WriteLine("Addition is  = "+(Convert.ToInt32(num1) + Convert.ToInt32(num2)));
                    break;
                case 2:

                    Console.WriteLine("Substraction  is  = " + (num1 - num2));
                    break;
                case 3:

                    Console.WriteLine("Multiplication  is  = " + num1 * num2);
                    break;
                case 4:

                    Console.WriteLine("Division is  = " + num1 / num2);
                    break;
                case 0:
                    Console.WriteLine("Wrong choice !!!! ");
                    break;
            }

        }
    }
}
