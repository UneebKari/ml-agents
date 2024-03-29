using UnityEngine;
using System.Collections;

public class DestroyObstacleType4: MonoBehaviour  {
		public GameObject ObstacleType4;
		public GameObject EscapeType4;
		public AudioClip coin;
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Boundary" || other.tag == "bonus") {
						return;
	}

		else if (other.tag=="ball" ) {

				Destroy(ObstacleType4);
				Destroy(EscapeType4);
			AudioSource.PlayClipAtPoint(coin,transform.position);
			ScoreGui.Myscore+=40;
			} 

		else {

			ScoreGui.Myscore=0;
			Application.LoadLevel ("_Scene");
	}
	}



}

