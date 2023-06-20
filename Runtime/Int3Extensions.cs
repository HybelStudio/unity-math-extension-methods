using Unity.Mathematics;

namespace Hybel.ExtensionMethods
{
    /// <summary>
    /// Extension Methods used on int3s.
    /// </summary>
    public static class Int3Extensions
    {
        /// <summary>
        /// Set x and/or y to any value.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <param name="x">Value to set x to. (Optional)</param>
        /// <param name="y">Value to set y to. (Optional)</param>
        /// <param name="z">Value to set z to. (Optional)</param>
        /// <returns>int3 with changed values.</returns>
        public static int3 With(this int3 vector, int? x = null, int? y = null, int? z = null) =>
            new int3(x ?? vector.x, y ?? vector.y, z ?? vector.z);

        /// <summary>
        /// Add two vectors together.
        /// </summary>
        /// /// <param name="x">Value to add to x. (Optional)</param>
        /// <param name="y">Value to add to y. (Optional)</param>
        /// <param name="z">Value to add to z. (Optional)</param>
        public static int3 Add(this int3 vector, int? x = null, int? y = null, int? z = null) =>
            new int3(vector.x + x ?? vector.x, vector.y + y ?? vector.y, vector.z + z ?? vector.z);

        /// <summary>
        /// Subtract any value from x, y and/or z.
        /// </summary>
        /// <param name="vector">Vector</param>
        /// <param name="x">Value to subtract from x. (Optional)</param>
        /// <param name="y">Value to subtract from y. (Optional)</param>
        /// <param name="z">Value to subtract from z. (Optional)</param>
        /// <returns>float2 with subtracted values.</returns>
        public static int3 Sub(this int3 vector, int? x = null, int? y = null, int? z = null) =>
            new int3(vector.x - x ?? vector.x, vector.y - y ?? vector.y, vector.z - z ?? vector.z);

        /// <summary>
        /// Subtract any value from x, y and/or z.
        /// </summary>
        /// <param name="vector">Vector</param>
        /// <param name="x">Value to subtract from x. (Optional)</param>
        /// <param name="y">Value to subtract from y. (Optional)</param>
        /// <param name="z">Value to subtract from z. (Optional)</param>
        /// <returns>int3 with subtracted values.</returns>
        public static int3 Mul(this int3 vector, int? x = null, int? y = null, int? z = null) =>
            new int3(vector.x * x ?? vector.x, vector.y * y ?? vector.y, vector.z * z ?? vector.z);

        /// <summary>
        /// Divide any value with x, y and/or z.
        /// </summary>
        /// <param name="vector">Vector</param>
        /// <param name="x">Value to divide with x. (Optional)</param>
        /// <param name="y">Value to divide with y. (Optional)</param>
        /// <param name="z">Value to divide with z. (Optional)</param>
        /// <returns>int3 with divided values.</returns>
        public static int3 Div(this int3 vector, int? x = null, int? y = null, int? z = null) =>
            new int3(vector.x / x ?? vector.x, vector.y / y ?? vector.y, vector.z / z ?? vector.z);

        /// <summary>
        /// Modulus any value with x, y and/or z.
        /// </summary>
        /// <param name="vector">Vector</param>
        /// <param name="x">Value to modulus with x. (Optional)</param>
        /// <param name="y">Value to modulus with y. (Optional)</param>
        /// <param name="z">Value to modulus with z. (Optional)</param>
        /// <returns>int3 with modulused values.</returns>
        public static int3 Mod(this int3 vector, int? x = null, int? y = null, int? z = null) =>
            new int3(vector.x % x ?? vector.x, vector.y % y ?? vector.y, vector.z % z ?? vector.z);

        /// <summary>
        /// Convert from int3 to Vector3.
        /// </summary>
        public static int3 ToVector3(this int3 vector) =>
            new int3(vector.x, vector.y, vector.z);

        /// <summary>
        /// Convert from int3 to int2.
        /// </summary>
        public static int2 ToInt2XY(this int3 vector) =>
            new int2(vector.x, vector.y);

        /// <summary>
        /// Convert from int3 to int2.
        /// </summary>
        public static int2 ToInt2XZ(this int3 vector) =>
            new int2(vector.x, vector.z);

        /// <summary>
        /// Convert from int3 to int2.
        /// </summary>
        public static int2 ToInt2YZ(this int3 vector) =>
            new int2(vector.y, vector.z);

        /// <summary>
        /// Convert from int3 to float2.
        /// </summary>
        public static float2 ToFloat2XY(this int3 vector) =>
            new float2(vector.x, vector.y);

        /// <summary>
        /// Convert from int3 to float2.
        /// </summary>
        public static float2 TofFloat2XZ(this int3 vector) =>
            new float2(vector.x, vector.z);

        /// <summary>
        /// Convert from int3 to float2.
        /// </summary>
        public static float2 ToFloat2YZ(this int3 vector) =>
            new float2(vector.y, vector.z);

        /// <summary>
        /// Set a vectors min and max values.
        /// </summary>
        public static int3 Clamp(this int3 vector, int? minX = null, int? minY = null, int? minZ = null, int? maxX = null, int? maxY = null, int? maxZ = null) =>
            vector.With(vector.x.Clamp(minX, maxX), vector.y.Clamp(minY, maxY), vector.z.Clamp(minZ, maxZ));

        /// <summary>
        /// Converts a <see cref="int3"/> into a C# matrix.
        /// </summary>
        public static int[,] ToMatrix(this int3 vector)
        {
            return new int[,]
            {
                {vector.x},
                {vector.y},
                {vector.z},
            };
        }
    }
}