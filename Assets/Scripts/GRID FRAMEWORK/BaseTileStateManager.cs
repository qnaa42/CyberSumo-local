using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
namespace GPC
{
    public class BaseTileStateManager : MonoBehaviour
    {
        public TileState.State currentTileState;
        public TileState.State targetTileState;
        public TileState.State lastTileState;

        public virtual void SetTargetState(TileState.State aState)
        {
            targetTileState = aState;

            if (targetTileState != currentTileState)
                UpdateTargetState();
        }

        public TileState.State GetCurrentState()
        {
            return currentTileState;
        }

        [Header("Tile Events")]

        public UnityEvent OnActive;
        public UnityEvent OnCasting;

        public virtual void Active() { OnActive.Invoke(); }
        public virtual void Casting() { OnCasting.Invoke(); }

        public virtual void UpdateTargetState()
        {
            if (targetTileState == currentTileState)
                return;

            switch(targetTileState)
            {
                case TileState.State.active:
                    break;

                case TileState.State.casting:
                    break;
            }
            currentTileState = targetTileState;
        }
        public virtual void UpdateCurrentState()
        {
            switch (currentTileState)
            {
                case TileState.State.active:
                    break;

                case TileState.State.casting:
                    break;
            }
        }
    }

}


