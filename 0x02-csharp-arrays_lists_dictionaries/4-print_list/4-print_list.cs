using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        List<int> numbers = new List<int>();
        if ( size > 0)
        {    
            int i;
            for (i = 0; i < size - 1; i++)
            {
                numbers.Add(i);
                Console.Write("{0} ",i);
            }

            numbers.Add(i);
            Console.WriteLine(i);
        }
        else
            Console.WriteLine();
        return numbers;
    }
}
