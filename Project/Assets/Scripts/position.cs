using UnityEngine;
using System.Collections;

public class position : MonoBehaviour {

//	private RaycastHit hit;
	public float smooth = 2.0F;
	public float tiltAngle = 30.0F;
	public float xMin;
	public float xMax;
	public float yMin;
	public float yMax;


	void FixedUpdate() {
			if (Application.isEditor) {
			float horizontal = Input.GetAxis ("Mouse X")/*("Mouse X")*/* -tiltAngle;
			float vertical = Input.GetAxis ("Mouse Y")/*("Mouse Y")*/* tiltAngle;

			Quaternion target = Quaternion.Euler (vertical, 0, horizontal);
			transform.rotation = Quaternion.Slerp (transform.rotation, target, Time.deltaTime * smooth);
			Vector3 movement = new Vector3 (horizontal, vertical, 0.0f);
			Vector3 temp = transform.position;
			temp += (movement/150);
			temp = new Vector3 (Mathf.Clamp(temp.x,xMin,xMax),	Mathf.Clamp( temp.y,yMin,yMax), 0.0f);
			transform.position=temp;
//transform.rotation = Quaternion.Euler (0,0,0) ;
//movement.x* tilt
//Vector3 myTransform= racket.transform.forward;
//if (Physics.Raycast(transform.position,myTransform,out hit,10)){
//if(hit.collider.gameObject.CompareTag("ball"))
//{
//Debug.DrawRay(transform.position,racket.transform.forward,Color.red);
//print("There's the ");;
//}
//	
//}
				} 
		else
		{
			transform.Translate(Input.acceleration.x, 0, -Input.acceleration.z);

		}

	}
	
	    //OnGUI is called multiple times per frame. Use this for GUI stuff only!


}
