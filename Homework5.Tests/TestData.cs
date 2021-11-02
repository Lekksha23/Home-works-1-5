using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5.Tests
{
    public class TestData
    {
        public static int[,] GetArrayForTransposeTheMatrixTest(int index)
        {
            return index switch
            {
                0 => new int[,] {{ 1, 5 },{ 1, 5 }},
                1 => new int[,] { { 17, 43, 12 }, { 48, 53, 17 }, { 15, 22, 87 } },
                2 => new int[,] { { 0, 21, 12 }, { 65, 0, 17 }, {23, 10, 0 } },
                3 => new int[,] { { 42 } },
                _ => new int[,] { { } },
            };
        }

        public static int[,] GetExpectedArrayForTransposeTheMatrixTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1, 1 }, { 5, 5 } },
                1 => new int[,] { { 17, 48, 15 }, { 43, 53, 22 }, { 12, 17, 87 } },
                2 => new int[,] { { 0, 65, 23 }, { 21, 0, 10 }, { 12, 17, 0 } },
                3 => new int[,] { { 42 } },
                _ => new int[,] { { } },
            };
        }

        public static int[,] GetArrayForCountElementsThatGreaterThanNeighborsTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 10, 11 }, { 11, 10 } },
                1 => new int[,] { { 17, 43, 12 }, { 48, 53, 17 }, { 15, 22, 87 } },
                2 => new int[,] { { 12, 12, 12 }, { 12, 12, 12 }, { 12, 12, 12 } },
                3 => new int[,] { { 42 } },
                _ => new int[,] { { } },
            };
        }

        public static int[,] GetArrayForFindIndexOfMaxElementInDoubleArrayTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 10, 11 }, { 11, 10 } },
                1 => new int[,] { { 17, 43, 12 }, { 48, 53, 17 } },
                2 => new int[,] { { 12, 12, 12 }, { 12, 12, 12 }, { 12, 12, 12 } },
                3 => new int[,] { { 42 } },
                _ => new int[,] { { } },
            };
        }

        public static int[,] GetArrayForFindIndexOfMinElementInDoubleArrayTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 10, 11 }, { 11, 10 } },
                1 => new int[,] { { 17, 43, 12 }, { 48, 53, 17 } },
                2 => new int[,] { { 12, 12, 12 }, { 12, 12, 12 }, { 12, 12, 12 } },
                3 => new int[,] { { 42 } },
                _ => new int[,] { { } },
            };
        }

        public static int[,] GetArrayForFindMaxElementInDoubleArrayTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 10, 11 }, { 11, 10 } },
                1 => new int[,] { { 17, 43, 12 }, { 48, 53, 17 } },
                2 => new int[,] { { 12, 12, 12 }, { 12, 12, 12 }, { 12, 12, 12 } },
                3 => new int[,] { { 0 }, },
                _ => new int[,] { { } },
            };
        }

        public static int[,] GetArrayForFindMinElementInDoubleArrayTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 10, 11 }, { 11, 10 } },
                1 => new int[,] { { 17, 43, 12 }, { 48, 53, 17 } },
                2 => new int[,] { { 12, 12, 12 }, { 12, 12, 12 }, { 12, 12, 12 } },
                3 => new int[,] { { 0 }, },
                _ => new int[,] { { } },
            };
        }
    }
}
