using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


using UnityEngine.UI;

public class EscapeMgr : MonoBehaviour
{
	public Text ResultInfoText;

	private const string HighScoreName = "HighScore";
	private const string TempScoreName = "TempScore";
	private bool ResultTextSet = false;

	private int TempScore
	{
		get { return PlayerPrefs.GetInt(TempScoreName); }
		set { PlayerPrefs.SetInt(TempScoreName, value); }
	}

	private int HighScore
	{
		get { return PlayerPrefs.GetInt(HighScoreName); }
		set { PlayerPrefs.SetInt(HighScoreName, value); }
	}

    // Update is called once per frame
    void Update()
    {
		if (ResultTextSet == false) 
		{
			//PlayerPrefs.DeleteAll ();

			TempScore = 335;
			//HighScore = 156;

			if (TempScore > HighScore) 
			{
				ResultInfoText.text = string.Format ("YOU BEAT HIGHSCORE {0} WITH RESULT {1}!!!", HighScore, TempScore);
				HighScore = TempScore;
			} 
			else 
				ResultInfoText.text = string.Format ("YOU WERE TOO SLOW! YOUR RESULT: {0}, HIGHSCORE {1}.", TempScore, HighScore);

			ResultTextSet = true;
		}


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
