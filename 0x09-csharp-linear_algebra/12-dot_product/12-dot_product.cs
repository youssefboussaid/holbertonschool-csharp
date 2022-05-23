using System;

    class VectorMath
    {
        public static double DotProduct(double[] vector1, double[] vector2)
        {
            if (vector.Length != 3 && vector.Length != 2)
                return -1;
            int x = 0;
            for (int i = 0; i < vector1.Length; i++)
            {   
                x += vector1[i] * vector2[i];     
            }
            return x;
        }
    }

