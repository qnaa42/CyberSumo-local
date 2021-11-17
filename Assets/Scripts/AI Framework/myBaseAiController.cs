using System.Collections;
using System.Collections.Generic;
using myAiStates;
using UnityEngine;

namespace GPC
{

    public class myBaseAiController : ExtendedCustomMonoBehaviour
    {
        public bool AiControlled;

        public GameObject playerStats;
        public GameObject aiStats;

        [Header("AI States")]
        public myAiState currentAiState;
        public myAiState targetAiState;

        [Header("AI Position")]
        public GameObject AI;
        public int aiHorzintal;
        public int aiVertical;

        [Header("Player Position")]
        public GameObject Player;
        public int playerHorizontal;
        public int playerVertical;

        [Header("Position To Target tracker")]
        public int NumberOfTilesInBetween;
        public bool isPresentUp;
        public bool isPresentMinusUp;
        public bool isPresentRight;
        public bool isPresentMinusRight;

        [Header("Tile Manager")]
        public GameObject thisTile;
        public GameObject targetTile;
        public GameObject playerTile;

        [Header("Other Stats")]
        public bool reachedTarget;
        public bool continueActionNextTurn;

        [Header("Layer masks and raycasting")]
        public LayerMask targetLayer;
        public string potentialTargetTag = "Player";
        public int obstacleFinderResult;

        private RaycastHit hit;

        // Start is called before the first frame update
        void Start()
        {
            Init();
            playerStats = GameObject.Find("Player Manager");
            aiStats = GameObject.Find("AI Manager");
        }

        public virtual void Init()
        {
            _GO = gameObject;

            _TR = transform;

            _RB2D = _TR.GetComponent<Rigidbody2D>();

            didInit = true;
        }

        public void SetAiControl(bool state)
        {
            AiControlled = state;
        }

        public void SetNumberOfTilesInBetween(int anAmount)
        {
            NumberOfTilesInBetween = anAmount;
        }

        public virtual void SetAiState(myAiState newState)
        {
            targetAiState = newState;
            UpdateTargetAiState();
        }

        public virtual void SetPlayer(GameObject player)
        {
            Player = player;
        }


        public virtual void Update()
        {
            if (!didInit)
                Init();

            if (!AiControlled)
                return;

            UpdateCurrentAiState();

        }

        public virtual void UpdateCurrentAiState()
        {
            BaseAiStatsController _aiStats = aiStats.GetComponent<BaseAiStatsController>();
            aiHorzintal = _aiStats.GetAiPosHorizontal();
            aiVertical = _aiStats.GetAiPosVertical();

            switch (currentAiState)
            {
                case myAiState.paused_no_player:
                    break;

                default:
                    break;
            }
        }

        public virtual void UpdateTargetAiState()
        {
            switch(targetAiState)
            {
                default:
                    break;
            }

            currentAiState = targetAiState;
        }

        public virtual void LookForPlayer()
        {
            GameObject tileOcuupiedByPlayer = Player.transform.gameObject.

        }

    }
}
