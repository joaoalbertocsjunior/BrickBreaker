using UnityEngine;
using System.Collections;

public class SideBorders : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter (Collision col) {
		//Debug.Log("COLISAO");
		foreach (ContactPoint contact in col.contacts) {
			if (contact.thisCollider == collider) {
				// This is the paddle contact point
				float paddleContact = contact.point.x - transform.position.x;
				
				contact.otherCollider.rigidbody.AddForce(300f * paddleContact, 0, 0);
			}
		}
	}
}
