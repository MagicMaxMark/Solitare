using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckScript : MonoBehaviour
{
    public GameObject[] Cards;
    public GameObject[] ShuffledDeck;
    public GameObject Foundation0;
    public GameObject Foundation1;
    public GameObject Foundation2;
    public GameObject Foundation3;
    public GameObject Discard;
    public bool DeckIsShuffled = false;
    public bool isClicked = false;
    int FoundationCardCounter;
    int FoundationCardMax;
    int RandNum;

    int CardCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
       while (CardCounter <= 51)
        {
            RandNum = Random.Range(0, Cards.Length);
         while(Cards[RandNum] == null)
            {
                RandNum = Random.Range(0, Cards.Length);
            }
            ShuffledDeck[CardCounter] = Cards[RandNum];
            Cards[RandNum] = null;
            CardCounter += 1;
        }
        DeckIsShuffled = true;

        FoundationCardCounter = 0;
        FoundationCardMax = 3;

        while (FoundationCardCounter < FoundationCardMax)
        {
            Debug.Log("hello");
            Foundation0.GetComponent<FirstFoundationScript>().Foundation0Array[FoundationCardCounter] = ShuffledDeck[0];

            CardCounter = 0;

            while (CardCounter < 51)
            {
                ShuffledDeck[CardCounter] = ShuffledDeck[CardCounter + 1];
                CardCounter += 1;
            }

            ShuffledDeck[51] = null;

            FoundationCardCounter += 1;

        }


        FoundationCardCounter = 0;
        FoundationCardMax = 4;

        while (FoundationCardCounter < FoundationCardMax)
        {
            Debug.Log("hello");
            Foundation1.GetComponent<FirstFoundationScript>().Foundation0Array[FoundationCardCounter] = ShuffledDeck[0];

            CardCounter = 0;

            while (CardCounter < 51)
            {
                ShuffledDeck[CardCounter] = ShuffledDeck[CardCounter + 1];
                CardCounter += 1;
            }

            ShuffledDeck[51] = null;

            FoundationCardCounter += 1;

        }


        FoundationCardCounter = 0;
        FoundationCardMax = 5;

        while (FoundationCardCounter < FoundationCardMax)
        {
            Debug.Log("hello");
            Foundation2.GetComponent<FirstFoundationScript>().Foundation0Array[FoundationCardCounter] = ShuffledDeck[0];

            CardCounter = 0;

            while (CardCounter < 51)
            {
                ShuffledDeck[CardCounter] = ShuffledDeck[CardCounter + 1];
                CardCounter += 1;
            }

            ShuffledDeck[51] = null;

            FoundationCardCounter += 1;

        }


        FoundationCardCounter = 0;
        FoundationCardMax = 6;

        while (FoundationCardCounter < FoundationCardMax)
        {
            Debug.Log("hello");
            Foundation3.GetComponent<FirstFoundationScript>().Foundation0Array[FoundationCardCounter] = ShuffledDeck[0];

            CardCounter = 0;

            while (CardCounter < 51)
            {
                ShuffledDeck[CardCounter] = ShuffledDeck[CardCounter + 1];
                CardCounter += 1;
            }

            ShuffledDeck[51] = null;

            FoundationCardCounter += 1;

        }


        FoundationCardCounter = 0;
        FoundationCardMax = 1;

        while (FoundationCardCounter < FoundationCardMax)
        {
            Debug.Log("hello");
            Discard.GetComponent<FirstFoundationScript>().Foundation0Array[FoundationCardCounter] = ShuffledDeck[0];

            CardCounter = 0;

            while (CardCounter < 51)
            {
                ShuffledDeck[CardCounter] = ShuffledDeck[CardCounter + 1];
                CardCounter += 1;
            }

            ShuffledDeck[51] = null;

            FoundationCardCounter += 1;

        }

    }


      

    // Update is called once per frame
    void Update()
    {
        if (ShuffledDeck[0] == null)
        {
            CardCounter = 0;

            while (CardCounter < 51)
            {
                ShuffledDeck[CardCounter] = ShuffledDeck[CardCounter + 1];
                CardCounter += 1;
            }
            ShuffledDeck[51] = null;
        }
            


        if (isClicked == true)
        {

        }
    }
}
