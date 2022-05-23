using System;


/// <summary>
/// VectorMath: Class
/// </summary>
class VectorMath
{
	/// <summary>
    /// Calculates a given vector magnitude
    /// </summary>
    /// <param name="vector">the vector</param>
    /// <returns>Magntiude of the vector</returns>
	public static double Magnitude(double[] vector)
    {
        double magnitudeSquare = 0;
        if (vector.Length != 2 && vector.Length != 3)
            return -1;
        foreach (var elem in vector)
            magnitudeSquare += Math.Pow(elem, 2);
        return Math.Round(Math.Sqrt(magnitudeSquare), 2);
    }
	
}