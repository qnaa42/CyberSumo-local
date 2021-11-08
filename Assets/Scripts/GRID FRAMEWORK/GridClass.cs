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
                DebugImage[x,y] = UtilsClass.CreateWorldImage(Grid.transform, "Tile" + x + "/" + y, Resources.Load<Sprite>("Tile"), GetWorldPosition(x, y), new Vector2(150,150), Color.white, x, y, false, false, 0, out int _Horizontal, out int _Vertical);
                GameObject thisTile = GameObject.Find("Tile" + x + "/" + y);
                thisTile.gameObject.transform.SetParent(Grid.transform, true);
            }
        }
        SetValue(1, 1, 24);
    }

    private Vector3 GetWorldPosition(int x, int y)
    {
        return new Vector3(x, y) * cellSize;
    }

    private void GetXY(Vector3 worldPosition, out int x, out int y)
    {
        x = Mathf.FloorToInt(Input.mousePosition.x / cellSize);
        y = Mathf.FloorToInt(Input.mousePosition.y / cellSize);
    }

    public void SetValue(int x, int y, int value )
    {
        if (x >= 0 && y >= 0 && x < Horizontal && y < Vertical)
        {
            gridArray[x, y] = value;
            //           byte a = System.Convert.ToByte(value);
            //            DebugImage[x, y].GetComponent<Image>().color = new Color32(a, a, a, a );
            DebugImage[x, y].gameObject.transform.GetChild(0).GetComponent<Text>().text = value.ToString();
            Debug.Log("Here");
                
        }
    }
    public void SetValue1(Vector3 worldPosition, int value)
    {
        int x, y;
        GetXY(worldPosition, out x, out y);
        SetValue(x, y, value);
        Debug.Log("Here" + x + "/" + y);

    }

}
