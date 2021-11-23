using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GPC;

public class Populated : MonoBehaviour
{
    public bool isNotPopulated;
    public GameObject CardArea;
    private GameObject card;
   public Sumo_UIManager uIManager;
    


    private void Start()
    {
        isNotPopulated = true;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == true)
        {
            card = CardArea.transform.GetChild(0).gameObject;
            GameObject thiscard = card.transform.GetChild(0).gameObject;
            Card thisCardStats = thiscard.GetComponent<Card>();
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
