using System;
using System.Collections.Generic;

    class List
    {
        public static List<int> CommonElements(List<int> list1, List<int> list2)
        {
            List<int> new_list = new List<int>();
            foreach(var element in list1)
            {
                foreach(var element2 in list2)
                    {
                        if (element == element2)
                            new_list.Add(element);
                    }
            }
            return new_list;

        }
    }

