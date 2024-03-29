using UnityEngine;
using System.Collections;

public class DestroyObstacleType3: MonoBehaviour  {
		public GameObject ObstacleType3;
		public GameObject EscapeType3;
		public AudioClip coin;
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Boundary" || other.tag == "bonus") {
						return;
	}

		else if (other.tag=="ball" ) {

				Destroy(ObstacleType3);
				Destroy(EscapeType3);
			AudioSource.PlayClipAtPoint(coin,transform.position);
			ScoreGui.Myscore+=30;
			} 

		else {

			ScoreGui.Myscore=0;
			Application.LoadLevel ("_Scene");
	}
	}



}

