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

        public void SimpleAttack(GameObject caster)
        {
            if (caster.gameObject.tag == "Player")
            {
                BasePlayerStatsController _playerStats = caster.gameObject.GetComponent<BasePlayerStatsController>();
                GameObject tagetTile = GameObject.Find("Tile" + (_playerStats.GetPosHorizontal() + 1) + "/" + _playerStats.GetPosVertical());
                Tile _targetTile = tagetTile.gameObject.GetComponent<Tile>();
                _targetTile.phasing = 3;
            }
        }
        public void ClickTestAttack()
        {
            SimpleAttack(player);
        }
    }
}

