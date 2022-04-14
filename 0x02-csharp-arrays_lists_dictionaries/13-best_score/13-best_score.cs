﻿using System;
using System.Collections.Generic;


    class Dictionary
    {
        public static string BestScore(Dictionary<string, int> myList)
        {   
            string best_student = "None";
            int max_score = 0;
            foreach(KeyValuePair<string, int> element in myList)
            {
                if (element.Value > max_score)
                {
                    best_student = element.Key;
                    max_score = element.Value;
                }
            } 
            return best_student;
        }
    }
