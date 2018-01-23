using System;

namespace myLib
{
    public class MathHelper
    {
        /// <summary>
        /// Returns the larger of two integers.
        /// </summary>
        /// <param name="x">The first of two integers to compare.</param>
        /// <param name="y">The second of two integers to compare.</param>
        /// <returns>Parameter x or y, whichever is larger.</returns>
        public int Max(int x, int y)
        {
            if (x == y)
            {
                return x;
            }
            if (x > y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }

        /// <summary>
        /// Returns the smaller of two integers.
        /// </summary>
        /// <param name="x">The first of two integers to compare.</param>
        /// <param name="y">The second of two integers to compare.</param>
        /// <returns>Parameter x or y, whichever is smaller.</returns>
        public int Min(int x, int y)
        {
            if (x == y)
            {
                return x;
            }
            if (x < y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
    }
}