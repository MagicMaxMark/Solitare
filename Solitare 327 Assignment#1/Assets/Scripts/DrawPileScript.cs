using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawPileScript : MonoBehaviour
{
    public bool ClickedOn = false;
    public int[] Cards;
    public GameObject DiscardPile;
    public GameObject Card;
    public int RandomNumber;
    public string CardType = "";
    public Sprite[] CardSprite;
    // Start is called before the first frame update
    void Start()
    {
        Cards = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52 };
        
        RandomNumber = Random.Range(0, Cards.Length);
        Debug.Log(RandomNumber);
        CardType = "Assets/Cards/playingCard_" + Cards[RandomNumber];
        Debug.Log(CardType);
        CardSprite = Resources.LoadAll<Sprite>(CardType);
        Card.GetComponent<SpriteRenderer>().sprite = CardSprite[0];
        
        Instantiate(Card, new Vector3(DiscardPile.transform.position.x, DiscardPile.transform.position.y, DiscardPile.transform.position.z), Quaternion.identity);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (ClickedOn == true)
        {

            /*
            RandomNumber = Random.Range(0, Cards.Length);
            CardType = "playingCard_" + Cards[RandomNumber];
            CardSprite = Resources.LoadAll<Sprite>(CardType);
            Card.GetComponent<SpriteRenderer>().sprite = CardSprite[0];
            */
            Instantiate(Card,new Vector3(DiscardPile.transform.position.x, DiscardPile.transform.position.y, DiscardPile.transform.position.z), Quaternion.identity);
            ClickedOn = false;
            
            
            
        }
        
    }
}