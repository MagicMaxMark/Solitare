using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombineScript : MonoBehaviour
{
    public GameObject txt0;
    public GameObject txt1;
    int i;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (System.Int32.Parse(txt0.gameObject.GetComponent<TextMesh>().text) >= System.Int32.Parse(txt1.gameObject.GetComponent<TextMesh>().text))
        {
            i = System.Int32.Parse(txt0.gameObject.GetComponent<TextMesh>().text) - System.Int32.Parse(txt1.gameObject.GetComponent<TextMesh>().text);
        }

        if (System.Int32.Parse(txt0.gameObject.GetComponent<TextMesh>().text) < System.Int32.Parse(txt1.gameObject.GetComponent<TextMesh>().text))
        {
            i =  System.Int32.Parse(txt1.gameObject.GetComponent<TextMesh>().text) - System.Int32.Parse(txt0.gameObject.GetComponent<TextMesh>().text);
        }

        gameObject.GetComponent<TextMesh>().text = "" + i;
    }
}
