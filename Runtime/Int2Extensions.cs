using System.Collections.Generic;
using Unity.Mathematics;

namespace Hybel.ExtensionMethods
{
    /// <summary>
    /// Extension Methods used on int2s.
    /// </summary>
    public static class Int2Extensions
    {
        /// <summary>
        /// Set x and/or y to any value.
        /// </summary>
        /// <param name="x">Value to set x to. (Optional)</param>
        /// <param name="y">Value to set y to. (Optional)</param>
        /// <returns>int2 with changed values.</returns>
        public static int2 With(this int2 vector, int? x = null, int? y = null) =>
            new int2(x ?? vector.x, y ?? vector.y);

        /// <summary>
        /// Add two vectors together.
        /// </summary>
        /// <param name="x">Value to add to x. (Optional)</param>
        /// <param name="y">Value to add to y. (Optional)</param>
        /// <returns>int2 with changed values.</returns>
        public static int2 Add(this int2 vector, int? x = null, int? y = null) =>
            new int2(vector.x + x ?? vector.x, vector.y + y ?? vector.y);

        /// <summary>
        /// Subtract any value from x and/or y.
        /// </summary>
        /// <param name="x">Value to subtract from x. (Optional)</param>
        /// <param name="y">Value to subtract from y. (Optional)</param>
        /// <returns>int2 with subtracted values.</returns>
        public static int2 Sub(this int2 vector, int? x = null, int? y = null) =>
            new int2(vector.x - x ?? vector.x, vector.y - y ?? vector.y);

        /// <summary>
        /// Subtract any value from x and/or y.
        /// </summary>
        /// <param name="x">Value to subtract from x. (Optional)</param>
        /// <param name="y">Value to subtract from y. (Optional)</param>
        /// <returns>int2 with subtracted values.</returns>
        public static int2 Mul(this int2 vector, int? x = null, int? y = null) =>
            new int2(vector.x * x ?? vector.x, vector.y * y ?? vector.y);

        /// <summary>
        /// Divide any value with x and/or y.
        /// </summary>
        /// <param name="x">Value to divide with x. (Optional)</param>
        /// <param name="y">Value to divide with y. (Optional)</param>
        /// <returns>int2 with divided values.</returns>
        public static int2 Div(this int2 vector, int? x = null, int? y = null) =>
            new int2(vector.x / x ?? vector.x, vector.y / y ?? vector.y);

        /// <summary>
        /// Modulus any value with x and/or y.
        /// </summary>
        /// <param name="x">Value to modulus with x. (Optional)</param>
        /// <param name="y">Value to modulus with y. (Optional)</param>
        /// <returns>int2 with modulused values.</returns>
        public static int2 Mod(this int2 vector, int? x = null, int? y = null) =>
            new int2(vector.x % x ?? vector.x, vector.y % y ?? vector.y);

        /// <summary>
        /// Convert from int2 to float2.
        /// </summary>
        public static float2 ToFloat2(this int2 vector) =>
            new float2(vector.x, vector.y);

        /// <summary>
        /// Convert from int2 to int3.
        /// </summary>
        public static int3 ToInt3XY(this int2 vector, int z = 0) =>
            new int3(vector.x, vector.y, 0);

        /// <summary>
        /// Convert from int2 to int3.
        /// </summary>
        public static int3 ToInt3XZ(this int2 vector, int y = 0) =>
            new int3(vector.x, 0, vector.y);

        /// <summary>
        /// Convert from int2 to int3.
        /// </summary>
        public static int3 ToInt3YZ(this int2 vector, int x = 0) =>
            new int3(0, vector.x, vector.y);

        /// <summary>
        /// Convert from int2 to float3.
        /// </summary>
        public static float3 ToFloat3XY(this int2 vector, float z = 0f) =>
            new float3(vector.x, vector.y, 0f);

        /// <summary>
        /// Convert from int2 to float3.
        /// </summary>
        public static float3 ToFloat3XZ(this int2 vector, float y = 0f) =>
            new float3(vector.x, 0f, vector.y);

        /// <summary>
        /// Convert from int2 to float3.
        /// </summary>
        public static float3 ToFloat3YZ(this int2 vector, float x = 0f) =>
            new float3(0f, vector.x, vector.y);

        /// <summary>
        /// Set a vectors min and max values.
        /// </summary>
        public static int2 Clamp(this int2 vector, int? minX = null, int? minY = null, int? maxX = null, int? maxY = null) =>
            vector.With(vector.x.Clamp(minX, maxX), vector.y.Clamp(minY, maxY));

        /// <summary>
        /// Set a vectors min and max values.
        /// </summary>
        public static int2 Clamp(this int2 vector, int2? min = null, int2? max = null) =>
            vector.Clamp(min?.x, min?.y, max?.x, max?.y);

        /// <summary>
        /// Translates a group of points.
        /// </summary>
        public static IEnumerable<int2> Translate(this IEnumerable<int2> points, int2 translation)
        {
            var result = new List<int2>();

            foreach (int2 point in points)
                result.Add(point + translation);

            return result;
        }

        /// <summary>
        /// Converts a <see cref="int2"/> into a C# matrix.
        /// </summary>
        public static int[,] ToMatrix(this int2 vector)
        {
            return new int[,]
            {
                {vector.x},
                {vector.y},
            };
        }
    }
}