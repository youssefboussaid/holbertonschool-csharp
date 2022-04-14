using System;

    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged_arr = new int[3][];
            jagged_arr[0] = new int[] {0, 1, 2, 3};
            jagged_arr[1] = new int[] {0, 1, 2, 3, 4, 5, 6};
            jagged_arr[2] = new int[] {0, 1};

            for (int n = 0; n < jagged_arr.Length; n++)
            {
                for (int k = 0; k < jagged_arr[n].Length; k++)
                {
                    if (k == jagged_arr[n].Length - 1)
                        Console.Write("{0}", jagged_arr[n][k]);
                    else
                        Console.Write("{0} ", jagged_arr[n][k]);
                }
            Console.WriteLine();
            }
        }
    }
