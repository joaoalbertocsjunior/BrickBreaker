using UnityEngine;
using System.Collections;

public class LeBar : MonoBehaviour {
	
	//public Vector3 speedRight = new Vector3(1,0,0);
	//public Vector3 speedLeft  = new Vector3(-1,0,0);
	//public Vector3 speedZero  = new Vector3(0,0,0);
	
	public GameObject ballPrefab;
	GameObject attachedBall = null;
	GUIText guiLives;
	public AudioSource audiofile;
	bool ballAttached = false;
	public float maxRight;
	public float maxLeft;
	
	//bool ballIsPlaying = false;
	
	int lives = 4;
	
	int score = 0;
	
	public GUISkin scoreBoardSkin;
	
	public void SpawnBall() {
		
		//if (ballIsPlaying == false) {
			if (ballPrefab == null) {
				Debug.Log("Missing ball reference!");
				return;
			}
		
			//Vector3 ballPosition = transform.position + new Vector3(0, 1f, 0);
			//Quaternion ballRotation = Quaternion.identity;
		
			attachedBall = (GameObject)Instantiate( ballPrefab, transform.position + new Vector3(0, 1f, 0), Quaternion.identity );
			
			lives--;
			
			
		
			guiLives.text = "Lives: " + lives;
			//ballIsPlaying = true;
		//}
	}
	
	void OnGUI() {
		GUI.skin = scoreBoardSkin;
		GUI.Label(new Rect(0,10,300,100), "Score: " + score);
		
	}
	
	//public GUISkin scoreboardSkin;
	// Use this for initialization
	void Start () {
		//DontDestroyOnLoad(gameObject);
		//DontDestroyOnLoad(gameObject);
		guiLives = GameObject.Find("guiLives").GetComponent<GUIText>();
		//guiLives = GameObject.Find();
		SpawnBall();
		
	}
	
	public void AddPoint(int valor) {
		score += valor;	
	}
	
	// Update is called once per frame
	void Update () {
		
		if ((Input.GetAxis( "Horizontal" ) < 0) && (transform.position.x > maxLeft)) {
			
			//Debug.Log("Left!");
			transform.Translate( -30f * Time.deltaTime, 0, 0);
		}
		
		
		if ((Input.GetAxis("Horizontal") > 0 ) && (transform.position.x < maxRight)) {
			
			//Debug.Log("Right!");
			transform.Translate( 30f * Time.deltaTime, 0, 0);
		}
		
		
		if (attachedBall /**&& (ballIsPlaying == true)*/) {
			
			Rigidbody ballRigidbody = attachedBall.rigidbody;
			
			ballRigidbody.position = transform.position + new Vector3(0, 1f, 0);
			
			if (Input.GetButtonDown( "Jump" )) {
				// Fire the ball //
				//if (theBall /**&& (ballIsPlaying == true)*/) {
				attachedBall.rigidbody.isKinematic = false;
				//attachedBall.rigidbody.AddForce(300f * Input.GetAxis("Horizontal"), 900f, 0);
				attachedBall.rigidbody.AddForce(300f * Input.GetAxis("Horizontal"), 900f, 0);
				attachedBall = null;
			}
		}
	}
	
	void OnCollisionEnter (Collision col) {
		//Debug.Log("COLLISAO");
		foreach (ContactPoint contact in col.contacts) {
			if (contact.thisCollider == collider) {
				// This is the paddle contact point
				float boyBigAward = contact.point.x - transform.position.x;
				
				contact.otherCollider.rigidbody.AddForce(300f * boyBigAward, 0, 0);
			}
		}
		
		audio.Play();
	}
	
	/**
	void FixedUpdate () {
		if (Input.GetKey(KeyCode.RightArrow) && (transform.position.x <= 14.6))
		{
			if (Input.GetKey(KeyCode.LeftArrow))
			{
				rigidbody.MovePosition(rigidbody.position + speedZero * Time.deltaTime);
			}
		
				rigidbody.MovePosition(rigidbody.position + speedRight * Time.deltaTime); 	
			
		}
		
		if (Input.GetKey(KeyCode.LeftArrow) && (transform.position.x >= 1.5))
		{
			if (Input.GetKey(KeyCode.RightArrow))
			{
				rigidbody.MovePosition(rigidbody.position + speedZero * Time.deltaTime);
			}
			
			rigidbody.MovePosition(rigidbody.position + speedLeft * Time.deltaTime);
		}
	}
	*/
	
}