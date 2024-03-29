using UnityEngine;
using System.Collections;

public class gameState : MonoBehaviour
{
//	public Rect button= new Rect(15,15,200,110);
//	public string buttonlabel="LoadGame";
//	public string leveletoload="Level";

	private void OnGUI()
	{
				if (GUI.Button (new Rect (150, 250, 100, 50), "StartGame"))
						Application.LoadLevel ("_Scene");
	}
}