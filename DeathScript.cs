﻿using UnityEngine;
using System.Collections;

public class DeathScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other) {
		BallScript ballScript = other.GetComponent<BallScript>();
		
		if( ballScript ) {
			ballScript.Die();
		}
	}
}
