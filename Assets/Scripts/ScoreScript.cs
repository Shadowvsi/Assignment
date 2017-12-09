using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour {
	public enum Score
	{
		p1Score, p2Score

	}

	void Awake(){
		DontDestroyOnLoad (transform.gameObject);
	
	}

	string lvl1Score = "";
	int p1wins = 0, p2wins = 0;
	public Text p1Scoretxt, p2Scoretxt;
	private int P1Score, P2Score;


	public void Increment(Score whichScore){
		if (whichScore == Score.p2Score)
			p2Scoretxt.text = (++P2Score).ToString ();
		else
			p1Scoretxt.text = (++P1Score).ToString ();
		
		if (P1Score == 5 || P2Score == 5 && SceneManager.GetActiveScene ().name == "level1") {
			lvl1Score = P1Score + " - " + P2Score;
			P1Score == 5? p1wins++: p2wins;
			SceneManager.LoadScene ("level2");
		}
		if(P1Score == 10 || P2Score == 5 && SceneManager.GetActiveScene().name == "level2")SceneManager.LoadScene("level3");
		if(P1Score == 15 || P2Score == 5 && SceneManager.GetActiveScene().name == "level3")SceneManager.LoadScene("Win");
	}


}
