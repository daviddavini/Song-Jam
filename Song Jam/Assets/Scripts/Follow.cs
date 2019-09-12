using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
	[SerializeField]
	private Transform target;

	private Vector2 currentVelocity = Vector3.zero;

    [SerializeField]
	private float smoothTime = 1f;

    void FixedUpdate()
	{
		Vector2 newPosition = Vector2.SmoothDamp(transform.position, target.position, ref currentVelocity, smoothTime);
        transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);
	}
}
