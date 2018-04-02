using System;

namespace Array_Update
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter an array:");
            for(int j = 0; j < arr.Length; j++)
            {
                arr[j] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter index to be updated");
            int i = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the updated value");
            int val = int.Parse(Console.ReadLine());

            update_array(arr, i, val);
        }

        public static void update_array(int[] array, int index, int value)
        {
            array[index] = value;

            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
    }
}
