using System;

namespace Array_Insertion
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int num, pos;
            int[] arr = new int[10];
            Console.WriteLine("Enter an array");
            for(i = 0; i < arr.Length - 2; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter an element that needs to be inserted:");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the position:");
            pos = int.Parse(Console.ReadLine());

            insert_element(arr, num, pos);
        }

        public static void insert_element(int[] array, int number, int position )
        {
            if (position >= array.Length)
            {
                Console.WriteLine("Not enough space");
            }
            else if (position == array.Length - 1)
            {
                array[array.Length - 1] = number;
            }
            else
            {
                int j = array.Length - 1;
                while (j > position)
                {
                    array[j] = array[j - 1];
                    j -= 1;
                }
                array[position] = number;
            }

            Console.WriteLine("Resulting Array");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
    }
}
