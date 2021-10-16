using System;

namespace Homework2
{
    public class HW2
    {
        public void SolveTask1()
        {
            int a = GetNumberFromUser("Введите число A: ");
            int b = GetNumberFromUser("Введите число B: ");
            Console.WriteLine("Результат первой задачи: " );
            CompareAndCalc(a, b);
        }

        public void SolveTask2()
        {
            int x = GetNumberFromUser("Введите X: ");
            int y = GetNumberFromUser("Введите Y: ");
            Console.WriteLine("Результат второй задачи: ");
            CheckInWhichQuarterDotLies(x, y);
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
            Console.WriteLine("Результат четвертой задачи: ");
            string result = SolveQuadraticEquation(coefA, coefB, coefC);
            Console.WriteLine(result);
        }

        public void SolveTask5()
        {
            int number = GetNumberFromUser("Введите двузначное число: ");
            Console.WriteLine("Результат пятой задачи: ");
            Console.WriteLine(ConvertInWords(number));
        }

        public string ConvertInWords(int number)
        {
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

        public string SolveQuadraticEquation(int coefA, int coefB, int coefC)
        {
            double discr = Math.Pow(coefB, 2) - 4 * coefA * coefC;
            Console.WriteLine($"Дискриминант равен {discr}");

            string result ="";

            if (discr > 0)
            {
                Console.WriteLine("У уравнения два корня");
                double x1 = (coefB * (-1) + Math.Sqrt(discr)) / (2 * coefA);
                double x2 = (coefB * (-1) - Math.Sqrt(discr)) / (2 * coefA);
                result = $"X1 = {x1}. X2 = {x2}";
            }
            else if (discr == 0)
            {
                Console.WriteLine("У уравнения один корень");
                double x = coefB * (-1.0) / 2 * coefA;
                result = $"X = {x}";

            }
            else if (discr < 0)
            {
                Console.WriteLine("У уравнения нет корней");
            }

            return result;
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

        public void CheckInWhichQuarterDotLies(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine($"Точка с координатами ({x},{y}) лежит в 1-ой четверти");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"Точка с координатами ({x},{y}) лежит во 2-ой четверти");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"Точка с координатами ({x},{y}) лежит в 3-ей четверти");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"Точка с координатами ({x},{y}) лежит в 4-ой четверти");
            }
            if ((x == 0 && y >= 0) || (y == 0 && x > 0)
                || (x == 0 && y < 0) || (y == 0 && x < 0))
            {
                Console.WriteLine("Точка лежит на координатной оси!");
            }
        }

        public int GetNumberFromUser(string message)
        {
            Console.Write(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        public void CompareAndCalc(int a, int b)
        {
            if (a > b)
            {
                int sum = a + b;
                Console.WriteLine($"A > B ... Cумма равна {sum}");
            }
            else if (a == b)
            {
                int mult = a * b;
                Console.WriteLine($"A = B ... Произведение равно {mult}");
            }
            else if (a < b)
            {
                int subtraction = a - b;
                Console.WriteLine($"A < B ... А - B равно {subtraction}");
            }
        }




    }
}
