namespace Alquimiaware
{
    using UnityEngine;
    using System.Collections;
    using System;

    public static class VectorEx
    {
        public static Vector2 XX(this Vector2 vector)
        {
            vector.y = vector.x;
            return vector;
        }

        public static Vector2 YY(this Vector2 vector)
        {
            vector.x = vector.y;
            return vector;
        }
    }
}