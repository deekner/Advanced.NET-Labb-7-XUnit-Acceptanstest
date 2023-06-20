using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.NET_Labb_7_XUnit_Acceptanstest
{
    public class CalculatorLogic
    {
        public List<CalculatorHistory> CalcHistory;

        public CalculatorLogic()
        {
            CalcHistory = new List<CalculatorHistory>();
        }

        public int Addition(int num1, int num2)
        {

            int result = num1 + num2;
           
            Console.WriteLine($"Here's your result: {result}");

            // Create a new instance of the CalculatorHistory class to represent a calculation
            CalculatorHistory calculation = new CalculatorHistory
            {
                Operation = "+", // Set the operation symbol for the calculation
                num1 = num1, 
                num2 = num2, 
                Result = result //Finally sets the result
            };

            //Then we save it to a list called CalcHistory
            CalcHistory.Add(calculation);

            return result;           
        }

        public int Subtraction(int num1, int num2)
        {
            int result = num1 - num2;

            Console.WriteLine($"Here's your result: {result}");

            CalculatorHistory calculation = new CalculatorHistory
            {
                Operation = "-",
                num1 = num1,
                num2 = num2,
                Result = result
            };

            CalcHistory.Add(calculation);

            return result;

        }

        public int Divide(int num1, int num2)
        {
            int result = num1 / num2;

            Console.WriteLine($"Here's your result: {result}");

            CalculatorHistory calculation = new CalculatorHistory
            {
                Operation = "/",
                num1 = num1,
                num2 = num2,
                Result = result
            };

            CalcHistory.Add(calculation);

            return result;

        }

        public int Multiplication(int num1, int num2)
        {
            int result = num1 * num2;

            Console.WriteLine($"Here's your result: {result}");

            CalculatorHistory calculation = new CalculatorHistory
            {
                Operation = "*",
                num1 = num1,
                num2 = num2,
                Result = result
            };

            CalcHistory.Add(calculation);

            return result;
        }

        public void PrintCalculationHistory()
        {
            Console.Clear();
            Console.WriteLine("Previous Calculations: ");
            foreach (CalculatorHistory calculation in CalcHistory)
            {
                Console.WriteLine(calculation);
            }
            Console.ReadKey();
            
        }

    }
}
