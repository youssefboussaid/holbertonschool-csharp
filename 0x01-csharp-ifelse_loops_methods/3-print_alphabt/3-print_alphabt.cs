﻿using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            char i;
            for (i = 'a'; i <= 'z'; i++)
            {
                if (i != 'e' && i != 'q')
                    Console.Write(i);
            }
        }
    }
}
