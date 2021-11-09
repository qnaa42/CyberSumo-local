using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using GPC;


namespace GPC
{
    public class Tile : MonoBehaviour
    {
//        public List<TileClass> thisTile = new List<TileClass>();
        public int thisId;

        private int Horizontal;
        private int Vertical;

        public int horizontal;
        public int vertical;
        public bool isPopulatedByPlayer;
        public bool isPopulatedByAi;
        public int phasing;

        public int numberOfTilesInPlay;
        // Start is called before the first frame update
        void Start()
        {
            EventTrigger trigger = gameObject.GetComponent<EventTrigger>();
            EventTrigger.Entry entry = new EventTrigger.Entry();
            entry.eventID = EventTriggerType.PointerClick;
            entry.callback.AddListener((data => { OnPointerClickDelegate((PointerEventData)data); }));
            trigger.triggers.Add(entry);


        }
        public void OnPointerClickDelegate(PointerEventData data)
        {
            Debug.Log(horizontal.ToString());
            Debug.Log(vertical.ToString());
            Sumo_GameManager.instance.ShowPositionOfTile(horizontal, vertical);
            Transform thisTile = GetComponent<Transform>();

        }

//        void Update()
//        {

            //            numberOfTilesInPlay = Sumo_GridManager.numberOfTiles;
            //            horizontal = thisTile[0].horizontal;
            //            vertical = thisTile[0].vertical;
            //            isPopulatedByPlayer = thisTile[0].isPopulatedByPlayer;
            //            isPopulatedByAi = thisTile[0].isPopulatedByAi;
            //            phasing = thisTile[0].phasing;


            //           if (this.tag == "Clone")
            //           {
            //               thisTile[0] = Sumo_GridManager.staticTileDeck[numberOfTilesInPlay - 1];
            //               numberOfTilesInPlay -= 1;
            //               Sumo_GridManager.numberOfTiles -= 1;
            //               this.tag = "Untagged";
            //           }
 //       }
        public void OnColliderStay2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                isPopulatedByPlayer = true;
            }
        }
        public void OnColliderExit2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                isPopulatedByPlayer = false;
            }
        }
    }
}
