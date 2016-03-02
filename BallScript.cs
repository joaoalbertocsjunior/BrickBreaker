using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {
	
	bool ballCollided = false;

	// Use this for initialization
	void Start () {
	//rigidbody.AddForce( 0, 900f, 0);
	}
	
	// Update is called once per frame
	void Update () {
		// Debug.Log(gameObject.rigidbody.velocity.magnitude); // << IMPORTANT!!!
	}
	
	void OnCollisionEnter(Collision col) {
		//this.rigidbody.AddForce(Vector3.Reflect(rigidbody.velocity ,col.contacts[0].normal));
		if (ballCollided == false) {
			ballCollided = true;
			//rigidbody.AddForce(300f, 0 , 0);
			rigidbody.AddForce(150f, 0 , 0);
		}
	}
	
	public void Die() {
		Destroy( gameObject );
		GameObject paddleObject = GameObject.Find("Bar");
		LeBar leBar = paddleObject.GetComponent<LeBar>();
		leBar.SpawnBall();
	}
}
