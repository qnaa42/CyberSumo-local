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
        private GameObject AiManager;
        public TileManager tileStateMachine;


        private int resolveCounter;

        public int thisId;

        private int Horizontal;
        private int Vertical;

        public int horizontal;
        public int vertical;
        public bool isPopulatedByPlayer;
        public bool isPopulatedByAi;
        public bool phasingPlacedByAi;
        public bool phasingPlacedByPlayer;
        public int phasing;
        public int phasingPower;

        public int numberOfTilesInPlay;

        public bool isPopulatedByPlayerResolveState;
        public bool isPopulatedByAiResolveState;
        public bool phasingPlacedByAiResolveState;
        public bool phasingPlacedByPlayerResolveState;
        public int phasingResolveState;
        public int phasingPowerResolveState;
        // Start is called before the first frame update
        void Start()
        {
            tileStateMachine = this.GetComponent<TileManager>();
            phasingPower = 10;
            resolveCounter = 1;
            thisTile = GameObject.Find("Tile" + horizontal + "/" + vertical);
            PlayerManager = GameObject.Find("Player Manager");
            AiManager = GameObject.Find("AI Manager");
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

            if (Sumo_GameManager.instance.currentGameState == Game.State.playerUpkeep || Sumo_GameManager.instance.currentGameState == Game.State.aiUpkeep)
            {
                resolveCounter = 1;
            }
            if (Sumo_GameManager.instance.currentGameState == Game.State.playerResolveDMG && resolveCounter > 0)
            {
                if (phasing == 1 && phasingPlacedByPlayer)
                {
                    if (isPopulatedByAi)
                    {
                        GameObject aiToken = thisTile.gameObject.transform.GetChild(0).gameObject;
                        AIToken _aiToken = aiToken.GetComponent<AIToken>();
                        BaseAiStatsController _aiStats = AiManager.GetComponent<BaseAiStatsController>();
                        _aiStats.SetAiDetails(_aiToken.id);
                        _aiStats.ReduceAiHealth(phasingPower);
                        phasing--;
                        if (phasing == 0)
                        {
                            phasingPlacedByPlayer = false;
                        }
                        else if (isPopulatedByPlayer)
                        {
                            GameObject playerToken = thisTile.gameObject.transform.GetChild(0).gameObject;
                            BasePlayerStatsController _playerStats = PlayerManager.GetComponent<BasePlayerStatsController>();
                            _playerStats.ReduceHealthNow(phasingPower);
                            phasing--;
                            if (phasing == 0)
                            {
                                phasingPlacedByPlayer = false;
                            }

                        }
                    }
                    else if (!isPopulatedByAi && !isPopulatedByPlayer)
                    {
                        phasing--;
                        if (phasing == 0)
                        {
                            phasingPlacedByAi = false;
                        }

                    }
                    
                }

                else if (phasing > 1 && phasingPlacedByPlayer)
                {
                    phasing--;
                    if (phasing == 0)
                    {
                        phasingPlacedByPlayer = false;
                    }
                }
                resolveCounter--;
            }
            if (Sumo_GameManager.instance.currentGameState == Game.State.aiResolveDMG && resolveCounter > 0)
            {
                if (phasing == 1 && phasingPlacedByAi)
                {
                    if (isPopulatedByAi)
                    {
                        GameObject aiToken = thisTile.gameObject.transform.GetChild(0).gameObject;
                        AIToken _aiToken = aiToken.GetComponent<AIToken>();
                        BaseAiStatsController _aiStats = AiManager.GetComponent<BaseAiStatsController>();
                        _aiStats.SetAiDetails(_aiToken.id);
                        _aiStats.ReduceAiHealth(phasingPower);
                        phasing--;
                        if (phasing == 0)
                        {
                            phasingPlacedByAi = false;
                        }

                    }
                    else if (isPopulatedByPlayer)
                    {
                        GameObject playerToken = thisTile.gameObject.transform.GetChild(0).gameObject;
                        Sumo_GameManager.instance._playerStats.ReduceHealthNow(phasingPower);
                        phasing--;
                        if (phasing == 0)
                        {
                            phasingPlacedByAi = false;
                        }
                    }
                    else if (!isPopulatedByPlayer && !isPopulatedByAi)
                    {
                        phasing--;
                        if (phasing == 0)
                        {
                            phasingPlacedByAi = false;
                        }
                    }
                }

                else if (phasing > 1 && phasingPlacedByAi)
                {
                    phasing--;
                    if (phasing == 0)
                    {
                        phasingPlacedByAi = false;
                    }
                }
                resolveCounter--;
            }
        }


        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision == true && collision.gameObject.tag == "Player")
            {
                isPopulatedByAi = false;
                isPopulatedByPlayer = true;
            }
            else if (collision == true && collision.gameObject.tag == "AI")
            {
                isPopulatedByAi = true;
                isPopulatedByPlayer = false;
            }
        }
        public void OnTriggerExit2D(Collider2D collision)
        {
            isPopulatedByPlayer = false;
            isPopulatedByAi = false;
        }
    }

}



