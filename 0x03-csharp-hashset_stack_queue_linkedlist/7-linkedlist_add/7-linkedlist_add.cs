﻿using System;
using System.Collections.Generic;


    class LList
    {
        public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
        {
            var node = myLList.AddFirst(n);
            return node;
        }
    }
