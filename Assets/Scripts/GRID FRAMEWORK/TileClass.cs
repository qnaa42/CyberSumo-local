using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class TileClass
{
    public int horizontal;
    public int vertical;
    public bool isPopulatedByPlayer;
    public bool isPopulatedByAi;
    public int phasing;

    public TileClass(int Horizontal, int Vertical, bool IsPopulatedByPlayer, bool IsPopulatedByAi, int Phasing)
    {
        horizontal = Horizontal;
        vertical = Vertical;
        isPopulatedByPlayer = IsPopulatedByPlayer;
        isPopulatedByAi = IsPopulatedByAi;
        phasing = Phasing;
    }
}
