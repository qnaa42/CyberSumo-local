using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
using UnityEngine.UI;

public class GridClass
{
    private int Horizontal;
    private int Vertical;
    private float cellSize;
    private int[,] gridArray;
    private GameObject[,] DebugImage;


    private GameObject Grid;


    public GridClass(int Horizontal, int Vertical, float cellSize)
    {
        Grid = GameObject.Find("Grid");
        this.Horizontal = Horizontal;
        this.Vertical = Vertical;
        this.cellSize = cellSize;

        gridArray = new int[Horizontal, Vertical];
        DebugImage = new GameObject[Horizontal, Vertical];

        for (int x=0; x < gridArray.GetLength(0); x++)
        {
            for (int y = 0; y < gridArray.GetLength(1); y++)
            {

                
                //UtilsClass.CreateWorldText(gridArray[x, y].ToString(), Grid.transform, GetWorldPosition(x, y) + new Vector3(cellSize, cellSize) *0.5f, 50, Color.black, TextAnchor.MiddleCenter);
               // Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x, y + 1), Color.black, 100f);
              //  Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x + 1, y), Color.black, 100f);



                DebugImage[x,y] = UtilsClass.CreateWorldImage(Grid.transform, "Tile" + x + "/" + y, Resources.Load<Sprite>("Tile"), GetWorldPosition(x, y), new Vector2(150,150), Color.white);
                GameObject thisTile = GameObject.Find("Tile" + x + "/" + y);
                thisTile.gameObject.transform.SetParent(Grid.transform, true);
            }
        }
    }

    private Vector3 GetWorldPosition(int x, int y)
    {
        return new Vector3(x, y) * cellSize;
    }

    public void SetValue(int x, int y, int value)
    {
        if (x >= 0 && y <= 0 && x < Horizontal && y < Vertical)
        {
            gridArray[x, y] = value;
        }
    }

}
