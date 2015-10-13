using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class CompareText : MonoBehaviour {

    public GameObject CodeLine;
	string[] CodeLines;
	bool CanPickANumber = true;
	void Start()
	{
		CodeLines = new string[8];
		CodeLines [0] = "int i = 0;";
		CodeLines [1] = "float nothing = 0;";
		CodeLines [2] = "string all != tree;";
		CodeLines [3] = "int shared = new int[1];";
		CodeLines [4] = "oldlife - var shoot = var newlife;";
		CodeLines [5] = "var;";
		CodeLines [6] = "var = ber /..;";
		CodeLines [7] = "i(1) = getSpectrumData();";

	}

	void TextAppear()
	{
		if (CanPickANumber) 
		{
			CodeLine.GetComponent<Text> ().text = CodeLines [Random.Range (0, 7)];
			CanPickANumber = false;
		}
		//if (Input.GetKeyDown ("r")) 
		//{
		//	CanPickANumber = true;
		//}
		//print (CanPickANumber);
	}

    void CompareTexts()
    {
        if (this.GetComponent<Text>().text == CodeLine.GetComponent<Text>().text)
        {
            ScoreInGameProgramming.score += 10;
            CanPickANumber = true;
            print("consegui");
        }
    }
	void Update () 
    {
		TextAppear ();
        CompareTexts();
	}
}
