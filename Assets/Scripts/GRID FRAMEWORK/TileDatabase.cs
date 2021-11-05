using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileDatabase : MonoBehaviour
{
    public static List<TileClass> TileList = new List<TileClass>();

    private void Awake()
    {
        TileList.Add(new TileClass(1, 1, false, false, 1));
    }


}
