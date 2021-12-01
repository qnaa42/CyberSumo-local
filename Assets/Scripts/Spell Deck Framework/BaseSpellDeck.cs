using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GPC;

namespace GPC
{
    public class BaseSpellDeck : MonoBehaviour
    {
        public BasePlayerStatsController PlayerStats;
        public BaseAiStatsController AiStats;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        public virtual void PhaseTile(int phasing, int phasingPower, int howManyTilesHorizontal, int howManyTilesVertical, string who)
        {
            if (who == "Player")
            {

                    GameObject targetTile = GameObject.Find("Tile" + (PlayerStats.GetPosHorizontal() + howManyTilesHorizontal) + "/" + (PlayerStats.GetPosVertical() + howManyTilesVertical));
                    Tile _targetTile = targetTile.GetComponent<Tile>();
                _targetTile.tileStateMachine.targetTileState = TileState.State.casting;
                _targetTile.tileStateMachine.UpdateCurrentState();
                    _targetTile.phasing = phasing;
                    _targetTile.phasingPower = phasingPower;
                    _targetTile.phasingPlacedByPlayer = true;                                                
            }
            else if (who == "Ai")
            {

                    GameObject targetTile = GameObject.Find("Tile" + (AiStats.GetAiPosHorizontal() + howManyTilesHorizontal) + "/" + (AiStats.GetAiPosVertical() + howManyTilesVertical));
                    Tile _targetTile = targetTile.GetComponent<Tile>();
                _targetTile.tileStateMachine.targetTileState = TileState.State.casting;
                _targetTile.tileStateMachine.UpdateCurrentState();
                _targetTile.phasing = phasing;
                    _targetTile.phasingPower = phasingPower;
                    _targetTile.phasingPlacedByAi = true;
            }
            else if (who == null)
            {
                GameObject targetTile = GameObject.Find("Tile" + (PlayerStats.GetPosHorizontal() + howManyTilesHorizontal) + "/" + (PlayerStats.GetPosVertical() + howManyTilesVertical));
                Tile _targetTile = targetTile.GetComponent<Tile>();
                _targetTile.tileStateMachine.targetTileState = TileState.State.active;
                _targetTile.tileStateMachine.UpdateCurrentState();
                _targetTile.phasing = _targetTile.phasingResolveState;
                _targetTile.phasingPower = _targetTile.phasingPowerResolveState;
                _targetTile.phasingPlacedByAi = _targetTile.phasingPlacedByAiResolveState;
                _targetTile.phasingPlacedByPlayer = _targetTile.phasingPlacedByPlayerResolveState;
               

            }
        }
        public virtual void PushBack(int targetTileHowManyTileAwayHorizontal, int targetTileHowManyTileAwayVertical, int howManyTilesPushFromCasterHorizontal, int howManyTilesPushFromCasterVertical, string who)
        {
            if (who == "Player")
            {
                GameObject tileOccupiedByTarget = GameObject.Find("Tile" + (PlayerStats.GetPosHorizontal() + targetTileHowManyTileAwayHorizontal) + "/" + (PlayerStats.GetPosVertical() + targetTileHowManyTileAwayVertical));
                Tile tileOccupiedByTargetTileClass = tileOccupiedByTarget.GetComponent<Tile>();
                Transform tileOccupiedByTargetTransform = tileOccupiedByTarget.transform;
                if (tileOccupiedByTargetTileClass.isPopulatedByAi)
                {
                    GameObject target = tileOccupiedByTargetTransform.GetChild(0).gameObject;
                    GameObject targetTile = GameObject.Find("Tile" + (PlayerStats.GetPosHorizontal() + howManyTilesPushFromCasterHorizontal) + "/" + (PlayerStats.GetPosVertical() + howManyTilesPushFromCasterVertical));
                    Transform targetTileTransform = targetTile.transform;
                    Tile targetTileClass = targetTile.GetComponent<Tile>();
                    AiStats.SetAiPosVertical(targetTileClass.vertical);
                    AiStats.SetAiPosHorizontal(targetTileClass.horizontal);
                    target.transform.position = targetTileTransform.transform.position;
                    target.transform.SetParent(targetTileTransform, true);
                }
            }
            if(who == "Ai")
            {
                GameObject tileOccupiedByTarget = GameObject.Find("Tile" + (AiStats.GetAiPosHorizontal() + targetTileHowManyTileAwayHorizontal) + "/" + (AiStats.GetAiPosVertical() + targetTileHowManyTileAwayVertical));
                Tile tileOccupiedByTargetTileClass = tileOccupiedByTarget.GetComponent<Tile>();
                Transform tileOccupiedByTargetTransform = tileOccupiedByTarget.transform;
                if (tileOccupiedByTargetTileClass.isPopulatedByPlayer)
                {
                    GameObject target = tileOccupiedByTargetTransform.GetChild(0).gameObject;
                    GameObject targetTile = GameObject.Find("Tile" + (AiStats.GetAiPosHorizontal() + howManyTilesPushFromCasterHorizontal) + "/" + (AiStats.GetAiPosVertical() + howManyTilesPushFromCasterVertical));
                    Transform targetTileTransform = targetTile.transform;
                    Tile targetTileClass = targetTile.GetComponent<Tile>();
                    PlayerStats.SetPosVertical(targetTileClass.vertical);
                    PlayerStats.SetPosHorizontal(targetTileClass.horizontal);
                    target.transform.position = targetTileTransform.transform.position;
                    target.transform.SetParent(targetTileTransform, true);
                }

            }
            else if (who == null)
            {
                GameObject tileOccupiedByTarget = GameObject.Find("Tile" + (PlayerStats.GetPosHorizontal() + targetTileHowManyTileAwayHorizontal) + "/" + (PlayerStats.GetPosVertical() + targetTileHowManyTileAwayVertical));
                Tile tileOccupiedByTargetTileClass = tileOccupiedByTarget.GetComponent<Tile>();
                Transform tileOccupiedByTargetTransform = tileOccupiedByTarget.transform;
                if (tileOccupiedByTargetTileClass.isPopulatedByAiResolveState)
                {

                    GameObject targetTile = GameObject.Find("Tile" + (PlayerStats.GetPosHorizontal() + howManyTilesPushFromCasterHorizontal) + "/" + (PlayerStats.GetPosVertical() + howManyTilesPushFromCasterVertical));
                    Transform targetTileTransform = targetTile.transform;
                    GameObject target = targetTileTransform.GetChild(0).gameObject;

                    Tile targetTileClass = targetTile.GetComponent<Tile>();
                    AiStats.SetAiPosVertical(tileOccupiedByTargetTileClass.vertical);
                    AiStats.SetAiPosHorizontal(tileOccupiedByTargetTileClass.horizontal);
                    target.transform.position = targetTileTransform.transform.position;
                    target.transform.SetParent(targetTileTransform, true);
                }

            }
        }
        public virtual void PullBack(int targetTileHowManyTileAwayHorizontal, int targetTileHowManyTileAwayVertical, int howManyTilesPushFromCasterHorizontal, int howManyTilesPushFromCasterVertical, string who)
        {
            if (who == "Player")
            {
                GameObject tileOccupiedByTarget = GameObject.Find("Tile" + (PlayerStats.GetPosHorizontal() + targetTileHowManyTileAwayHorizontal) + "/" + (PlayerStats.GetPosVertical() + targetTileHowManyTileAwayVertical));
                Tile tileOccupiedByTargetTileClass = tileOccupiedByTarget.GetComponent<Tile>();
                Transform tileOccupiedByTargetTransform = tileOccupiedByTarget.transform;
                if (tileOccupiedByTargetTileClass.isPopulatedByAi)
                {
                    GameObject target = tileOccupiedByTargetTransform.GetChild(0).gameObject;
                    GameObject targetTile = GameObject.Find("Tile" + (PlayerStats.GetPosHorizontal() + howManyTilesPushFromCasterHorizontal) + "/" + (PlayerStats.GetPosVertical() + howManyTilesPushFromCasterVertical));
                    Transform targetTileTransform = targetTile.transform;
                    Tile targetTileClass = targetTile.GetComponent<Tile>();
                    AiStats.SetAiPosVertical(targetTileClass.vertical);
                    target.transform.position = targetTileTransform.transform.position;
                    target.transform.SetParent(targetTileTransform, true);
                }
            }
            if (who == "Ai")
            {
                GameObject tileOccupiedByTarget = GameObject.Find("Tile" + (AiStats.GetAiPosHorizontal() + targetTileHowManyTileAwayHorizontal) + "/" + (AiStats.GetAiPosVertical() + targetTileHowManyTileAwayVertical));
                Tile tileOccupiedByTargetTileClass = tileOccupiedByTarget.GetComponent<Tile>();
                Transform tileOccupiedByTargetTransform = tileOccupiedByTarget.transform;
                if (tileOccupiedByTargetTileClass.isPopulatedByPlayer)
                {
                    GameObject target = tileOccupiedByTargetTransform.GetChild(0).gameObject;
                    GameObject targetTile = GameObject.Find("Tile" + (AiStats.GetAiPosHorizontal() + howManyTilesPushFromCasterHorizontal) + "/" + (AiStats.GetAiPosVertical() + howManyTilesPushFromCasterVertical));
                    Transform targetTileTransform = targetTile.transform;
                    Tile targetTileClass = targetTile.GetComponent<Tile>();
                    PlayerStats.SetPosVertical(targetTileClass.vertical);
                    target.transform.position = targetTileTransform.transform.position;
                    target.transform.SetParent(targetTileTransform, true);
                }

            }
        }
    }
}

