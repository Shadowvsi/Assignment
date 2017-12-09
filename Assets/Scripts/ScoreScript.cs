using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {
	public enum Score
	{
		p1Score, p2Score

	}
	public Text p1Scoretxt, p2Scoretxt;
	private int P1Score, P2Score;


	public void Increment(Score whichScore){
		if (whichScore == Score.p2Score)
			p2Scoretxt.text = (++P2Score).ToString ();
		else
			p1Scoretxt.text = (++P1Score).ToString ();
		
	}
}
