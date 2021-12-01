using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GPC;

public class TileManager : BaseTileStateManager
{
    private Tile thisTile;
    // Start is called before the first frame update
    void Start()
    {
        thisTile = this.GetComponent<Tile>();
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
                thisTile.phasingPlacedByAiResolveState = thisTile.phasingPlacedByAi;
                thisTile.phasingPlacedByPlayerResolveState = thisTile.phasingPlacedByPlayer;
                thisTile.phasingPowerResolveState = thisTile.phasingPower;
                thisTile.phasingResolveState = thisTile.phasing;
                break;
        }
    }
}
