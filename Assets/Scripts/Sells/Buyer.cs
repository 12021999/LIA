using UnityEngine;
using System.Collections;

public class Buyer : MonoBehaviour {

	void Start () 
    {
        InitialPositionX = transform.position.x;
        InitialPositionY = transform.position.y;
	}
    float InitialPositionX;
    float InitialPositionY;
    int NumberCharacter = 1;
    bool Right = false;
    bool Wrong = false;
    bool Middle = false;

    void ChangeCharacters()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load("Characters" + NumberCharacter.ToString(), typeof(Sprite)) as Sprite;
    }

    void Movimentation()
    {
        if(transform.position.x > 0)
        {
            Middle = false;
            Right = false;
            Wrong = false;
        }
        if (transform.position.x <= 0)
        {
            Middle = true;
            Reborn();
        }
        if (!Middle)
        {
            transform.position += new Vector3(-0.1f, 0, 0);
        }
    }

    void Reborn()
    {
        NumberCharacter = Random.Range(1, 7);
        transform.position = new Vector3(InitialPositionX,InitialPositionY,0);
    }

	void Update () 
    {
        Movimentation();
        ChangeCharacters();
	}
}
