using UnityEngine;
using System.Collections;

public class Boundary : MonoBehaviour {
	public float xMin,xMax,yMin,yMax;
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position = new Vector3 
			(
				Mathf.Clamp (transform.position.x, xMin, xMax), 
				Mathf.Clamp (transform.position.y, yMin, yMax),
				0.0f
				);

	}
}
