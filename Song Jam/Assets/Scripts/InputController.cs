using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : Controller
{
    protected override Vector3 GetDirection()
	{
		return new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
	}
}
