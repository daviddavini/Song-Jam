using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Controller : MonoBehaviour
{
    private Movement movement;

    private void Awake()
    {
        movement = GetComponent<Movement>();
    }

    private void FixedUpdate()
    {
        movement.MoveInDirection(GetDirection());
    }

    protected abstract Vector3 GetDirection();
}
