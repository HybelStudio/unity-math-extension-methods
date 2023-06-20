using System;
using Unity.Mathematics;
using System.Collections.Generic;

namespace Hybel.ExtensionMethods
{
    /// <summary>
    /// Extension Methods used on float2s.
    /// </summary>
    public static class Float2Extensions
    {
        /// <summary>
        /// Set x and/or y to any value.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <param name="x">Value to set x to. (Optional)</param>
        /// <param name="y">Value to set y to. (Optional)</param>
        /// <returns>float2 with changed values.</returns>
        public static float2 With(this float2 vector, float? x = null, float? y = null) =>
            new float2(x ?? vector.x, y ?? vector.y);

        /// <summary>
        /// Add any value to x and/or y.
        /// </summary>
        /// <param name="vector">Vector</param>
        /// <param name="x">Value to add to x. (Optional)</param>
        /// <param name="y">Value to add to y. (Optional)</param>
        /// <returns>float2 with added values.</returns>
        public static float2 Add(this float2 vector, float? x = null, float? y = null) =>
            new float2(vector.x + x ?? vector.x, vector.y + y ?? vector.y);

        /// <summary>
        /// Add two vectors together.
        /// </summary>
        public static float2 Add(this float2 vector, float2 addedVector) =>
            vector + addedVector;

        /// <summary>
        /// Subtract any value from x and/or y.
        /// </summary>
        /// <param name="vector">Vector</param>
        /// <param name="x">Value to subtract from x. (Optional)</param>
        /// <param name="y">Value to subtract from y. (Optional)</param>
        /// <returns>float2 with subtracted values.</returns>
        public static float2 Sub(this float2 vector, float? x = null, float? y = null) =>
            new float2(vector.x - x ?? vector.x, vector.y - y ?? vector.y);

        /// <summary>
        /// Subtract any value from x and/or y.
        /// </summary>
        public static float2 Sub(this float2 vector, float2 subtractedVector) =>
            vector - subtractedVector;

        /// <summary>
        /// Multiplied any value with x and/or y.
        /// </summary>
        /// <param name="vector">Vector</param>
        /// <param name="x">Value to multiply with x. (Optional)</param>
        /// <param name="y">Value to multiply with y. (Optional)</param>
        /// <returns>float2 with multiplied values.</returns>
        public static float2 Mul(this float2 vector, float? x = null, float? y = null) =>
            new float2(vector.x * x ?? vector.x, vector.y * y ?? vector.y);

        /// <summary>
        /// Divide any value with x and/or y.
        /// </summary>
        /// <param name="vector">Vector</param>
        /// <param name="x">Value to divide with x. (Optional)</param>
        /// <param name="y">Value to divide with y. (Optional)</param>
        /// <returns>float2 with divided values.</returns>
        public static float2 Div(this float2 vector, float? x = null, float? y = null) =>
            new float2(vector.x / x ?? vector.x, vector.y / y ?? vector.y);

        /// <summary>
        /// Modulus any value with x and/or y.
        /// </summary>
        /// <param name="vector">Vector</param>
        /// <param name="x">Value to modulus with x. (Optional)</param>
        /// <param name="y">Value to modulus with y. (Optional)</param>
        /// <returns>float2 with modulused values.</returns>
        public static float2 Mod(this float2 vector, float? x = null, float? y = null) =>
            new float2(vector.x % x ?? vector.x, vector.y % y ?? vector.y);

        /// <summary>
        /// Get the magnitude as if it is a vector.
        /// </summary>
        public static float Magnitude(this float2 vector) => (float) math.sqrt((double)vector.x * (double)vector.x + (double)vector.y * (double)vector.y);
    
        /// <summary>
        /// Get the squared magnitude as if it is a vector. This avoids a square root operation.
        /// </summary>
        public static float SqrMagnitude(this float2 vector) => (float)((double)vector.x * (double)vector.x + (double)vector.y * (double)vector.y);

        /// <summary>
        /// Flatten the vector to a given value on the y axis.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <param name="flatLevel">Value to set y to. (Default = 0)</param>
        /// <returns>float2 with y set to 0 or set flat level.</returns>
        public static float2 Flat(this float2 vector, float flatLevel = 0f) =>
            new float2(vector.x, flatLevel);

        /// <summary>
        /// Finds the direction towards a given vector.
        /// </summary>
        /// <param name="source">Vector.</param>
        /// <param name="destination">Vector to find the direction to.</param>
        /// <returns>Direction in the form of a normalized float2.</returns>
        public static float2 DirectionTo(this float2 source, float2 destination) =>
            math.normalize(destination - source);

        /// <summary>
        /// Rounds each axis of the vector to a whole number.
        /// </summary>
        public static float2 Round(this float2 vector)
        {
            vector.x = math.round(vector.x);
            vector.y = math.round(vector.y);
            return vector;
        }

        /// <summary>
        /// Rounds each axis of the vector to a multiple of a given value.
        /// </summary>
        public static float2 Round(this float2 vector, float multiple) =>
            (vector / multiple).Round() * multiple;

        /// <summary>
        /// Rounds each axis of the vector to a multiple of a given value.
        /// </summary>
        public static float2 Round(this float2 vector, float2 multiple) =>
            (vector / multiple).Round() * multiple;

        /// <summary>
        /// Floors each axis of the vector to a whole number.
        /// </summary>
        public static float2 Floor(this float2 vector)
        {
            vector.x = math.floor(vector.x);
            vector.y = math.floor(vector.y);
            return vector;
        }

        /// <summary>
        /// Floors each axis of the vector to a multiple of a given value.
        /// </summary>
        public static float2 Floor(this float2 vector, float multiple) =>
            (vector / multiple).Floor() * multiple;

        /// <summary>
        /// Floors each axis of the vector to a multiple of a given value.
        /// </summary>
        public static float2 Floor(this float2 vector, float2 multiple) =>
            (vector / multiple).Floor() * multiple;

        /// <summary>
        /// Floors each axis of the vector to a whole number and converts to an int.
        /// </summary>
        public static int2 FloorToInt(this float2 vector)
        {
            vector = vector.Floor();
            return new int2((int)vector.x, (int)vector.y);
        }

        /// <summary>
        /// Floors each axis of the vector to a multiple of a given value.
        /// </summary>
        public static int2 FloorToInt(this float2 vector, int multiple) =>
            (vector / multiple).FloorToInt() * multiple;

        /// <summary>
        /// Floors each axis of the vector to a multiple of a given value.
        /// </summary>
        public static int2 FloorToInt(this float2 vector, int2 multiple) =>
            (vector / multiple).FloorToInt() * multiple;

        /// <summary>
        /// Ceils each axis of the vector to a whole number.
        /// </summary>
        public static float2 Ceil(this float2 vector)
        {
            vector.x = math.ceil(vector.x);
            vector.y = math.ceil(vector.y);
            return vector;
        }

        /// <summary>
        /// Ceils each axis of the vector to a multiple of a given value.
        /// </summary>
        public static float2 Ceil(this float2 vector, float multiple) =>
            (vector / multiple).Ceil() * multiple;

        /// <summary>
        /// Ceils each axis of the vector to a multiple of a given value.
        /// </summary>
        public static float2 Ceil(this float2 vector, float2 multiple) =>
            (vector / multiple).Ceil() * multiple;

        /// <summary>
        /// Converts a float2 to a float3.
        /// </summary>
        public static float3 ToFloat3XY(this float2 vector) =>
            new float3(vector.x, vector.y, 0f);

        /// <summary>
        /// Converts a float2 to a float3.
        /// </summary>
        public static float3 ToFloat3XY(this float2 vector, float z) =>
            new float3(vector.x, vector.y, z);

        /// <summary>
        /// Converts a float2 to a float3.
        /// </summary>
        public static float3 ToFloat3XZ(this float2 vector) =>
            new float3(vector.x, 0f, vector.y);

        /// <summary>
        /// Converts a float2 to a float3.
        /// </summary>
        public static float3 ToFloat3XZ(this float2 vector, float y) =>
            new float3(vector.x, y, vector.y);

        /// <summary>
        /// Converts a float2 to a float3.
        /// </summary>
        public static float3 ToFloat3YZ(this float2 vector) =>
            new float3(0f, vector.x, vector.y);

        /// <summary>
        /// Converts a float2 to a float3.
        /// </summary>
        public static float3 ToFloat3YZ(this float2 vector, float x) =>
            new float3(x, vector.x, vector.y);

        /// <summary>
        /// Swap the <see cref="float2.x"/> and <see cref="float2.y"/> components.
        /// </summary>
        public static float2 Swap(this float2 vector) => new float2(vector.y, vector.x);

        /// <summary>
        /// Finds the closest float2 from an array of vectors.
        /// </summary>
        public static float2 Closest(this float2 target, float2[] vectors)
        {
            float2 closest = new float2(float.PositiveInfinity, float.PositiveInfinity);
            foreach (float2 vector in vectors)
            {
                float current = (vector - target).SqrMagnitude();
                if (current < (closest - target).SqrMagnitude())
                    closest = vector;
            }
            return closest;
        }

        /// <summary>
        /// Finds the farthest float2 from an array of vectors.
        /// </summary>
        /// <param name="target">Vector.</param>
        /// <param name="vectors">Array of float2.</param>
        /// <returns>Farthest float2 from target.</returns>
        public static float2 Farthest(this float2 target, float2[] vectors)
        {
            float2 farthest = float2.zero;
            foreach (float2 vector in vectors)
            {
                float current = (vector - target).SqrMagnitude();
                if (current > (farthest - target).SqrMagnitude())
                    farthest = vector;
            }
            return farthest;
        }

        /// <summary>
        /// Find the average of an array of float2.
        /// </summary>
        /// <param name="vectors">Vector Array.</param>
        /// <returns>Average float2 from array.</returns>
        public static float2 Average(this float2[] vectors)
        {
            float2 average = float2.zero;
            foreach (float2 vector in vectors)
                average += vector;

            return average / vectors.Length;
        }

        /// <summary>
        /// Returns the vector with a set origin.
        /// </summary>
        /// <param name="vector">float2.</param>
        /// <param name="origin">Origin.</param>
        /// <returns>Original float2 with new origin.</returns>
        public static float2 WithOrigin(this float2 vector, float2 origin) =>
            vector + origin;

        /// <summary>
        /// Finds the Cross Product between this vector and given vector.
        /// </summary>
        /// <param name="vector1">This float2</param>
        /// <param name="float2">Given float2.</param>
        /// <returns>Cross Product between two float2.</returns>
        public static float Cross(this float2 vector1, float2 float2) =>
            (vector1.x * float2.y) - (vector1.y * float2.x);

        /// <summary>
        /// Returns a float2 Perpendicular to the input.
        /// </summary>
        /// <param name="vector">float2.</param>
        public static float2 Perp(this float2 vector) =>
            new float2(vector.y, -vector.x);

        /// <summary>
        /// Checks if this float2 is within a given distance from a given float2.
        /// </summary>
        /// <param name="vector">This float2.</param>
        /// <param name="radius">Distance.</param>
        /// <param name="origin">Origin.</param>
        /// <returns>True if is within. False if not within.</returns>
        public static bool IsWithin(this float2 vector, float2 origin, float radius) =>
            (vector - origin).SqrMagnitude() < radius * radius;

        /// <summary>
        /// Checks if this float2 is within a given area.
        /// </summary>
        public static bool IsWithin(this float2 vector, float2 bottomLeft, float2 topRight) =>
            vector.x > bottomLeft.x && vector.x < topRight.x && vector.y > bottomLeft.y && vector.y < topRight.y;

        /// <summary>
        /// Checks if this float2 is beyond a given distance from a given float2.
        /// </summary>
        /// <param name="vector">This float2.</param>
        /// <param name="radius">Distance.</param>
        /// <param name="origin">Origin.</param>
        /// <returns>True if is beyond. False if not beyond.</returns>
        public static bool IsBeyond(this float2 vector, float2 origin, float radius) =>
            (vector - origin).SqrMagnitude() > radius * radius;

        /// <summary>
        /// Checks if this float2 is beyond a given area.
        /// </summary>
        public static bool IsBeyond(this float2 vector, float2 bottomLeft, float2 topRight) =>
            vector.x < bottomLeft.x || vector.x > topRight.x || vector.y < bottomLeft.y || vector.y > topRight.y;

        /// <summary>
        /// Sets the magnitude of a vector.
        /// </summary>
        /// <param name="vector">float2.</param>
        /// <param name="magnitude">Magnitude.</param>
        /// <returns>The vector with new magnitude.</returns>
        public static float2 SetMagnitude(this float2 vector, float magnitude) =>
            math.normalize(vector) * magnitude;

        /// <summary>
        /// Round components to closest integers and convert to int2.
        /// </summary>
        public static int2 ToInt2(this float2 vector) =>
            new int2(Convert.ToInt32(vector.x.Round()), Convert.ToInt32(vector.y.Round()));

        /// <summary>
        /// Round components to closest integers and convert to int3.
        /// </summary>
        public static int3 ToInt3(this float2 vector) =>
            new int3(Convert.ToInt32(vector.x.Round()), Convert.ToInt32(vector.y.Round()), 0);

        /// <summary>
        /// Set a vectors min and max values.
        /// </summary>
        public static float2 Clamp(this float2 vector, float? minX = null, float? minY = null, float? maxX = null, float? maxY = null) =>
            vector.With(vector.x.Clamp(minX, maxX), vector.y.Clamp(minY, maxY));

        /// <summary>
        /// Set a vectors min and max values.
        /// </summary>
        public static float2 Clamp(this float2 vector, float2? min = null, float2? max = null) =>
            vector.Clamp(min?.x ?? vector.x, min?.y ?? vector.y, max?.x ?? vector.x, max?.y ?? vector.y);

        /// <summary>
        /// Finds the distance from this vector to the <paramref name="target"/> vector.
        /// </summary>
        public static float DistanceFrom(this float2 vector, float2 target) => math.distance(vector, target);

        /// <summary>
        /// Finds the squared distance from this vector to the target vector.
        /// <para>This is faster than <see cref="DistanceFrom(float2, float2)"/> since it doesn't run a square root operation.</para>
        /// </summary>
        public static float SqrDistanceFrom(this float2 vector, float2 target) => (target - vector).SqrMagnitude();

        /// <summary>
        /// Find the manhattan distance from this vector to the <paramref name="target"/> vector.
        /// </summary>
        public static float ManhattanDistanceFrom(this float2 vector, float2 target) =>
            math.abs(target.x - vector.x) + math.abs(target.y - vector.y);

        /// <summary>
        /// Checks if <paramref name="position"/> is closer to <paramref name="origin"/> than <paramref name="comparedPosition"/>.
        /// </summary>
        public static bool IsCloserThan(this float2 position, float2 comparedPosition, float2 origin)
        {
            float positionCloseness = (position - origin).SqrMagnitude();
            float comparedPositionCloseness = (comparedPosition - origin).SqrMagnitude();

            return positionCloseness < comparedPositionCloseness;
        }

        /// <summary>
        /// Checks if <paramref name="position"/> is closer to <paramref name="origin"/> than <paramref name="comparedPosition"/>.
        /// </summary>
        /// <param name="closeness">The closeness of the closest position from <paramref name="origin"/> between <paramref name="position"/> and <paramref name="comparedPosition"/>.</param>
        public static bool IsCloserThan(this float2 position, float2 comparedPosition, float2 origin, out float closeness)
        {
            float positionCloseness = (position - origin).SqrMagnitude();
            float comparedPositionCloseness = (comparedPosition - origin).SqrMagnitude();

            bool isCloser = positionCloseness < comparedPositionCloseness;
            closeness = isCloser ? positionCloseness : comparedPositionCloseness;
            return isCloser;
        }

        /// <summary>
        /// Checks if <paramref name="position"/> is closer to <paramref name="origin"/> than <paramref name="closestValue"/>.
        /// </summary>
        /// <param name="closeness">The closeness of the closest position from <paramref name="origin"/> between <paramref name="position"/> and <paramref name="closestValue"/>.</param>
        public static bool IsCloserThan(this float2 position, float2 origin, float closestValue, out float closeness)
        {
            float positionCloseness = (position - origin).SqrMagnitude();

            bool isCloser = positionCloseness < closestValue;
            closeness = isCloser ? positionCloseness : closestValue;
            return isCloser;
        }

        /// <summary>
        /// Checks if <paramref name="position"/> is closer to <paramref name="origin"/> than <paramref name="closestValue"/>.
        /// </summary>
        /// <param name="closeness">The closeness of the closest position from <paramref name="origin"/> between <paramref name="position"/> and <paramref name="closestValue"/>.</param>
        public static bool IsCloserThan(this float2 position, float2 origin, ref float closestValue)
        {
            float positionCloseness = (position - origin).SqrMagnitude();

            bool isCloser = positionCloseness < closestValue;
            closestValue = isCloser ? positionCloseness : closestValue;
            return isCloser;
        }

        /// <summary>
        /// Get the closest vector to the <paramref name="referencePoint"/>.
        /// </summary>
        public static float2 ClosestTo(this IEnumerable<float2> vectors, float2 referencePoint)
        {
            float2 closest = new float2(float.PositiveInfinity, float.PositiveInfinity);

            foreach (float2 vector in vectors)
                if (vector.IsCloserThan(closest, referencePoint))
                    closest = vector;

            return closest;
        }

        /// <summary>
        /// Translates a group of points.
        /// </summary>
        public static IEnumerable<float2> Translate(this IEnumerable<float2> points, float2 translation)
        {
            var result = new List<float2>();

            foreach (float2 point in points)
                result.Add(point + translation);

            return result;
        }

        /// <summary>
        /// Converts a <see cref="float2"/> into a C# matrix.
        /// </summary>
        public static float[,] ToMatrix(this float2 vector) =>
            new float[,]
            {
                {vector.x},
                {vector.y},
            };
    }
}