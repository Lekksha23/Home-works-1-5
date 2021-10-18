using System;

namespace Homework1
{
    public class HW1
    {
        public void SolveTask1()
        {
            double a = GetNumberFromUser("Введите число A: ");
            double b = GetNumberFromUser("Введите число B: ");
            double result = CalcFormula(a, b);
            Console.WriteLine($"Результат первого задания: {result}");
        }

        public void SolveTask2()
        {
            string a = GetStringFromUser("Введите строку 1: ");
            string b = GetStringFromUser("Введите строку 2: ");
            SwapTwoStringVariables(ref a, ref b);
            Console.WriteLine($"Результат второго задания: строка 1 - {a}, строка 2 - {b}");
        }

        public void SolveTask3()
        {
            int a = GetNumberFromUser("Введите число A: ");
            int b = GetNumberFromUser("Введите число B: ");
            double result = DivideFirstOperandBySecond(a, b);
            int remainderOfDivision = CalcRemainderOfDivision(a, b);
            Console.WriteLine($"Результат третьего задания: {a} / {b} = {result}");
            Console.WriteLine($"Остаток деления: {remainderOfDivision}");
        }

        public void SolveTask4()
        {
            int a = GetNumberFromUser("Введите число A: ");
            int b = GetNumberFromUser("Введите число B: ");
            int c = GetNumberFromUser("Введите число C: ");
            double result = CalcFormula2(a, b, c);
            Console.WriteLine($"Результат четвертого задания: x равен {result}");
        }

        public void SolveTask5()
        {
            int x1 = GetNumberFromUser("Введите X1: ");
            int y1 = GetNumberFromUser("Введите Y1: ");
            int x2 = GetNumberFromUser("Введите X2: ");
            int y2 = GetNumberFromUser("Введите Y2: ");
            double coefK = CalcCoefK(x1, y1, x2, y2);
            double coefB = CalcCoefB(coefK, x2, y2);
            Console.WriteLine($"Коэффициент b = {coefB}");
            Console.WriteLine($"Результат пятого задания: y = {coefK}x + {coefB}");
        }

        public int GetNumberFromUser(string message)
        {
            Console.Write(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        public double CalcCoefK(int x1, int y1, int x2, int y2)
        {
            double coefK = (y1 - y2) * 1.0 / (x1 - x2);

            if (double.IsInfinity(coefK) || double.IsNaN(coefK))
            {
                throw new DivideByZeroException("Тобi жопа");
            }
            return coefK;
        }

        public double CalcCoefB(double coefK, int x2, int y2)
        {
            double coefB = y2 - coefK * x2;
            return coefB;
        }

        public double CalcFormula2(int a, int b, int c)
        {
            if (a == 0)
            {
                throw new DivideByZeroException("Произошло деление на ноль!");
            }
            double result = (c - b) * 1.0 / a;
            return result;
        }

        public int CalcRemainderOfDivision(int a, int b)
        {
            int remainderOfDivision = a % b;
            return remainderOfDivision;
        }

        public double DivideFirstOperandBySecond(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Нельзя делить на ноль!");
            }
            double result = a * 1.0 / b;
            return result;
        }

        public void SwapTwoStringVariables( ref string a, ref string b)
        {
            string tmp = a;
            a = b;
            b = tmp;
        }

        public string GetStringFromUser(string message)
        {
            Console.Write(message);
            string str = Console.ReadLine();
            return str;
        }


        public double CalcFormula(double a, double b)
        {
            if (a == b)
            {
                throw new ArgumentException("Значения a и b должны быть разными!");
            }
            double result = (5 * a + b * b)* 1.0 / (b - a);
            return result;
        }



    }
}
