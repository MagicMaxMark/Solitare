using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    int FoundationCardCounter = 0;
    int Val;
    int CurrentFoundation;
    public GameObject[] Foundations;
    public GameObject Discard;
    public GameObject EndText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Val = 0;

        CurrentFoundation = 0;

        while(CurrentFoundation <= 3)
        {
            FoundationCardCounter = 0;

            while (Foundations[CurrentFoundation].gameObject.GetComponent<FirstFoundationScript>().Foundation0Array[FoundationCardCounter] != null && FoundationCardCounter < 52)
            {
                FoundationCardCounter += 1;
            }

            while (FoundationCardCounter > 0)
            {
                FoundationCardCounter -= 1;
                if (CurrentFoundation == 0 || CurrentFoundation == 2)
                {
                    Val += Foundations[CurrentFoundation].gameObject.GetComponent<FirstFoundationScript>().Foundation0Array[FoundationCardCounter].gameObject.GetComponent<CardTypes>().CardNum;
                }
                if (CurrentFoundation == 1 || CurrentFoundation == 3)
                {
                    Val -= Foundations[CurrentFoundation].gameObject.GetComponent<FirstFoundationScript>().Foundation0Array[FoundationCardCounter].gameObject.GetComponent<CardTypes>().CardNum;
                }
            }
            Debug.Log("Current Foundation " + CurrentFoundation);
            Debug.Log("Val " + Val);

            CurrentFoundation += 1;
        }

        Val = Mathf.Abs(Val) + System.Int32.Parse(Discard.gameObject.GetComponent<TextMesh>().text) - 1;

        EndText.gameObject.GetComponent<TextMesh>().text += "Score " + Val;

    }
}
