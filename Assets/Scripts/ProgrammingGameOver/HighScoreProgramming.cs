using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class HighScoreProgramming : MonoBehaviour
{

    public GameObject highScore;
    void Start()
    {
     
    }
	void Update () 
    {
        int scoreNumber = PlayerPrefs.GetInt("Player Score");
        int Highscore = PlayerPrefs.GetInt("Player HighScore");
        if (scoreNumber > Highscore)
        {
            Highscore = scoreNumber;
            PlayerPrefs.SetInt("Player HighScore", Highscore);
        }
        highScore.GetComponent<Text>().text = "HighScore : " + PlayerPrefs.GetInt("Player HighScore").ToString();
        PlayerPrefs.SetInt("Player HighScore", Highscore);
	}
}
