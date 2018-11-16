using System;

namespace GitPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            double result = 0;
            Calculator calc = new Calculator();

            while(choice != 5)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1.Add");
                Console.WriteLine("2.Subtract");
                Console.WriteLine("3.Multiply");
                Console.WriteLine("4.Divide");
                Console.WriteLine("5.Exit");

                choice = int.Parse(Console.ReadLine());

                if(choice != 5)
                {
                    Console.WriteLine("Number 1: ");
                    int number1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Number 2: ");
                    int number2 = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 2:
                            result = calc.Subtract(number1, number2);
                            break;
                        case 1:
                            result = calc.Add(number1, number2);
                            break;
                        case 3:
                            result = calc.Multiply(number1, number2);
                            break;
                        case 4:
                            result = calc.Divide(number1, number2);
                            break;
                        default:
                            Console.WriteLine("Not a valid choice");
                            break;
                    }

                    Console.WriteLine($"Result: {result}");
                }  
            }          
        }
    }
}
