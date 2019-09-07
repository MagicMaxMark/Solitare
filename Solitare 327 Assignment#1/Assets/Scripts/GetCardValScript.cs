using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCardValScript : MonoBehaviour
{
    public GameObject Foundation;
    int FoundationCardCounter;
    int Val;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Val = 0;
        FoundationCardCounter = 0;
        while (Foundation.gameObject.GetComponent<FirstFoundationScript>().Foundation0Array[FoundationCardCounter] != null && FoundationCardCounter < 52)
        {
            FoundationCardCounter += 1;
        }

        while (FoundationCardCounter > 0)
        {
            FoundationCardCounter -= 1;
            Val += Foundation.gameObject.GetComponent<FirstFoundationScript>().Foundation0Array[FoundationCardCounter].gameObject.GetComponent<CardTypes>().CardNum;
        }

        gameObject.GetComponent<TextMesh>().text = "" + Val;

    }
}
