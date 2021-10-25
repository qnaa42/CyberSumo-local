using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class CardClass
{
    public int id;
    public string cardName;
    public int cost;
    public int power;
    public string cardDescirbtion;

    public Sprite thisImage;

    public string color;

    public CardClass()
    {

    }

    public CardClass(int Id, string CardName, int Cost, int Power, string CardDescription, Sprite ThisImage, string Color)
    {
        id = Id;
        cardName = CardName;
        cost = Cost;
        power = Power;
        cardDescirbtion = CardDescription;
        thisImage = ThisImage;
        color = Color;
    }
}

