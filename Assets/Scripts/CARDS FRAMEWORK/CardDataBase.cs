using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDataBase : MonoBehaviour
{
    public static List<CardClass> cardList = new List<CardClass>();

    void Awake()
    {
        cardList.Add(new CardClass(0, "None", 0, 3, "None", Resources.Load<Sprite>("0"), "None"));
        cardList.Add(new CardClass(1, "Land", 0, 0, "Add Two Temporary Move", Resources.Load<Sprite>("1"), "Green"));
        cardList.Add(new CardClass(2, "Land2", 0, 0, "Add One Empty Mana Cell, or Add One Temporary Move", Resources.Load<Sprite>("2"), "Green"));
        cardList.Add(new CardClass(3, "Land3", 0, 0, "Add One Empty Mana cell", Resources.Load<Sprite>("3"), "Green"));
        cardList.Add(new CardClass(4, "Land4", 0, 0, "Add One Empty Move Cell", Resources.Load<Sprite>("4"), "Green"));
        cardList.Add(new CardClass(5, "Mega Artefact", 4, 0, "Test Description", Resources.Load<Sprite>("5"), "Grey"));
        cardList.Add(new CardClass(6, "Super Duper Artefact", 6, 0, "Test Description", Resources.Load<Sprite>("6"), "Grey"));
        cardList.Add(new CardClass(7, "Attack", 2, 1, "Test Description", Resources.Load<Sprite>("7"), "Red"));
        cardList.Add(new CardClass(8, "Better Attack", 3, 2, "Test Description", Resources.Load<Sprite>("8"), "Red"));
        cardList.Add(new CardClass(9, "Best Attack", 6, 4, "Test Description", Resources.Load<Sprite>("9"), "Red"));
    }
}
