using UnityEngine;
using System.Collections;

public class DestroyObstacleType1: MonoBehaviour  {
		public GameObject ObstacleType1;
		public GameObject EscapeType1;
		public AudioClip coin;
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Boundary" || other.tag == "bonus") {
						return;
	}

		else if (other.tag=="ball" ) {

			Destroy(ObstacleType1);
			Destroy(EscapeType1);
			AudioSource.PlayClipAtPoint(coin,transform.position);
			ScoreGui.Myscore+=10;
			} 

		else {

			ScoreGui.Myscore=0;
			Application.LoadLevel ("_Scene");
	}
	}



}

