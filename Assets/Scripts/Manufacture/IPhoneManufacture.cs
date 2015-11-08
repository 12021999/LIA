using UnityEngine;
using System.Collections;

public class IPhoneManufacture : MonoBehaviour {

    int NumberIPhone;
    bool hitted = false;
    public static string receptor1;
    public static string receptor2;
    public static string receptor3;

    void Start()
    {
        receptor1 = "";
        receptor2 = "";
        receptor3 = "";
    }

    void ManageReceptors()
    {
        if (NumberIPhone == 1)
        { 
        }
        if (NumberIPhone == 2)
        {
        }
        if (NumberIPhone == 3)
        {
        }
        if (NumberIPhone == 4)
        {
        }
        if (NumberIPhone == 5)
        {
        }
        if (NumberIPhone == 6)
        {
        }
        if (NumberIPhone == 7)
        {
        }
    }

    void ChangeCharacters()
    {
        NumberIPhone = Random.Range(1, 7);
        gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load("IPhoneDismounted" + NumberIPhone.ToString(), typeof(Sprite)) as Sprite;
    }

    void ManageHit()
    {
        if (hitted)
        {
            ChangeCharacters();
            hitted = false;
        }
    }

	void Update () 
    {
        ManageHit();
	}
}
