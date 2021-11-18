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
                    GameObject targetTileOne = GameObject.Find("Tile" + aiStats.GetAiPosHorizontal() + "/" + (aiStats.GetAiPosVertical() + 1));
                    GameObject targetTileTwo = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() - 1) + "/" + (aiStats.GetAiPosVertical() + 1));
                    GameObject targetTileThree = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() + 1) + "/" + (aiStats.GetAiPosVertical() + 1));
                    Tile _targetTileOne = targetTileOne.GetComponent<Tile>();
                    Tile _targetTileTwo = targetTileTwo.GetComponent<Tile>();
                    Tile _targetTileThree = targetTileThree.GetComponent<Tile>();
                    _targetTileOne.phasing = 3;
                    _targetTileTwo.phasing = 3;
                    _targetTileThree.phasing = 3;
                }
                else if (direction == "minusUp")
                {
                    GameObject targetTileOne = GameObject.Find("Tile" + aiStats.GetAiPosHorizontal() + "/" + (aiStats.GetAiPosVertical() - 1));
                    GameObject targetTileTwo = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() - 1) + "/" + (aiStats.GetAiPosVertical() - 1));
                    GameObject targetTileThree = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() + 1) + "/" + (aiStats.GetAiPosVertical() - 1));
                    Tile _targetTileOne = targetTileOne.GetComponent<Tile>();
                    Tile _targetTileTwo = targetTileTwo.GetComponent<Tile>();
                    Tile _targetTileThree = targetTileThree.GetComponent<Tile>();
                    _targetTileOne.phasing = 3;
                    _targetTileTwo.phasing = 3;
                    _targetTileThree.phasing = 3;
                }
                else if (direction == "Right")
                {
                    GameObject targetTileOne = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() + 1) + "/" + aiStats.GetAiPosVertical());
                    GameObject targetTileTwo = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() + 1) + "/" + (aiStats.GetAiPosVertical() + 1));
                    GameObject targetTileThree = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() + 1) + "/" + (aiStats.GetAiPosVertical() - 1));
                    Tile _targetTileOne = targetTileOne.GetComponent<Tile>();
                    Tile _targetTileTwo = targetTileTwo.GetComponent<Tile>();
                    Tile _targetTileThree = targetTileThree.GetComponent<Tile>();
                    _targetTileOne.phasing = 3;
                    _targetTileTwo.phasing = 3;
                    _targetTileThree.phasing = 3;
                }
                else if (direction == "minusRight")
                {
                    GameObject targetTileOne = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() - 1) + "/" + aiStats.GetAiPosVertical());
                    GameObject targetTileTwo = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() - 1) + "/" + (aiStats.GetAiPosVertical() + 1));
                    GameObject targetTileThree = GameObject.Find("Tile" + (aiStats.GetAiPosHorizontal() - 1) + "/" + (aiStats.GetAiPosVertical() - 1));
                    Tile _targetTileOne = targetTileOne.GetComponent<Tile>();
                    Tile _targetTileTwo = targetTileTwo.GetComponent<Tile>();
                    Tile _targetTileThree = targetTileThree.GetComponent<Tile>();
                    _targetTileOne.phasing = 3;
                    _targetTileTwo.phasing = 3;
                    _targetTileThree.phasing = 3;
                }
            }
        }
        public void ClickTestAttack()
        {
            SimpleAttack(player, "right");
        }
    }
}

