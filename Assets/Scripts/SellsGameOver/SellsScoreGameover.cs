using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class SellsScoreGameover : MonoBehaviour {

    public GameObject Scoregameover;
    
	void Update () 
    {
        int scoregameover = PlayerPrefs.GetInt("Player Score Sells");
        Scoregameover.GetComponent<Text>().text = "Score : " + scoregameover.ToString();
	}
}
