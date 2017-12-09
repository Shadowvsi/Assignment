using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementWmouse : MonoBehaviour {
	public float speed = 200;
	// Use this for initialization
	void Update() {
		Vector3 pos = transform.position;
		if (Input.GetMouseButton(0)) {
			if (pos.y < 382) {
				pos.y += speed * Time.deltaTime;
			}
		}
		if (Input.GetMouseButton(1)) {
			if (pos.y > 36) {
				pos.y -= speed * Time.deltaTime;
			}
		}
		transform.position = pos;
	}
}