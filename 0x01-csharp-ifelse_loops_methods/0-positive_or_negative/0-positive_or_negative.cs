﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10, 10);
        if (number == 0)
            Console.WriteLine("{0:d} is zero", number);
        else if (number > 0)
            Console.WriteLine("{0:d} is positive", number);
        else
            Console.WriteLine("{0:d} is negative", number);
    }
}