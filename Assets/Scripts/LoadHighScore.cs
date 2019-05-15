using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadHighScore : MonoBehaviour {

	private const string HighScoreName = "HighScore";
	private const string TempScoreName = "TempScore";

	public GameObject ScoreDisplay;
	public float HightScore;

	void Start () {
		HightScore = PlayerPrefs.GetFloat(HighScoreName);
		ScoreDisplay.GetComponent<Text>().text = string.Format ("({1}) HIGH SCORE: {0}, CURRENT: {2}>>", 
			(HightScore*100).ToString("n0"), 
			SceneManager.GetActiveScene().buildIndex,
			PlayerPrefs.GetFloat(TempScoreName)	);
	}

}
