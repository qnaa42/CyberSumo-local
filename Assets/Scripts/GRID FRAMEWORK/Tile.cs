using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using GPC;


namespace GPC
{
    public class Tile : MonoBehaviour
    {
        //        public List<TileClass> thisTile = new List<TileClass>();
        private GameObject thisTile;
        private GameObject PlayerManager;
        private int resolveCounter;

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
            resolveCounter = 1;
            thisTile = GameObject.Find("Tile" + horizontal + "/" + vertical);
            PlayerManager = GameObject.Find("Player Manager");
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
        void Update()
        {
            if (phasing == 3)
            {
                Image thisImage = thisTile.GetComponent<Image>();
                thisImage.color = new Color32(10, 220, 0, 255);

            }
            if (phasing == 2)
            {
                Image thisImage = thisTile.GetComponent<Image>();
                thisImage.color = new Color32(255, 253, 0, 255);
            }
            if (phasing == 1)
            {
                Image thisImage = thisTile.GetComponent<Image>();
                thisImage.color = new Color32(255, 30, 0, 255);
            }
            if (phasing == 0)
            {
                Image thisImage = thisTile.GetComponent<Image>();
                thisImage.color = new Color32(255, 255, 255, 255);
            }
          
            if (Sumo_GameManager.instance.currentGameState == Game.State.playerUpkeep)
            {
                resolveCounter = 1;
            }
            if (Sumo_GameManager.instance.currentGameState == Game.State.playerResolveDMG && resolveCounter > 0)
            {
                    if (phasing == 1)
                    {
                        if (isPopulatedByPlayer)
                        {
                            GameObject playerToken = thisTile.gameObject.transform.GetChild(0).gameObject;
                            BasePlayerStatsController _playerStats = PlayerManager.GetComponent<BasePlayerStatsController>();
                            _playerStats.ReduceHealth(1);
                            phasing--;
                        }
                        else
                        {
                            phasing--;
                        }                        
                    }
                else if (phasing > 1)
                {
                    phasing--;
                }
                resolveCounter--;
            }
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
        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision == true && collision.gameObject.tag == "Player")
            {
                isPopulatedByPlayer = true;
            }
        }
        public void OnTriggerExit2D(Collider2D collision)
        {
                isPopulatedByPlayer = false;
                isPopulatedByAi = false;
        }
    }
}
