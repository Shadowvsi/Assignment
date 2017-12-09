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

	public string lvl1Score = "";
	public string lvl2Score = "";
	public string lvl3Score = "";
	public int p1wins = 0, p2wins = 0;


	public Text p1Scoretxt, p2Scoretxt;
	private int P1Score, P2Score;


	public void Increment(Score whichScore){
		p1Scoretxt = GameObject.FindGameObjectWithTag ("p1ScoreText").GetComponent<Text>();
		p2Scoretxt = GameObject.FindGameObjectWithTag ("p2ScoreText").GetComponent<Text>();

		if (whichScore == Score.p2Score)
			p2Scoretxt.text = (++P2Score).ToString ();
		else
			p1Scoretxt.text = (++P1Score).ToString ();
		
		if ((P1Score >= 5 || P2Score >= 5) && SceneManager.GetActiveScene ().name == "level1") {
			lvl1Score = P1Score + " - " + P2Score;
			if (P1Score == 5)
				p1wins++;
			else p2wins++;
			Debug.Log (P1Score + " - " + P2Score);
			P1Score = 0;
			P2Score = 0;
			SceneManager.LoadScene ("level2");
		}
		if ((P1Score >= 10 || P2Score >= 10)  && SceneManager.GetActiveScene ().name == "level2") {
			lvl2Score = P1Score + " - " + P2Score;
			if (P1Score == 10)
				p1wins++;
			else p2wins++;
			Debug.Log (P1Score + " - " + P2Score);
			P1Score = 0;
			P2Score = 0;
			SceneManager.LoadScene ("level3");
		}
		if ((P1Score >= 15 || P2Score >= 15)  && SceneManager.GetActiveScene ().name == "level3") {
			lvl3Score = P1Score + " - " + P2Score;
			if (P1Score == 15)
				p1wins++;
			else p2wins++;
			Debug.Log (P1Score + " - " + P2Score);
			SceneManager.LoadScene ("Win");
		}
	}


}
