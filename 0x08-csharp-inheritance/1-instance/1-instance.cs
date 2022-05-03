using System;

    class Obj
    {
        public static bool IsInstanceOfArray(object obj)
        {
        /// <summary>
        /// check if obj insatnce of array or sub
        /// </summary>
        /// <param name="obj">obj to check</param>
        /// <returns> True or  False </returns>
            var array = new int[10];
            return Object.ReferenceEquals(obj.GetType(), array.GetType());
        }
    }

