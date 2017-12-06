using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {
	public enum Score
	{
		netp1, netp2

	}
	public Text p1Score, p2Score;
	private int p1Scores, p2Scores;


	public void Increment(Score whichScore){
		if (whichScore == Score.netp2)
			p2Score.text = (++p2Scores).ToString ();
		else
			p1Score.text = (++p1Scores).ToString ();
		
	}
}
