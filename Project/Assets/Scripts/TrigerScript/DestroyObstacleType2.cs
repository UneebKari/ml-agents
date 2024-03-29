using UnityEngine;
using System.Collections;

public class DestroyObstacleType2: MonoBehaviour  {
		public GameObject ObstacleType2;
		public GameObject EscapeType2;
		public AudioClip coin;
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Boundary" || other.tag == "bonus") {
						return;
	}

		else if (other.tag=="ball" ) {

			Destroy(ObstacleType2);
			Destroy(EscapeType2);
			AudioSource.PlayClipAtPoint(coin,transform.position);
			ScoreGui.Myscore+=20;
			} 

		else {

			ScoreGui.Myscore=0;
			Application.LoadLevel ("_Scene");
	}
	}



}

