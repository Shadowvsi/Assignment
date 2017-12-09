using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Winner : MonoBehaviour {

	public ScoreScript ScoreScriptInstance;
	public Text lvl1score;
	public Text lvl2score;
	public Text lvl3score;
	public Text winnerText;

	// Use this for initialization
	void Start () {
		ScoreScriptInstance = GameObject.Find ("SceneManager").GetComponent<ScoreScript> ();
		lvl1score.text = ScoreScriptInstance.lvl1Score;
		lvl2score.text = ScoreScriptInstance.lvl2Score;
		lvl3score.text = ScoreScriptInstance.lvl3Score;

		if (ScoreScriptInstance.p1wins > ScoreScriptInstance.p2wins)
			winnerText.text = "Winner Player 1";
		else
			winnerText.text = "Winner Player 2";


		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
