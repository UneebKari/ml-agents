using UnityEngine;
using System.Collections;

public class BounusScript : MonoBehaviour {
	
	public AudioClip coin;
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody>().velocity = new Vector3 (0, -0.8f, 0);
	}
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Boundary"||other.tag == "obstacleType1"||other.tag == "escapeType1"
		    ||other.tag == "obstacleType2"||other.tag == "escapeType2"
		    ||other.tag == "obstacleType3"||other.tag == "escapeType3"
		    ||other.tag == "obstacleType4"||other.tag == "escapeType4") {
			return;
		}
		
		else if (other.tag=="ball"||other.tag=="player" ) {

			ChooseBounusPoints();
			Destroy(gameObject);
			AudioSource.PlayClipAtPoint(coin,transform.position);

		} 
		
		else {
			
			ScoreGui.Myscore=0;
			Application.LoadLevel ("_Scene");
		}
	}
	void ChooseBounusPoints(){
		switch (Random.Range (0, 6)) {
		case 0:
			ScoreGui.Myscore+=100;
			break;
		case 1:
			ScoreGui.Myscore+=200;
			break;
		case 2:
			ScoreGui.Myscore+=300;
			break;
		case 3:
			ScoreGui.Myscore+=400;
			break;
		case 4:
			ScoreGui.Myscore+=500;
			break;
		}
	}
}
