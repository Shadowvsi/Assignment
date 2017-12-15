using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour {
	private Rigidbody2D rb;
	float speed = 200f;
	// Use this for initialization
	void Start () {
		

		rb = GetComponent<Rigidbody2D> ();
		StartCoroutine (ResetBall ());
		
	}

	public IEnumerator ResetBall()
	{
		yield return new WaitForSecondsRealtime (1);

		if (SceneManager.GetActiveScene ().name == "level1")
			speed = 450f;
		if (SceneManager.GetActiveScene ().name == "level2")
			speed = 550f;
		if (SceneManager.GetActiveScene ().name == "level3")
			speed = 600f;

		//this.transform.Rotate(new Vector3(0, 0, Random.Range(0, 360)));

		float speedy = Random.Range (-speed, speed);
		rb.velocity = new Vector2 ((int)Random.Range(0, 2) == 0?speed:-speed, speedy);
		//WasGoal = false;
		this.transform.position = new Vector2 (284, 219);
	}
}
