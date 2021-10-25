using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Populated : MonoBehaviour
{
    public bool isNotPopulated;
    public GameObject CardArea;
    private GameObject card;


    private void Start()
    {
        isNotPopulated = true;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == true)
        {
            card = CardArea.transform.GetChild(0).gameObject;
            if (card.activeInHierarchy == true)
            {
                isNotPopulated = false;
                
            }
            
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        
            isNotPopulated = true;
        
    }



}
