﻿using System;

namespace Enemies
{
    // This class is empty.
    /// <summary>
    /// This class is empty.
    /// </summary>
    public class Zombie
    {
        /// <summary>Field that defines the health of zombie.</summary> 
        public int health;
 /// <summary>Initializes a new instance of the <see cref="Zombie"/> class.</summary>
        public Zombie()
        {
            health = 0;
        }
/// <summary>Initializes a new instance of the <see cref="Zombie"/> class and checks if value is greater than 0.</summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new Exception("Health must be greater than or equal to 0");
            }
            health = value;
        }
    }
}