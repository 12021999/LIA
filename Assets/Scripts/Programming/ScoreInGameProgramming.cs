using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class ScoreInGameProgramming : MonoBehaviour {
	
	public GameObject Score;
	public static int score = 0;
    public static int Scoregame = 0;

    void Start()
    {
        score = 0;
    }

	void Update () 
	{
        Scoregame = score;
		Score.GetComponent<Text>().text = "Score : " + Scoregame.ToString();
        if (score > 50)
        {
            PlayerPrefs.SetInt("Player Score", Scoregame);
            Application.LoadLevel("");
        }
	}
}
