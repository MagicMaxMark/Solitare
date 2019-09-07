using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstFoundationScript : MonoBehaviour
{
    public GameObject Deck;
    public GameObject[] Foundation0Array;
    int FoundationCardCounter = 0;
    int CardCounter = 0;
    public bool Foundation0Setup = false;
    int RenderCounter = 0;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        
            FoundationCardCounter = 0;

            while (Foundation0Array[FoundationCardCounter] != null)
            {
                FoundationCardCounter += 1;
            }

            Debug.Log(FoundationCardCounter);

        RenderCounter = 0;

            while (RenderCounter <= FoundationCardCounter)
            {
                Foundation0Array[RenderCounter].transform.parent = gameObject.transform;
                Foundation0Array[RenderCounter].transform.localPosition = new Vector3(RenderCounter * 0.5f, 0, 0);
                Foundation0Array[RenderCounter].GetComponent<SpriteRenderer>().sortingOrder = 52 - RenderCounter;
                RenderCounter += 1;
            }
        
    }
}