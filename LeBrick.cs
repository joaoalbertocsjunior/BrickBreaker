using UnityEngine;
using System.Collections;

public class LeBrick : MonoBehaviour {
	
	//AudioSource myAudio;
	//static int numBricks = 0;
	public int pointValue = 1;
	//public int lives;
	//string cache;

	// Use this for initialization
	void Start () {
		//numBricks++;
		//myAudio = GameObject.Find("mapGeneratorGameObject").GetComponent<AudioSource>;
		//gameObject.audio = myAudio;
	}
	
	/**
	public int setLives(int myLives) {
		lives = myLives;
		return lives;
	}
	
	int removeLifeCount () {
		lives--;
		return lives;
	}
	*/
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter (Collision col) {
		Destroy(gameObject);
		GameObject.Find("Bar").GetComponent<LeBar>().AddPoint(pointValue);
		GameObject.Find("mapGeneratorGameObject").GetComponent<TestInstantiating>().removeBrickCount();
		//removeLifeCount();
		//cache = GameObject.Find("mapGeneratorGameObject").GetComponent<TestInstantiating>().numBricks.ToString;
		Debug.Log(GameObject.Find("mapGeneratorGameObject").GetComponent<TestInstantiating>().numBricks.ToString());
		if (col.gameObject.name == "Ball(Clone)") {
			GameObject.Find("mapGeneratorGameObject").audio.Play();
		}
		/**
		if (lives <= 0) {
			Destroy(gameObject);
		} */
		
		//GameObject.FindGameObjectsWithTag("jonnyeozi");
		//numBricks--;
		//Debug.Log(numBricks);
		//if (numBricks <= 0) {
			
		//}
	}
}
