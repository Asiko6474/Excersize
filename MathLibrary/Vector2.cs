﻿using System;
using System.Collections.Generic;
using static System.Collections.IEnumerable;

namespace MathLibrary
{
    public struct Vector2
    {
        public float x;
        public float y;

        public Vector2(float x1, float y1)
        {
            x = x1;
            y = y1;
        }
            

        /// <summary>
        /// Gets the length of the vector
        /// </summary>
        public float Magnitude
        {
            get
            {
                return (float)Math.Sqrt(x * x + y * y);
            }
        }

        /// <summary>
        /// Changes this vector to have a magnitude that is equal to one 
        /// </summary>
        /// <returns>The result of the normalization. returns an empty vector if the magnitude is zero</returns>
        public Vector2 Normalize()
        {
            if (Magnitude == 0)
                return new Vector2();

            return this / Magnitude;
        }

        /// <summary>
        /// Gets the normalized version of this vector without changing it 
        /// </summary>
        public Vector2 Normalized
        {
            get
            {
                Vector2 value = this;
                return value.Normalize();
            }
        }
        /// <summary>
        /// Adds the x values of the second vector to the first, and adds the y values of the second vector to the first
        /// </summary>
        /// <param name="lhs">The vector that is increasing</param>
        /// <param name="rhs">The vector used to increase the 1st vector</param>
        /// <returns>The result of the vector additions</returns>
        public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2 { x = lhs.x + rhs.x, y = rhs.y + lhs.y };
        }

      /// <summary>
      /// Multiplies the vectors X and Y values by the scalar
      /// </summary>
      /// <param name="lhs">The vector that is being scaled </param>
      /// <param name="scalar">The value to scale the vector by</param>
      /// <returns></returns>
        public static Vector2 operator *(Vector2 lhs, float scalar)
        {
            return new Vector2 { x = lhs.x * scalar, y = scalar * lhs.y };
        }

        /// <summary>
        /// Divides X and Y values by the scalar given
        /// </summary>
        /// <param name="lhs">The vector that is being scaled</param>
        /// <param name="scalar">The Value to scale the vector by</param>
        /// <returns>Result of the vector scaling</returns>
        public static Vector2 operator /(Vector2 lhs, float scalar)
        {
            return new Vector2 { x = lhs.x / scalar, y = scalar * lhs.y };
        }

        /// <summary>
        /// Subracts X and y values of the second vector from the first.
        /// </summary>
        /// <param name="lhs">The vector that is decreasing</param>
        /// <param name="scalar">The vector used to decrease the first vector</param>
        /// <returns></returns>
        public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2 { x = lhs.x - rhs.x, y = rhs.y - lhs.y };
        }
       /// <summary>
       /// Comapres the x and y values of two vectors.
       /// </summary>
       /// <param name="lhs">The left side of the comparison</param>
       /// <param name="rhs">The right side of the comparison</param>
       /// <returns>True if the x values of both vectors </returns>
        public static bool operator ==(Vector2 lhs, Vector2 rhs)
        {
            return rhs.x == lhs.x && lhs.y == rhs.y; 
        }

        public static bool operator !=(Vector2 lhs, Vector2 rhs)
        {
            return rhs.x != lhs.x && lhs.y != rhs.y;
        }

    }
}
