using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sumo_CardManager : MonoBehaviour
{

//Singleton

    public static Sumo_CardManager CardManager { get; private set; }

   public Sumo_CardManager()
   {
       CardManager = this;
   }

    public List<CardClass> deck = new List<CardClass>();
    public List<CardClass> shufflepile = new List<CardClass>();
    public static List<CardClass> staticDeck = new List<CardClass>();

    public int x;
    public static int deckSize;   

    public GameObject cardInDeck1;
    public GameObject cardInDeck2;
    public GameObject cardInDeck3;
    public GameObject cardInDeck4;

    public GameObject Card;
    public GameObject Deck;

    public GameObject[] Clones;

    public GameObject Hand;



    // Start is called before the first frame update
    void Start()
    {
        deckSize = 40;

        x = 0;
        for (int i = 0; i < deckSize; i++)
        {
            x = Random.Range(1, 6);
            deck[i] = CardDataBase.cardList[x];

        }
        


    }
    public void Shuffle()
    {
        for(int i = 0; i<deckSize; i++)
        {
            shufflepile[0] = deck[i];
            int randomIndex = Random.Range(i, deckSize);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = shufflepile[0];
        }

    }
    void Update()
    {
        staticDeck = deck;
        if(deckSize<30)
        { cardInDeck1.SetActive(false); }
        if(deckSize<20)
        { cardInDeck2.SetActive(false); }
        if(deckSize<10)
        { cardInDeck3.SetActive(false); }
        if(deckSize == 0)
        { cardInDeck4.SetActive(false); }

        

        


        
    }


}
