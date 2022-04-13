﻿using System;
class Array
{
    public static int[] CreatePrint(int size){
        int i;
        if (size == 0){
            Console.WriteLine();
            return new int[size];

        }
        else if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        else
        {
            int[] array = new int[size];
            for ( i= 0;i < size ;i++)
            {
                array[i] = i;
                if (i < size -1)
                    Console.Write(array[i] + " ");
                else
                    Console.Write(array[i]);

                

            }
            Console.WriteLine();
            return array;
        }
    }
}