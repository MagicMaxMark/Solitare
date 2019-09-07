using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public GameObject[] Cards;
    public GameObject[] ShuffledDeck;
    public bool DeckIsShuffled = false;
    public bool isClicked = false;
    int foo;

    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
       while (i <= 51)
        {
            foo = Random.Range(0, Cards.Length);
            while(Cards[foo] == null)
            {
                foo = Random.Range(0, Cards.Length);
            }
            ShuffledDeck[i] = Cards[foo];
            Cards[foo] = null;
            i += 1;
        }
        DeckIsShuffled = true;
    }

    // Update is called once per frame
    void Update()
    {
       if (isClicked == true)
        {

        }
    }
}
