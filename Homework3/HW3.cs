using System;

namespace Homework3
{
    public class HW3
    {
        public void SolveTask1()
        {
            int A = GetNumberFromUser("Введите число A: ");
            int B = GetNumberFromUser("Введите число B: ");
            Console.WriteLine("Результат первой задачи: ");
            Console.WriteLine(RaiseNumberToPower(A, B));
        }

        public void SolveTask2()
        {
            int num = GetNumberFromUser("Введите число: ");
            Console.WriteLine("Результат второй задачи: ");
            PrintDivisibleNumbersByUserNumberInRange(num);
        }

        public void SolveTask3()
        {
            int a = GetNumberFromUser("Введите число A: ");
            int count = CountSquareOfNumbersLessThanUserNumber(a);
            Console.WriteLine("Результат третьей задачи: ");
            Console.WriteLine($"Кол-во чисел, квадрат которых меньше A равно {count}");
        }

        public void SolveTask4()
        {
            int number = GetNumberFromUser("Введите число: ");
            Console.WriteLine("Результат четвертой задачи: ");
            Console.WriteLine($"Наибольший делитель {FindMaxDividor(number)}");
        }

        public void SolveTask5()
        {
            int numA = GetNumberFromUser("Введите число А: ");
            int numB = GetNumberFromUser("Введите число В: ");
            int sum = FindSumOfNumbersDivisibleBySevenOnUserRange(numA, numB);
            Console.WriteLine("Результат пятой задачи: ");
            Console.WriteLine($"Сумма чисел из диапазона, которые делятся без остатка на 7 равна {sum}");
        }

        public void SolveTask6()
        {
            int n = GetNumberFromUser("Введите число N: ");
            int number = FindNumberOfNumberInFibonacсiRow(n);
            Console.WriteLine("Результат шестой задачи: ");
            Console.WriteLine($"Под номером {n} в ряду Фибоначчи стоит число {number}");
        }

        public void SolveTask7()
        {
            int num1 = GetNumberFromUser("Введите число 1: ");
            int num2 = GetNumberFromUser("Введите число 2: ");
            Console.WriteLine("Результат седьмой задачи: ");
            Console.WriteLine($"НОД равен {FindGreatestCommonDividor(num1, num2)}");
        }

        public void SolveTask8()
        {
            int x = GetNumberFromUser("Введите целое положительное число: ");
            Console.WriteLine("Результат восьмой задачи: ");
            Console.WriteLine($"{FindNUsingBinarySearch(x)}");   
        }

        public void SolveTask9()
        {
            int numberA = GetNumberFromUser("Введите целое положительное число: ");
            int counter = CountOddFiguresInNumber(numberA);
            Console.WriteLine("Результат девятой задачи: ");
            Console.WriteLine($"Кол-во нечетных цифр равно {counter}");
        }

        public void SolveTask10()
        {
            int y = GetNumberFromUser("Введите целое положительное число: ");
            Console.WriteLine("Результат десятой задачи: ");
            MirrorFiguresInNumber(y);
        }

        public void SolveTask11()
        {
            int N = GetNumberFromUser("Введите число N: ");
            Console.WriteLine("Результат одиннадцатой задачи: ");
            CountSumOfEvenFiguresInNumber(N);
        }

        public void SolveTask12()
        {
            int numN1= GetNumberFromUser("Введите первое число: ");
            int numN2= GetNumberFromUser("Введите второе число: ");
            Console.WriteLine("Результат двенадцатой задачи: ");
            CheckForSameNumbers(numN1, numN2);
        }

        public void CheckForSameNumbers(int numN1, int numN2)
        {
            int tmp1;
            int tmp2;
            int copy = numN2;

            while (numN1 != 0)
            {
                tmp1 = numN1;
                int check1 = numN1 % 10;
                numN2 = copy;

                while (numN2 != 0)
                {
                    tmp2 = numN2;
                    int check2 = numN2 % 10;

                    if (check1 == check2)
                    {
                        Console.WriteLine("ДА");
                        return;
                    }
                    numN2 /= 10;
                }

                numN1 /= 10;
            }
            Console.WriteLine("НЕТ");
        }

        public void CountSumOfEvenFiguresInNumber(int N)
        {
            for (int i = 1; i <= N; i++)
            {
                int sumOfEven = 0;
                int sumOfOdd = 0;
                int check = 0;
                int numb = i;

                while (numb != 0)
                {
                    check = numb % 10;

                    if (check % 2 == 0)
                    {
                        sumOfEven += check;
                    }
                    else
                    {
                        sumOfOdd += check;
                    }
                    numb /= 10;
                }
                if (sumOfEven > sumOfOdd)
                {
                    Console.Write($" {i}");
                }
            }
            Console.WriteLine();
        }

        public void MirrorFiguresInNumber(int y)
        {
            while (y != 0)
            {
                Console.Write($"{y % 10}");
                y /= 10;
            }
        }

        public int CountOddFiguresInNumber(int numberA)
        {
            int numCheck;
            int counter = 0;

            while (numberA != 0)
            {
                numCheck = numberA % 10;

                if (numCheck % 2 != 0)
                {
                    counter++;
                }

                numberA /= 10;
            }

            return counter;
        }

        public double FindNUsingBinarySearch(int x)
        {
            double right = x;
            double left = 0;
            double center = x / 2;
            double sigma = 0.1;

            while (!(x <= Math.Pow(center + sigma, 3) && x >= Math.Pow(center - sigma, 3)))
            {
                if (Math.Pow(center, 3) > x)
                {
                    right = center;
                }
                else
                {
                    left = center;
                }
                center = (right + left) / 2;
            }

            return center;
        }

        public int FindGreatestCommonDividor(int num1, int num2)
        {
            int dividor = 0;

            while (num1 != 0 && num2 != 0)
            {
                if (num1 > num2)
                {
                    num1 = num1 % num2;
                }
                else
                {
                    num2 = num2 % num1;
                }
            }
            dividor = num1 + num2;
            return dividor;
        }


        public int FindNumberOfNumberInFibonacсiRow(int n)
        {
            int first = 1;
            int second = 1;
            int j = 2;
            int summ = 0;

            while (j <= n)
            {
                summ = first + second;
                first = second;
                second = summ;
                j++;
            }
            return first;
        }

        public int FindSumOfNumbersDivisibleBySevenOnUserRange(int numA, int numB)
        {
            int sum = 0;

            if (numA > numB)
            {
                for (int i = numB; i <= numA; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum += i;
                    }
                }
                return sum;
            }

            if (numB > numA)
            {
                for (int i = numA; i <= numB; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum += i;
                    }
                }
                return sum;
            }
            return sum;
        }

        public int FindMaxDividor(int number)
        {
            int maxDividor = 0;

            for (int i = number - 1; i > 0; i--)
            {
                if (number % i == 0)
                {
                    maxDividor = i;
                    break;
                }
            }
            return maxDividor;
        }

        public int CountSquareOfNumbersLessThanUserNumber(int a)
        {
            int count = 0;

            for (int i = 1; i < a; i++)
            {
                if (Math.Pow(i, 2) < a)
                {
                    count += 1;
                }
            }
            return count;
        }

        public void PrintDivisibleNumbersByUserNumberInRange(int num)
        {
            int range = 1000;
            Console.WriteLine($"Числа от 1 до 1000, которые делятся на {num}:");

            for (int i = 1; i <= range; i++)
            {
                if (i % num == 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }


        public double RaiseNumberToPower(int A, int B)
        {
            double res = 1;

            for (int i = 0; i < B; i++)
            {
                res *= A;
            }

            return res;
        }

        public int GetNumberFromUser(string message)
        {
            Console.Write(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

    }
}
