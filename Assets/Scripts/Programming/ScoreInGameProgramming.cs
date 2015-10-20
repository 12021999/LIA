using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class ScoreInGameProgramming : MonoBehaviour {
	
	public GameObject Score;
    public GameObject Time;
    public static int time = 100;
	public static int score = 0;
    public static int Scoregame = 0;

    void Start()
    {
        score = 0;
        time = 100;
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(1);
        time -= 1;
        StartCoroutine(Timer());
    }

	void Update () 
	{
        print(time);
        Screen.orientation = ScreenOrientation.PortraitUpsideDown;
        Scoregame = score;
		Score.GetComponent<Text>().text = "Score : " + Scoregame.ToString();
        Time.GetComponent<Text>().text = "Tempo : " + time.ToString();
        if (time <= 0)
        {
            PlayerPrefs.SetInt("Player Score", Scoregame);
            Application.LoadLevel("ProgrammingGameOver");
        }
	}
}
