using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GPC;

namespace GPC
{
    public class Tile : MonoBehaviour
    {
        public List<TileClass> thisTile = new List<TileClass>();
        public int thisId;

        public int horizontal;
        public int vertical;
        public bool isPopulatedByPlayer;
        public bool isPopulatedByAi;
        public int phasing;

        public int numberOfTilesInPlay;
        // Start is called before the first frame update
        void Start()
        {
            thisTile[0] = TileDatabase.TileList[thisId];
        }

        // Update is called once per frame
        void Update()
        {
            numberOfTilesInPlay = Sumo_GridManager.numberOfTiles;
            horizontal = thisTile[0].horizontal;
            vertical = thisTile[0].vertical;
            isPopulatedByPlayer = thisTile[0].isPopulatedByPlayer;
            isPopulatedByAi = thisTile[0].isPopulatedByAi;
            phasing = thisTile[0].phasing;


            if (this.tag == "Clone")
            {
                thisTile[0] = Sumo_GridManager.staticTileDeck[numberOfTilesInPlay - 1];
                numberOfTilesInPlay -= 1;
                Sumo_GridManager.numberOfTiles -= 1;
                this.tag = "Untagged";
            }
        }
    }
}
