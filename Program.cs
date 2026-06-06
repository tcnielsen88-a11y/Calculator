namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("staring Calculator:...");
            Console.WriteLine("----------------------------------------\n");
            //int numberOne = 1;
            //int numberTwo = 2;
            
            
            

            Console.WriteLine("Enter first number: ");
            int numberOne = Convert.ToInt32( Console.ReadLine());// to write in the program.

            Console.WriteLine("Enter operator (+, -, *, /): ");
            string insertedOperator = Console.ReadLine();

            Console.WriteLine("Enter second number: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            string plus = "+";
            string minus = "-";
            string gange = "*";
            string divider = "/";
            // chousse signs 
            if (insertedOperator == plus)
            {
                // block of code to be executed if the condition1 is True
                Console.WriteLine("Calculating...\n = " + (numberOne + numberTwo));
            }
            else if (insertedOperator ==gange) 
            {
                // block of code to be executed if the condition1 is false and condition2 is True
                Console.WriteLine("Calculating...\n = " + (numberOne * numberTwo));
            }
            else if (insertedOperator ==divider)
            {
                // block of code to be executed if the condition1 is false and condition2 is Fals
                Console.WriteLine("Calculating...\n = " + (numberOne / numberTwo));

            }
            // ----------------------------Calculation ----------------------
            //Console.WriteLine("Calculating...\n = " + (numberOne + numberTwo));
           
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("Ending Calculator:...");
            Console.WriteLine("----------------------------------------\n");
        }
    }
}
