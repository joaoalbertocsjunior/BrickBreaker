using UnityEngine;
using System.Collections;

public class TestInstantiating : MonoBehaviour {
	
	int markedBlock;
	public int numBricks;
	
	// Use this for initialization
	void Start () {
		numBricks = 0;
		for (int y = 0;y < 32; y++) {
			for (int x = 0; x < 20; x++) {
				//GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
				//cube.AddComponent<Rigidbody>();
				//cube.transform.position = new Vector3(x, y, 0);
				CreateCube(x,y/**,y*/);
				numBricks++;
				
				markedBlock = Random.Range(1, 8);
				if (markedBlock <= 3) {
					GiveRandomAttribute();
				}
				//GiveRandomAttribute();
			}
		}
		GameObject[] cubes = GameObject.FindGameObjectsWithTag("leCube");
		//Debug.Log(cubes.Length);
	}
	
	public void removeBrickCount() {
		numBricks--;
	}

	// Update is called once per frame
	void Update () {
		
	}
	
	void FixedUpdate () {
		//Debug.Log(numBricks);	 // WHY NOT WORK?
	}
	
	public void CreateCube(int xA, int yA/**, int cubeLives */) {
		GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube.transform.localScale = new Vector3(1f, 1f, 1f);
		cube.transform.position = new Vector3(xA, yA, 0);
		cube.AddComponent("LeBrick");
		cube.tag = "leCube";
		//cube.GetComponent<LeBrick>().setLives(cubeLives);
		//cube.AddComponent();
		//cube.audio = audio;
	}
	
	// Make every 3 from 8 blocks come attached with a random DropScript (Old Version) \\//
	/**
	bool MarkDroppableBlocks () {
		int randomMark;
		randomMark = Random.Range(1, 8);
		switch (randomMark) {
			case 1:
			case 2:
			case 3:
				//Debug.Log("True!");
				return true;
				break;
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
				//Debug.Log("False!");
				return false;
				break;
			default:
				return null;
				break;
		}
	}
	*/
	
	//  \/ Return String (?)
	
	void GiveRandomAttribute () {
		int random;
		random = Random.Range(1, 100);
		switch (random) {
		case 1: 
		case 2:
		case 3:
		case 4:
		case 5:
		case 6:
			Debug.Log("De-Buff: Shorten Bar");
			break;
		case 7:
		case 8:
		case 9:
		case 10:
		case 11:
		case 12:
			Debug.Log("De-Buff: Smaller Ball");
			break;
		case 13:
		case 14:
		case 15:
		case 16:
		case 17:
		case 18:
			Debug.Log("De-Buff: Faster Ball");
			break;
		case 19:
		case 20:
		case 21:
		case 22:
		case 23:
		case 24:
			Debug.Log("De-Buff: Slower Ball");
			break;
		case 25:
		case 26:
		case 27:
		case 28:
		case 29:
		case 30:
			Debug.Log("De-Buff: Score -");
			break;
		case 31:
		case 32:
		case 33:
		case 34:
		case 35:
		case 36:
		case 37:
		case 38:
		case 39:
		case 40:
			Debug.Log("Buff: Longer Bar");
			break;
		case 41:
		case 42:
		case 43:
		case 44:
		case 45:
		case 46:
		case 47:
		case 48:
		case 49:
		case 50:
			Debug.Log("Buff: Bigger Ball");
			break;
		case 51:
		case 52:
		case 53:
		case 54:
		case 55:
		case 56:
		case 57:
		case 58:
		case 59:
		case 60:
		case 61:
		case 62:
		case 63:
		case 64:
		case 65:
		case 66:
		case 67:
		case 68:
		case 69:
		case 70:
			Debug.Log("Buff: Extra Ball");
			break;
		case 71:
		case 72:
		case 73:
		case 74:
		case 75:
		case 76:
		case 77:
		case 78:
		case 79:
		case 80:
		case 81:
		case 82:
		case 83:
		case 84:
		case 85:
		case 86:
		case 87:
		case 88:
		case 89:
		case 90:
			Debug.Log("Buff: Extra Life");
			break;
		case 91:
		case 92:
		case 93:
		case 94:
		case 95:
			Debug.Log("Buff: Strong Ball");
			break;
		case 96:
		case 97:
		case 98:
		case 99:
		case 100:
			Debug.Log("Buff: Score +");
			break;
		default:
			Debug.Log("Error?!");
			break;
		}
	}
	
}

