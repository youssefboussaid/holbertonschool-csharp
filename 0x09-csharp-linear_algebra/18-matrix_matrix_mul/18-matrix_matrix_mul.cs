﻿using System;
/// <summary>
/// class MatrixMath
/// </summary>


    class MatrixMath
    {
        public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
        {
            if (matrix1.GetLength(1) != matrix2.GetLength(0))
                return new double[,] { { -1} };
            

            double[,] A = new double[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0 ; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        A[i, j] += matrix1[i , k] * matrix2[k , j];
                    }
                }
            }
            return A;
        }
    }
