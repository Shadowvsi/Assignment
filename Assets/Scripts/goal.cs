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
			if (other.tag == "p1Score") {
				ScoreScriptInstance.Increment (ScoreScript.Score.netp1);
				WasGoal = true;
				StartCoroutine (ResetScore ());
			}
			else if (other.tag == "p2Score") {
				ScoreScriptInstance.Increment (ScoreScript.Score.netp2);
				WasGoal = true;
				StartCoroutine (ResetScore ());
			}
		}
	}
	private IEnumerator ResetScore()
	{
		yield return new WaitForSecondsRealtime (1);
		WasGoal = false;
		rb.velocity = rb.position = new Vector2 (284, 219);
	}
	

}
