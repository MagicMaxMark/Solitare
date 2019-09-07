using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickScript : MonoBehaviour
{
    public GameObject MouseCard;
    public GameObject[] FoundationArray;
    int FoundationCardCounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    if (Input.GetMouseButtonUp(0)) 
        {
            Debug.Log(":)");
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10)), Vector2.zero);

            if(hit.collider != null)
            {

                if (hit.collider.CompareTag("Foundation") && MouseCard.gameObject.GetComponent<MouseCardScript>().HasAttachedCard == false)
                {
                    MouseCard.gameObject.GetComponent<MouseCardScript>().AttachedCard = hit.transform.gameObject.GetComponent<FirstFoundationScript>().Foundation0Array[0];
                    Debug.Log("foundation0 " + hit.transform.gameObject.GetComponent<FirstFoundationScript>().Foundation0Array[0]);
                    FoundationCardCounter = 0;

                    while (hit.transform.gameObject.GetComponent<FirstFoundationScript>().Foundation0Array[FoundationCardCounter] != null)
                    {

                        hit.transform.gameObject.GetComponent<FirstFoundationScript>().Foundation0Array[FoundationCardCounter] = hit.transform.gameObject.GetComponent<FirstFoundationScript>().Foundation0Array[FoundationCardCounter + 1];
                        Debug.Log("FoundationCardCounterInc " + FoundationCardCounter);
                        FoundationCardCounter += 1;
                    }

                    if(hit.transform.gameObject.GetComponent<FirstFoundationScript>().Foundation0Array[0].gameObject.GetComponent<CardTypes>().Hidden == true)
                    {
                        hit.transform.gameObject.GetComponent<FirstFoundationScript>().Foundation0Array[0].gameObject.GetComponent<CardTypes>().Hidden = false;
                    }


                    MouseCard.gameObject.GetComponent<MouseCardScript>().HasAttachedCard = true;
                }

                else if (hit.collider.CompareTag("Foundation") && MouseCard.gameObject.GetComponent<MouseCardScript>().HasAttachedCard == true)
                {
                    if (hit.transform.gameObject.name == "Discard Pile" || MouseCard.gameObject.GetComponent<MouseCardScript>().AttachedCard.gameObject.GetComponent<CardTypes>().CardNum == hit.transform.gameObject.GetComponent<FirstFoundationScript>().Foundation0Array[0].gameObject.GetComponent<CardTypes>().CardNum || MouseCard.gameObject.GetComponent<MouseCardScript>().AttachedCard.gameObject.GetComponent<CardTypes>().Cardsuit == hit.transform.gameObject.GetComponent<FirstFoundationScript>().Foundation0Array[0].gameObject.GetComponent<CardTypes>().Cardsuit) {
                        FoundationCardCounter = 0;

                        while (hit.transform.gameObject.GetComponent<FirstFoundationScript>().Foundation0Array[FoundationCardCounter] != null)
                        {
                            FoundationCardCounter += 1;
                            Debug.Log("FoundationCardCounter " + FoundationCardCounter);
                        }

                        while (FoundationCardCounter + 1 != 0)
                        {
                            hit.transform.gameObject.GetComponent<FirstFoundationScript>().Foundation0Array[FoundationCardCounter + 1] = hit.transform.gameObject.GetComponent<FirstFoundationScript>().Foundation0Array[FoundationCardCounter];
                            FoundationCardCounter -= 1;
                            Debug.Log("FoundationCardCounter2 " + FoundationCardCounter);
                        }

                        hit.transform.gameObject.GetComponent<FirstFoundationScript>().Foundation0Array[0] = MouseCard.gameObject.GetComponent<MouseCardScript>().AttachedCard;
                        MouseCard.gameObject.GetComponent<MouseCardScript>().AttachedCard = null;
                        MouseCard.gameObject.GetComponent<MouseCardScript>().HasAttachedCard = false;
                    }
                }

                else if (hit.collider.CompareTag("Deck"))
                {

                    FoundationCardCounter = 0;

                    while (hit.transform.GetComponent<DeckScript>().Discard.transform.GetComponent<FirstFoundationScript>().Foundation0Array[FoundationCardCounter] != null)
                    {
                        FoundationCardCounter += 1;
                        Debug.Log("FoundationCardCounter " + FoundationCardCounter);
                    }

                    while (FoundationCardCounter + 1 != 0)
                    {
                        hit.transform.GetComponent<DeckScript>().Discard.transform.GetComponent<FirstFoundationScript>().Foundation0Array[FoundationCardCounter + 1] = hit.transform.GetComponent<DeckScript>().Discard.transform.GetComponent<FirstFoundationScript>().Foundation0Array[FoundationCardCounter];
                        FoundationCardCounter -= 1;
                        Debug.Log("FoundationCardCounter2 " + FoundationCardCounter);
                    }

                    hit.transform.GetComponent<DeckScript>().Discard.transform.GetComponent<FirstFoundationScript>().Foundation0Array[0] = hit.transform.GetComponent<DeckScript>().ShuffledDeck[0];
                    hit.transform.GetComponent<DeckScript>().ShuffledDeck[0] = null;

                }
                
            }
        }
    }
}
