using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
namespace GPC
{
    public class Card : MonoBehaviour
    {
        public List<CardClass> thisCard = new List<CardClass>();
        public int thisId;
        public string type;

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
        public Image borderFrame;

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
            if (id >= 1 && id < 5)
            {
                type = "Land";
            }

            nameText.text = "" + cardName;
            costText.text = "" + cost;
            powerText.text = "" + power;
            descriptionText.text = "" + cardDescription;
            thatImage.sprite = thisSprite;


            if (thisCard[0].color == "Red")
            {
                frame.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            }
            if (thisCard[0].color == "Green")
            {
                frame.GetComponent<Image>().color = new Color32(0, 92, 14, 255);
            }
            if (thisCard[0].color == "Grey")
            {
                frame.GetComponent<Image>().color = new Color32(123, 123, 123, 255);
            }

            if (this.tag == "Clone")
            {
                thisCard[0] = Sumo_CardManager.staticDeck[numberOfCardsInDeck - 1];
                numberOfCardsInDeck -= 1;
                Sumo_CardManager.deckSize -= 1;
                this.tag = "Untagged";
            }
            if (Sumo_GameManager.instance.currentGameState == Game.State.playerPlay1 || Sumo_GameManager.instance.currentGameState == Game.State.playerPlay2 || Sumo_GameManager.instance.currentGameState == Game.State.playerTrigger1 || Sumo_GameManager.instance.currentGameState == Game.State.playerTrigger2)
            {
                if (id >= 0 && id <= 4)
                {
                    if (Sumo_GameManager.instance._playerStats.GetManaCardCounterNow() > 0)
                    {
                        borderFrame.color = new Color32(10, 220, 0, 255);
                    }
                    else if (Sumo_GameManager.instance._playerStats.GetManaCardCounterNow() <= 0)
                    {
                        borderFrame.color = new Color32(255, 30, 0, 255);
                    }
                }
                //!!!!! 5 for now, increase when more card with cast emmerges !!!!!!!
                else if (id == 5)
                {
                    if (Sumo_GameManager.instance._playerStats.GetManaNow() >= cost)
                    {
                        borderFrame.color = new Color32(10, 220, 0, 255);
                    }
                    else if (Sumo_GameManager.instance._playerStats.GetManaCardCounterNow() < cost)
                    {
                        borderFrame.color = new Color32(255, 30, 0, 255);
                    }
                    else
                    {
                        borderFrame.color = new Color32(255, 253, 0, 255);
                    }
                }
                else
                {
                    borderFrame.color = new Color32(0, 0, 0, 255);
                }
            }
            else
            {
                borderFrame.color = new Color32(0, 0, 0, 255);
            }
        }
    }
}
