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

                while(foo < 51 && Deck.GetComponent<Deck>().ShuffledDeck[foo] != null)
                {
                    Deck.GetComponent<Deck>().ShuffledDeck[foo] = Deck.GetComponent<Deck>().ShuffledDeck[foo + 1];
                    
                    foo += 1;
                }

                if (foo == 51)
                {
                    Deck.GetComponent<Deck>().ShuffledDeck[foo] = null;
                    foo = 0;
                }


                i += 1;
            }

            Foundation1Setup = false;
            Deck.GetComponent<Deck>().ShuffledDeck[foo] = null;

          

        }

        if (Foundation1Setup == false)
        {
            Foundation1Array[0].transform.parent = gameObject.transform;
            Foundation1Array[0].transform.localPosition = new Vector3(0, 0, 0);
            Foundation1Array[0].GetComponent<SpriteRenderer>().sortingOrder = 52 - 0;

            Foundation1Array[1].transform.parent = gameObject.transform;
            Foundation1Array[1].transform.localPosition = new Vector3(0.5f, 0, 0);
            Foundation1Array[1].GetComponent<SpriteRenderer>().sortingOrder = 52 - 1;

            Foundation1Array[2].transform.parent = gameObject.transform;
            Foundation1Array[2].transform.localPosition = new Vector3(1, 0, 0);
            Foundation1Array[2].GetComponent<SpriteRenderer>().sortingOrder = 52 - 2;
        }
    }
}
