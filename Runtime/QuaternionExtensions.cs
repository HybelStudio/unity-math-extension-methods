using Unity.Mathematics;

namespace Hybel.ExtensionMethods
{
    public static class QuaternionExtensions
    {
        /// <summary>
        /// Returns the result of transforming a <paramref name="vector"/> by a <paramref name="quaternion"/>.
        /// </summary>
        public static float3 Multiply(this quaternion quaternion, float3 vector) =>
            math.mul(quaternion, vector);
        
        /// <summary>
        /// Set x, y, z and/or w to any value.
        /// </summary>
        /// <param name="x">Value to set x to. (Optional)</param>
        /// <param name="y">Value to set y to. (Optional)</param>
        /// <param name="z">Value to set z to. (Optional)</param>
        /// <param name="w">Value to set w to. (Optional)</param>
        /// <returns>quaternion with changed values.</returns>
        public static quaternion With(this quaternion quaternion, float? x = null, float? y = null, float? z = null, float? w = null) =>
            new quaternion(x ?? quaternion.value.x, y ?? quaternion.value.y, z ?? quaternion.value.z, w ?? quaternion.value.w);
        
        /// <summary>
        /// Add any value to x, y, z and/or w.
        /// </summary>
        /// <param name="x">Value to add to x. (Optional)</param>
        /// <param name="y">Value to add to y. (Optional)</param>
        /// <param name="z">Value to add to z. (Optional)</param>
        /// <param name="w">Value to add to w. (Optional)</param>
        /// <returns>quaternion with added values.</returns>
        public static quaternion Add(this quaternion quaternion, float? x = null, float? y = null, float? z = null, float? w = null) =>
            new quaternion(quaternion.value.x + x ?? quaternion.value.x, quaternion.value.y + y ?? quaternion.value.y, quaternion.value.z + z ?? quaternion.value.z, quaternion.value.w + w ?? quaternion.value.w);
        
        /// <summary>
        /// Subtract any value from x, y, z and/or w.
        /// </summary>
        /// <param name="x">Value to subtract from x. (Optional)</param>
        /// <param name="y">Value to subtract from y. (Optional)</param>
        /// <param name="z">Value to subtract from z. (Optional)</param>
        /// <param name="w">Value to subtract from w. (Optional)</param>
        /// <returns>quaternion with subtracted values.</returns>
        public static quaternion Sub(this quaternion quaternion, float? x = null, float? y = null, float? z = null, float? w = null) =>
            new quaternion(quaternion.value.x - x ?? quaternion.value.x, quaternion.value.y - y ?? quaternion.value.y, quaternion.value.z - z ?? quaternion.value.z, quaternion.value.w - w ?? quaternion.value.w);
        
        /// <summary>
        /// Multiply any value with x, y, z and/or w.
        /// </summary>
        /// <param name="x">Value to multiply with x. (Optional)</param>
        /// <param name="y">Value to multiply with y. (Optional)</param>
        /// <param name="z">Value to multiply with z. (Optional)</param>
        /// <param name="w">Value to multiply with w. (Optional)</param>
        /// <returns>quaternion with multiplied values.</returns>
        public static quaternion Mul(this quaternion quaternion, float? x = null, float? y = null, float? z = null, float? w = null) =>
            new quaternion(quaternion.value.x * x ?? quaternion.value.x, quaternion.value.y * y ?? quaternion.value.y, quaternion.value.z * z ?? quaternion.value.z, quaternion.value.w * w ?? quaternion.value.w);
        
        /// <summary>
        /// Divide any value with x, y, z and/or w.
        /// </summary>
        /// <param name="x">Value to divide with x. (Optional)</param>
        /// <param name="y">Value to divide with y. (Optional)</param>
        /// <param name="z">Value to divide with z. (Optional)</param>
        /// <param name="w">Value to divide with w. (Optional)</param>
        /// <returns>quaternion with divided values.</returns>
        public static quaternion Div(this quaternion quaternion, float? x = null, float? y = null, float? z = null, float? w = null) =>
            new quaternion(quaternion.value.x / x ?? quaternion.value.x, quaternion.value.y / y ?? quaternion.value.y, quaternion.value.z / z ?? quaternion.value.z, quaternion.value.w / w ?? quaternion.value.w);
        
        /// <summary>
        /// Modulus any value with x, y, z and/or w.
        /// </summary>
        /// <param name="x">Value to modulus with x. (Optional)</param>
        /// <param name="y">Value to modulus with y. (Optional)</param>
        /// <param name="z">Value to modulus with z. (Optional)</param>
        /// <param name="w">Value to modulus with w. (Optional)</param>
        /// <returns>quaternion with modulused values.</returns>
        public static quaternion Mod(this quaternion quaternion, float? x = null, float? y = null, float? z = null, float? w = null) =>
            new quaternion(quaternion.value.x % x ?? quaternion.value.x, quaternion.value.y % y ?? quaternion.value.y, quaternion.value.z % z ?? quaternion.value.z, quaternion.value.w % w ?? quaternion.value.w);
    }
}
