using System;

namespace HomeworkArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = ArrayFuncions.CreateRandomArray(20);
            Console.WriteLine("CREATED ARRAY");
            ArrayFuncions.ShowArray(a);
            ArrayFuncions.SortArrayDesc(a);
            Console.WriteLine("ARRAY AFTER MAGIC");
            ArrayFuncions.ShowArray(a);
        }
    }
}
