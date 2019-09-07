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

                    while(hit.transform.gameObject.GetComponent<FirstFoundationScript>().Foundation0Array[FoundationCardCounter] != null)
                    {
                        
                        hit.transform.gameObject.GetComponent<FirstFoundationScript>().Foundation0Array[FoundationCardCounter] = hit.transform.gameObject.GetComponent<FirstFoundationScript>().Foundation0Array[FoundationCardCounter + 1];
                        Debug.Log("FoundationCardCounterInc " + FoundationCardCounter);
                        FoundationCardCounter += 1;
                    }


                    MouseCard.gameObject.GetComponent<MouseCardScript>().HasAttachedCard = true;
                }
                
                else if (hit.collider.CompareTag("Foundation") && MouseCard.gameObject.GetComponent<MouseCardScript>().HasAttachedCard == true)
                {
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
        }
    }
}
