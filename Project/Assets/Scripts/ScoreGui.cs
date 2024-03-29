using UnityEngine;
using System.Collections;

public class ScoreGui : MonoBehaviour {
	public static int Myscore=0;
//	public static double HighScore = HighScore;
	void OnGUI()
	{

		GUILayout.Label(" Score: " + Myscore);
//		GUILayout.Label (" HighScore:" + HighScore);
	}  
}
