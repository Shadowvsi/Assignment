using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {


	public void LoadLevel(string name)
	{
		print("Level Load requested for " + name);
		SceneManager.LoadScene (name);
	}
	public void exitGame(){
		Application.Quit();
	
	}

}
