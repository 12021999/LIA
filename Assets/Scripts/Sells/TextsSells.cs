using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;


public class TextsSells : MonoBehaviour {

    public GameObject Prices;
    public GameObject Price1;
    public GameObject Price2;
    public GameObject ScoreSells;
    public GameObject TimeSells;
    static int Price;
    static int MoneyGaven;
    public static int MoneyToBuyer;
    int NumberRandomize;
    float IenumeratorTimerNum;
    public static int TimeSellNum;
    public static int ScoreSellNum;
    public static bool Beated;
    public static bool Missed;
    public static bool OutScreen;
    public static bool LoseSell;
	
    void Start () 
    {
        ScoreSellNum = 0;
        TimeSellNum = 70;
        IenumeratorTimerNum = 0.5f;
        RandomizePrices();
        StartCoroutine(Timer());
        Beated = false;
        Missed = false;
        OutScreen = false;
        LoseSell = false;
	}

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(IenumeratorTimerNum);
        if (Buyer.Middle)
        {
            TimeSellNum -= 1;
        }
        StartCoroutine(Timer());
    }

    void TimeSell()
    {
        TimeSells.GetComponent<Text>().text = "Tempo\n" + TimeSellNum.ToString();
    }

    void ScoreSell()
    {
        ScoreSells.GetComponent<Text>().text = "Score\n" + ScoreSellNum.ToString();
    }

    void RandomizePrices() 
    { 
        Price = 500 + 3000 / Random.Range(1,14);
        MoneyGaven = Price + (100 + 100 / Random.Range(1, 14));
        MoneyToBuyer = MoneyGaven - Price;
        NumberRandomize = Random.Range(0,20);
        if (NumberRandomize <= 10)
        {
            Price1.GetComponent<Text>().text = "R$" + MoneyToBuyer.ToString();
            Price2.GetComponent<Text>().text = "R$" + (MoneyToBuyer + Random.Range(10, 320)).ToString();
        }
        if (NumberRandomize >= 11)
        {
            Price1.GetComponent<Text>().text = "R$" + (MoneyToBuyer + Random.Range(10, 320)).ToString();
            Price2.GetComponent<Text>().text = "R$" + MoneyToBuyer.ToString();
        }
    }

    void TextsPrices()
    {
        Prices.GetComponent<Text>().text = "Preço : R$" + Price + "\n" + "Dinheiro dado : R$" + MoneyGaven + "\n" + "Qual é o troco ?" + MoneyToBuyer;
    }

    void Lose()
    {
        if (TimeSellNum <= 0)
        {
            LoseSell = true;
            PlayerPrefs.SetInt("Player Score Sells", ScoreSellNum);
        }
        if (LoseSell)
        {
            Application.LoadLevel("SellsGameOver");
        }
    }

    void ManageIenumerator()
    {
        if (TimeSellNum < 100)
        {
            IenumeratorTimerNum = 0.5f;
        }
        if (TimeSellNum > 100 && TimeSellNum < 199)
        {
            IenumeratorTimerNum = 0.3f;
        }
        if (TimeSellNum > 200 && TimeSellNum < 299)
        {
            IenumeratorTimerNum = 0.1f;
        }
        if (TimeSellNum > 300 && TimeSellNum < 399)
        {
            IenumeratorTimerNum = 0.05f;
        }
        if (TimeSellNum > 400 && TimeSellNum < 499)
        {
            IenumeratorTimerNum = 0.00001f;
        }
        if (TimeSellNum > 500)
        {
            IenumeratorTimerNum = 0.00000000000001f/0.00000001f;
        }
    }

	void Update () 
    {
        if (NumberRandomize == 0)
        {
            RandomizePrices();
        }
        if (OutScreen)
        {
            RandomizePrices();
            OutScreen = false;
        }
        ManageIenumerator();
        Lose();
        ScoreSell();
        TimeSell();
        TextsPrices();
	}
}
