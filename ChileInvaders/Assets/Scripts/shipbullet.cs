﻿using UnityEngine;
using System.Collections;

public class shipbullet : MonoBehaviour {

	//here we set a counter so that we can keep track of how long the bullet has existed
	private float lifeCounter = 0.0f;
	
	void  Start (){
		//here we give the bullet a speed going left
		rigidbody.velocity = new Vector3( -8, rigidbody.velocity.y, rigidbody.velocity.z);
	}
	
	void  Update (){
		//here we keep track of time
		lifeCounter += Time.deltaTime;
		//if the bullet goes too far left we destroy it
		if(transform.position.x < -12){
			Destroy(gameObject);
		}
		//if the bullet is alive for longer than 6 seconds, we destroy it.
		if(lifeCounter > 6){
			Destroy(gameObject);
		}
	}
}