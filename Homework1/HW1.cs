﻿using System;

namespace Homework1
{
    public class HW1
    {
        public void SolveTask1()
        {
            int a = GetNumberFromUser("Введите число A: ");
            int b = GetNumberFromUser("Введите число B: ");
            double result = CalcFormula(a, b);
            Console.WriteLine($"Результат первого задания: {result}");
        }

        public void SolveTask2()
        {
            string a = GetStringFromUser("Введите строку 1: ");
            string b = GetStringFromUser("Введите строку 2: ");
            string result = SwapTwoStringVariables(a, b);
            Console.WriteLine($"Результат второго задания: {result}");
        }

        public void SolveTask3()
        {
            int a = GetNumberFromUser("Введите число A: ");
            int b = GetNumberFromUser("Введите число B: ");
            double result = Divide(a, b);
            int remainderOfDivision = ReturnRemainderOfDivision(a, b);
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

        public double CalcCoefK(int x1, int y1, int x2, int y2)
        {
            double coefK = (y1 - y2) * 1.0 / (x1 - x2);
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
                throw new Exception("Произошло деление на ноль");
            }
            double result = (c - b) * 1.0 / a;
            return result;
        }

        public int ReturnRemainderOfDivision(int a, int b)
        {
            int remainderOfDivision = a % b;
            return remainderOfDivision;
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new Exception("Нельзя делить на ноль!");
            }
            double result = a * 1.0 / b;
            return result;
        }

        public string SwapTwoStringVariables(string a, string b)
        {
            string tmp = a;
            a = b;
            b = tmp;
            string result = $"Строка 1 - {a}. Строка 2 - {b}";
            return result;
        }

        public string GetStringFromUser(string message)
        {
            Console.Write(message);
            string str = Console.ReadLine();
            return str;
        }

        public int GetNumberFromUser(string message)
        {
            Console.Write(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        public double CalcFormula(int a, int b)
        {
            if (a == b)
            {
                throw new Exception("Числа должны быть разными!");
            }
            double result = (5 * a + b * b) * 1.0 / (b - a);
            return result;
        }



    }
}
