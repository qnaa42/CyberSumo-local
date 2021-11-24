using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GPC;

namespace GPC
{

    public class SpellDeck : MonoBehaviour
    {
        public GameObject player;
        public BaseSpellDeck spellDeck;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            player = GameObject.Find("PlayerToken(Clone)");
        }

        public void SimpleAttack(GameObject caster, string direction)
        {
            if (caster.gameObject.tag == "Player")
            {
                BasePlayerStatsController _playerStats = caster.gameObject.GetComponent<BasePlayerStatsController>();
                GameObject tagetTile = GameObject.Find("Tile" + (_playerStats.GetPosHorizontal() + 1) + "/" + _playerStats.GetPosVertical());
                Tile _targetTile = tagetTile.gameObject.GetComponent<Tile>();
                _targetTile.phasing = 3;
            }
            if (caster.gameObject.tag == "AI")
            {
                GameObject aiManager = GameObject.Find("AI Manager");
                BaseAiStatsController aiStats = aiManager.GetComponent<BaseAiStatsController>();
                if (direction == "Up")
                {
//Creating this if statment for up and minus up is not nessesery, in this case it is impossibe in game to occur for tile to be about of horizontal value. However, might be usefull in future and i did it for integrity sake too.
                    if (aiStats.GetAiPosHorizontal() >= 0 && aiStats.GetAiPosHorizontal()  <= 6 && (aiStats.GetAiPosVertical() +1) >= 0 && (aiStats.GetAiPosVertical() +1) <= 4)
                    {
                        GameObject targetTileOne = GameObject.Find("Tile" + aiStats.GetAiPosHorizontal() + "/" + (aiStats.GetAiPosVertical() + 1));
                        Tile _targetTileOne = targetTileOne.GetComponent<Tile>();
                        _targetTileOne.phasing = 3;
                        _targetTileOne.phasingPlacedByAi = true;
                    }
                    if ((aiStats.GetAiPosHorizontal() - 1) >= 0 && (aiStats.GetAiPosHorizontal() - 1) <= 6 && (aiStats.GetAiPosVertical() + 1) >= 0 && (aiStats.GetAiPosVertical() + 1) <= 4)
                    {
                        GameObject targetTileTwo = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() - 1) + "/" + (aiStats.GetAiPosVertical() + 1));
                        Tile _targetTileTwo = targetTileTwo.GetComponent<Tile>();
                        _targetTileTwo.phasing = 3;
                        _targetTileTwo.phasingPlacedByAi = true;
                    }
                    if ((aiStats.GetAiPosHorizontal() + 1) >= 0 && (aiStats.GetAiPosHorizontal() + 1) <= 6 && (aiStats.GetAiPosVertical() + 1) >= 0 && (aiStats.GetAiPosVertical() + 1) <= 4)
                    {
                        GameObject targetTileThree = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() + 1) + "/" + (aiStats.GetAiPosVertical() + 1));
                        Tile _targetTileThree = targetTileThree.GetComponent<Tile>();
                        _targetTileThree.phasing = 3;
                        _targetTileThree.phasingPlacedByAi = true;
                    }
                }
                else if (direction == "minusUp")
                {
                    if (aiStats.GetAiPosHorizontal() >= 0 && aiStats.GetAiPosHorizontal() <= 6 && (aiStats.GetAiPosVertical() - 1) >= 0 && (aiStats.GetAiPosVertical() - 1) <= 4)
                    {
                        GameObject targetTileOne = GameObject.Find("Tile" + aiStats.GetAiPosHorizontal() + "/" + (aiStats.GetAiPosVertical() - 1));
                        Tile _targetTileOne = targetTileOne.GetComponent<Tile>();
                        _targetTileOne.phasing = 3;
                        _targetTileOne.phasingPlacedByAi = true;
                    }
                    if ((aiStats.GetAiPosHorizontal() - 1) >= 0 && (aiStats.GetAiPosHorizontal() - 1) <= 6 && (aiStats.GetAiPosVertical() - 1) >= 0 && (aiStats.GetAiPosVertical() - 1) <= 4)
                    {
                        GameObject targetTileTwo = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() - 1) + "/" + (aiStats.GetAiPosVertical() - 1));
                        Tile _targetTileTwo = targetTileTwo.GetComponent<Tile>();
                        _targetTileTwo.phasing = 3;
                        _targetTileTwo.phasingPlacedByAi = true;
                    }
                    if ((aiStats.GetAiPosHorizontal() + 1) >= 0 && (aiStats.GetAiPosHorizontal() + 1) <= 6 && (aiStats.GetAiPosVertical() - 1) >= 0 && (aiStats.GetAiPosVertical() - 1) <= 4)
                    {
                        GameObject targetTileThree = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() + 1) + "/" + (aiStats.GetAiPosVertical() - 1));
                        Tile _targetTileThree = targetTileThree.GetComponent<Tile>();
                        _targetTileThree.phasing = 3;
                        _targetTileThree.phasingPlacedByAi = true;
                    }
                }
                else if (direction == "Right")
                {
                    if ((aiStats.GetAiPosHorizontal() + 1) >= 0 && (aiStats.GetAiPosHorizontal() + 1) <= 6 && aiStats.GetAiPosVertical() >= 0 && aiStats.GetAiPosVertical() <= 4)
                    {
                        GameObject targetTileOne = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() + 1) + "/" + aiStats.GetAiPosVertical());
                        Tile _targetTileOne = targetTileOne.GetComponent<Tile>();
                        _targetTileOne.phasing = 3;
                        _targetTileOne.phasingPlacedByAi = true;
                    }
                    if ((aiStats.GetAiPosHorizontal() + 1) >= 0 && (aiStats.GetAiPosHorizontal() + 1) <= 6 && (aiStats.GetAiPosVertical() + 1) >= 0 && (aiStats.GetAiPosVertical() +1) <= 4)
                    {
                        GameObject targetTileTwo = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() + 1) + "/" + (aiStats.GetAiPosVertical() + 1));
                        Tile _targetTileTwo = targetTileTwo.GetComponent<Tile>();
                        _targetTileTwo.phasing = 3;
                        _targetTileTwo.phasingPlacedByAi = true;
                    }
                    if ((aiStats.GetAiPosHorizontal() + 1) >= 0 && (aiStats.GetAiPosHorizontal() + 1) <= 6 && (aiStats.GetAiPosVertical() - 1) >= 0 && (aiStats.GetAiPosVertical() -1) <= 4)
                    {
                        GameObject targetTileThree = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() + 1) + "/" + (aiStats.GetAiPosVertical() - 1));
                        Tile _targetTileThree = targetTileThree.GetComponent<Tile>();
                        _targetTileThree.phasing = 3;
                        _targetTileThree.phasingPlacedByAi = true;
                    }
                }
                else if (direction == "minusRight")
                {
                    if ((aiStats.GetAiPosHorizontal() - 1) >= 0 && (aiStats.GetAiPosHorizontal() - 1) <= 6 && aiStats.GetAiPosVertical() >= 0 && aiStats.GetAiPosVertical() <= 4)
                    {
                        GameObject targetTileOne = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() - 1) + "/" + aiStats.GetAiPosVertical());
                        Tile _targetTileOne = targetTileOne.GetComponent<Tile>();
                        _targetTileOne.phasing = 3;
                        _targetTileOne.phasingPlacedByAi = true;
                    }
                    if ((aiStats.GetAiPosHorizontal() - 1) >= 0 && (aiStats.GetAiPosHorizontal() - 1) <= 6 && (aiStats.GetAiPosVertical() + 1) >= 0 && (aiStats.GetAiPosVertical() + 1) <= 4)
                    {
                        GameObject targetTileTwo = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() - 1) + "/" + (aiStats.GetAiPosVertical() + 1));
                        Tile _targetTileTwo = targetTileTwo.GetComponent<Tile>();
                        _targetTileTwo.phasing = 3;
                        _targetTileTwo.phasingPlacedByAi = true;
                    }
                    if ((aiStats.GetAiPosHorizontal() - 1) >= 0 && (aiStats.GetAiPosHorizontal() - 1) <= 6 && (aiStats.GetAiPosVertical() - 1) >= 0 && (aiStats.GetAiPosVertical() - 1) <= 4)
                    {
                        GameObject targetTileThree = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() - 1) + "/" + (aiStats.GetAiPosVertical() - 1));
                        Tile _targetTileThree = targetTileThree.GetComponent<Tile>();
                        _targetTileThree.phasing = 3;
                        _targetTileThree.phasingPlacedByAi = true;
                    }
                }
            }
        }
        public void PushAndDiamonAttackPattern(GameObject caster, string direction, int phasingPower, string cancelClick)
        {
            if (caster.gameObject.tag == "AI" && cancelClick == "No")
            {
                GameObject aiManager = GameObject.Find("AI Manager");
                BaseAiStatsController aiStats = aiManager.GetComponent<BaseAiStatsController>();
                GameObject playerManager = GameObject.Find("Player Manager");
                BasePlayerStatsController playerStats = playerManager.GetComponent<BasePlayerStatsController>();
                if(direction == "Up")
                {
                    if (aiStats.GetAiPosHorizontal() >= 0 && aiStats.GetAiPosHorizontal() <= 6 && (aiStats.GetAiPosVertical() + 1) >= 0 && (aiStats.GetAiPosVertical() + 1) <= 4)
                    {
                        spellDeck.PhaseTile(2, phasingPower, 0, 1, "Ai");
                    }
                    if (aiStats.GetAiPosHorizontal() >= 0 && aiStats.GetAiPosHorizontal() <= 6 && (aiStats.GetAiPosVertical() + 2) >= 0 && (aiStats.GetAiPosVertical() + 2) <= 4)
                    {
                        spellDeck.PhaseTile(1, (phasingPower/2), 0, 2, "Ai");
                        spellDeck.PushBack(0, 1, 0, 2, "Ai");
                        
                    }
                    if ((aiStats.GetAiPosHorizontal() - 1) >= 0 && (aiStats.GetAiPosHorizontal() - 1) <= 6 && (aiStats.GetAiPosVertical() + 2) >= 0 && (aiStats.GetAiPosVertical() + 2) <= 4)
                    {
                        spellDeck.PhaseTile(2, phasingPower, -1, 2, "Ai");
                    }
                    if ((aiStats.GetAiPosHorizontal() + 1) >= 0 && (aiStats.GetAiPosHorizontal() + 1) <= 6 && (aiStats.GetAiPosVertical() + 2) >= 0 && (aiStats.GetAiPosVertical() + 2) <= 4)
                    {
                        spellDeck.PhaseTile(2, phasingPower, 1, 2, "Ai");
                    }
                    if (aiStats.GetAiPosHorizontal() >= 0 && aiStats.GetAiPosHorizontal() <= 6 && (aiStats.GetAiPosVertical() + 3) >= 0 && (aiStats.GetAiPosVertical() + 3) <= 4)
                    {
                        spellDeck.PhaseTile(2, phasingPower, 0, 3, "Ai");
                    }
                }
                else if (direction == "minusUp")
                {
                    if (aiStats.GetAiPosHorizontal() >= 0 && aiStats.GetAiPosHorizontal() <= 6 && (aiStats.GetAiPosVertical() - 1) >= 0 && (aiStats.GetAiPosVertical() - 1) <= 4)
                    {
                        spellDeck.PhaseTile(2, phasingPower, 0, -1, "Ai");
                    }
                    if (aiStats.GetAiPosHorizontal() >= 0 && aiStats.GetAiPosHorizontal() <= 6 && (aiStats.GetAiPosVertical() - 2) >= 0 && (aiStats.GetAiPosVertical() - 2) <= 4)
                    {
                        spellDeck.PhaseTile(1, (phasingPower / 2), 0, -2, "Ai");
                        spellDeck.PushBack(0, -1, 0, -2, "Ai");

                    }
                    if ((aiStats.GetAiPosHorizontal() - 1) >= 0 && (aiStats.GetAiPosHorizontal() - 1) <= 6 && (aiStats.GetAiPosVertical() - 2) >= 0 && (aiStats.GetAiPosVertical() - 2) <= 4)
                    {
                        spellDeck.PhaseTile(2, phasingPower, -1, -2, "Ai");
                    }
                    if ((aiStats.GetAiPosHorizontal() + 1) >= 0 && (aiStats.GetAiPosHorizontal() + 1) <= 6 && (aiStats.GetAiPosVertical() - 2) >= 0 && (aiStats.GetAiPosVertical() - 2) <= 4)
                    {
                        spellDeck.PhaseTile(2, phasingPower, 1, -2, "Ai");
                    }
                    if (aiStats.GetAiPosHorizontal() >= 0 && aiStats.GetAiPosHorizontal() <= 6 && (aiStats.GetAiPosVertical() - 3) >= 0 && (aiStats.GetAiPosVertical() - 3) <= 4)
                    {
                        spellDeck.PhaseTile(2, phasingPower, 0, -3, "Ai");
                    }
                }
                else if (direction == "Right")
                {
                    if ((aiStats.GetAiPosHorizontal() + 1) >= 0 && (aiStats.GetAiPosHorizontal() + 1) <= 6 && aiStats.GetAiPosVertical() >= 0 && aiStats.GetAiPosVertical() <= 4)
                    {
                        spellDeck.PhaseTile(2, phasingPower, 1, 0, "Ai");
                    }
                    if ((aiStats.GetAiPosHorizontal() + 2) >= 0 && (aiStats.GetAiPosHorizontal() + 2) <= 6 && aiStats.GetAiPosVertical() >= 0 && aiStats.GetAiPosVertical() <= 4)
                    {
                        spellDeck.PhaseTile(1, (phasingPower / 2), 2, 0, "Ai");
                        spellDeck.PushBack(1, 0, 2, 0, "Ai");
                    }
                    if ((aiStats.GetAiPosHorizontal() + 2) >= 0 && (aiStats.GetAiPosHorizontal() + 2) <= 6 && (aiStats.GetAiPosVertical() + 1) >= 0 && (aiStats.GetAiPosVertical() + 1) <= 4)
                    {
                        spellDeck.PhaseTile(2, phasingPower, 2, 1, "Ai");
                    }
                    if ((aiStats.GetAiPosHorizontal() + 2) >= 0 && (aiStats.GetAiPosHorizontal() + 2) <= 6 && (aiStats.GetAiPosVertical() - 1) >= 0 && (aiStats.GetAiPosVertical() - 1) <= 4)
                    {
                        spellDeck.PhaseTile(2, phasingPower, 2, -1, "Ai");
                    }
                    if ((aiStats.GetAiPosHorizontal() + 3) >= 0 && (aiStats.GetAiPosHorizontal() + 3) <= 6 && aiStats.GetAiPosVertical() >= 0 && aiStats.GetAiPosVertical() <= 4)
                    {
                        spellDeck.PhaseTile(2, phasingPower, 3, 0, "Ai");
                    }
                }
                else if (direction == "minusRight")
                {
                    if ((aiStats.GetAiPosHorizontal() - 1) >= 0 && (aiStats.GetAiPosHorizontal() - 1) <= 6 && aiStats.GetAiPosVertical() >= 0 && aiStats.GetAiPosVertical() <= 4)
                    {
                        spellDeck.PhaseTile(2, phasingPower, -1, 0, "Ai");
                    }
                    if ((aiStats.GetAiPosHorizontal() - 2) >= 0 && (aiStats.GetAiPosHorizontal() - 2) <= 6 && aiStats.GetAiPosVertical() >= 0 && aiStats.GetAiPosVertical() <= 4)
                    {
                        spellDeck.PhaseTile(1, (phasingPower / 2), -2, 0, "Ai");
                        spellDeck.PushBack(-1, 0, -2, 0, "Ai");
                    }
                    if ((aiStats.GetAiPosHorizontal() - 2) >= 0 && (aiStats.GetAiPosHorizontal() - 2) <= 6 && (aiStats.GetAiPosVertical() + 1) >= 0 && (aiStats.GetAiPosVertical() + 1) <= 4)
                    {
                        spellDeck.PhaseTile(2, phasingPower, -2, 1, "Ai");
                    }
                    if ((aiStats.GetAiPosHorizontal() - 2) >= 0 && (aiStats.GetAiPosHorizontal() - 2) <= 6 && (aiStats.GetAiPosVertical() - 1) >= 0 && (aiStats.GetAiPosVertical() - 1) <= 4)
                    {
                        spellDeck.PhaseTile(2, phasingPower, -2, -1, "Ai");
                    }
                    if ((aiStats.GetAiPosHorizontal() - 3) >= 0 && (aiStats.GetAiPosHorizontal() - 3) <= 6 && aiStats.GetAiPosVertical() >= 0 && aiStats.GetAiPosVertical() <= 4)
                    {
                        spellDeck.PhaseTile(2, phasingPower, -3, 0, "Ai");
                    }
                }


            }
            else if (caster.gameObject.tag == "Player" && cancelClick == "No")
            {
                GameObject aiManager = GameObject.Find("AI Manager");
                BaseAiStatsController aiStats = aiManager.GetComponent<BaseAiStatsController>();
                GameObject playerManager = GameObject.Find("Player Manager");
                BasePlayerStatsController playerStats = playerManager.GetComponent<BasePlayerStatsController>();
                if (direction == "Up")
                {
                    if (playerStats.GetPosHorizontal() >= 0 && playerStats.GetPosHorizontal() <= 6 && (playerStats.GetPosVertical() + 1) >= 0 && (playerStats.GetPosVertical() + 1) <= 4)
                    {
                        spellDeck.PhaseTile(2, 10,0, 1, "Player");

                    }
                    if (playerStats.GetPosHorizontal() >= 0 && playerStats.GetPosHorizontal() <= 6 && (playerStats.GetPosVertical() + 2) >= 0 && (playerStats.GetPosVertical() + 2) <= 4)
                    {

                        spellDeck.PhaseTile(1, 5,0, 2, "Player");
                        GameObject tileOccupiedByTarget = GameObject.Find("Tile" + playerStats.GetPosHorizontal() + "/" + (playerStats.GetPosVertical() + 1));
                        Tile tileOccupiedByTargetTileClass = tileOccupiedByTarget.GetComponent<Tile>();
                        Transform tileOccupiedByTargetTransform = tileOccupiedByTarget.transform;
                        if (tileOccupiedByTargetTileClass.isPopulatedByAi)
                        {
                            GameObject target = tileOccupiedByTargetTransform.GetChild(0).gameObject;
                            GameObject targetTile = GameObject.Find("Tile" + playerStats.GetPosHorizontal() + "/" + (playerStats.GetPosVertical() + 2));
                            Transform targetTileTransform = targetTile.transform;
                            Tile targetTileClass = targetTile.GetComponent<Tile>();
                            aiStats.SetAiPosVertical(targetTileClass.vertical);
                            target.transform.position = targetTileTransform.transform.position;
                            target.transform.SetParent(targetTileTransform, true);
                        }


                    }
                    if ((playerStats.GetPosHorizontal() - 1) >= 0 && (playerStats.GetPosHorizontal() - 1) <= 6 && (playerStats.GetPosVertical() + 2) >= 0 && (playerStats.GetPosVertical() + 2) <= 4)
                    {
                        spellDeck.PhaseTile(2, 10, -1, 2, "Player");        
                    }
                    if ((playerStats.GetPosHorizontal() + 1) >= 0 && (playerStats.GetPosHorizontal() + 1) <= 6 && (playerStats.GetPosVertical() + 2) >= 0 && (playerStats.GetPosVertical() + 2) <= 4)
                    {
                        spellDeck.PhaseTile(2, 10, 1, 2, "Player");
                    }
                    if (playerStats.GetPosHorizontal() >= 0 && playerStats.GetPosHorizontal() <= 6 && (playerStats.GetPosVertical() + 3) >= 0 && (playerStats.GetPosVertical() + 3) <= 4)
                    {
                        spellDeck.PhaseTile(2, 10, 0, 3, "Player");
                    }
                }
                else if (direction == "minusUp")
                {
                    if (playerStats.GetPosHorizontal() >= 0 && playerStats.GetPosHorizontal() <= 6 && (playerStats.GetPosVertical() - 1) >= 0 && (playerStats.GetPosVertical() - 1) <= 4)
                    {
                        spellDeck.PhaseTile(2, 10, 0, -1, "Player");
                    }
                    if (playerStats.GetPosHorizontal() >= 0 && playerStats.GetPosHorizontal() <= 6 && (playerStats.GetPosVertical() - 2) >= 0 && (playerStats.GetPosVertical() - 2) <= 4)
                    {
                        spellDeck.PhaseTile(1, 5, 0, -2, "Player");
                        GameObject tileOccupiedByTarget = GameObject.Find("Tile" + playerStats.GetPosHorizontal() + "/" + (playerStats.GetPosVertical() - 1));
                        Tile tileOccupiedByTargetTileClass = tileOccupiedByTarget.GetComponent<Tile>();
                        Transform tileOccupiedByTargetTransform = tileOccupiedByTarget.transform;
                        if (tileOccupiedByTargetTileClass.isPopulatedByAi)
                        {
                            GameObject target = tileOccupiedByTargetTransform.GetChild(0).gameObject;
                            GameObject targetTile = GameObject.Find("Tile" + playerStats.GetPosHorizontal() + "/" + (playerStats.GetPosVertical() - 2));
                            Transform targetTileTransform = targetTile.transform;
                            Tile targetTileClass = targetTile.GetComponent<Tile>();
                            aiStats.SetAiPosVertical(targetTileClass.vertical);
                            target.transform.position = targetTileTransform.transform.position;
                            target.transform.SetParent(targetTileTransform, true);
                        }

                    }
                    if ((playerStats.GetPosHorizontal() - 1) >= 0 && (playerStats.GetPosHorizontal() - 1) <= 6 && (playerStats.GetPosVertical() - 2) >= 0 && (playerStats.GetPosVertical() - 2) <= 4)
                    {
                        spellDeck.PhaseTile(2, 10, -1, -2, "Player");
                    }
                    if ((playerStats.GetPosHorizontal() + 1) >= 0 && (playerStats.GetPosHorizontal() + 1) <= 6 && (playerStats.GetPosVertical() - 2) >= 0 && (playerStats.GetPosVertical() - 2) <= 4)
                    {
                        spellDeck.PhaseTile(2, 10, 1, -2, "Player");
                    }
                    if (playerStats.GetPosHorizontal() >= 0 && playerStats.GetPosHorizontal() <= 6 && (playerStats.GetPosVertical() - 3) >= 0 && (playerStats.GetPosVertical() - 3) <= 4)
                    {
                        spellDeck.PhaseTile(2, 10, 0, -3, "Player");
                    }
                }
                else if (direction == "Right")
                {
                    if ((playerStats.GetPosHorizontal() + 1) >= 0 && (playerStats.GetPosHorizontal() + 1) <= 6 && playerStats.GetPosVertical() >= 0 && playerStats.GetPosVertical() <= 4)
                    {
                        spellDeck.PhaseTile(2, 10, 1, 0, "Player");
                    }
                    if ((playerStats.GetPosHorizontal() + 2) >= 0 && (playerStats.GetPosHorizontal() + 2) <= 6 && playerStats.GetPosVertical() >= 0 && playerStats.GetPosVertical() <= 4)
                    {
                        spellDeck.PhaseTile(1, 5, 2, 0, "Player");
                        GameObject tileOccupiedByTarget = GameObject.Find("Tile" + (playerStats.GetPosHorizontal() + 1) + "/" + playerStats.GetPosVertical());
                        Tile tileOccupiedByTargetTileClass = tileOccupiedByTarget.GetComponent<Tile>();
                        Transform tileOccupiedByTargetTransform = tileOccupiedByTarget.transform;
                        if (tileOccupiedByTargetTileClass.isPopulatedByAi)
                        {
                            GameObject target = tileOccupiedByTargetTransform.GetChild(0).gameObject;
                            GameObject targetTile = GameObject.Find("Tile" + (playerStats.GetPosHorizontal() + 2) + "/" + playerStats.GetPosVertical());
                            Transform targetTileTransform = targetTile.transform;
                            Tile targetTileClass = targetTile.GetComponent<Tile>();
                            aiStats.SetAiPosHorizontal(targetTileClass.horizontal);
                            target.transform.position = targetTileTransform.transform.position;
                            target.transform.SetParent(targetTileTransform, true);
                        }
                    }
                    if ((playerStats.GetPosHorizontal() + 2) >= 0 && (playerStats.GetPosHorizontal() + 2) <= 6 && (playerStats.GetPosVertical() + 1) >= 0 && (playerStats.GetPosVertical() + 1) <= 4)
                    {
                        spellDeck.PhaseTile(2, 10, 2, 1, "Player");
                    }
                    if ((playerStats.GetPosHorizontal() + 2) >= 0 && (playerStats.GetPosHorizontal() + 2) <= 6 && (playerStats.GetPosVertical() - 1) >= 0 && (playerStats.GetPosVertical() - 1) <= 4)
                    {
                        spellDeck.PhaseTile(2, 10, 2, -1, "Player");
                    }
                    if ((playerStats.GetPosHorizontal() + 3) >= 0 && (playerStats.GetPosHorizontal() + 3) <= 6 && playerStats.GetPosVertical() >= 0 && playerStats.GetPosVertical() <= 4)
                    {
                        spellDeck.PhaseTile(2, 10, 3, 0, "Player");
                    }
                }
                else if (direction == "minusRight")
                {
                    if ((playerStats.GetPosHorizontal() - 1) >= 0 && (playerStats.GetPosHorizontal() - 1) <= 6 && playerStats.GetPosVertical() >= 0 && playerStats.GetPosVertical() <= 4)
                    {
                        spellDeck.PhaseTile(2, 10, -1, 0, "Player");
                    }
                    if ((playerStats.GetPosHorizontal() - 2) >= 0 && (playerStats.GetPosHorizontal() - 2) <= 6 && playerStats.GetPosVertical() >= 0 && playerStats.GetPosVertical() <= 4)
                    {
                        spellDeck.PhaseTile(1, 5, -2, 0, "Player");
                        GameObject tileOccupiedByTarget = GameObject.Find("Tile" + (playerStats.GetPosHorizontal() - 1) + "/" + playerStats.GetPosVertical());
                        Tile tileOccupiedByTargetTileClass = tileOccupiedByTarget.GetComponent<Tile>();
                        Transform tileOccupiedByTargetTransform = tileOccupiedByTarget.transform;
                        if (tileOccupiedByTargetTileClass.isPopulatedByAi)
                        {
                            GameObject target = tileOccupiedByTargetTransform.GetChild(0).gameObject;
                            GameObject targetTile = GameObject.Find("Tile" + (playerStats.GetPosHorizontal() - 2) + "/" + playerStats.GetPosVertical());
                            Transform targetTileTransform = targetTile.transform;
                            Tile targetTileClass = targetTile.GetComponent<Tile>();
                            aiStats.SetAiPosHorizontal(targetTileClass.horizontal);
                            target.transform.position = targetTileTransform.transform.position;
                            target.transform.SetParent(targetTileTransform, true);
                        }
                    }
                    if ((playerStats.GetPosHorizontal() - 2) >= 0 && (playerStats.GetPosHorizontal() - 2) <= 6 && (playerStats.GetPosVertical() + 1) >= 0 && (playerStats.GetPosVertical() + 1) <= 4)
                    {
                        spellDeck.PhaseTile(2, 10, -2, 1, "Player");
                    }
                    if ((playerStats.GetPosHorizontal() - 2) >= 0 && (playerStats.GetPosHorizontal() - 2) <= 6 && (playerStats.GetPosVertical() - 1) >= 0 && (playerStats.GetPosVertical() - 1) <= 4)
                    {
                        GameObject targetTileThree = GameObject.Find("Tile" + (playerStats.GetPosHorizontal() - 2) + "/" + (playerStats.GetPosVertical() - 1));
                        Tile _targetTileThree = targetTileThree.GetComponent<Tile>();
                        _targetTileThree.phasing = 2;
                        _targetTileThree.phasingPlacedByPlayer = true;
                        _targetTileThree.phasingPower = 10;
                        spellDeck.PhaseTile(2, 10, -2, -1, "Player");
                    }
                    if ((playerStats.GetPosHorizontal() - 3) >= 0 && (playerStats.GetPosHorizontal() - 3) <= 6 && playerStats.GetPosVertical() >= 0 && playerStats.GetPosVertical() <= 4)
                    {
                        spellDeck.PhaseTile(2, 10, -3, 0, "Player");
                    }
                }


            }
            else if ((caster.gameObject.tag == "Player" || caster.gameObject.tag =="Player") && cancelClick == "Yes")
            {
                GameObject aiManager = GameObject.Find("AI Manager");
                BaseAiStatsController aiStats = aiManager.GetComponent<BaseAiStatsController>();
                GameObject playerManager = GameObject.Find("Player Manager");
                BasePlayerStatsController playerStats = playerManager.GetComponent<BasePlayerStatsController>();
                if (direction == "Up")
                {
                    if (playerStats.GetPosHorizontal() >= 0 && playerStats.GetPosHorizontal() <= 6 && (playerStats.GetPosVertical() + 1) >= 0 && (playerStats.GetPosVertical() + 1) <= 4)
                    {
                        spellDeck.PhaseTile(2, 10, 0, 1, null);

                    }
                    if (playerStats.GetPosHorizontal() >= 0 && playerStats.GetPosHorizontal() <= 6 && (playerStats.GetPosVertical() + 2) >= 0 && (playerStats.GetPosVertical() + 2) <= 4)
                    {

                        spellDeck.PhaseTile(1, 5, 0, 2, null);
                        spellDeck.PullBack(0, 2, 0, 1, "Player");
                    }
                    if ((playerStats.GetPosHorizontal() - 1) >= 0 && (playerStats.GetPosHorizontal() - 1) <= 6 && (playerStats.GetPosVertical() + 2) >= 0 && (playerStats.GetPosVertical() + 2) <= 4)
                    {
                        spellDeck.PhaseTile(2, 10, -1, 2, null);
                    }
                    if ((playerStats.GetPosHorizontal() + 1) >= 0 && (playerStats.GetPosHorizontal() + 1) <= 6 && (playerStats.GetPosVertical() + 2) >= 0 && (playerStats.GetPosVertical() + 2) <= 4)
                    {
                        spellDeck.PhaseTile(2, 10, 1, 2, null);
                    }
                    if (playerStats.GetPosHorizontal() >= 0 && playerStats.GetPosHorizontal() <= 6 && (playerStats.GetPosVertical() + 3) >= 0 && (playerStats.GetPosVertical() + 3) <= 4)
                    {
                        spellDeck.PhaseTile(2, 10, 0, 3, null);
                    }
                }
                else if (direction == "minusUp")
                {
                    if (playerStats.GetPosHorizontal() >= 0 && playerStats.GetPosHorizontal() <= 6 && (playerStats.GetPosVertical() - 1) >= 0 && (playerStats.GetPosVertical() - 1) <= 4)
                    {
                        spellDeck.PhaseTile(2, 10, 0, -1, null);
                    }
                    if (playerStats.GetPosHorizontal() >= 0 && playerStats.GetPosHorizontal() <= 6 && (playerStats.GetPosVertical() - 2) >= 0 && (playerStats.GetPosVertical() - 2) <= 4)
                    {
                        spellDeck.PhaseTile(1, 5, 0, -2, null);
                        spellDeck.PullBack(0, -2, 0, -1, "Player");
                    }
                    if ((playerStats.GetPosHorizontal() - 1) >= 0 && (playerStats.GetPosHorizontal() - 1) <= 6 && (playerStats.GetPosVertical() - 2) >= 0 && (playerStats.GetPosVertical() - 2) <= 4)
                    {
                        spellDeck.PhaseTile(2, 10, -1, -2, null);
                    }
                    if ((playerStats.GetPosHorizontal() + 1) >= 0 && (playerStats.GetPosHorizontal() + 1) <= 6 && (playerStats.GetPosVertical() - 2) >= 0 && (playerStats.GetPosVertical() - 2) <= 4)
                    {
                        spellDeck.PhaseTile(2, 10, 1, -2, null);
                    }
                    if (playerStats.GetPosHorizontal() >= 0 && playerStats.GetPosHorizontal() <= 6 && (playerStats.GetPosVertical() - 3) >= 0 && (playerStats.GetPosVertical() - 3) <= 4)
                    {
                        spellDeck.PhaseTile(2, 10, 0, -3, null);
                    }
                }
                else if (direction == "Right")
                {
                    if ((playerStats.GetPosHorizontal() + 1) >= 0 && (playerStats.GetPosHorizontal() + 1) <= 6 && playerStats.GetPosVertical() >= 0 && playerStats.GetPosVertical() <= 4)
                    {
                        spellDeck.PhaseTile(2, 10, 1, 0, null);
                    }
                    if ((playerStats.GetPosHorizontal() + 2) >= 0 && (playerStats.GetPosHorizontal() + 2) <= 6 && playerStats.GetPosVertical() >= 0 && playerStats.GetPosVertical() <= 4)
                    {
                        spellDeck.PhaseTile(1, 5, 2, 0, null);
                        spellDeck.PullBack(2, 0, 1, 0, "Player");
                    }
                    if ((playerStats.GetPosHorizontal() + 2) >= 0 && (playerStats.GetPosHorizontal() + 2) <= 6 && (playerStats.GetPosVertical() + 1) >= 0 && (playerStats.GetPosVertical() + 1) <= 4)
                    {
                        spellDeck.PhaseTile(2, 10, 2, 1, null);
                    }
                    if ((playerStats.GetPosHorizontal() + 2) >= 0 && (playerStats.GetPosHorizontal() + 2) <= 6 && (playerStats.GetPosVertical() - 1) >= 0 && (playerStats.GetPosVertical() - 1) <= 4)
                    {
                        spellDeck.PhaseTile(2, 10, 2, -1, null);
                    }
                    if ((playerStats.GetPosHorizontal() + 3) >= 0 && (playerStats.GetPosHorizontal() + 3) <= 6 && playerStats.GetPosVertical() >= 0 && playerStats.GetPosVertical() <= 4)
                    {
                        spellDeck.PhaseTile(2, 10, 3, 0, null);
                    }
                }
                else if (direction == "minusRight")
                {
                    if ((playerStats.GetPosHorizontal() - 1) >= 0 && (playerStats.GetPosHorizontal() - 1) <= 6 && playerStats.GetPosVertical() >= 0 && playerStats.GetPosVertical() <= 4)
                    {
                        spellDeck.PhaseTile(2, 10, -1, 0, null);
                    }
                    if ((playerStats.GetPosHorizontal() - 2) >= 0 && (playerStats.GetPosHorizontal() - 2) <= 6 && playerStats.GetPosVertical() >= 0 && playerStats.GetPosVertical() <= 4)
                    {
                        spellDeck.PhaseTile(1, 5, -2, 0, null);
                        spellDeck.PullBack(-2, 0, -1, 0, "Player");
                    }
                    if ((playerStats.GetPosHorizontal() - 2) >= 0 && (playerStats.GetPosHorizontal() - 2) <= 6 && (playerStats.GetPosVertical() + 1) >= 0 && (playerStats.GetPosVertical() + 1) <= 4)
                    {
                        spellDeck.PhaseTile(2, 10, -2, 1, null);
                    }
                    if ((playerStats.GetPosHorizontal() - 2) >= 0 && (playerStats.GetPosHorizontal() - 2) <= 6 && (playerStats.GetPosVertical() - 1) >= 0 && (playerStats.GetPosVertical() - 1) <= 4)
                    {
                        spellDeck.PhaseTile(2, 10, -2, -1, null);
                    }
                    if ((playerStats.GetPosHorizontal() - 3) >= 0 && (playerStats.GetPosHorizontal() - 3) <= 6 && playerStats.GetPosVertical() >= 0 && playerStats.GetPosVertical() <= 4)
                    {
                        spellDeck.PhaseTile(2, 10, -3, 0, null);
                    }
                }


            }
        }
        public void ClickTestAttack()
        {
            SimpleAttack(player, "right");
        }
    }
}

