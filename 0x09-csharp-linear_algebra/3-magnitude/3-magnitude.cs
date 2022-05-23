using System;
/// <summary>
/// VectorMath class
/// </summary>
    class VectorMath
    {
        
        public static double Magnitude(double[] vector)
        {
            /// <summary>
            /// Calculate Magnitude of 2D or 3D vectore
            /// </summary>
            /// <param name="vector">vector</param>
            /// <returns>magnitude or -1 if its not a vector</returns>
            double x = 0;
            if (vector.Length !=3 && vector.Length !=2)
                return -1;
            else if (vector.Length == 2)
                x = Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2));
            else if (vector.Length == 3)
                x = Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2));
            return Math.Round(x , 2);
        }
    }