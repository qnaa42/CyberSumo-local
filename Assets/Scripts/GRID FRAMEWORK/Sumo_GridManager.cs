using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sumo_GridManager : MonoBehaviour
{
    //    public static Sumo_GridManager GridManager { get; private set; }
    //    public Sumo_GridManager()
    //    {
    //        GridManager = this;
    //    }

    public List<TileClass> tileDeck = new List<TileClass>();
    public static List<TileClass> staticTileDeck = new List<TileClass>(); 

    public static int numberOfTiles;

    public int x;
    // Start is called before the first frame update
    void Start()
    {
        numberOfTiles = 35;
        for (int i = 0; i < numberOfTiles; i ++)
        {
            tileDeck[i] = TileDatabase.TileList[0];
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
