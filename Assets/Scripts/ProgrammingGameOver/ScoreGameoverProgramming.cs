using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class ScoreGameoverProgramming : MonoBehaviour {

    public GameObject Scoregameover;

    void GetScore()
    {
        int scoregameover = PlayerPrefs.GetInt("Player Score");
        Scoregameover.GetComponent<Text>().text = "Score : " + scoregameover.ToString();
    }

	void Update () 
    {
        GetScore();
	}
}
