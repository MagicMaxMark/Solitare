using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscardCountScript : MonoBehaviour
{
    public GameObject DiscardPile;
    public int Val = 0;
    int FoundationCardCounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FoundationCardCounter = 0;

        while (DiscardPile.gameObject.GetComponent<FirstFoundationScript>().Foundation0Array[FoundationCardCounter] != null)
        {
            FoundationCardCounter += 1;
        }

        Val = FoundationCardCounter;
        gameObject.GetComponent<TextMesh>().text = "" + Val;
    }
}
