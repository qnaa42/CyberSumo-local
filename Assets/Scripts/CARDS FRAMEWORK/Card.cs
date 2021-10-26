using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour
{
    public List<CardClass> thisCard = new List<CardClass>();
    public int thisId;

    public int id;
    public string cardName;
    public int cost;
    public int power;
    public string cardDescription;

    public Text nameText;
    public Text costText;
    public Text powerText;
    public Text descriptionText;

    public Sprite thisSprite;
    public Image thatImage;

    public Image frame;

    public int numberOfCardsInDeck;

    // Start is called before the first frame update
    void Start()
    {
        thisCard[0] = CardDataBase.cardList[thisId];
        



    }

    // Update is called once per frame
    void Update()
    {
        numberOfCardsInDeck = Sumo_CardManager.deckSize;
        id = thisCard[0].id;
        cardName = thisCard[0].cardName;
        cost = thisCard[0].cost;
        power = thisCard[0].power;
        cardDescription = thisCard[0].cardDescirbtion;
        thisSprite = thisCard[0].thisImage;

        nameText.text = "" + cardName;
        costText.text = "" + cost;
        powerText.text = "" + power;
        descriptionText.text = "" + cardDescription;
        thatImage.sprite = thisSprite;

        if(thisCard[0].color=="Red")
        {
            frame.GetComponent<Image>().color = new Color32(255,0,0,255);
        }
        if (thisCard[0].color == "Green")
        {
            frame.GetComponent<Image>().color = new Color32(0, 92, 14, 255);
        }
        if (thisCard[0].color == "Grey")
        {
            frame.GetComponent<Image>().color = new Color32(123, 123, 123, 255);
        }

        if(this.tag == "Clone")
        {
            thisCard[0] = Sumo_CardManager.staticDeck[numberOfCardsInDeck-1];
            numberOfCardsInDeck -= 1;
            Sumo_CardManager.deckSize -= 1;
            this.tag = "Untagged";
        }

    }
}
