using System;

namespace Homework4
{
    public class HW4
    {
        public void SolveTask1()
        {
            int length = GetLengthFromUser("Введите размер массива: ");
            int[] array = FillAnArray(length);
            PrintAnArrayToConsole(array);
            int min = FindMinElementInArray(array);

            Console.WriteLine();
            Console.WriteLine("Результат первой задачи: ");
            Console.WriteLine($"Наименьший элемент массива: {min}");
        }

        public void SolveTask2()
        {
            int length = GetLengthFromUser("Введите размер массива: ");
            int[] array = FillAnArray(length);
            PrintAnArrayToConsole(array);
            int max = FindMaxElementInArray(array);

            Console.WriteLine();
            Console.WriteLine("Результат второй задачи: ");
            Console.WriteLine($"Наибольший элемент массива: {max}");
        }

        public void SolveTask3()
        {
            int length = GetLengthFromUser("Введите размер массива: ");
            int[] array = FillAnArray(length);
            PrintAnArrayToConsole(array);
            int indexOfMin = FindIndexOfMinElementInArray(array);

            Console.WriteLine();
            Console.WriteLine("Результат третьей задачи: ");
            Console.WriteLine($"Индекс наименьшего элемента массива: {indexOfMin}");
        }

        public void SolveTask4()
        {
            int length = GetLengthFromUser("Введите размер массива: ");
            int[] array = FillAnArray(length);
            PrintAnArrayToConsole(array);
            int indexOfMax = FindIndexOfMinElementInArray(array);

            Console.WriteLine();
            Console.WriteLine("Результат четвертой задачи: ");
            Console.WriteLine($"Индекс наименьшего элемента массива: {indexOfMax}");
        }

        public void SolveTask5()
        {
            int length = GetLengthFromUser("Введите размер массива: ");
            int[] array = FillAnArray(length);
            PrintAnArrayToConsole(array);
            int sum = CountSumOfElementsWithOddIndexes(array);

            Console.WriteLine();
            Console.WriteLine("Результат пятой задачи: ");
            Console.WriteLine($"Сумма элементов с нечетными индексами равна {sum}");
        }

        public void SolveTask6()
        {
            int length = GetLengthFromUser("Введите размер массива: ");
            int[] array = FillAnArray(length);
            PrintAnArrayToConsole(array);
            array = ReverseOfArray(array);

            Console.WriteLine();
            Console.WriteLine("Результат шестой задачи: ");
            PrintAnArrayToConsole(array);
        }

        public void SolveTask7()
        {
            int length = GetLengthFromUser("Введите размер массива: ");
            int[] array = FillAnArray(length);
            PrintAnArrayToConsole(array);
            int count = CountOddElementsOfArray(array);

            Console.WriteLine();
            Console.WriteLine("Результат седьмой задачи: ");
            Console.WriteLine($"Кол-во нечетных элементов массива равно {count}");
        }

        public void SolveTask8()
        {
            int length = GetLengthFromUser("Введите размер массива: ");
            int[] array = FillAnArray(length);
            PrintAnArrayToConsole(array);
            array = SwapFirstAndSecondHalfOfArray(array);

            Console.WriteLine();
            Console.WriteLine("Результат восьмой задачи: ");
            PrintAnArrayToConsole(array);
        }

        public void SolveTask9()
        {
            int length = GetLengthFromUser("Введите размер массива: ");
            int[] array = FillAnArray(length);
            PrintAnArrayToConsole(array);
            array = SortAnArrayBySelectionSort(array);

            Console.WriteLine();
            Console.WriteLine("Результат девятой задачи: ");
            PrintAnArrayToConsole(array);
        }

        public void SolveTask10()
        {
            int length = GetLengthFromUser("Введите размер массива: ");
            int[] array = FillAnArray(length);
            PrintAnArrayToConsole(array);
            array = SortAnArrayByInsertionSort(array);

            Console.WriteLine();
            Console.WriteLine("Результат десятой задачи: ");
            PrintAnArrayToConsole(array);
        }

        public int[] SortAnArrayByInsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j;
                int tmp = array[i];

                for (j = i - 1; j >= 0; j--)
                {
                    if (array[j] > tmp)
                        break;

                    array[j + 1] = array[j];
                }
                array[j + 1] = tmp;
            }

            return array;
        }

        public int[] SortAnArrayBySelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int indexOfMin = i;

                for (int j = i; j < array.Length; j++)
                {
                    if (array[indexOfMin] > array[j])
                    {
                        indexOfMin = j;
                    }
                }
                int tmp = array[i];
                array[i] = array[indexOfMin];
                array[indexOfMin] = tmp;
            }

            return array;
        }

        public int[] SwapFirstAndSecondHalfOfArray(int[] array)
        {
            int middle = array.Length / 2;

            for (int i = 0; i < middle; i++)
            {
                int tmp = array[i];
                array[i] = array[i + array.Length - middle];
                array[i + array.Length - middle] = tmp;
            }

            return array;
        }

        public int CountOddElementsOfArray(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }

        public void PrintAnArrayToConsole(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} \t");
            }
        }

        public int[] ReverseOfArray(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int tmp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = tmp;
            }
            return array;
        }

        public int CountSumOfElementsWithOddIndexes(int[] array)
        {
            int sum = 0;

            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }
            return sum;
        }
            

        public int FindIndexOfMaxElementInArray(int[] array)
        {
            int indexOfMax = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[indexOfMax] < array[i])
                {
                    indexOfMax = i;
                }
            }
            return indexOfMax;
        }

        public int FindIndexOfMinElementInArray(int[] array)
        {
            int indexOfMin = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[indexOfMin] > array[i])
                {
                    indexOfMin = i;
                }
            }
            return indexOfMin;
        }

        public int FindMaxElementInArray(int[] array)
        {
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }

        public int GetLengthFromUser(string message)
        {
            Console.Write(message);
            int length = Convert.ToInt32(Console.ReadLine());
            return length;
        }

        public int[] FillAnArray(int length)
        {
            Random rnd = new Random();

            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = rnd.Next(-100, 100);
            }
            return array;
        }

        public int FindMinElementInArray(int[] array)
        {
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }
    }
}
