using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GPC;

namespace GPC
{

    public class SpellDeck : MonoBehaviour
    {
        public GameObject player;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            player = GameObject.Find("PlayerToken(Clone)");
        }
        public void DiamondCastPlayerTest()
        {
            PushAndDiamonAttackPattern(player, "minusUp");
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
        public void PushAndDiamonAttackPattern(GameObject caster, string direction)
        {
            if (caster.gameObject.tag == "AI")
            {
                GameObject aiManager = GameObject.Find("AI Manager");
                BaseAiStatsController aiStats = aiManager.GetComponent<BaseAiStatsController>();
                GameObject playerManager = GameObject.Find("Player Manager");
                BasePlayerStatsController playerStats = playerManager.GetComponent<BasePlayerStatsController>();
                if(direction == "Up")
                {
                    if (aiStats.GetAiPosHorizontal() >= 0 && aiStats.GetAiPosHorizontal() <= 6 && (aiStats.GetAiPosVertical() + 1) >= 0 && (aiStats.GetAiPosVertical() + 1) <= 4)
                    {
                        GameObject targetTileOne = GameObject.Find("Tile" + aiStats.GetAiPosHorizontal() + "/" + (aiStats.GetAiPosVertical() + 1));
                        Tile _targetTileOne = targetTileOne.GetComponent<Tile>();
                        _targetTileOne.phasing = 2;
                        _targetTileOne.phasingPlacedByAi = true;
                        _targetTileOne.phasingPower = 10;
                    }
                    if (aiStats.GetAiPosHorizontal() >= 0 && aiStats.GetAiPosHorizontal() <= 6 && (aiStats.GetAiPosVertical() + 2) >= 0 && (aiStats.GetAiPosVertical() + 2) <= 4)
                    {
                        GameObject targetTileOne = GameObject.Find("Tile" + aiStats.GetAiPosHorizontal() + "/" + (aiStats.GetAiPosVertical() + 2));
                        Tile _targetTileOne = targetTileOne.GetComponent<Tile>();
                        _targetTileOne.phasing = 1;
                        _targetTileOne.phasingPlacedByAi = true;
                        _targetTileOne.phasingPower = 5;
                        GameObject tileOccupiedByTarget = GameObject.Find("Tile" + aiStats.GetAiPosHorizontal() + "/" + (aiStats.GetAiPosVertical() + 1));
                        Transform tileOccupiedByTargetTransform = tileOccupiedByTarget.transform;
                        GameObject target = tileOccupiedByTargetTransform.GetChild(0).gameObject;
                        GameObject targetTile = GameObject.Find("Tile" + aiStats.GetAiPosHorizontal() + "/" + (aiStats.GetAiPosVertical() + 2));
                        Transform targetTileTransform = targetTile.transform;
                        Tile targetTileClass = targetTile.GetComponent<Tile>();
                        playerStats.SetPosVertical(targetTileClass.vertical);
                        target.transform.position = targetTileTransform.transform.position;
                        target.transform.SetParent(targetTileTransform, true);
                        
                    }
                    if ((aiStats.GetAiPosHorizontal() - 1) >= 0 && (aiStats.GetAiPosHorizontal() - 1) <= 6 && (aiStats.GetAiPosVertical() + 2) >= 0 && (aiStats.GetAiPosVertical() + 2) <= 4)
                    {
                        GameObject targetTileTwo = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() - 1) + "/" + (aiStats.GetAiPosVertical() + 2));
                        Tile _targetTileTwo = targetTileTwo.GetComponent<Tile>();
                        _targetTileTwo.phasing = 2;
                        _targetTileTwo.phasingPlacedByAi = true;
                        _targetTileTwo.phasingPower = 10;
                    }
                    if ((aiStats.GetAiPosHorizontal() + 1) >= 0 && (aiStats.GetAiPosHorizontal() + 1) <= 6 && (aiStats.GetAiPosVertical() + 2) >= 0 && (aiStats.GetAiPosVertical() + 2) <= 4)
                    {
                        GameObject targetTileThree = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() + 1) + "/" + (aiStats.GetAiPosVertical() + 2));
                        Tile _targetTileThree = targetTileThree.GetComponent<Tile>();
                        _targetTileThree.phasing = 2;
                        _targetTileThree.phasingPlacedByAi = true;
                        _targetTileThree.phasingPower = 10;
                    }
                    if (aiStats.GetAiPosHorizontal() >= 0 && aiStats.GetAiPosHorizontal() <= 6 && (aiStats.GetAiPosVertical() + 3) >= 0 && (aiStats.GetAiPosVertical() + 3) <= 4)
                    {
                        GameObject targetTileOne = GameObject.Find("Tile" + aiStats.GetAiPosHorizontal() + "/" + (aiStats.GetAiPosVertical() + 3));
                        Tile _targetTileOne = targetTileOne.GetComponent<Tile>();
                        _targetTileOne.phasing = 2;
                        _targetTileOne.phasingPlacedByAi = true;
                        _targetTileOne.phasingPower = 10;
                    }
                }
                else if (direction == "minusUp")
                {
                    if (aiStats.GetAiPosHorizontal() >= 0 && aiStats.GetAiPosHorizontal() <= 6 && (aiStats.GetAiPosVertical() - 1) >= 0 && (aiStats.GetAiPosVertical() - 1) <= 4)
                    {
                        GameObject targetTileOne = GameObject.Find("Tile" + aiStats.GetAiPosHorizontal() + "/" + (aiStats.GetAiPosVertical() - 1));
                        Tile _targetTileOne = targetTileOne.GetComponent<Tile>();
                        _targetTileOne.phasing = 2;
                        _targetTileOne.phasingPlacedByAi = true;
                        _targetTileOne.phasingPower = 10;
                    }
                    if (aiStats.GetAiPosHorizontal() >= 0 && aiStats.GetAiPosHorizontal() <= 6 && (aiStats.GetAiPosVertical() - 2) >= 0 && (aiStats.GetAiPosVertical() - 2) <= 4)
                    {
                        GameObject targetTileOne = GameObject.Find("Tile" + aiStats.GetAiPosHorizontal() + "/" + (aiStats.GetAiPosVertical() - 2));
                        Tile _targetTileOne = targetTileOne.GetComponent<Tile>();
                        _targetTileOne.phasing = 1;
                        _targetTileOne.phasingPlacedByAi = true;
                        _targetTileOne.phasingPower = 5;
                        GameObject tileOccupiedByTarget = GameObject.Find("Tile" + aiStats.GetAiPosHorizontal() + "/" + (aiStats.GetAiPosVertical() - 1));
                        Transform tileOccupiedByTargetTransform = tileOccupiedByTarget.transform;
                        GameObject target = tileOccupiedByTargetTransform.GetChild(0).gameObject;
                        GameObject targetTile = GameObject.Find("Tile" + aiStats.GetAiPosHorizontal() + "/" + (aiStats.GetAiPosVertical() - 2));
                        Transform targetTileTransform = targetTile.transform;
                        Tile targetTileClass = targetTile.GetComponent<Tile>();
                        playerStats.SetPosVertical(targetTileClass.vertical);
                        target.transform.position = targetTileTransform.transform.position;
                        target.transform.SetParent(targetTileTransform, true);

                    }
                    if ((aiStats.GetAiPosHorizontal() - 1) >= 0 && (aiStats.GetAiPosHorizontal() - 1) <= 6 && (aiStats.GetAiPosVertical() - 2) >= 0 && (aiStats.GetAiPosVertical() - 2) <= 4)
                    {
                        GameObject targetTileTwo = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() - 1) + "/" + (aiStats.GetAiPosVertical() - 2));
                        Tile _targetTileTwo = targetTileTwo.GetComponent<Tile>();
                        _targetTileTwo.phasing = 2;
                        _targetTileTwo.phasingPlacedByAi = true;
                        _targetTileTwo.phasingPower = 10;
                    }
                    if ((aiStats.GetAiPosHorizontal() + 1) >= 0 && (aiStats.GetAiPosHorizontal() + 1) <= 6 && (aiStats.GetAiPosVertical() - 2) >= 0 && (aiStats.GetAiPosVertical() - 2) <= 4)
                    {
                        GameObject targetTileThree = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() + 1) + "/" + (aiStats.GetAiPosVertical() - 2));
                        Tile _targetTileThree = targetTileThree.GetComponent<Tile>();
                        _targetTileThree.phasing = 2;
                        _targetTileThree.phasingPlacedByAi = true;
                        _targetTileThree.phasingPower = 10;
                    }
                    if (aiStats.GetAiPosHorizontal() >= 0 && aiStats.GetAiPosHorizontal() <= 6 && (aiStats.GetAiPosVertical() - 3) >= 0 && (aiStats.GetAiPosVertical() - 3) <= 4)
                    {
                        GameObject targetTileOne = GameObject.Find("Tile" + aiStats.GetAiPosHorizontal() + "/" + (aiStats.GetAiPosVertical() - 3));
                        Tile _targetTileOne = targetTileOne.GetComponent<Tile>();
                        _targetTileOne.phasing = 2;
                        _targetTileOne.phasingPlacedByAi = true;
                        _targetTileOne.phasingPower = 10;
                    }
                }
                else if (direction == "Right")
                {
                    if ((aiStats.GetAiPosHorizontal() + 1) >= 0 && (aiStats.GetAiPosHorizontal() + 1) <= 6 && aiStats.GetAiPosVertical() >= 0 && aiStats.GetAiPosVertical() <= 4)
                    {
                        GameObject targetTileOne = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() + 1) + "/" + aiStats.GetAiPosVertical());
                        Tile _targetTileOne = targetTileOne.GetComponent<Tile>();
                        _targetTileOne.phasing = 2;
                        _targetTileOne.phasingPlacedByAi = true;
                        _targetTileOne.phasingPower = 10;
                    }
                    if ((aiStats.GetAiPosHorizontal() + 2) >= 0 && (aiStats.GetAiPosHorizontal() + 2) <= 6 && aiStats.GetAiPosVertical() >= 0 && aiStats.GetAiPosVertical() <= 4)
                    {
                        GameObject targetTileOne = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() + 2) + "/" + aiStats.GetAiPosVertical());
                        Tile _targetTileOne = targetTileOne.GetComponent<Tile>();
                        _targetTileOne.phasing = 1;
                        _targetTileOne.phasingPlacedByAi = true;
                        _targetTileOne.phasingPower = 5;
                        GameObject tileOccupiedByTarget = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() +1) + "/" + aiStats.GetAiPosVertical());
                        Transform tileOccupiedByTargetTransform = tileOccupiedByTarget.transform;
                        GameObject target = tileOccupiedByTargetTransform.GetChild(0).gameObject;
                        GameObject targetTile = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() + 2) + "/" + aiStats.GetAiPosVertical());
                        Transform targetTileTransform = targetTile.transform;
                        Tile targetTileClass = targetTile.GetComponent<Tile>();
                        playerStats.SetPosHorizontal(targetTileClass.horizontal);
                        target.transform.position = targetTileTransform.transform.position;
                        target.transform.SetParent(targetTileTransform, true);
                    }
                    if ((aiStats.GetAiPosHorizontal() + 2) >= 0 && (aiStats.GetAiPosHorizontal() + 2) <= 6 && (aiStats.GetAiPosVertical() + 1) >= 0 && (aiStats.GetAiPosVertical() + 1) <= 4)
                    {
                        GameObject targetTileTwo = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() + 2) + "/" + (aiStats.GetAiPosVertical() + 1));
                        Tile _targetTileTwo = targetTileTwo.GetComponent<Tile>();
                        _targetTileTwo.phasing = 2;
                        _targetTileTwo.phasingPlacedByAi = true;
                        _targetTileTwo.phasingPower = 10;
                    }
                    if ((aiStats.GetAiPosHorizontal() + 2) >= 0 && (aiStats.GetAiPosHorizontal() + 2) <= 6 && (aiStats.GetAiPosVertical() - 1) >= 0 && (aiStats.GetAiPosVertical() - 1) <= 4)
                    {
                        GameObject targetTileThree = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() + 2) + "/" + (aiStats.GetAiPosVertical() - 1));
                        Tile _targetTileThree = targetTileThree.GetComponent<Tile>();
                        _targetTileThree.phasing = 2;
                        _targetTileThree.phasingPlacedByAi = true;
                        _targetTileThree.phasingPower = 10;
                    }
                    if ((aiStats.GetAiPosHorizontal() + 3) >= 0 && (aiStats.GetAiPosHorizontal() + 3) <= 6 && aiStats.GetAiPosVertical() >= 0 && aiStats.GetAiPosVertical() <= 4)
                    {
                        GameObject targetTileOne = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() + 3) + "/" + aiStats.GetAiPosVertical());
                        Tile _targetTileOne = targetTileOne.GetComponent<Tile>();
                        _targetTileOne.phasing = 2;
                        _targetTileOne.phasingPlacedByAi = true;
                        _targetTileOne.phasingPower = 10;
                    }
                }
                else if (direction == "minusRight")
                {
                    if ((aiStats.GetAiPosHorizontal() - 1) >= 0 && (aiStats.GetAiPosHorizontal() - 1) <= 6 && aiStats.GetAiPosVertical() >= 0 && aiStats.GetAiPosVertical() <= 4)
                    {
                        GameObject targetTileOne = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() - 1) + "/" + aiStats.GetAiPosVertical());
                        Tile _targetTileOne = targetTileOne.GetComponent<Tile>();
                        _targetTileOne.phasing = 2;
                        _targetTileOne.phasingPlacedByAi = true;
                        _targetTileOne.phasingPower = 10;
                    }
                    if ((aiStats.GetAiPosHorizontal() - 2) >= 0 && (aiStats.GetAiPosHorizontal() - 2) <= 6 && aiStats.GetAiPosVertical() >= 0 && aiStats.GetAiPosVertical() <= 4)
                    {
                        GameObject targetTileOne = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() - 2) + "/" + aiStats.GetAiPosVertical());
                        Tile _targetTileOne = targetTileOne.GetComponent<Tile>();
                        _targetTileOne.phasing = 1;
                        _targetTileOne.phasingPlacedByAi = true;
                        _targetTileOne.phasingPower = 5;
                        GameObject tileOccupiedByTarget = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() - 1) + "/" + aiStats.GetAiPosVertical());
                        Transform tileOccupiedByTargetTransform = tileOccupiedByTarget.transform;
                        GameObject target = tileOccupiedByTargetTransform.GetChild(0).gameObject;
                        GameObject targetTile = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() - 2) + "/" + aiStats.GetAiPosVertical());
                        Transform targetTileTransform = targetTile.transform;
                        Tile targetTileClass = targetTile.GetComponent<Tile>();
                        playerStats.SetPosHorizontal(targetTileClass.horizontal);
                        target.transform.position = targetTileTransform.transform.position;
                        target.transform.SetParent(targetTileTransform, true);
                    }
                    if ((aiStats.GetAiPosHorizontal() - 2) >= 0 && (aiStats.GetAiPosHorizontal() - 2) <= 6 && (aiStats.GetAiPosVertical() + 1) >= 0 && (aiStats.GetAiPosVertical() + 1) <= 4)
                    {
                        GameObject targetTileTwo = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() - 2) + "/" + (aiStats.GetAiPosVertical() + 1));
                        Tile _targetTileTwo = targetTileTwo.GetComponent<Tile>();
                        _targetTileTwo.phasing = 2;
                        _targetTileTwo.phasingPlacedByAi = true;
                        _targetTileTwo.phasingPower = 10;
                    }
                    if ((aiStats.GetAiPosHorizontal() - 2) >= 0 && (aiStats.GetAiPosHorizontal() - 2) <= 6 && (aiStats.GetAiPosVertical() - 1) >= 0 && (aiStats.GetAiPosVertical() - 1) <= 4)
                    {
                        GameObject targetTileThree = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() - 2) + "/" + (aiStats.GetAiPosVertical() - 1));
                        Tile _targetTileThree = targetTileThree.GetComponent<Tile>();
                        _targetTileThree.phasing = 2;
                        _targetTileThree.phasingPlacedByAi = true;
                        _targetTileThree.phasingPower = 10;
                    }
                    if ((aiStats.GetAiPosHorizontal() - 3) >= 0 && (aiStats.GetAiPosHorizontal() - 3) <= 6 && aiStats.GetAiPosVertical() >= 0 && aiStats.GetAiPosVertical() <= 4)
                    {
                        GameObject targetTileOne = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() - 3) + "/" + aiStats.GetAiPosVertical());
                        Tile _targetTileOne = targetTileOne.GetComponent<Tile>();
                        _targetTileOne.phasing = 2;
                        _targetTileOne.phasingPlacedByAi = true;
                        _targetTileOne.phasingPower = 10;
                    }
                }


            }
            if (caster.gameObject.tag == "Player")
            {
                GameObject aiManager = GameObject.Find("AI Manager");
                BaseAiStatsController aiStats = aiManager.GetComponent<BaseAiStatsController>();
                GameObject playerManager = GameObject.Find("Player Manager");
                BasePlayerStatsController playerStats = playerManager.GetComponent<BasePlayerStatsController>();
                if (direction == "Up")
                {
                    if (playerStats.GetPosHorizontal() >= 0 && playerStats.GetPosHorizontal() <= 6 && (playerStats.GetPosVertical() + 1) >= 0 && (playerStats.GetPosVertical() + 1) <= 4)
                    {
                        GameObject targetTileOne = GameObject.Find("Tile" + playerStats.GetPosHorizontal() + "/" + (playerStats.GetPosVertical() + 1));
                        Tile _targetTileOne = targetTileOne.GetComponent<Tile>();
                        _targetTileOne.phasing = 2;
                        _targetTileOne.phasingPlacedByPlayer = true;
                        _targetTileOne.phasingPower = 10;
                    }
                    if (playerStats.GetPosHorizontal() >= 0 && playerStats.GetPosHorizontal() <= 6 && (playerStats.GetPosVertical() + 2) >= 0 && (playerStats.GetPosVertical() + 2) <= 4)
                    {
                        GameObject targetTileOne = GameObject.Find("Tile" + playerStats.GetPosHorizontal() + "/" + (playerStats.GetPosVertical() + 2));
                        Tile _targetTileOne = targetTileOne.GetComponent<Tile>();
                        _targetTileOne.phasing = 1;
                        _targetTileOne.phasingPlacedByPlayer = true;
                        _targetTileOne.phasingPower = 5;
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
                        GameObject targetTileTwo = GameObject.Find("Tile" + (playerStats.GetPosHorizontal() - 1) + "/" + (playerStats.GetPosVertical() + 2));
                        Tile _targetTileTwo = targetTileTwo.GetComponent<Tile>();
                        _targetTileTwo.phasing = 2;
                        _targetTileTwo.phasingPlacedByPlayer = true;
                        _targetTileTwo.phasingPower = 10;
                    }
                    if ((playerStats.GetPosHorizontal() + 1) >= 0 && (playerStats.GetPosHorizontal() + 1) <= 6 && (playerStats.GetPosVertical() + 2) >= 0 && (playerStats.GetPosVertical() + 2) <= 4)
                    {
                        GameObject targetTileThree = GameObject.Find("Tile" + (playerStats.GetPosHorizontal() + 1) + "/" + (playerStats.GetPosVertical() + 2));
                        Tile _targetTileThree = targetTileThree.GetComponent<Tile>();
                        _targetTileThree.phasing = 2;
                        _targetTileThree.phasingPlacedByPlayer = true;
                        _targetTileThree.phasingPower = 10;
                    }
                    if (playerStats.GetPosHorizontal() >= 0 && playerStats.GetPosHorizontal() <= 6 && (playerStats.GetPosVertical() + 3) >= 0 && (playerStats.GetPosVertical() + 3) <= 4)
                    {
                        GameObject targetTileOne = GameObject.Find("Tile" + playerStats.GetPosHorizontal() + "/" + (playerStats.GetPosVertical() + 3));
                        Tile _targetTileOne = targetTileOne.GetComponent<Tile>();
                        _targetTileOne.phasing = 2;
                        _targetTileOne.phasingPlacedByPlayer = true;
                        _targetTileOne.phasingPower = 10;
                    }
                }
                else if (direction == "minusUp")
                {
                    if (playerStats.GetPosHorizontal() >= 0 && playerStats.GetPosHorizontal() <= 6 && (playerStats.GetPosVertical() - 1) >= 0 && (playerStats.GetPosVertical() - 1) <= 4)
                    {
                        GameObject targetTileOne = GameObject.Find("Tile" + playerStats.GetPosHorizontal() + "/" + (playerStats.GetPosVertical() - 1));
                        Tile _targetTileOne = targetTileOne.GetComponent<Tile>();
                        _targetTileOne.phasing = 2;
                        _targetTileOne.phasingPlacedByPlayer = true;
                        _targetTileOne.phasingPower = 10;
                    }
                    if (playerStats.GetPosHorizontal() >= 0 && playerStats.GetPosHorizontal() <= 6 && (playerStats.GetPosVertical() - 2) >= 0 && (playerStats.GetPosVertical() - 2) <= 4)
                    {
                        GameObject targetTileOne = GameObject.Find("Tile" + playerStats.GetPosHorizontal() + "/" + (playerStats.GetPosVertical() - 2));
                        Tile _targetTileOne = targetTileOne.GetComponent<Tile>();
                        _targetTileOne.phasing = 1;
                        _targetTileOne.phasingPlacedByPlayer = true;
                        _targetTileOne.phasingPower = 5;
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
                        GameObject targetTileTwo = GameObject.Find("Tile" + (playerStats.GetPosHorizontal() - 1) + "/" + (playerStats.GetPosVertical() - 2));
                        Tile _targetTileTwo = targetTileTwo.GetComponent<Tile>();
                        _targetTileTwo.phasing = 2;
                        _targetTileTwo.phasingPlacedByPlayer = true;
                        _targetTileTwo.phasingPower = 10;
                    }
                    if ((playerStats.GetPosHorizontal() + 1) >= 0 && (playerStats.GetPosHorizontal() + 1) <= 6 && (playerStats.GetPosVertical() - 2) >= 0 && (playerStats.GetPosVertical() - 2) <= 4)
                    {
                        GameObject targetTileThree = GameObject.Find("Tile" + (playerStats.GetPosHorizontal() + 1) + "/" + (playerStats.GetPosVertical() - 2));
                        Tile _targetTileThree = targetTileThree.GetComponent<Tile>();
                        _targetTileThree.phasing = 2;
                        _targetTileThree.phasingPlacedByPlayer = true;
                        _targetTileThree.phasingPower = 10;
                    }
                    if (playerStats.GetPosHorizontal() >= 0 && playerStats.GetPosHorizontal() <= 6 && (playerStats.GetPosVertical() - 3) >= 0 && (playerStats.GetPosVertical() - 3) <= 4)
                    {
                        GameObject targetTileOne = GameObject.Find("Tile" + playerStats.GetPosHorizontal() + "/" + (playerStats.GetPosVertical() - 3));
                        Tile _targetTileOne = targetTileOne.GetComponent<Tile>();
                        _targetTileOne.phasing = 2;
                        _targetTileOne.phasingPlacedByPlayer = true;
                        _targetTileOne.phasingPower = 10;
                    }
                }
                else if (direction == "Right")
                {
                    if ((playerStats.GetPosHorizontal() + 1) >= 0 && (playerStats.GetPosHorizontal() + 1) <= 6 && playerStats.GetPosVertical() >= 0 && playerStats.GetPosVertical() <= 4)
                    {
                        GameObject targetTileOne = GameObject.Find("Tile" + (playerStats.GetPosHorizontal() + 1) + "/" + playerStats.GetPosVertical());
                        Tile _targetTileOne = targetTileOne.GetComponent<Tile>();
                        _targetTileOne.phasing = 2;
                        _targetTileOne.phasingPlacedByPlayer = true;
                        _targetTileOne.phasingPower = 10;
                    }
                    if ((playerStats.GetPosHorizontal() + 2) >= 0 && (playerStats.GetPosHorizontal() + 2) <= 6 && playerStats.GetPosVertical() >= 0 && playerStats.GetPosVertical() <= 4)
                    {
                        GameObject targetTileOne = GameObject.Find("Tile" + (playerStats.GetPosHorizontal() + 2) + "/" + playerStats.GetPosVertical());
                        Tile _targetTileOne = targetTileOne.GetComponent<Tile>();
                        _targetTileOne.phasing = 1;
                        _targetTileOne.phasingPlacedByPlayer = true;
                        _targetTileOne.phasingPower = 5;
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
                        GameObject targetTileTwo = GameObject.Find("Tile" + (playerStats.GetPosHorizontal() + 2) + "/" + (playerStats.GetPosVertical() + 1));
                        Tile _targetTileTwo = targetTileTwo.GetComponent<Tile>();
                        _targetTileTwo.phasing = 2;
                        _targetTileTwo.phasingPlacedByPlayer = true;
                        _targetTileTwo.phasingPower = 10;
                    }
                    if ((playerStats.GetPosHorizontal() + 2) >= 0 && (playerStats.GetPosHorizontal() + 2) <= 6 && (playerStats.GetPosVertical() - 1) >= 0 && (playerStats.GetPosVertical() - 1) <= 4)
                    {
                        GameObject targetTileThree = GameObject.Find("Tile" + (playerStats.GetPosHorizontal() + 2) + "/" + (playerStats.GetPosVertical() - 1));
                        Tile _targetTileThree = targetTileThree.GetComponent<Tile>();
                        _targetTileThree.phasing = 2;
                        _targetTileThree.phasingPlacedByPlayer = true;
                        _targetTileThree.phasingPower = 10;
                    }
                    if ((playerStats.GetPosHorizontal() + 3) >= 0 && (playerStats.GetPosHorizontal() + 3) <= 6 && playerStats.GetPosVertical() >= 0 && playerStats.GetPosVertical() <= 4)
                    {
                        GameObject targetTileOne = GameObject.Find("Tile" + (playerStats.GetPosHorizontal() + 3) + "/" + playerStats.GetPosVertical());
                        Tile _targetTileOne = targetTileOne.GetComponent<Tile>();
                        _targetTileOne.phasing = 2;
                        _targetTileOne.phasingPlacedByPlayer = true;
                        _targetTileOne.phasingPower = 10;
                    }
                }
                else if (direction == "minusRight")
                {
                    if ((playerStats.GetPosHorizontal() - 1) >= 0 && (playerStats.GetPosHorizontal() - 1) <= 6 && playerStats.GetPosVertical() >= 0 && playerStats.GetPosVertical() <= 4)
                    {
                        GameObject targetTileOne = GameObject.Find("Tile" + (playerStats.GetPosHorizontal() - 1) + "/" + playerStats.GetPosVertical());
                        Tile _targetTileOne = targetTileOne.GetComponent<Tile>();
                        _targetTileOne.phasing = 2;
                        _targetTileOne.phasingPlacedByPlayer = true;
                        _targetTileOne.phasingPower = 10;
                    }
                    if ((playerStats.GetPosHorizontal() - 2) >= 0 && (playerStats.GetPosHorizontal() - 2) <= 6 && playerStats.GetPosVertical() >= 0 && playerStats.GetPosVertical() <= 4)
                    {
                        GameObject targetTileOne = GameObject.Find("Tile" + (playerStats.GetPosHorizontal() - 2) + "/" + playerStats.GetPosVertical());
                        Tile _targetTileOne = targetTileOne.GetComponent<Tile>();
                        _targetTileOne.phasing = 1;
                        _targetTileOne.phasingPlacedByPlayer = true;
                        _targetTileOne.phasingPower = 5;
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
                        GameObject targetTileTwo = GameObject.Find("Tile" + (playerStats.GetPosHorizontal() - 2) + "/" + (playerStats.GetPosVertical() + 1));
                        Tile _targetTileTwo = targetTileTwo.GetComponent<Tile>();
                        _targetTileTwo.phasing = 2;
                        _targetTileTwo.phasingPlacedByPlayer = true;
                        _targetTileTwo.phasingPower = 10;
                    }
                    if ((playerStats.GetPosHorizontal() - 2) >= 0 && (playerStats.GetPosHorizontal() - 2) <= 6 && (playerStats.GetPosVertical() - 1) >= 0 && (playerStats.GetPosVertical() - 1) <= 4)
                    {
                        GameObject targetTileThree = GameObject.Find("Tile" + (playerStats.GetPosHorizontal() - 2) + "/" + (playerStats.GetPosVertical() - 1));
                        Tile _targetTileThree = targetTileThree.GetComponent<Tile>();
                        _targetTileThree.phasing = 2;
                        _targetTileThree.phasingPlacedByPlayer = true;
                        _targetTileThree.phasingPower = 10;
                    }
                    if ((playerStats.GetPosHorizontal() - 3) >= 0 && (playerStats.GetPosHorizontal() - 3) <= 6 && playerStats.GetPosVertical() >= 0 && playerStats.GetPosVertical() <= 4)
                    {
                        GameObject targetTileOne = GameObject.Find("Tile" + (playerStats.GetPosHorizontal() - 3) + "/" + playerStats.GetPosVertical());
                        Tile _targetTileOne = targetTileOne.GetComponent<Tile>();
                        _targetTileOne.phasing = 2;
                        _targetTileOne.phasingPlacedByPlayer = true;
                        _targetTileOne.phasingPower = 10;
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

