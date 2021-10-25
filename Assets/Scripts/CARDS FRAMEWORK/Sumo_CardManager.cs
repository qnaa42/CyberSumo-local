using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sumo_CardManager : MonoBehaviour
{

//Singleton

    public static Sumo_CardManager CardManager { get; private set; }

    public List<CardClass> deck = new List<CardClass>();
    public int x;
    public int deckSize;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        deckSize = 40;
        for (int i = 0; i < deckSize; i++)
        {
            x = Random.Range(1, 9);
            deck[i] = CardDataBase.cardList[x];

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
