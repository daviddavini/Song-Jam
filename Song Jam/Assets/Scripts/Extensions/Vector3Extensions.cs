﻿using System;
using UnityEngine;

public static class Vector3Extensions
{
    public static Vector3 Flat(this Vector3 v)
    {
        return new Vector3(v.x, v.y, 0);
    }
}