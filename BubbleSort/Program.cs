using System.Runtime.InteropServices;

namespace BubbleSort
{
    internal class Program
    {
        public static int[] BubbleSort(int[] arr)
        {
            int count = arr.Length - 1;
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    }
                }
                count--;
            }
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            return arr;
        }



        public static int[] SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
            foreach(int i in arr)
            { 
                Console.WriteLine(i); 
            }
            return arr;
        }


        static void Main(string[] args)
        {
            int[] arr = [ 64, 25, 12, 22, 11 ];

            Console.WriteLine("Hello, World!");
            Console.WriteLine(BubbleSort([3, 1, 5, 2, 7, 4, 0]));
            Console.WriteLine(SelectionSort(arr));
        }
    }
}
