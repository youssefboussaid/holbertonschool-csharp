using System;

    class Array
    {
        public static int elementAt(int[] array, int index)
        {
            for (int i = 0; i <= array.Length; i++)
            {
                if (i == index)
                    return array[i];
            }
            Console.WriteLine("Index out of range");
            return -1;
        }
    }