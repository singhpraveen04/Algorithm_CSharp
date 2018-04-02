using System;

namespace Array_BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter an array");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter element to be searched");
            int num = int.Parse(Console.ReadLine());

            binary_search_array(arr, num);

        }

        public static void binary_search_array(int[] array, int number)
        {
            int low = 0;
            int high = array.Length - 1;
            int mid = -1;

            while (low <= high)
            {
                mid = low + (high - low) / 2;

                if (number == array[mid])
                {
                    Console.WriteLine("Number found at {0} index", mid);
                    Console.ReadLine();
                    break;
                    
                }
                else if (number > array[mid])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            Console.WriteLine("Number not found!");
            Console.ReadLine();
        }
    }
}
