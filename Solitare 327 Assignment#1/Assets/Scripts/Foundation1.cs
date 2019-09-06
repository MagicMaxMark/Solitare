using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foundation1 : MonoBehaviour
{
    public GameObject Deck;
    public GameObject[] Foundation1Array;
    int i = 0;
    int foo = 0;
    bool Foundation1Setup = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Deck.GetComponent<Deck>().DeckIsShuffled == true && Foundation1Setup == true)
        {
            while(i < 3)
            {
                Foundation1Array[i] = Deck.GetComponent<Deck>().ShuffledDeck[0];
                foo = 0;
                while(foo <= 54 && Deck.GetComponent<Deck>().ShuffledDeck[foo] != null)
                {
                    Deck.GetComponent<Deck>().ShuffledDeck[foo] = Deck.GetComponent<Deck>().ShuffledDeck[foo + 1] ;
                    foo += 1;
                }
                Debug.Log(i);
            
                i += 1;
            }

            Foundation1Setup = false;

        }
    }
}
