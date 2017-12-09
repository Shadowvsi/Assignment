﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keymovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public float speed = 200;
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;

		if (Input.GetKey (KeyCode.UpArrow)) {
			if (pos.y < 380) {
				pos.y += speed * Time.deltaTime;
			}
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			if (pos.y > 36) {
				pos.y -= speed * Time.deltaTime;
			}

		}

		if (Input.GetKey ("w")) {
			if (pos.y < 382) {
				pos.y += speed * Time.deltaTime;
			}
		}
		if (Input.GetKey ("s")) {
			if (pos.y > 36) {
				pos.y -= speed * Time.deltaTime;
			}
		}
		transform.position = pos;
		
	}
}
