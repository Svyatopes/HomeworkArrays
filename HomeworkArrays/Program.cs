using System;

namespace HomeworkArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //one dimensional arrays
            //int[] a = ArrayFuncions.CreateRandomArray(7);
            //Console.WriteLine("CREATED ARRAY");
            //ArrayFuncions.ShowArray(a);
            //ArrayFuncions.ReverseArray(a);
            //Console.WriteLine("ARRAY AFTER MAGIC");
            //ArrayFuncions.ShowArray(a);
            //ArrayFuncions.SortArrayDesc(a);
            //Console.WriteLine("ARRAY AFTER SECOND MAGIC");
            //ArrayFuncions.ShowArray(a);

            //two dimensional arrays
            int[,] arrayTwoDimensional = ArrayFuncions.CreateRandomArray2Dimensional(5, 5, -10, 10);
            Console.WriteLine("CREATED ARRAY");
            ArrayFuncions.ShowArray(arrayTwoDimensional);
            ArrayFuncions.MirrorArrayAboutMainDiagonal(arrayTwoDimensional);

            Console.WriteLine("ARRAY AFTER MAGIC");

            ArrayFuncions.ShowArray(arrayTwoDimensional);
            //var minElemIndex = ArrayFuncions.FindIndexOfMinValue(arrayTwoDimensional);
            //var maxElement = ArrayFuncions.FindMaxValue(arrayTwoDimensional);
            //Console.WriteLine($"min elem: ({minElemIndex.Item1}, {minElemIndex.Item2})\n" +
            //    $"max elem: {maxElement}");

        }
    }
}
