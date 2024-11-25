namespace CalculatorViaOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            char operation;
            double result = 0;
            bool exit = false;
            while (!exit)
            {
                try
                {
                    Console.WriteLine("Enter first number: ");
                    calc.numberOne = Convert.ToDouble(Console.ReadLine());
                }
                catch(Exception)
                {
                    Console.WriteLine("Enter a number!");
                    continue;
                }

                try
                {
                    Console.WriteLine("Enter operation: ");
                    operation = Convert.ToChar(Console.ReadLine());
                }
                catch(Exception)
                {
                    Console.WriteLine("Enter '+', '-', '*' or '/'!");
                    continue;
                }

                try
                {
                    Console.WriteLine("Enter second number: ");
                    calc.numberTwo = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter a number!");
                    continue;
                }
                                
                switch (operation)
                {
                    case '+':
                        result = calc.Plus();
                        Console.WriteLine("RESULT: " + result);
                        break;
                    case '-':
                        result = calc.Minus();
                        Console.WriteLine("RESULT: " + result);
                        break;
                    case '*':
                        result = calc.Pow();
                        Console.WriteLine("RESULT: " + result);
                        break;
                    case '/':
                        if (calc.numberTwo == 0)
                        {
                            Console.WriteLine("Error!");
                            break;
                        }
                        result = calc.Divide();
                        Console.WriteLine("RESULT: " + result);
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }                

                Console.WriteLine("For exit type: <exit> or press <Enter> to continue");

                string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                {
                    exit = true;
                    Console.WriteLine("Good luck!");
                }
            }      
        }
    }
}
