using Unity.Mathematics;

namespace Hybel.ExtensionMethods
{
    /// <summary>
    /// Extension Methods used on float3.
    /// </summary>
    public static class Float3Extensions
    {
        /// <summary>
        /// Set x, y and/or z to any value.
        /// </summary>
        /// <param name="x">Value to set x to. (Optional)</param>
        /// <param name="y">Value to set y to. (Optional)</param>
        /// <param name="z">Value to set z to. (Optional)</param>
        /// <returns>float2 with changed values.</returns>
        public static float3 With(this float3 vector, float? x = null, float? y = null, float? z = null) =>
            new float3(x ?? vector.x, y ?? vector.y, z ?? vector.z);

        /// <summary>
        /// Add any value to x, y and/or z.
        /// </summary>
        /// <param name="x">Value to add to x. (Optional)</param>
        /// <param name="y">Value to add to y. (Optional)</param>
        /// <param name="z">Value to add to z. (Optional)</param>
        /// <returns>float3 with added values.</returns>
        public static float3 Add(this float3 vector, float? x = null, float? y = null, float? z = null) =>
            new float3(vector.x + x ?? vector.x, vector.y + y ?? vector.y, vector.z + z ?? vector.z);

        /// <summary>
        /// Subtract any value from x, y and/or z.
        /// </summary>
        /// <param name="x">Value to subtract from x. (Optional)</param>
        /// <param name="y">Value to subtract from y. (Optional)</param>
        /// <param name="z">Value to subtract from z. (Optional)</param>
        /// <returns>float2 with subtracted values.</returns>
        public static float3 Sub(this float3 vector, float? x = null, float? y = null, float? z = null) =>
            new float3(vector.x - x ?? vector.x, vector.y - y ?? vector.y, vector.z - z ?? vector.z);

        /// <summary>
        /// Subtract any value from x, y and/or z.
        /// </summary>
        /// <param name="x">Value to subtract from x. (Optional)</param>
        /// <param name="y">Value to subtract from y. (Optional)</param>
        /// <param name="z">Value to subtract from z. (Optional)</param>
        /// <returns>float2 with subtracted values.</returns>
        public static float3 Mul(this float3 vector, float? x = null, float? y = null, float? z = null) =>
            new float3(vector.x * x ?? vector.x, vector.y * y ?? vector.y, vector.z * z ?? vector.z);

        /// <summary>
        /// Divide any value with x, y and/or z.
        /// </summary>
        /// <param name="x">Value to divide with x. (Optional)</param>
        /// <param name="y">Value to divide with y. (Optional)</param>
        /// <param name="z">Value to divide with z. (Optional)</param>
        /// <returns>float2 with divided values.</returns>
        public static float3 Div(this float3 vector, float? x = null, float? y = null, float? z = null) =>
            new float3(vector.x / x ?? vector.x, vector.y / y ?? vector.y, vector.z / z ?? vector.z);

        /// <summary>
        /// Modulus any value with x, y and/or z.
        /// </summary>
        /// <param name="x">Value to modulus with x. (Optional)</param>
        /// <param name="y">Value to modulus with y. (Optional)</param>
        /// <param name="z">Value to modulus with z. (Optional)</param>
        /// <returns>float2 with modulused values.</returns>
        public static float3 Mod(this float3 vector, float? x = null, float? y = null, float? z = null) =>
            new float3(vector.x % x ?? vector.x, vector.y % y ?? vector.y, vector.z % z ?? vector.z);

        /// <summary>
        /// Get the magnitude as if it is a vector.
        /// </summary>
        public static float Magnitude(this float3 vector) => (float) math.sqrt((double)vector.x * (double)vector.x + (double)vector.y * (double)vector.y + vector.z * (double)vector.z);
    
        /// <summary>
        /// Get the squared magnitude as if it is a vector. This avoids a square root operation.
        /// </summary>
        public static float SqrMagnitude(this float3 vector) => (float)((double)vector.x * (double)vector.x + (double)vector.y * (double)vector.y + vector.z * (double)vector.z);

        /// <summary>
        /// Flatten the vector to a given value on the y axis.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <param name="flatLevel">Value to set y to. (Default = 0)</param>
        /// <returns>float3 with y set to 0 or set flat level.</returns>
        public static float3 Flat(this float3 vector, float flatLevel = 0) =>
            new float3(vector.x, flatLevel, vector.z);

        /// <summary>
        /// Finds the direction towards a given vector.
        /// </summary>
        /// <param name="source">Vector.</param>
        /// <param name="destination">Vector to find the direction to.</param>
        /// <returns>Direction in the form of a normalized float3.</returns>
        public static float3 DirectionTo(this float3 source, float3 destination) =>
            math.normalize(destination - source);

        /// <summary>
        /// Rounds each axis of the vector to a whole number.
        /// </summary>
        public static float3 Round(this float3 vector)
        {
            vector.x = math.round(vector.x);
            vector.y = math.round(vector.y);
            vector.z = math.round(vector.z);
            return vector;
        }

        /// <summary>
        /// Rounds each axis of the vector to a multiple of a given value.
        /// </summary>
        public static float3 Round(this float3 vector, float multiple) =>
            (vector / multiple).Round() * multiple;

        /// <summary>
        /// Rounds each axis of the vector to a multiple of a given value.
        /// </summary>
        public static float3 Round(this float3 vector, float3 multiple) => new float3
            (
                (vector.x / multiple.x).Round() * multiple.x,
                (vector.y / multiple.y).Round() * multiple.y,
                (vector.z / multiple.z).Round() * multiple.z
            );

        /// <summary>
        /// Floors each axis of the vector to a whole number.
        /// </summary>
        public static float3 Floor(this float3 vector)
        {
            vector.x = math.floor(vector.x);
            vector.y = math.floor(vector.y);
            vector.z = math.floor(vector.z);
            return vector;
        }

        /// <summary>
        /// Floors each axis of the vector to a multiple of a given value.
        /// </summary>
        public static float3 Floor(this float3 vector, float multiple) =>
            (vector / multiple).Floor() * multiple;

        /// <summary>
        /// Floors each axis of the vector to a multiple of a given value.
        /// </summary>
        public static float3 Floor(this float3 vector, float3 multiple) => new float3
            (
                (vector.x / multiple.x).Floor() * multiple.x,
                (vector.y / multiple.y).Floor() * multiple.y,
                (vector.z / multiple.z).Floor() * multiple.z
            );

        /// <summary>
        /// Ceils each axis of the vector to a whole number.
        /// </summary>
        public static float3 Ceil(this float3 vector)
        {
            vector.x = math.ceil(vector.x);
            vector.y = math.ceil(vector.y);
            vector.z = math.ceil(vector.z);
            return vector;
        }

        /// <summary>
        /// Ceils each axis of the vector to a multiple of a given value.
        /// </summary>
        public static float3 Ceil(this float3 vector, float multiple) =>
            (vector / multiple).Ceil() * multiple;

        /// <summary>
        /// Ceils each axis of the vector to a multiple of a given value.
        /// </summary>
        public static float3 Ceil(this float3 vector, float3 multiple) => new float3
            (
                (vector.x / multiple.x).Ceil() * multiple.x,
                (vector.y / multiple.y).Ceil() * multiple.y,
                (vector.z / multiple.z).Ceil() * multiple.z
            );

        /// <summary>
        /// Converts a float3 to a float2 using the x and y coordinates.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <returns>float2 found from the float3 x and y coordinates.</returns>
        public static float2 Tofloat2XY(this float3 vector) =>
            new float2(vector.x, vector.y);

        /// <summary>
        /// Converts a float3 to a float2 using the x and z coordinates.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <returns>float2 found from the float3 x and z coordinates.</returns>
        public static float2 Tofloat2XZ(this float3 vector) =>
            new float2(vector.x, vector.z);

        /// <summary>
        /// Converts a float3 to a float2 using the y and z coordinates.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <returns>float2 found from the float3 y and z coordinates.</returns>
        public static float2 Tofloat2YZ(this float3 vector) =>
            new float2(vector.y, vector.z);

        /// <summary>
        /// Swap the <see cref="float3.x"/>, <see cref="float3.y"/> and <see cref="float3.z"/> components forwards.
        /// <para>This means x becomes y, y becomes z and z becomes x.</para>
        /// </summary>
        public static float3 SwapForwards(this float3 vector) => new float3(vector.z, vector.x, vector.y);

        /// <summary>
        /// Swap the <see cref="float3.x"/>, <see cref="float3.y"/> and <see cref="float3.z"/> components backwards.
        /// <para>This means x becomes z, y becomes x and z becomes y.</para>
        /// </summary>
        public static float3 SwapBackwards(this float3 vector) => new float3(vector.y, vector.z, vector.x);

        /// <summary>
        /// Finds the closest float3 from an array of vectors.
        /// </summary>
        /// <param name="target">Vector.</param>
        /// <param name="vectors">Array of float3.</param>
        /// <returns>Closest float3 to target.</returns>
        public static float3 Closest(this float3 target, float3[] vectors)
        {
            float3 closest = new float3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity);
            foreach (float3 vector in vectors)
            {
                float current = (vector - target).SqrMagnitude();
                if (current < (closest - target).SqrMagnitude())
                    closest = vector;
            }
            return closest;
        }

        /// <summary>
        /// Finds the farthest float3 from an array of vectors.
        /// </summary>
        /// <param name="target">Vector.</param>
        /// <param name="vectors">Array of float3.</param>
        /// <returns>Farthest float3 from target.</returns>
        public static float3 Farthest(this float3 target, float3[] vectors)
        {
            float3 farthest = float3.zero;
            foreach (float3 vector in vectors)
            {
                float current = (vector - target).SqrMagnitude();
                if (current > (farthest - target).SqrMagnitude())
                    farthest = vector;
            }
            return farthest;
        }

        /// <summary>
        /// Find the average of an array of float3.
        /// </summary>
        /// <param name="vectors">Vector Array.</param>
        /// <returns>Average float3 from array.</returns>
        public static float3 Average(this float3[] vectors)
        {
            float3 total = float3.zero;
            foreach (float3 vector in vectors)
                total += vector;

            return total / vectors.Length;
        }

        /// <summary>
        /// Returns the vector with a set origin.
        /// </summary>
        /// <param name="vector">float3.</param>
        /// <param name="origin">Origin.</param>
        /// <returns>Original float3 with new origin.</returns>
        public static float3 WithOrigin(this float3 vector, float3 origin) =>
            vector + origin;

        /// <summary>
        /// Finds the Cross Product between this vector and given vector.
        /// </summary>
        /// <param name="vector1">This float3</param>
        /// <param name="vector2">Given float3.</param>
        /// <returns>Cross Product between two float2.</returns>
        public static float3 Cross(this float3 vector1, float3 vector2) =>
            math.cross(vector1, vector2);

        /// <summary>
        /// Returns a float3 Perpendicular to the input.
        /// </summary>
        /// <param name="vector">float3.</param>
        public static float3 PerpXY(this float3 vector) =>
            new float3(vector.y, -vector.x, 0f);

        /// <summary>
        /// Returns a float3 Perpendicular to the input.
        /// </summary>
        /// <param name="vector">float3.</param>
        public static float3 PerpXZ(this float3 vector) =>
            new float3(vector.y, 0f, -vector.x);

        /// <summary>
        /// Returns a float3 Perpendicular to the input.
        /// </summary>
        /// <param name="vector">float3.</param>
        public static float3 PerpYZ(this float3 vector) =>
            new float3(0f, vector.y, -vector.x);

        /// <summary>
        /// Checks if this float3 is within a given distance from a given float3.
        /// </summary>
        /// <param name="vector">This float3.</param>
        /// <param name="radius">Distance.</param>
        /// <param name="origin">Origin.</param>
        /// <returns>True if is within. False if not within.</returns>
        public static bool IsWithin(this float3 vector, float3 origin, float radius) =>
            (vector - origin).SqrMagnitude() < radius * radius;

        /// <summary>
        /// Checks if this float2 is within a given area.
        /// </summary>
        public static bool IsWithin(this float3 vector, float3 bottomLeftFront, float3 topRightBack) =>
            vector.x > bottomLeftFront.x && vector.x < topRightBack.x &&
            vector.y > bottomLeftFront.y && vector.y < topRightBack.y &&
            vector.z > bottomLeftFront.z && vector.z < topRightBack.z;

        /// <summary>
        /// Checks if this float3 is beyond a given distance from a given float3.
        /// </summary>
        /// <param name="vector">This float3.</param>
        /// <param name="radius">Distance.</param>
        /// <param name="origin">Origin.</param>
        /// <returns>True if is beyond. False if not beyond.</returns>
        public static bool IsBeyond(this float3 vector, float3 origin, float radius) =>
            (vector - origin).SqrMagnitude() > radius * radius;

        /// <summary>
        /// Checks if this float2 is beyond a given area.
        /// </summary>
        public static bool IsBeyond(this float3 vector, float3 bottomLeftFront, float3 topRightBack) =>
            vector.x < bottomLeftFront.x || vector.x > topRightBack.x ||
            vector.y < bottomLeftFront.y || vector.y > topRightBack.y ||
            vector.z < bottomLeftFront.z || vector.z > topRightBack.z;

        /// <summary>
        /// Sets the magnitude of a vector.
        /// </summary>
        public static float3 SetMagnitude(this float3 vector, float magnitude) =>
            math.normalize(vector) * magnitude;

        /// <summary>
        /// Round components to closest integers and convert to int3.
        /// </summary>
        public static int3 ToInt3(this float3 vector) =>
            new int3(vector.x.RoundToInt(), vector.y.RoundToInt(), vector.z.RoundToInt());

        /// <summary>
        /// Round components to closest integers and convert to int2.
        /// </summary>
        public static int2 ToInt2(this float3 vector) =>
            new int2(vector.x.RoundToInt(), vector.y.RoundToInt());

        /// <summary>
        /// Set a vectors min and max values.
        /// </summary>
        public static float3 Clamp(this float3 vector, float? minX = null, float? minY = null, float? minZ = null, float? maxX = null, float? maxY = null, float? maxZ = null) =>
            vector.With(vector.x.Clamp(minX, maxX), vector.y.Clamp(minY, maxY), vector.z.Clamp(minZ, maxZ));

        /// <summary>
        /// Returns a copy of <paramref name="vector"/> with its magnitude clamped to <paramref name="maxLength"/>.
        /// </summary>
        public static float3 ClampMagnitude(this float3 vector, float maxLength = 1) => vector.SetMagnitude(math.max(vector.Magnitude(), maxLength));

        /// <summary>
        /// Finds the distance from this vector to the target vector.
        /// </summary>
        public static float DistanceFrom(this float3 vector, float3 target) => math.distance(vector, target);

        /// <summary>
        /// Finds the squared distance from this vector to the target vector.
        /// <para>This is faster than <see cref="DistanceFrom(float3, float3)"/> since it doesn't run a square root operation.</para>
        /// </summary>
        public static float SqrDistanceFrom(this float3 vector, float3 target) => math.distancesq(vector, target);

        /// <summary>
        /// Find the manhattan distance from this vector to the <paramref name="target"/> vector.
        /// </summary>
        public static float ManhattanDistanceFrom(this float3 vector, float3 target) =>
            math.abs(target.x - vector.x) + math.abs(target.y - vector.y) + math.abs(target.z - vector.z);

        /// <summary>
        /// Checks if <paramref name="position"/> is closer to <paramref name="origin"/> than <paramref name="comparedPosition"/>.
        /// </summary>
        public static bool IsCloserThan(this float3 position, float3 comparedPosition, float3 origin)
        {
            float positionCloseness = (position - origin).SqrMagnitude();
            float comparedPositionCloseness = (comparedPosition - origin).SqrMagnitude();

            return positionCloseness < comparedPositionCloseness;
        }

        /// <summary>
        /// Checks if <paramref name="position"/> is closer to <paramref name="origin"/> than <paramref name="comparedPosition"/>.
        /// </summary>
        /// <param name="closeness">The closeness of the closest position from <paramref name="origin"/> between <paramref name="position"/> and <paramref name="comparedPosition"/>.</param>
        public static bool IsCloserThan(this float3 position, float3 comparedPosition, float3 origin, out float closeness)
        {
            float positionCloseness = (position - origin).SqrMagnitude();
            float comparedPositionCloseness = (comparedPosition - origin).SqrMagnitude();

            bool isCloser = positionCloseness < comparedPositionCloseness;
            closeness = isCloser ? positionCloseness : comparedPositionCloseness;
            return isCloser;
        }

        /// <summary>
        /// Checks if <paramref name="position"/>s distance <paramref name="origin"/> is less than <paramref name="closestValue"/>.
        /// </summary>
        /// <param name="closeness">The closeness of the closest position from <paramref name="origin"/> between <paramref name="position"/> and <paramref name="closestValue"/>.</param>
        public static bool IsCloserTo(this float3 position, float3 origin, float closestValue, out float closeness)
        {
            float positionCloseness = (position - origin).SqrMagnitude();

            bool isCloser = positionCloseness < closestValue;
            closeness = isCloser ? positionCloseness : closestValue;
            return isCloser;
        }

        /// <summary>
        /// Checks if <paramref name="position"/>s distance <paramref name="origin"/> is less than <paramref name="closestValue"/>.
        /// </summary>
        /// <param name="closestValue">Current closest value.
        /// <para>Is updated internally to the closest value between <paramref name="position"/> and the passed in <paramref name="closestValue"/>.</para>
        /// </param>
        public static bool IsCloserTo(this float3 position, float3 origin, ref float closestValue)
        {
            float positionCloseness = (position - origin).SqrMagnitude();

            bool isCloser = positionCloseness < closestValue;
            closestValue = isCloser ? positionCloseness : closestValue;
            return isCloser;
        }

        /// <summary>
        /// Translates a group of points.
        /// </summary>
        public static IEnumerable<float3> Translate(this IEnumerable<float3> points, float3 translation)
        {
            List<float3> result = new List<float3>();

            foreach (float3 point in points)
                result.Add(point + translation);

            return result;
        }

        /// <summary>
        /// Rotate a <paramref name="worldPosition"/> around a <paramref name="centerOfRotation"/>.
        /// </summary>
        /// <param name="worldPosition">Current world position.</param>
        /// <param name="centerOfRotation">World space position to rotate around.</param>
        /// <param name="orientation">Relative orientation.</param>
        /// <returns><paramref name="worldPosition"/> rotated around <paramref name="centerOfRotation"/> by <paramref name="orientation"/>.</returns>
        public static float3 Rotate(this float3 worldPosition, float3 centerOfRotation, quaternion orientation)
        {
            var localPosition = worldPosition - centerOfRotation;
            localPosition = orientation.Multiply(localPosition);
            worldPosition = localPosition + centerOfRotation;
            return worldPosition;
        }

        /// <summary>
        /// Rotate a <paramref name="worldPosition"/> around a <paramref name="centerOfRotation"/>.
        /// </summary>
        /// <param name="worldPosition">Current world position.</param>
        /// <param name="centerOfRotation">World space position to rotate around.</param>
        /// <param name="eulerAngles">Relative angles.</param>
        /// <returns><paramref name="worldPosition"/> rotated around <paramref name="centerOfRotation"/> by <paramref name="eulerAngles"/>.</returns>
        public static float3 Rotate(this float3 worldPosition, float3 centerOfRotation, float3 eulerAngles) =>
            Rotate(worldPosition, centerOfRotation, quaternion.Euler(eulerAngles));

        /// <summary>
        /// Converts a <see cref="float3"/> into a C# matrix.
        /// </summary>
        public static float[,] ToMatrix(this float3 vector)
        {
            return new float[,]
            {
                {vector.x},
                {vector.y},
                {vector.z},
            };
        }
    }
}