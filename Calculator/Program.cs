using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            double firstValue = 0;
            double secondValue = 0;
            string operation = "";

            InputValues values = new InputValues();
            firstValue = values.GetFirstValue();
            secondValue = values.GetSecondValue();

            MainCalculator calculator = new MainCalculator();
            Console.WriteLine("Hello from Calculator" +
                "");
            Console.WriteLine("Введите операцию: (+,-,*,/,x^2, 1/x, sin, cos, tg)");


            operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    {
                        double result = calculator.SumOfTwoValues(firstValue, secondValue);
                        Console.WriteLine("Сумма: " + result);
                    }
                    break;
                case "-":
                    try
                    {
                        Console.WriteLine("Разность: " + calculator.DifferenceOfTwoValues(firstValue, secondValue));
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Incorrect value");
                    }
                    break;
                case "*":
                    try
                    {
                        Console.WriteLine("Произведение: " + calculator.MultiplyTwoValues(firstValue, secondValue));
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Incorrect value");
                    }
                    break;
                case "/":
                    try
                    {
                        Console.WriteLine("Деление: " + calculator.DivisionOfTwoValues(firstValue, secondValue));
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Incorrect value");
                    }
                    break;
                case "x^2":
                    try
                    {
                        Console.WriteLine("Возведение в квадрат: " + calculator.ValueInSecondPower(firstValue));
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Incorrect value");
                    }
                    break;
                case "1/x":
                    try
                    {
                        Console.WriteLine("Обратное значение: " + calculator.ReverseValue(firstValue));
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Incorrect value");
                    }
                    break;
                case "sin":
                    try
                    {
                        Console.WriteLine("Синус (первого значения): " + calculator.SinOfValue(firstValue));
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Incorrect value");
                    }
                    break;
                case "cos":
                    try
                    {
                        Console.WriteLine("Косинус (первого значение): " + calculator.CosOfValue(firstValue));
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Incorrect value");
                    }
                    break;
                case "tg":
                    try
                    {
                        Console.WriteLine("Тангенс (первого значения): " + calculator.TanOfValue(firstValue));
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Incorrect value");
                    }
                    break;
                default:
                    Console.WriteLine("Неверная операция");
                    break;
            }
            Console.ReadLine();
        }
    }

    public class InputValues
    {
        public double GetFirstValue()
        {
            Console.WriteLine("Введите первое число: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        public double GetSecondValue()
        {
            Console.WriteLine("Введите второе число: ");
            return Convert.ToDouble(Console.ReadLine());
        }
    }


    public class MainCalculator
    {
        public double SumOfTwoValues(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }

        public double DifferenceOfTwoValues(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }

        public double MultiplyTwoValues(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }

        public double DivisionOfTwoValues(double firstValue, double secondValue)
        {
            if (secondValue == 0.0D)
                throw new DivideByZeroException("Делить на ноль запрещено");
            return Math.Round(firstValue / secondValue, 4);
        }

        public double ValueInSecondPower(double firstValue)
        {
            return Math.Pow(firstValue, 2);
        }

        public double ReverseValue(double firstValue)
        {
            if (firstValue == 0.0D)
                throw new DivideByZeroException("Делить на ноль запрещено");
            return 1 / firstValue;
        }

        public double SinOfValue(double firstValue)
        {
            return Math.Round(Math.Sin(firstValue), 4);
        }

        public double CosOfValue(double firstValue)
        {
            return Math.Round(Math.Cos(firstValue), 4);
        }

        public double TanOfValue(double firstValue)
        {
            return Math.Round(Math.Tan(firstValue), 4);
        }
    }
}
