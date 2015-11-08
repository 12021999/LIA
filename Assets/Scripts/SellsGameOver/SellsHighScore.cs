using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class SellsHighScore : MonoBehaviour {

    public GameObject highScore;
   
	void Update () 
    {
        int scoreNumber = PlayerPrefs.GetInt("Player Score Sells");
        int Highscore = PlayerPrefs.GetInt("Player HighScore Sells");
        if (scoreNumber > Highscore)
        {
            Highscore = scoreNumber;
            PlayerPrefs.SetInt("Player HighScore Sells", Highscore);
        }
        highScore.GetComponent<Text>().text = "HighScore : " + PlayerPrefs.GetInt("Player HighScore Sells").ToString();
        PlayerPrefs.SetInt("Player HighScore Sells", Highscore);
	}
}
