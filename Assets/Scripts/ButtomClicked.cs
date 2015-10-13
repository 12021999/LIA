using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class ButtomClicked : MonoBehaviour {

    public void Buttomclicked(string ButtomName)
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        if (ButtomName == "PlayAgainProgramming" || ButtomName == "PlayProgramming")
        {
            Application.LoadLevel("Programming");
        }
        if (ButtomName == "PlayAgainSells" || ButtomName == "PlaySells")
        {
            Application.LoadLevel("Sells");
        }
        if (ButtomName == "PlayAgainManufacture" || ButtomName == "PlayManufacture")
        {
            Application.LoadLevel("Manufacture");
        }
        if (ButtomName == "Instructions")
        {
            Application.LoadLevel("Instructions");
        }
        if (ButtomName == "Credits")
        {
            Application.LoadLevel("Credits");
        }
        if (ButtomName == "History")
        {
            Application.LoadLevel("History");
        }
        if (ButtomName == "Games")
        {
            Application.LoadLevel("GameMenu");
        }
        if (ButtomName == "BackToGamesMenu")
        {
            Application.LoadLevel("GameMenu");
        }
        if (ButtomName == "BackToMenu")
        {
            Application.LoadLevel("Menu");
        }
        if (ButtomName == "BackToMainMenu")
        {
            Application.LoadLevel("MainMenu");
        }
    }
}
