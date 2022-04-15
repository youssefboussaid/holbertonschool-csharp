using System;
using System.Collections.Generic;

    class List
    {
        public static int Sum(List<int> myList)
        {
            int sum = 0;
            HashSet<int> add_list = new HashSet<int>();
            foreach (int element in myList)
                add_list.Add(element);
            foreach(int item in add_list)
                sum += item;
            return sum;
        }
    }
