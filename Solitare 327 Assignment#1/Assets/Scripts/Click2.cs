using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click2 : MonoBehaviour
{
    Ray ray;
    RaycastHit2D hit;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("clicked");
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Input.GetMouseButtonDown(0))
            {
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

                hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

                //checks if you clicked on the deck and if you did activates deckclickedoncode
                if (hit.transform.tag == "Deck")
                {
                    Debug.Log("triggered Drawscript");
                    hit.transform.GetComponent<DrawPileScript>().ClickedOn = true;
                }
            }
        }
    }
}
