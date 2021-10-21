﻿using System;

namespace Homework2
{
    public class HW2
    {
        public void SolveTask1()
        {
            int a = GetNumberFromUser("Введите число A: ");
            int b = GetNumberFromUser("Введите число B: ");
            int result = CompareTwoOperands(a, b);
            Console.WriteLine($"Результат первой задачи: {result}" );
        }

        public void SolveTask2()
        {
            int x = GetNumberFromUser("Введите X: ");
            int y = GetNumberFromUser("Введите Y: ");
            int res = CheckInWhichQuarterDotLies(x, y);
            Console.WriteLine($"Результат второй задачи: ");
            CheckAnswer(res);
        }

        public void SolveTask3()
        {
            int a = GetNumberFromUser("Введите число A: ");
            int b = GetNumberFromUser("Введите число B: ");
            int c = GetNumberFromUser("Введите число C: ");
            string result = SortThreeNumbers(a, b, c);
            Console.WriteLine($"Результат третьей задачи: {result}");
        }

        public void SolveTask4()
        {
            int coefA = GetNumberFromUser("Введите число A: ");
            int coefB = GetNumberFromUser("Введите число B: ");
            int coefC = GetNumberFromUser("Введите число C: ");
            double discr = CalcDiscr(coefA, coefB, coefC);
            double[] answer = SolveQuadraticEquation(coefA, coefB, coefC, discr);
            Console.WriteLine("Результат четвертой задачи: ");
            AnalizeAnswer(answer);
        }

        public void SolveTask5()
        {
            int number = GetNumberFromUser("Введите двузначное число: ");
            Console.WriteLine("Результат пятой задачи: ");
            Console.WriteLine(ConvertIntoWords(number));
        }

        public void CheckAnswer(int res)
        {
            switch (res)
            {
                case 1:
                    Console.WriteLine("Точка лежит в 1-ой четверти =)");
                    break;
                case 2:
                    Console.WriteLine("Точка лежит в 2-ой четверти =)");
                    break;
                case 3:
                    Console.WriteLine("Точка лежит в 3-ой четверти =)");
                    break;
                case 4:
                    Console.WriteLine("Точка лежит в 4-ой четверти =)");
                    break;
                default:
                    Console.WriteLine("Точка лежит в 5-ой четверти =)");
                    break;
            }

            //res switch
            //{
            //    1 => Console.WriteLine("Точка лежит в 1-ой четверти =)"),
            //    2 => Console.WriteLine("Точка лежит во 2-ой четверти =)"),
            //    3 => Console.WriteLine("Точка лежит в 3-ей четверти =)"),
            //    4 => Console.WriteLine("Точка лежит в 4-ой четверти =)"),
            //    -666 => Console.WriteLine("Точка лежит на оси!"),
            //}; 
            // не работает и я не знаю почему =(
        }

        public void AnalizeAnswer(double[] answer)
        {
            if (answer.Length == 2 )
            {
                Console.WriteLine($"У уравнения два корня: x1 = {answer[0]}; x2 = {answer[1]}");
            }
            else
            {
                Console.WriteLine($"У уравнения один корень: x = {answer[0]}");
            }
        }

        public int CompareTwoOperands(int a, int b)
        {
            int result = 0;

            if (a > b)
            {
                result = Sum(a, b);
            }
            else if (a == b)
            {
                result = Multiply(a, b);
            }
            else if (a < b)
            {
                result = Subtract(a, b);
            }

            return result;
        }

        public string ConvertIntoWords(int number)
        {
            if (number < 10 || number > 99)
            {
                throw new ArgumentException("Число должно быть двузначным!");
            }

            int dozens = number / 10;
            int remainder = number % 10;

            string firstStr = "";
            string secondStr = "";

            if (number < 20)
            {
                switch (remainder)
                {
                    case 0:
                        firstStr = "Десять";
                        break;
                    case 1:
                        firstStr = "Одиннадцать";
                        break;
                    case 2:
                        firstStr = "Двенадцать";
                        break;
                    case 3:
                        firstStr = "Тринадцать";
                        break;
                    case 4:
                        firstStr = "Четырнадцать";
                        break;
                    case 5:
                        firstStr = "Пятнадцать";
                        break;
                    case 6:
                        firstStr = "Шестнадцать";
                        break;
                    case 7:
                        firstStr = "Семнадцать";
                        break;
                    case 8:
                        firstStr = "Восемнадцать";
                        break;
                    case 9:
                        firstStr = "Девятнадцать";
                        break;
                }
            }

            switch (dozens)
            {
                case 2:
                    firstStr = "Двадцать";
                    break;
                case 3:
                    firstStr = "Тридцать";
                    break;
                case 4:
                    firstStr = "Сорок";
                    break;
                case 5:
                    firstStr = "Пятьдесят";
                    break;
                case 6:
                    firstStr = "Шестьдесят";
                    break;
                case 7:
                    firstStr = "Семьдесят";
                    break;
                case 8:
                    firstStr = "Восемьдесят";
                    break;
                case 9:
                    firstStr = "Девяносто";
                    break;
            }

            if (number > 20)
            {
                switch (remainder)
                {
                    case 1:
                        secondStr = "один";
                        break;
                    case 2:
                        secondStr = "два";
                        break;
                    case 3:
                        secondStr = "три";
                        break;
                    case 4:
                        secondStr = "четыре";
                        break;
                    case 5:
                        secondStr = "пять";
                        break;
                    case 6:
                        secondStr = "шесть";
                        break;
                    case 7:
                        secondStr = "семь";
                        break;
                    case 8:
                        secondStr = "восемь";
                        break;
                    case 9:
                        secondStr = "девять";
                        break;
                }
            }

            return $"{firstStr} {secondStr}";
        }

        public double CalcDiscr(int coefA, int coefB, int coefC)
        {
            double discr = Math.Pow(coefB, 2) - 4 * coefA * coefC;
            return discr;
        }

        public double CalcX1(double discr, int coefA, int coefB)
        {
            double x1 = (coefB * (-1) + Math.Sqrt(discr)) / (2 * coefA);

            if (coefA == 0)
            {
                throw new DivideByZeroException("Тобi жопа");
            }
            return x1;
        }

        public double CalcX2(double discr, int coefA, int coefB)
        {
            double x2 = (coefB * (-1) - Math.Sqrt(discr)) / (2 * coefA);

            if (coefA == 0)
            {
                throw new DivideByZeroException("Тобi жопа");
            }
            return x2;
        }

        public double CalcX(int coefA, int coefB)
        {
            if (coefA == 0)
            {
                throw new DivideByZeroException("Произошло деление на ноль!");
            }
            double x = coefB * (-1.0) / (2 * coefA);
            return x;
        }

        public double[] SolveQuadraticEquation(int coefA, int coefB, int coefC, double discr)
        {
            if (discr > 0)
            {
                double x1 = CalcX1(discr, coefA, coefB);
                double x2 = CalcX2(discr, coefA, coefB);
                double[] roots = new double[2] { x1, x2 };
                return roots;
            }
            else if (discr == 0)
            {
                double x = CalcX(coefA, coefB);
                double[] root = new double[1] { x };
                return root;
            }
            else
            {
                throw new Exception("Нет корней!");
            }
        }

        public string SortThreeNumbers(int a, int b, int c)
        {
            int max = 0;
            int mid = 0;
            int min = 0;

            if (a < b && a < c)
            {
                min = a;

                if (b < c)
                {
                    mid = b;
                    max = c;
                }
                else
                {
                    mid = c;
                    max = b;
                }
            }

            if (b < a && b < c)
            {
                min = b;

                if (a < c)
                {
                    mid = a;
                    max = c;
                }
                else
                {
                    mid = c;
                    max = a;
                }
            }

            if (c < a && c < b)
            {
                min = c;

                if (b < a)
                {
                    mid = b;
                    max = a;
                }
                else
                {
                    mid = a;
                    max = b;
                }
            }

            string result = $"{min} {mid} {max}";
            return result;
        }

        public int CheckInWhichQuarterDotLies(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                return 1;
            }
            else if (x < 0 && y > 0)
            {
                return 2;
            }
            else if (x < 0 && y < 0)
            {
                return 3;
            }
            else if (x > 0 && y < 0)
            {
                return 4;
            }
            if ((x == 0 && y >= 0) || (y == 0 && x > 0)
                || (x == 0 && y < 0) || (y == 0 && x < 0))
            {
                return -666;
            }
            return 5;
        }

        public int GetNumberFromUser(string message)
        {
            Console.Write(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        public int Sum(int a , int b)
        {
            int sum = a + b;
            return sum;
        }
        public int Subtract(int a, int b)
        {
            int sub = a - b;
            return sub;
        }

        public int Multiply(int a, int b)
        {
            int mult = a * b;
            return mult;
        }
    }
}
