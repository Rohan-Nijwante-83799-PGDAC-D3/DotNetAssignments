namespace Assignmet1Q2Commandline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No command-line arguments provided.");

            }
            else
            {

                Console.WriteLine("Command-line arguments:");
                // Loop through each argument and print it

                int num1 = Convert.ToInt32(args[0]);
                int num2 = Convert.ToInt32(args[1]);
                Console.WriteLine("Enter yuor choice 1.Addition 2.Substraction 3.Division 4.Mulltiplication");
                int choice = Convert.ToInt32(args[2]);
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Addition is  = " + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("Substraction is  = " + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("Division is  = " + (num1 / num2));
                        break;
                    case 4:
                        Console.WriteLine("Multiplication is  = " + (num1 * num2));
                        break;

                }
            }
            
        }
    }
}
