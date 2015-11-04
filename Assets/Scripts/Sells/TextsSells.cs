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
    int MoneyToBuyer;
    int NumberRandomize;
    public static int TimeSellNum;
	
    void Start () 
    {
        TimeSellNum = 50;
        RandomizePrices();
        StartCoroutine(Timer());
	}

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.5f);
        if (Buyer.Middle)
        {
            print("uau");
            TimeSellNum -= 1;
        }
        StartCoroutine(Timer());
    }

    void TimeSell()
    {
        TimeSells.GetComponent<Text>().text = "Tempo : " + TimeSellNum.ToString();
    }

    void ScoreSell()
    {
 
    }

    void RandomizePrices() 
    { 
        Price = 500 + 3000 / Random.Range(0,14);
        MoneyGaven = Price + (100 + 100 / Random.Range(0, 14));
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

	void Update () 
    {
        if (NumberRandomize == 0)
        {
            RandomizePrices();
        }
        TimeSell();
        TextsPrices();
	}
}
