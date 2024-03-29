using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public int bonusCount;
	public float bonusWait;
	public float strtWait;
	public float bonusWaveWait;
	private GameObject BonusType;
	public GameObject Type1;
	public GameObject Type2;

	public GameObject ball;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	public Transform ObstacleStartingPoint;
	public GameObject chunk;

	public GameObject chunk2;

	public GameObject chunk3;

	private GameObject chooseChunk;
	public GameObject bonusType;

	void Start (){	

		Vector3 ballpos= new Vector3(0,5.5f,-0.62f);
		Instantiate (ball, ballpos, Quaternion.identity);
		//StartCoroutine (StartBonus());
		//StartCoroutine (StartSpawningObstacles ());

	}
	void Update(){
		GameObject ball = GameObject.FindGameObjectWithTag ("ball");
		if (ball.transform.position.y < -2) {
		Destroy (ball);
		Vector3 ballpos= new Vector3(0,5.5f,-0.62f);
		Instantiate (ball, ballpos, Quaternion.identity);
//			if(ScoreGui.Myscore>=ScoreGui.HighScore){
//				ScoreGui.HighScore=ScoreGui.Myscore;
//			}
//			ScoreGui.Myscore=0;
//		Application.LoadLevel ("_Scene");
				
		}

	

	}

		IEnumerator StartSpawningObstacles (){	
			
			yield return new WaitForSeconds (startWait);
			while (true){
				for (int i = 0; i < hazardCount; i++){
			//	DecideSpawningPoints ();
				choosechunktype();
				Instantiate(chooseChunk,ObstacleStartingPoint.position,Quaternion.identity); 
				//ChooseObstacle.transform.Translate(0,1,0);
//				Instantiate(ChooseObstacleEscapePoint,EscapePoint,Quaternion.identity) ;
				//ChooseObstacleEscapePoint.transform.Rotate (new Vector3 (0,90,0)*Time.deltaTime);
					yield return new WaitForSeconds (spawnWait);
					}

				yield return new WaitForSeconds (waveWait);
			speedofHazards.speed-=0.05f;
			waveWait-=0.8f;
			spawnWait+=0.4f;

			Debug.Log("speed increased time decreased");

//			Application.LoadLevel ("_Menu");
	
			}
		}
//	void DecideSpawningPoints(){
//		switch (Random.Range (0, 2)) {
//		case 0:
//			ObstaclePoint = Point1;
//			EscapePoint = Point2;
//			break;
//		case 1:
//			ObstaclePoint = Point2;
//			EscapePoint = Point1;
//			break;
//			
//		}
//	}
			
	void choosechunktype(){
			switch (Random.Range (0, 3)) {
			case 0:
			chooseChunk=chunk;
				break;
			case 1:
			chooseChunk=chunk2;
				break;
			case 2:
			chooseChunk=chunk3;
				break;
			}
			
			
		}
	 void OnGUI(){
		if (GUI.Button (new Rect (338, 3, 58, 15), "Pause"))
		Time.timeScale = 0.0f;

		if (GUI.Button (new Rect (338, 18, 58,15), "Resume"))
		Time.timeScale = 1.0f;
			

	}

	//	void Update(){
	//	Transform object1 = Instantiate(obsticale,
	//		                                new Vector3(-2.47f, 6.99f, -0.79f), 
	//		                                Quaternion.identity) as Transform;
	//	
	//	Transform object2 = Instantiate(escapePoint, 
	//		                                new Vector3(2.38f, 6.99f, -0.79f), 
	//		            					Quaternion.identity) as Transform;
	//			}
	IEnumerator StartBonus (){	
		
		yield return new WaitForSeconds (strtWait);
		while (true){
			for (int i = 0; i < bonusCount; i++){
				ChooseBounusType();
				Vector3 RandomPos=new Vector3(Random.Range(-1.88f,2.27f),5.75f,-0.55f);
				Instantiate(BonusType,RandomPos,Quaternion.identity);

				
				yield return new WaitForSeconds (bonusWait);
				bonusWait+=1.0f;
			}
			//			bonusWait+=0.5f;
			
			yield return new WaitForSeconds (bonusWaveWait);
			bonusWaveWait+=2.0f;
			//			bonusWaveWait+=1.0f;
		}
	}
	void ChooseBounusType(){
		switch (Random.Range (0, 2)) {
		case 0:
			BonusType=Type1;
			break;
		case 1:
			BonusType=Type2;
			break;	
		}
	}
	
}
