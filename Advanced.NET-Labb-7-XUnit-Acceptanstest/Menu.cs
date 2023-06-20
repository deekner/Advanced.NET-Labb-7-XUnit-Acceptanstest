using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.NET_Labb_7_XUnit_Acceptanstest
{
    public class Menu
    {
        private CalculatorLogic calculator;

        public Menu()
        {
            calculator = new CalculatorLogic();
        }

        public void run()
        {
            
            Console.WriteLine("Please choose a calculation method");
            Console.WriteLine("Calculation Options");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Division");
            Console.WriteLine("4. Multiplication");
            Console.WriteLine("5. Previous Calculations");
            Console.WriteLine("6. Exit Program");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            

            switch (userChoice)
            {

                case 1:
                    Console.WriteLine("Addition");
                    Console.WriteLine("Enter the first Number: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the second Number: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    calculator.Addition(num1, num2);
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 2:
                    Console.WriteLine("Subtraction");
                    Console.WriteLine("Enter the first Number: ");
                    int numb1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the second Number: ");
                    int numb2 = Convert.ToInt32(Console.ReadLine());
                    calculator.Subtraction(numb1, numb2);
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 3:
                    Console.WriteLine("Divide");
                    Console.WriteLine("Enter the first Number: ");
                    int numbe1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the second Number: ");
                    int numbe2 = Convert.ToInt32(Console.ReadLine());
                    calculator.Divide(numbe1, numbe2);
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 4:
                    Console.WriteLine("Multiplication");
                    Console.WriteLine("Enter the first Number: ");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the second Number: ");
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    calculator.Multiplication(number1, number2);
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 5:
                    calculator.PrintCalculationHistory();
                    Console.Clear();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Number, choose between 1-5");
                    break;
            }
            run();
        }
    }
}
