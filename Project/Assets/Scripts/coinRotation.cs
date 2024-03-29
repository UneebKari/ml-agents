using UnityEngine;
using System.Collections;

public class coinRotation : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		Quaternion target = Quaternion.Euler(0, 90,0 );
		transform.rotation = Quaternion.Slerp(transform.rotation, target,Time.deltaTime*0);

		transform.Rotate (new Vector3 (90,90,90)*Time.deltaTime);
	}
}
