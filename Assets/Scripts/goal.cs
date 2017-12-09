using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour {

	public ScoreScript ScoreScriptInstance;
	public static bool WasGoal { get; private set;}
	private Rigidbody2D rb;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		WasGoal = false;
		
	}
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (!WasGoal) {
			if (other.tag == "p1Goal") {
				ScoreScriptInstance.Increment (ScoreScript.Score.p1Score);
				WasGoal = true;
				StartCoroutine (ResetBall ());
			}
			else if (other.tag == "p2Goal") {
				ScoreScriptInstance.Increment (ScoreScript.Score.p2Score);
				WasGoal = true;
				StartCoroutine (ResetBall ());
			}
		}
	}
	private IEnumerator ResetBall()
	{
		yield return new WaitForSecondsRealtime (1);
		WasGoal = false;
		rb.velocity = rb.position = new Vector2 (284, 219);
	}
	

}
