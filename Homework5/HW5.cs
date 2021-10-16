using System;

namespace Homework5
{
    public class HW5
    {
        public void SolveTask1()
        {
            int n = GetNumberFromUser("Введите кол-во строк: ");
            int m = GetNumberFromUser("Введите кол-во столбцов: ");
            int[,] array = FillDoubleArray(n, m);
            PrintDoubleArrayToConsole(array);
            int minElement = FindMinElementInDoubleArray(array);

            Console.WriteLine();
            Console.WriteLine("Результат первой задачи: ");
            Console.WriteLine($"Минимальный элемент равен {minElement}");
        }

        public void SolveTask2()
        {
            int n = GetNumberFromUser("Введите кол-во строк: ");
            int m = GetNumberFromUser("Введите кол-во столбцов: ");
            int[,] array = FillDoubleArray(n, m);
            PrintDoubleArrayToConsole(array);
            int maxElement = FindMaxElementInDoubleArray(array);

            Console.WriteLine(); 
            Console.WriteLine("Результат второй задачи: ");
            Console.WriteLine($"Максимальный элемент равен {maxElement}");
        }

        public void SolveTask3()
        {
            int n = GetNumberFromUser("Введите кол-во строк: ");
            int m = GetNumberFromUser("Введите кол-во столбцов: ");
            int[,] array = FillDoubleArray(n, m);
            PrintDoubleArrayToConsole(array);
            int minElement = FindMinElementInDoubleArray(array);
            int[] indexOfMin= FindIndexOfMinElementInDoubleArray(array);

            Console.WriteLine();
            Console.WriteLine("Результат третьей задачи: ");
            Console.WriteLine($"Индекс минимального элемента: [{indexOfMin[0]},{indexOfMin[1]}]");
            Console.WriteLine($"Минимальный элемент равен {minElement}");
        }

        public void SolveTask4()
        {
            int n = GetNumberFromUser("Введите кол-во строк: ");
            int m = GetNumberFromUser("Введите кол-во столбцов: ");
            int[,] array = FillDoubleArray(n, m);
            PrintDoubleArrayToConsole(array);
            int maxElement = FindMaxElementInDoubleArray(array);
            int[] indexOfMax = FindIndexOfMaxElementInDoubleArray(array);

            Console.WriteLine();
            Console.WriteLine("Результат четвертой задачи: ");
            Console.WriteLine($"Индекс максимального элемента: [{indexOfMax[0]},{indexOfMax[1]}]");
            Console.WriteLine($"Максимальный элемент равен {maxElement}");
        }

        public void SolveTask5()
        {
            int n = GetNumberFromUser("Введите кол-во строк: ");
            int m = GetNumberFromUser("Введите кол-во столбцов: ");
            int[,] array = FillDoubleArray(n, m);
            PrintDoubleArrayToConsole(array);
            Console.WriteLine();
            Console.WriteLine("Результат пятой задачи: ");
            int counter = CountSumOfElementsThatGreaterThanNeighbors(array);
            Console.WriteLine($"Кол-во элементов массива, которые больше " +
                              $"всех своих соседей равно {counter}");
            Console.WriteLine();
        }

        public void SolveTask6()
        {
            int n = GetNumberFromUser("Введите кол-во строк: ");
            int m = GetNumberFromUser("Введите кол-во столбцов: ");
            int[,] array = FillDoubleArray(n, m);
            PrintDoubleArrayToConsole(array);
            array = TransposeTheMatrix(array);

            Console.WriteLine();
            Console.WriteLine("Результат шестой задачи: ");
            PrintDoubleArrayToConsole(array);
        }

        public int[,] TransposeTheMatrix(int [,] array)
        {
            for (int i = 1; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int tmp = array[i, j];
                    array[i, j] = array[j, i];
                    array[j, i] = tmp;
                }
            }
            return array;
        }

        public void PrintDoubleArrayToConsole(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        public int CountSumOfElementsThatGreaterThanNeighbors(int[,] array)
        {
            int counter = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i == 0 || array[i, j] > array[i - 1, j])
                        && (i >= array.GetLength(0) - 1 || array[i, j] > array[i + 1, j])
                        && (j == 0 || array[i, j] > array[i, j - 1])
                        && (j >= array.GetLength(1) - 1 || array[i, j] > array[i, j + 1]))
                    {
                        counter++;
                        Console.Write($"[{i},{j}] : {array[i, j]}");
                        Console.WriteLine();
                    }
                }
            }

            return counter;
        }

        public int[] FindIndexOfMaxElementInDoubleArray(int[,] array)
        {
            int max = array[0, 0];
            int tmpIMax = 0;
            int tmpJMax = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        tmpIMax = i;
                        tmpJMax = j;
                    }
                }
            }
            int[] indexOfMax = new int[2] { tmpIMax, tmpJMax };
            return indexOfMax;
        }

        public int[] FindIndexOfMinElementInDoubleArray(int[,] array)
        {
            int min = array[0, 0];
            int tmpIMin = 0;
            int tmpJMin = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        tmpIMin = i;
                        tmpJMin = j;
                    }
                }
            }
            int[] indexOfMin = new int[2] { tmpIMin, tmpJMin };
            return indexOfMin;
        }

        public int FindMaxElementInDoubleArray(int[,] array)
        {
            int maxElement = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > maxElement)
                    {
                        maxElement = array[i, j];
                    }
                }
            }

            return maxElement;
        }

        public int GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        public int[,] FillDoubleArray(int n , int m)
        {
            Random rnd = new Random();

            int[,] array = new int[n, m];
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = rnd.Next(0, 100);
                }
                Console.WriteLine();
            }
            return array;
        }

        public int FindMinElementInDoubleArray(int[,] array)
        {
            int minElement = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < minElement)
                    {
                        minElement = array[i, j];
                    }
                }
            }

            return minElement;
        }

            
    }
}
