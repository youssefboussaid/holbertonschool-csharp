using System;
/// <summary>
/// Shape: Class
/// </summary>
class Shape
{
    /// <summary>
    /// Throws exception
    /// </summary>
    /// <returns>void</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// Rectangle: Class that inherits from Shape
/// </summary>
class Rectangle : Shape
{
    private int width;
    private int height;
    /// <summary>
    /// width setter and getter
    /// </summary>
    public int Width
    {
        get
        {
            return width;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            width = value;
        }
    }

    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            height = value;
        }
    }
}