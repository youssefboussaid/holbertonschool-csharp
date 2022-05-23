using System;
using System.Collections.Generic;
using System.Linq;

    class VectorMath
    {
        public static double[] Add(double[] vector1, double[] vector2)
        {
            if (vector1.Length != vector2.Length && ((vector1.Length >= 2 && vector1.Length <= 3) && (vector2.Length >= 2 && vector2.Length <= 3)))
                return new Double[1] {-1};
            double[] res = new Double[3];
            for(int i = 0; i < vector1.Length; i++)
                   res[i] = vector1[i] + vector2[i];
            return (res);
        }
    }