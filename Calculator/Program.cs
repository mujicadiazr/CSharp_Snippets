using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    // This is the class for calculate
    class Calculator
    {

        //This is the operate method
        public static int operate(int number1, int number2, Program.Operators op)
        {
            int result = 0;

            switch (op)
            {
                case Program.Operators.Add:
                    result = Add(number1, number2);
                    break;
                case Program.Operators.Sub:
                    result = Substract(number1, number2);
                    break;
                case Program.Operators.Mul:
                    result = Multiply(number1, number2);
                    break;
                case Program.Operators.Div:
                    result = Divide(number1, number2);
                    break;
            }

            return result;
        }

        private static int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        private static int Substract(int number1, int number2)
        {
            return number1 - number2;
        }

        private static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        private static int Divide(int number1, int number2)
        {
            return number1 / number2;
        }
    }

    class Program
    {
        public enum Operators { Add, Sub, Mul, Div};

        static int GetNumber(int indexOfNumber)
        {
            int number;
            
            while(true)
            {
                System.Console.WriteLine("Enter number {0}: ", indexOfNumber);
                string line = System.Console.ReadLine();

                if (Int32.TryParse(line, out number))
                    break;
                else
                    System.Console.WriteLine("You've entered a wrong number!");
            }

            return number;            
        }
        static private Operators GetOperator()
        {
            while (true)
            {
                System.Console.WriteLine("Enter the operator (+,-,*,/): ");
                string line = System.Console.ReadLine();

                switch (line)
                {
                    case "+":
                        return Operators.Add;
                    case "-":
                        return Operators.Sub;
                    case "*":
                        return Operators.Mul;
                    case "/":
                        return Operators.Div;
                    default:
                        System.Console.WriteLine("Wrong operator! ");
                        break;
                }
            }
        }

        static void GetInput(out int number1,out int number2)
        {
            number1 = GetNumber(1);
            number2 = GetNumber(2);
        }

        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0;
            GetInput(out n1, out n2);
            int result = Calculator.operate(n1, n2, GetOperator());
            System.Console.WriteLine("The result is: " + result);
        }
    }
}
