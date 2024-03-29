using UnityEngine;
using System.Collections;

public class speedofHazards : MonoBehaviour {

	public static float speed=-0.4f;
	// Update is called once per frame
	void FixedUpdate () {
		GetComponent<Rigidbody>().velocity = new Vector3 (0, speed, 0);
		if (transform.position.y < -8.66) 
		{
			Destroy(this.gameObject);
		}
	}
}
