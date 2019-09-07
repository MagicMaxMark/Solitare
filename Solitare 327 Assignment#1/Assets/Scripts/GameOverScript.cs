using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    int FoundationCardCounter = 0;
    int Val;
    GameObject[] Foundations;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        Val = 0;

        FoundationCardCounter = 0;
        while (Foundation.gameObject.GetComponent<FirstFoundationScript>().Foundation0Array[FoundationCardCounter] != null && FoundationCardCounter < 52)
        {
            FoundationCardCounter += 1;
        }

        while (FoundationCardCounter > 0)
        {
            FoundationCardCounter -= 1;
            if (Foundation.gameObject.GetComponent<FirstFoundationScript>().Foundation0Array[FoundationCardCounter].gameObject.GetComponent<CardTypes>().Hidden == false)
            {
                Val += Foundation.gameObject.GetComponent<FirstFoundationScript>().Foundation0Array[FoundationCardCounter].gameObject.GetComponent<CardTypes>().CardNum;
            }
        }

        gameObject.GetComponent<TextMesh>().text = "" + Val;
        */
    }
}
