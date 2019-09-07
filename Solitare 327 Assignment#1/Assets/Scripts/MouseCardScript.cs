using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCardScript : MonoBehaviour
{
    public GameObject AttachedCard;
    public bool HasAttachedCard = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 worldPoint2d = new Vector2(worldPoint.x, worldPoint.y);

        gameObject.transform.position = worldPoint2d;
        AttachedCard.transform.parent = gameObject.transform;
        AttachedCard.transform.GetComponent<SpriteRenderer>().sortingOrder = 100;
        AttachedCard.transform.localPosition = new Vector2(0, 0);
    }
}
