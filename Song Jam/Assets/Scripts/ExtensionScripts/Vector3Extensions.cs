using System;
using UnityEngine;

public static class Vector3Extensions
{
    public static Vector3 Flat(this Vector3 v)
    {
        return new Vector3(v.x, v.y, 0);
    }
    public static Vector3 RandomVector(this Vector3 v)
    {
        double theta = (double)UnityEngine.Random.Range(-3.14f, 3.14f);

        return new Vector3( (float)Math.Cos(theta),(float) Math.Sin(theta), 0f) * 200;
    }
}
