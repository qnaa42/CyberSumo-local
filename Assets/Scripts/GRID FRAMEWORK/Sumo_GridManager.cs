using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GPC;

public class Sumo_GridManager : MonoBehaviour
{
    //    public static Sumo_GridManager GridManager { get; private set; }
    //    public Sumo_GridManager()
    //    {
    //        GridManager = this;
    //    }

    public List<TileClass> tileDeck = new List<TileClass>();
    public static List<TileClass> staticTileDeck = new List<TileClass>();


    private GameObject TileToMove;

    public static int numberOfTiles;

    public GameObject[] Clones;

    public BasePlayerStatsController _playerStats;

    public int x;
    // Start is called before the first frame update
    void Start()
    {
        numberOfTiles = 35;
        for (int i = 0; i < numberOfTiles; i ++)
        {
            tileDeck[i] = TileDatabase.TileList[i];
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveOneTile(string direction, int anAmount, GameObject controller)
    {
//        int horizontal = _playerStats.GetPosHorizontal();
//        int vertical = -_playerStats.GetPosVertical();
        if (direction == "up" && _playerStats.GetMoveNow() > 0)
        {
            TileToMove = GameObject.Find("Tile" + _playerStats.GetPosHorizontal() + "/" + (_playerStats.GetPosVertical()+ anAmount));
            Transform tileToMoveTransform = TileToMove.GetComponent<Transform>();
            controller.transform.position = tileToMoveTransform.transform.position;
            controller.transform.SetParent(tileToMoveTransform, true);
            _playerStats.ReduceMoveNow(1);
        }
        if(direction == "-up" && _playerStats.GetMoveNow() > 0)
        {
            TileToMove = GameObject.Find("Tile" + _playerStats.GetPosHorizontal() + "/" + (_playerStats.GetPosVertical() - anAmount));
            Transform tileToMoveTransform = TileToMove.GetComponent<Transform>();
            controller.transform.position = tileToMoveTransform.transform.position;
            controller.transform.SetParent(tileToMoveTransform, true);
            _playerStats.ReduceMoveNow(1);
        }
        if(direction == "right" && _playerStats.GetMoveNow() > 0)
        {
            TileToMove = GameObject.Find("Tile" + (_playerStats.GetPosHorizontal() + anAmount) + "/" + _playerStats.GetPosVertical());
            Transform tileToMoveTransform = TileToMove.GetComponent<Transform>();
            controller.transform.position = tileToMoveTransform.transform.position;
            controller.transform.SetParent(tileToMoveTransform, true);
            _playerStats.ReduceMoveNow(1);
        }
        if(direction == "-right" && _playerStats.GetMoveNow() > 0)
        {
            TileToMove = GameObject.Find("Tile" + (_playerStats.GetPosHorizontal() - anAmount) + "/" + _playerStats.GetPosVertical());
            Transform tileToMoveTransform = TileToMove.GetComponent<Transform>();
            controller.transform.position = tileToMoveTransform.transform.position;
            controller.transform.SetParent(tileToMoveTransform, true);
            _playerStats.ReduceMoveNow(1);
        }
    }
}
