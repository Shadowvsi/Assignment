using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour {

	public ScoreScript ScoreScriptInstance;
	public static bool WasGoal { get; private set;}
	private Rigidbody2D rb;
	private BallController bc;

	void Start () {
		ScoreScriptInstance = GameObject.Find ("SceneManager").GetComponent<ScoreScript> ();
		rb = GetComponent<Rigidbody2D> ();
		bc = GetComponent<BallController> ();
		WasGoal = false;
		
	}
	private void OnTriggerEnter2D(Collider2D other)
	{
		//if (!WasGoal) {
			if (other.tag == "p1Goal") {
				ScoreScriptInstance.Increment (ScoreScript.Score.p1Score);
				//WasGoal = true;
				StartCoroutine (bc.ResetBall ());
				//WasGoal = false;
			}
			else if (other.tag == "p2Goal") {
				ScoreScriptInstance.Increment (ScoreScript.Score.p2Score);
				//WasGoal = true;
				StartCoroutine (bc.ResetBall ());
				//WasGoal = false;
			}
		//}
	}
	private IEnumerator ResetBall()
	{
		yield return new WaitForSecondsRealtime (1);
		WasGoal = false;
		rb.position = new Vector2 (284, 219);
	}
	

}
