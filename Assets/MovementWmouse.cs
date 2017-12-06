using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementWmouse : MonoBehaviour {

	// Use this for initialization
	public float horizontalSpeed = 2.0F;
	public float verticalSpeed = 2.0F;
	void Update() {
		float h = horizontalSpeed * Input.GetAxis("Mouse Y");
		float v = verticalSpeed * Input.GetAxis("Mouse X");
		transform.Translate(v, h, 0);
	}
}