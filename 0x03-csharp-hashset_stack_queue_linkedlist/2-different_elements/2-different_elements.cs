﻿using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> nlist = new List<int>();

        foreach (var item in list1)
        {
            if (list2.Contains(item) == false)
            {
                nlist.Add(item);
            }
        }
        foreach (var item in list2)
        {
            if (list1.Contains(item) == false)
            {
                nlist.Add(item);
            }
        }
        nlist.Sort();
        return nlist;
    }
}