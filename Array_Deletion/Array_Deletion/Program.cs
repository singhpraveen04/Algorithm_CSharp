using System;

namespace Array_Deletion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter Array:");
            for(int i = 0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter index of element to be deleted");
            int n = int.Parse(Console.ReadLine());

            delete_element(arr, n);
        }

        public static void delete_element(int[] array, int index)
        {
            if (index >= array.Length)
            {
                Console.WriteLine("Incorrect Paramter");
            }
            else
            {
                int k = index;
                while (k < array.Length - 1)
                {
                    array[k] = array[k + 1];
                    k += 1;
                }
            }

            Console.WriteLine("Resulting Array:");
            for(int i=0; i<array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
    }
}
