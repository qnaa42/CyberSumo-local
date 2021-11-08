using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileDatabase : MonoBehaviour
{
    public static List<TileClass> TileList = new List<TileClass>();

    private void Awake()
    {
        TileList.Add(new TileClass(1, 1, false, false, 1));
        TileList.Add(new TileClass(1, 2, false, false, 1));
        TileList.Add(new TileClass(1, 3, false, false, 1));
        TileList.Add(new TileClass(1, 4, false, false, 1));
        TileList.Add(new TileClass(1, 5, false, false, 1));
        TileList.Add(new TileClass(2, 1, false, false, 1));
        TileList.Add(new TileClass(2, 2, false, false, 1));
        TileList.Add(new TileClass(2, 3, false, false, 1));
        TileList.Add(new TileClass(2, 4, false, false, 1));
        TileList.Add(new TileClass(2, 5, false, false, 1));
        TileList.Add(new TileClass(3, 1, false, false, 1));
        TileList.Add(new TileClass(3, 2, false, false, 1));
        TileList.Add(new TileClass(3, 3, false, false, 1));
        TileList.Add(new TileClass(3, 4, false, false, 1));
        TileList.Add(new TileClass(3, 5, false, false, 1));
        TileList.Add(new TileClass(4, 1, false, false, 1));
        TileList.Add(new TileClass(4, 2, false, false, 1));
        TileList.Add(new TileClass(4, 3, false, false, 1));
        TileList.Add(new TileClass(4, 4, false, false, 1));
        TileList.Add(new TileClass(4, 5, false, false, 1));
        TileList.Add(new TileClass(5, 1, false, false, 1));
        TileList.Add(new TileClass(5, 2, false, false, 1));
        TileList.Add(new TileClass(5, 3, false, false, 1));
        TileList.Add(new TileClass(5, 4, false, false, 1));
        TileList.Add(new TileClass(5, 5, false, false, 1));
        TileList.Add(new TileClass(6, 1, false, false, 1));
        TileList.Add(new TileClass(6, 2, false, false, 1));
        TileList.Add(new TileClass(6, 3, false, false, 1));
        TileList.Add(new TileClass(6, 4, false, false, 1));
        TileList.Add(new TileClass(6, 5, false, false, 1));
        TileList.Add(new TileClass(7, 1, false, false, 1));
        TileList.Add(new TileClass(7, 2, false, false, 1));
        TileList.Add(new TileClass(7, 3, false, false, 1));
        TileList.Add(new TileClass(7, 4, false, false, 1));
        TileList.Add(new TileClass(7, 5, false, false, 1));

    }


}
