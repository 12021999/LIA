using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class CompareText : MonoBehaviour {

    public GameObject CodeLine;
    void CompareTexts()
    {
        if (this.GetComponent<Text>().text == CodeLine.GetComponent<Text>().text)
        {
            print("consegui");
        }
    }
	void Update () 
    {
        CompareTexts();
	}
}
