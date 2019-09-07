using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foundation0Script : MonoBehaviour
{
    public GameObject PrevFoundation;
    public GameObject Deck;
    public GameObject[] Foundation0Array;
    int FoundationCardCounter = 0;
    int CardCounter = 0;
    public bool Foundation0Setup = true;
    int RenderCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(PrevFoundation.GetComponent<FirstFoundationScript>().Foundation0Setup);
        Debug.Log(Foundation0Setup);

        if (Deck.GetComponent<Deck>().DeckIsShuffled == true && Foundation0Setup == true && PrevFoundation.GetComponent<FirstFoundationScript>().Foundation0Setup == false)
        {
            Debug.Log("trigger#1");
            if (FoundationCardCounter < 3)
            {
                Foundation0Array[FoundationCardCounter] = Deck.GetComponent<Deck>().ShuffledDeck[0];
                Deck.GetComponent<Deck>().ShuffledDeck[0] = null;
                FoundationCardCounter += 1;


            }

            if (FoundationCardCounter == 3)
            {
                Foundation0Setup = false;
            }



        }


        if (Foundation0Setup == false)
        {
            FoundationCardCounter = 0;

            while (Foundation0Array[FoundationCardCounter + 1] != null)
            {
                FoundationCardCounter += 1;
            }

            Debug.Log(FoundationCardCounter);


            while (RenderCounter <= FoundationCardCounter)
            {
                Foundation0Array[RenderCounter].transform.parent = gameObject.transform;
                Foundation0Array[RenderCounter].transform.localPosition = new Vector3(RenderCounter * 0.5f, 0, 0);
                Foundation0Array[RenderCounter].GetComponent<SpriteRenderer>().sortingOrder = 52 - RenderCounter;
                RenderCounter += 1;
            }
        }
    }
}