using UnityEngine;
using System.Collections;

public class DestroyBallByContact : MonoBehaviour{

	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Boundary" || other.tag == "bonus") {

						return;
	}
		else if (other.tag == "ball"|| other.tag=="player") {
			ScoreGui.Myscore=0;
			Application.LoadLevel ("_Scene");


	} 

	}

}