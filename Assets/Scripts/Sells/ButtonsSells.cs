using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class ButtonsSells : MonoBehaviour {

    public void Buttomclicked(GameObject ButtomName)
    {
        if (ButtomName.GetComponent<Text>().text == "R$" + TextsSells.MoneyToBuyer.ToString())
        {
            TextsSells.ScoreSellNum += 10;
            TextsSells.TimeSellNum += 10;
            TextsSells.Beated = true;
        }
        if (ButtomName.GetComponent<Text>().text != "R$" + TextsSells.MoneyToBuyer.ToString())
        {
            TextsSells.TimeSellNum -= 5;
            TextsSells.Missed = true;
        }
    }
}
