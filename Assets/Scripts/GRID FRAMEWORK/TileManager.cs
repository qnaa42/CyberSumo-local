using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GPC;

public class TileManager : BaseTileStateManager
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void UpdateTargetState()
    {
        if (targetTileState == currentTileState)
            return;
        switch (targetTileState)
        {
            case TileState.State.active:
                break;

            case TileState.State.casting:
                break;
        }
    }
}
