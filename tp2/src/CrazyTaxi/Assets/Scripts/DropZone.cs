﻿using UnityEngine;
using System.Collections;

public class DropZone : MonoBehaviour {

	private bool isInBox;
	
	void OnTriggerEnter (Collider other) {
		if (other.transform.root.tag == "Player") {
			Debug.Log ("atroden");
			isInBox = true;
		}
	}
	
	void OnTriggerExit (Collider other) {
		if (other.transform.root.tag == "Player") {
			Debug.Log ("ajueren");
			isInBox = false;
		}
	}
	
	void Update() {
		if (isInBox && Input.GetKey("space")) {
			GameObject car = GameObject.FindGameObjectWithTag("Player");
			if (car.rigidbody.velocity.magnitude < 0.05) {
				GameObject.Find("PickUpManager").SendMessage("PickUpModeOff", SendMessageOptions.DontRequireReceiver);
			}
		}
	}
}
