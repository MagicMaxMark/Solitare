using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardTypes : MonoBehaviour
{
    public int CardNum;
    public int Cardsuit;
    public bool Hidden = false;
    public GameObject CardBack;
    bool CardBackSpawned = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Hidden == true && CardBackSpawned == false)
        {
            Instantiate(CardBack, gameObject.transform);
            CardBackSpawned = true;
        }

        if(Hidden == true)
        {
            gameObject.transform.Find("playingCard_53(Clone)").transform.localPosition = new Vector3(0, 0, 0);
            int i = gameObject.GetComponent<SpriteRenderer>().sortingOrder;
            Debug.Log("sorting order " + i);
            gameObject.transform.Find("playingCard_53(Clone)").gameObject.GetComponent<SpriteRenderer>().sortingOrder = i + 1;
        }

        if(Hidden == false && CardBackSpawned == true)
        {
            Debug.Log("hidden == false");
            Destroy(gameObject.transform.Find("playingCard_53(Clone)").gameObject);
        }
        
    }
}
