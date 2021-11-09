using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GPC;
using CodeMonkey.Utils;

public class DragDropPlayer : MonoBehaviour
{
    public GameObject _playerStats;
    public GameObject _playerToken;
    public GameObject Canvas;
    public GameObject Grid;
    public GameObject thisTile;

    public bool isDragging = false;

    private GameObject startParent;
    private Vector3 startPosition;
    private GameObject grid;
    [SerializeField]
    private bool isOverGrid;
    [SerializeField]
    private GameObject StartTile;
    [SerializeField]
    private GameObject TileToMove;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _playerStats = GameObject.Find("Player Manager");
        BasePlayerStatsController playerStats = _playerStats.gameObject.GetComponent<BasePlayerStatsController>();

        
        Canvas = GameObject.Find("Main Canvas");
        Grid = GameObject.Find("Grid");
        StartTile = GameObject.Find("Tile" + playerStats.GetPosHorizontal() + "/" + playerStats.GetPosVertical());
        Transform playerToken = _playerToken.GetComponent<Transform>();
//        thisTile = playerToken.parent.gameObject;





        if (isDragging)
        {
            thisTile = null;
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            transform.SetParent(Canvas.transform, true);
        }

        if (!isDragging)
        {
            thisTile = playerToken.parent.gameObject;
            Tile _thisTile = thisTile.GetComponent<Tile>();
            BasePlayerStatsController PlayerStats = _playerStats.GetComponent<BasePlayerStatsController>();

            if (PlayerStats.GetPosHorizontal() != _thisTile.horizontal)
            {
                PlayerStats.SetPosHorizontal(_thisTile.horizontal);
            }
            if (PlayerStats.GetPosVertical() != _thisTile.vertical)
            {
                PlayerStats.SetPosVertical(_thisTile.vertical);
            }
        }


        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Tile")
        {
            isOverGrid = true;
            TileToMove = collision.gameObject;
        }
        else if(collision.gameObject.tag != "Tile")
        {
            isOverGrid = false;
            TileToMove = null; 
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isOverGrid = false;
        TileToMove = null;
    }
    public void StartDrag()
    {
        isDragging = true;
        startParent = StartTile.transform.parent.gameObject;
        startPosition = StartTile.transform.position;
    }
    public void EndDrag()
    {
        isDragging = false;
        if (isOverGrid)
        {
//            _playerToken.transform.position = TileToMove.transform.position;
            _playerToken.transform.SetParent(TileToMove.transform, true);
//            _playerToken.transform.parent = TileToMove.transform;
            Tile thisTile = TileToMove.GetComponent<Tile>();
//            BasePlayerStatsController playerStats = _playerStats.gameObject.GetComponent<BasePlayerStatsController>();
//            playerStats.SetPosHorizontal(thisTile.horizontal);
//            playerStats.SetPosVertical(thisTile.vertical);

        }
        else if (!isOverGrid)
        {
            _playerToken.transform.position = startPosition;
            _playerToken.transform.SetParent(startParent.transform, true);
            _playerToken.transform.parent = startParent.transform;
        }
    }
}
