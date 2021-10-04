using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkArrays
{
    public class ArrayFuncions
    {
        /// <summary>
        /// Create array with user defined length and random values in some bounds which defined by user
        /// </summary>
        /// <param name="length">Length of array</param>
        /// <param name="minValue">Minimum possible value of array elements</param>
        /// <param name="maxValue">Maximum possible value of array elements</param>
        /// <returns>New array with random values</returns>
        public static int[] CreateRandomArray(int length, int minValue, int maxValue)
        {
            int[] array = new int[length];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(minValue, maxValue);
            }
            return array;
        }

        /// <summary>
        /// Create array with user defined length and values from -100 to +100
        /// </summary>
        /// <param name="length">Length of array</param>
        /// <returns>New array with random values</returns>
        public static int[] CreateRandomArray(int length)
        {
            return CreateRandomArray(length, -100, 100);
        }


        /// <summary>
        /// Create array with length is 10 and values from -100 to +100
        /// </summary>
        /// <returns>New array with random values</returns>
        public static int[] CreateRandomArray()
        {
            return CreateRandomArray(10);
        }


        /// <summary>
        /// Display array in console by 10 items in a row
        /// </summary>
        /// <param name="array">Array to dispay</param>
        public static void ShowArray(int[] array)
        {
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}\t");
                if (((i + 1) % 10) == 0)
                {
                    Console.WriteLine("\r\n");
                }
            }
            Console.WriteLine();
        }


        /// <summary>
        /// Найти минимальный элемент массива
        /// </summary>
        /// <param name="array">Array to find mininum value in array</param>
        /// <returns>Minimum element</returns>
        public static int FindMinValue(int[] array)
        {
            int minElement = array[0];
            foreach (var elem in array)
            {
                if (elem < minElement)
                    minElement = elem;
            }
            return minElement;
        }

        /// <summary>
        /// Найти максимальный элемент массива
        /// </summary>
        /// <param name="array">Array to find maximum value in array</param>
        /// <returns>Max element</returns>
        public static int FindMaxValue(int[] array)
        {
            int maxElement = array[0];
            foreach (var elem in array)
            {
                if (elem > maxElement)
                    maxElement = elem;
            }
            return maxElement;
        }

        /// <summary>
        /// Найти индекс минимального элемента массива
        /// </summary>
        /// <param name="array">Array to find index of minimum value in array</param>
        /// <returns>Index of minimum value</returns>
        public static int FindIndexOfMinValue(int[] array)
        {
            int minElement = array[0];
            int index = 0;
            int indexOfMinValue = 0;
            foreach (var elem in array)
            {
                if (elem < minElement)
                {
                    minElement = elem;
                    indexOfMinValue = index;
                }
                index++;
            }
            return indexOfMinValue;
        }

        /// <summary>
        /// Найти индекс максимального элемента массива
        /// </summary>
        /// <param name="array">Array to find index of maximum value in array</param>
        /// <returns>Index of maximum value</returns>
        public static int FindIndexOfMaxValue(int[] array)
        {
            int maxElement = array[0];
            int index = 0;
            int indexOfMaxValue = 0;
            foreach (var elem in array)
            {
                if (elem > maxElement)
                {
                    maxElement = elem;
                    indexOfMaxValue = index;
                }
                index++;
            }
            return indexOfMaxValue;
        }


        /// <summary>
        /// Посчитать сумму элементов массива с нечетными индексами
        /// </summary>
        /// <param name="array">Array to find sum of elements with odd indexes</param>
        /// <returns>Sum of elements with odd indexes</returns>
        public static int SumOfElementsWithOddIndexes(int[] array)
        {
            int index = 0;
            int sumOfElementsWithOddIndex = 0;
            foreach (var elem in array)
            {
                if (index % 2 == 1)
                {
                    sumOfElementsWithOddIndex += elem;
                }
                index++;
            }
            return sumOfElementsWithOddIndex;
        }

        /// <summary>
        /// Сделать реверс массива(массив в обратном направлении)
        /// </summary>
        /// <param name="array">Array to reverse</param>
        /// <returns>New reverse array</returns>
        public static int[] GetReversedArray(int[] array)
        {
            int[] reverseArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                reverseArray[array.Length - 1 - i] = array[i];
            }
            return reverseArray;
        }


        /// <summary>
        /// Посчитать количество нечетных элементов массива
        /// </summary>
        /// <param name="array">Array to get count of odd elements in this array</param>
        /// <returns>Count of odd elements in this array</returns>
        public static int GetCountOfOddElements(int[] array)
        {
            int countOfOddElements = 0;
            foreach (var elem in array)
            {
                if (elem % 2 == 1)
                {
                    countOfOddElements++;
                }
            }
            return countOfOddElements;
        }


        /// <summary>
        /// Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.
        /// </summary>
        /// <param name="array"></param>
        public static void ReplaceLeftAndRightPart(int[] array)
        {
            int startRightPart = array.Length % 2 == 0 ? array.Length / 2 : array.Length / 2 + 1;
            for (int i = 0; i < array.Length / 2; i++)
            {
                int _ = array[i];
                array[i] = array[startRightPart + i];
                array[startRightPart + i] = _;
            }
        }

        /// <summary>
        /// Отсортировать массив по возрастанию одним из способов:  пузырьком(Bubble), выбором(Select) 
        /// или вставками(Insert)) 
        /// </summary>
        /// <param name="array">Array for sort by Ascending (Bubble)</param>
        public static void SortArrayAsc(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int _ = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = _;
                    }
                }
            }
        }

        /// <summary>
        ///Отсортировать массив по убыванию одним из способов, (отличным от способа в 9-м задании) :
        ///пузырьком(Bubble), выбором(Select) или вставками(Insert))
        /// </summary>
        /// <param name="array">Array for sort by Ascending (Select)</param>
        public static void SortArrayDesc(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int maxElement = array[i];
                int indexMaxElement = i;
                for (int j = i; j < array.Length; j++)
                {
                    if (maxElement < array[j])
                    {
                        maxElement = array[j];
                        indexMaxElement = j;
                    }
                }
                if (indexMaxElement != i)
                {
                    int _ = array[i];
                    array[i] = array[indexMaxElement];
                    array[indexMaxElement] = _;
                }
            }
        }
    }
}
