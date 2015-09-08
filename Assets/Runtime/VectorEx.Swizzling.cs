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

        public static Vector2 YX(this Vector2 vector)
        {
            float x = vector.x;
            vector.x = vector.y;
            vector.y = x;
            return vector;
        }

        public static Vector2 XO(this Vector2 vector)
        {
            vector.y = 0;
            return vector;
        }

        public static Vector2 OX(this Vector2 vector)
        {
            vector.y = vector.x;
            vector.x = 0;
            return vector;
        }

        public static Vector2 YO(this Vector2 vector)
        {
            vector.x = vector.y;
            vector.y = 0;
            return vector;
        }

        public static Vector2 OY(this Vector2 vector)
        {
            vector.x = 0;
            return vector;
        }
    }
}