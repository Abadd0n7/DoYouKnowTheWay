using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonMgr : MonoBehaviour {

	public Text HighScoreText;

	private const string HighScoreName = "HighScore";

	private int HighScore
	{
		get { return PlayerPrefs.GetInt(HighScoreName); }
	}

	public void levelButton(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
    }

    public void exitButton()
    {
        Application.Quit();
    }

	void Update(){
		HighScoreText.text = string.Format ("HIGHSCORE: {0}", HighScore);
	}
}
