using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    new private Rigidbody2D rigidbody;

    [SerializeField]
    private float speed;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    public void MoveInDirection(Vector3 direction)
    {
        rigidbody.AddForce(direction * speed, ForceMode2D.Impulse);
    }
}
