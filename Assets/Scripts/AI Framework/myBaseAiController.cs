using System.Collections;
using System.Collections.Generic;
using myAiStates;
using UnityEngine;

namespace GPC
{

    public class myBaseAiController : ExtendedCustomMonoBehaviour
    {
        public SpellDeck spellDeck;
        public bool AiControlled;

        public GameObject aiToken;

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
        public int NumberOfTilesInBetweenHorizontal;
        public int NumberOfTilesInBetweenVertical;
        public bool isNotPresentInLine;
        public bool isPresentUpAdjTile;
        public bool isPresentUp;
        public bool isPresentMinusUpTile;
        public bool isPresentMinusUp;
        public bool isPresentRightTile;
        public bool isPresentRight;
        public bool isPresentMinusRightTile;
        public bool isPresentMinusRight;

        public bool isCentreTileUp;
        public bool isCentreTileMinusUp;
        public bool isCentreTileUpInLine;
        public bool isCentreTileMinusUpInLine;
        public bool isCentreTileRight;
        public bool isCentreTileMinusRight;
        public bool isCentreTileRightInLine;
        public bool isCentreTileMinusRightInline;

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
        public void SetNumberOfTilesInBetweenHorizontal(int anAmount)
        {
            NumberOfTilesInBetweenHorizontal = anAmount;
        }
        public void SetNumberOfTilesInBetweenVertical(int anAmount)
        {
            NumberOfTilesInBetweenVertical = anAmount;
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
            AIToken _aiToken = aiToken.gameObject.GetComponent<AIToken>();
            _aiStats.SetAiDetails(_aiToken.id);
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
            aiToken = GameObject.Find("AiToken(Clone)");
            Player = GameObject.Find("PlayerToken(Clone)");
            GameObject tileOcuupiedByPlayer = Player.transform.parent.gameObject;
            Tile _tile = tileOcuupiedByPlayer.gameObject.GetComponent<Tile>();
            AIToken _aiToken = aiToken.gameObject.GetComponent<AIToken>();
            BaseAiStatsController _aiStats = aiStats.gameObject.GetComponent<BaseAiStatsController>();
 //           _aiStats.SetAiDetails(_aiToken.id);

            if(_tile.vertical == (_aiStats.GetAiPosVertical() + 1) && _tile.horizontal == (_aiStats.GetAiPosHorizontal()))
            {
                isNotPresentInLine = false;
                isPresentUpAdjTile = true;
                isPresentUp = false;
                isPresentMinusUpTile = false;
                isPresentMinusUp = false;
                isPresentRightTile = false;
                isPresentRight = false;
                isPresentMinusRightTile = false;
                isPresentMinusRight = false;
                SetNumberOfTilesInBetweenHorizontal(_aiStats.GetAiPosHorizontal() - _tile.horizontal);
                SetNumberOfTilesInBetweenVertical(_aiStats.GetAiPosVertical() - _tile.vertical);
            }
            else if(_tile.vertical > (_aiStats.GetAiPosVertical() + 1) && _tile.horizontal == (_aiStats.GetAiPosHorizontal()))
            {
                isNotPresentInLine = false;
                isPresentUpAdjTile = false;
                isPresentUp = true;
                isPresentMinusUpTile = false;
                isPresentMinusUp = false;
                isPresentRightTile = false;
                isPresentRight = false;
                isPresentMinusRightTile = false;
                isPresentMinusRight = false;
                SetNumberOfTilesInBetweenHorizontal(_aiStats.GetAiPosHorizontal() - _tile.horizontal);
                SetNumberOfTilesInBetweenVertical(_aiStats.GetAiPosVertical() - _tile.vertical);
            }
            else if(_tile.vertical == (_aiStats.GetAiPosVertical() - 1) && _tile.horizontal == (_aiStats.GetAiPosHorizontal()))
            {
                isNotPresentInLine = false;
                isPresentUpAdjTile = false;
                isPresentUp = false;
                isPresentMinusUpTile = true;
                isPresentMinusUp = false;
                isPresentRightTile = false;
                isPresentRight = false;
                isPresentMinusRightTile = false;
                isPresentMinusRight = false;
                SetNumberOfTilesInBetweenHorizontal(_aiStats.GetAiPosHorizontal() - _tile.horizontal);
                SetNumberOfTilesInBetweenVertical(_aiStats.GetAiPosVertical() - _tile.vertical);
            }
            else if (_tile.vertical < (_aiStats.GetAiPosVertical() - 1) && _tile.horizontal == (_aiStats.GetAiPosHorizontal()))
            {
                isNotPresentInLine = false;
                isPresentUpAdjTile = false;
                isPresentUp = false;
                isPresentMinusUpTile = false;
                isPresentMinusUp = true;
                isPresentRightTile = false;
                isPresentRight = false;
                isPresentMinusRightTile = false;
                isPresentMinusRight = false;
                SetNumberOfTilesInBetweenHorizontal(_aiStats.GetAiPosHorizontal() - _tile.horizontal);
                SetNumberOfTilesInBetweenVertical(_aiStats.GetAiPosVertical() - _tile.vertical);
            }
            else if(_tile.vertical == (_aiStats.GetAiPosVertical())  && _tile.horizontal == (_aiStats.GetAiPosHorizontal() +1))
            {
                isNotPresentInLine = false;
                isPresentUpAdjTile = false;
                isPresentUp = false;
                isPresentMinusUpTile = false;
                isPresentMinusUp = false;
                isPresentRightTile = true;
                isPresentRight = false;
                isPresentMinusRightTile = false;
                isPresentMinusRight = false;
                SetNumberOfTilesInBetweenHorizontal(_aiStats.GetAiPosHorizontal() - _tile.horizontal);
                SetNumberOfTilesInBetweenVertical(_aiStats.GetAiPosVertical() - _tile.vertical);
            }
            else if (_tile.vertical == (_aiStats.GetAiPosVertical()) && _tile.horizontal > (_aiStats.GetAiPosHorizontal() + 1))
            {
                isNotPresentInLine = false;
                isPresentUpAdjTile = false;
                isPresentUp = false;
                isPresentMinusUpTile = false;
                isPresentMinusUp = false;
                isPresentRightTile = false;
                isPresentRight = true;
                isPresentMinusRightTile = false;
                isPresentMinusRight = false;
                SetNumberOfTilesInBetweenHorizontal(_aiStats.GetAiPosHorizontal() - _tile.horizontal);
                SetNumberOfTilesInBetweenVertical(_aiStats.GetAiPosVertical() - _tile.vertical);
            }
            else if (_tile.vertical == (_aiStats.GetAiPosVertical()) && _tile.horizontal == (_aiStats.GetAiPosHorizontal() - 1))
            {
                isNotPresentInLine = false;
                isPresentUpAdjTile = false;
                isPresentUp = false;
                isPresentMinusUpTile = false;
                isPresentMinusUp = false;
                isPresentRightTile = false;
                isPresentRight = false;
                isPresentMinusRightTile = true;
                isPresentMinusRight = false;
                SetNumberOfTilesInBetweenHorizontal(_aiStats.GetAiPosHorizontal() - _tile.horizontal);
                SetNumberOfTilesInBetweenVertical(_aiStats.GetAiPosVertical() - _tile.vertical);
            }
            else if (_tile.vertical == (_aiStats.GetAiPosVertical()) && _tile.horizontal < (_aiStats.GetAiPosHorizontal() - 1))
            {
                isNotPresentInLine = false;
                isPresentUpAdjTile = false;
                isPresentUp = false;
                isPresentMinusUpTile = false;
                isPresentMinusUp = false;
                isPresentRightTile = false;
                isPresentRight = false;
                isPresentMinusRightTile = false;
                isPresentMinusRight = true;
                SetNumberOfTilesInBetweenHorizontal(_aiStats.GetAiPosHorizontal() - _tile.horizontal);
                SetNumberOfTilesInBetweenVertical(_aiStats.GetAiPosVertical() - _tile.vertical);
            }
            else
            {
                isNotPresentInLine = true;
                isPresentUpAdjTile = false;
                isPresentUp = false;
                isPresentMinusUpTile = false;
                isPresentMinusUp = false;
                isPresentRightTile = false;
                isPresentRight = false;
                isPresentMinusRightTile = false;
                isPresentMinusRight = false;
                SetNumberOfTilesInBetweenHorizontal(_aiStats.GetAiPosHorizontal() - _tile.horizontal);
                SetNumberOfTilesInBetweenVertical(_aiStats.GetAiPosVertical() - _tile.vertical);
            }

        }
        public void MoveTowardsPlayer()
        {
            BaseAiStatsController _aiStats = aiStats.GetComponent<BaseAiStatsController>();
            GameObject tileOcuupiedByPlayer = Player.transform.parent.gameObject;
            BasePlayerStatsController _playerStats = playerStats.GetComponent<BasePlayerStatsController>();

            for (int i = 0; i <= _aiStats.GetAiMoveCounterNow(); i++)
            {
                GameObject tileOccupiedByAi = aiToken.transform.parent.gameObject;

                if ((!isPresentUpAdjTile && !isPresentMinusUpTile && !isPresentRightTile && !isPresentMinusRightTile && isPresentUp) || (isNotPresentInLine|| isPresentMinusUp || isPresentRight || isPresentMinusRight))
                {
                    if (isPresentUp && NumberOfTilesInBetweenHorizontal == 0 && NumberOfTilesInBetweenVertical != 0)
                    {
                        GameObject targetTile = GameObject.Find("Tile" + _aiStats.GetAiPosHorizontal() + "/" + (_aiStats.GetAiPosVertical() +1));
                        Transform targetTileTransform = targetTile.transform;
                        aiToken.transform.position = targetTileTransform.transform.position;
                        aiToken.transform.SetParent(targetTileTransform, true);
                        GameObject nowTile = aiToken.transform.parent.gameObject;
                        Tile nowTileStats = nowTile.GetComponent<Tile>();
                        _aiStats.SetAiPosHorizontal(nowTileStats.horizontal);
                        _aiStats.SetAiPosVertical(nowTileStats.vertical);
                        _aiStats.ReduceAiMoveCounterNow(1);
                        LookForPlayer();
                        Debug.Log("Ai Move 1 Tile up");
                    }
                    else if (isPresentMinusUp  && NumberOfTilesInBetweenHorizontal == 0 && NumberOfTilesInBetweenVertical != 0)
                    {
                        GameObject targetTile = GameObject.Find("Tile" + _aiStats.GetAiPosHorizontal() + "/" + (_aiStats.GetAiPosVertical() - 1));
                        Transform targetTileTransform = targetTile.transform;
                        aiToken.transform.position = targetTileTransform.transform.position;
                        aiToken.transform.SetParent(targetTileTransform, true);
                        GameObject nowTile = aiToken.transform.parent.gameObject;
                        Tile nowTileStats = nowTile.GetComponent<Tile>();
                        _aiStats.SetAiPosHorizontal(nowTileStats.horizontal);
                        _aiStats.SetAiPosVertical(nowTileStats.vertical);
                        _aiStats.ReduceAiMoveCounterNow(1);
                        LookForPlayer();
                        Debug.Log("Ai Move 1 Tile minus up");
                    }
                    else if (isPresentRight && NumberOfTilesInBetweenHorizontal != 0 && NumberOfTilesInBetweenVertical == 0)
                    {
                        GameObject targetTile = GameObject.Find("Tile" + (_aiStats.GetAiPosHorizontal() + 1) + "/" + _aiStats.GetAiPosVertical());
                        Transform targetTileTransform = targetTile.transform;
                        aiToken.transform.position = targetTileTransform.transform.position;
                        aiToken.transform.SetParent(targetTileTransform, true);
                        GameObject nowTile = aiToken.transform.parent.gameObject;
                        Tile nowTileStats = nowTile.GetComponent<Tile>();
                        _aiStats.SetAiPosHorizontal(nowTileStats.horizontal);
                        _aiStats.SetAiPosVertical(nowTileStats.vertical);
                        _aiStats.ReduceAiMoveCounterNow(1);
                        LookForPlayer();
                        Debug.Log("Ai Move 1 Tile right");
                    }
                    else if (isPresentMinusRight && NumberOfTilesInBetweenHorizontal != 0 && NumberOfTilesInBetweenVertical == 0)
                    {
                        GameObject targetTile = GameObject.Find("Tile" + (_aiStats.GetAiPosHorizontal() - 1) + "/" + _aiStats.GetAiPosVertical());
                        Transform targetTileTransform = targetTile.transform;
                        aiToken.transform.position = targetTileTransform.transform.position;
                        aiToken.transform.SetParent(targetTileTransform, true);
                        GameObject nowTile = aiToken.transform.parent.gameObject;
                        Tile nowTileStats = nowTile.GetComponent<Tile>();
                        _aiStats.SetAiPosHorizontal(nowTileStats.horizontal);
                        _aiStats.SetAiPosVertical(nowTileStats.vertical);
                        _aiStats.ReduceAiMoveCounterNow(1);
                        LookForPlayer();
                        Debug.Log("Ai Move 1 Tile minus right");
                    }
                    else if (isNotPresentInLine && NumberOfTilesInBetweenHorizontal != 0 && NumberOfTilesInBetweenVertical !=0)
                    {
                        GameObject centreTile = GameObject.Find("Tile" + _playerStats.GetPosHorizontal() + "/" + _playerStats.GetPosVertical());
                        Tile centreTileClass = centreTile.GetComponent<Tile>();
                        var centreTileHorizontal = centreTileClass.horizontal;
                        var CentreTileVertical = centreTileClass.vertical;
                        var x = _aiStats.GetAiPosHorizontal() - centreTileHorizontal;
                        var y = _aiStats.GetAiPosVertical() - CentreTileVertical;
                        if (x < 0)
                        {
                            if (y == 0)
                            {
                                isCentreTileRightInLine = true;
                                isCentreTileMinusRightInline = false;
                                isCentreTileUp = false;
                                isCentreTileMinusUp = false;
                                GameObject targetTile = GameObject.Find("Tile" + (_aiStats.GetAiPosHorizontal() + 1) + "/" + _aiStats.GetAiPosVertical());
                                Transform targetTileTransform = targetTile.transform;
                                aiToken.transform.position = targetTileTransform.transform.position;
                                aiToken.transform.SetParent(targetTileTransform, true);
                                GameObject nowTile = aiToken.transform.parent.gameObject;
                                Tile nowTileStats = nowTile.GetComponent<Tile>();
                                _aiStats.SetAiPosHorizontal(nowTileStats.horizontal);
                                _aiStats.SetAiPosVertical(nowTileStats.vertical);
                                _aiStats.ReduceAiMoveCounterNow(1);
                                LookForPlayer();
                                Debug.Log("Ai Move 1 Tile right");
                            }
                            isCentreTileRight = true;
                            isCentreTileMinusRight = false;
                            x = -x;

                        }
                        else if (x > 0)
                        {
                            if (y == 0)
                            {
                                isCentreTileRightInLine = false;
                                isCentreTileMinusRightInline = true;
                                isCentreTileUp = false;
                                isCentreTileMinusUp = false;
                                GameObject targetTile = GameObject.Find("Tile" + (_aiStats.GetAiPosHorizontal() - 1) + "/" + _aiStats.GetAiPosVertical());
                                Transform targetTileTransform = targetTile.transform;
                                aiToken.transform.position = targetTileTransform.transform.position;
                                aiToken.transform.SetParent(targetTileTransform, true);
                                GameObject nowTile = aiToken.transform.parent.gameObject;
                                Tile nowTileStats = nowTile.GetComponent<Tile>();
                                _aiStats.SetAiPosHorizontal(nowTileStats.horizontal);
                                _aiStats.SetAiPosVertical(nowTileStats.vertical);
                                _aiStats.ReduceAiMoveCounterNow(1);
                                LookForPlayer();
                                Debug.Log("Ai Move 1 Tile minus right");
                            }
                            isCentreTileRight = false;
                            isCentreTileMinusRight = true;
                        }
                        if (y < 0)
                        {
                            if(x == 0)
                            {
                                isCentreTileRight = false;
                                isCentreTileMinusRight = false;
                                isCentreTileUpInLine = true;
                                isCentreTileMinusUpInLine = false;
                                GameObject targetTile = GameObject.Find("Tile" + _aiStats.GetAiPosHorizontal() + "/" + (_aiStats.GetAiPosVertical() + 1));
                                Transform targetTileTransform = targetTile.transform;
                                aiToken.transform.position = targetTileTransform.transform.position;
                                aiToken.transform.SetParent(targetTileTransform, true);
                                GameObject nowTile = aiToken.transform.parent.gameObject;
                                Tile nowTileStats = nowTile.GetComponent<Tile>();
                                _aiStats.SetAiPosHorizontal(nowTileStats.horizontal);
                                _aiStats.SetAiPosVertical(nowTileStats.vertical);
                                _aiStats.ReduceAiMoveCounterNow(1);
                                LookForPlayer();
                                Debug.Log("Ai Move 1 Tile up");
                            }
                            isCentreTileUp = true;
                            isCentreTileMinusUp = false;
                            y = -y;
                        }
                        else if (y > 0)
                        {
                            if(x == 0)
                            {
                                isCentreTileUpInLine = false;
                                isCentreTileMinusUpInLine = true;
                                isCentreTileUpInLine = true;
                                isCentreTileMinusUpInLine = false;
                                GameObject targetTile = GameObject.Find("Tile" + _aiStats.GetAiPosHorizontal() + "/" + (_aiStats.GetAiPosVertical() - 1));
                                Transform targetTileTransform = targetTile.transform;
                                aiToken.transform.position = targetTileTransform.transform.position;
                                aiToken.transform.SetParent(targetTileTransform, true);
                                GameObject nowTile = aiToken.transform.parent.gameObject;
                                Tile nowTileStats = nowTile.GetComponent<Tile>();
                                _aiStats.SetAiPosHorizontal(nowTileStats.horizontal);
                                _aiStats.SetAiPosVertical(nowTileStats.vertical);
                                _aiStats.ReduceAiMoveCounterNow(1);
                                LookForPlayer();
                                Debug.Log("Ai Move 1 Tile minus up");
                            }
                            isCentreTileUp = false;
                            isCentreTileMinusUp = true;
                        }
                        if (x > y)
                        {
                            if(isCentreTileUp && !isCentreTileMinusUp)
                            {
                                GameObject targetTile = GameObject.Find("Tile" + _aiStats.GetAiPosHorizontal() + "/" + (_aiStats.GetAiPosVertical() + 1));
                                Transform targetTileTransform = targetTile.transform;
                                aiToken.transform.position = targetTileTransform.transform.position;
                                aiToken.transform.SetParent(targetTileTransform, true);
                                GameObject nowTile = aiToken.transform.parent.gameObject;
                                Tile nowTileStats = nowTile.GetComponent<Tile>();
                                _aiStats.SetAiPosHorizontal(nowTileStats.horizontal);
                                _aiStats.SetAiPosVertical(nowTileStats.vertical);
                                _aiStats.ReduceAiMoveCounterNow(1);
                                LookForPlayer();
                                Debug.Log("Ai Move 1 Tile up");
                                //Ruszam w Gore
                            }
                            else if(!isCentreTileUp && isCentreTileMinusUp)
                            {
                                GameObject targetTile = GameObject.Find("Tile" + _aiStats.GetAiPosHorizontal() + "/" + (_aiStats.GetAiPosVertical() - 1));
                                Transform targetTileTransform = targetTile.transform;
                                aiToken.transform.position = targetTileTransform.transform.position;
                                aiToken.transform.SetParent(targetTileTransform, true);
                                GameObject nowTile = aiToken.transform.parent.gameObject;
                                Tile nowTileStats = nowTile.GetComponent<Tile>();
                                _aiStats.SetAiPosHorizontal(nowTileStats.horizontal);
                                _aiStats.SetAiPosVertical(nowTileStats.vertical);
                                _aiStats.ReduceAiMoveCounterNow(1);
                                LookForPlayer();
                                Debug.Log("Ai Move 1 Tile minus up");
                                //ruszam w dol
                            }
                        }
                        else if (x < y)
                        {
                            if(isCentreTileRight && !isCentreTileMinusRight)
                            {
                                GameObject targetTile = GameObject.Find("Tile" + (_aiStats.GetAiPosHorizontal() + 1) + "/" + _aiStats.GetAiPosVertical());
                                Transform targetTileTransform = targetTile.transform;
                                aiToken.transform.position = targetTileTransform.transform.position;
                                aiToken.transform.SetParent(targetTileTransform, true);
                                GameObject nowTile = aiToken.transform.parent.gameObject;
                                Tile nowTileStats = nowTile.GetComponent<Tile>();
                                _aiStats.SetAiPosHorizontal(nowTileStats.horizontal);
                                _aiStats.SetAiPosVertical(nowTileStats.vertical);
                                _aiStats.ReduceAiMoveCounterNow(1);
                                LookForPlayer();
                                Debug.Log("Ai Move 1 Tile right");
                                //ruszam w prawo
                            }
                            else if(!isCentreTileRight && isCentreTileMinusRight)
                            {
                                GameObject targetTile = GameObject.Find("Tile" + (_aiStats.GetAiPosHorizontal() - 1) + "/" + _aiStats.GetAiPosVertical());
                                Transform targetTileTransform = targetTile.transform;
                                aiToken.transform.position = targetTileTransform.transform.position;
                                aiToken.transform.SetParent(targetTileTransform, true);
                                GameObject nowTile = aiToken.transform.parent.gameObject;
                                Tile nowTileStats = nowTile.GetComponent<Tile>();
                                _aiStats.SetAiPosHorizontal(nowTileStats.horizontal);
                                _aiStats.SetAiPosVertical(nowTileStats.vertical);
                                _aiStats.ReduceAiMoveCounterNow(1);
                                LookForPlayer();
                                Debug.Log("Ai Move 1 Tile minus right");
                                //ruszam w lewo
                            }
                        }
                        else if (x == y)
                        {
                            int random = Random.Range(1, 100);
                            if (random >= 0 && random <= 50)
                            {
                                if (isCentreTileUp && !isCentreTileMinusUp)
                                {
                                    GameObject targetTile = GameObject.Find("Tile" + _aiStats.GetAiPosHorizontal() + "/" + (_aiStats.GetAiPosVertical() + 1));
                                    Transform targetTileTransform = targetTile.transform;
                                    aiToken.transform.position = targetTileTransform.transform.position;
                                    aiToken.transform.SetParent(targetTileTransform, true);
                                    GameObject nowTile = aiToken.transform.parent.gameObject;
                                    Tile nowTileStats = nowTile.GetComponent<Tile>();
                                    _aiStats.SetAiPosHorizontal(nowTileStats.horizontal);
                                    _aiStats.SetAiPosVertical(nowTileStats.vertical);
                                    _aiStats.ReduceAiMoveCounterNow(1);
                                    LookForPlayer();
                                    Debug.Log("Ai Move 1 Tile up");
                                    //Ruszam w Gore
                                }
                                else if (!isCentreTileUp && isCentreTileMinusUp)
                                {
                                    GameObject targetTile = GameObject.Find("Tile" + _aiStats.GetAiPosHorizontal() + "/" + (_aiStats.GetAiPosVertical() - 1));
                                    Transform targetTileTransform = targetTile.transform;
                                    aiToken.transform.position = targetTileTransform.transform.position;
                                    aiToken.transform.SetParent(targetTileTransform, true);
                                    GameObject nowTile = aiToken.transform.parent.gameObject;
                                    Tile nowTileStats = nowTile.GetComponent<Tile>();
                                    _aiStats.SetAiPosHorizontal(nowTileStats.horizontal);
                                    _aiStats.SetAiPosVertical(nowTileStats.vertical);
                                    _aiStats.ReduceAiMoveCounterNow(1);
                                    LookForPlayer();
                                    Debug.Log("Ai Move 1 Tile minus up");
                                    //ruszam w dol
                                }


                            }
                            else if(random > 50 && random <= 100)
                            {
                                if (isCentreTileRight && !isCentreTileMinusRight)
                                {
                                    GameObject targetTile = GameObject.Find("Tile" + (_aiStats.GetAiPosHorizontal() + 1) + "/" + _aiStats.GetAiPosVertical());
                                    Transform targetTileTransform = targetTile.transform;
                                    aiToken.transform.position = targetTileTransform.transform.position;
                                    aiToken.transform.SetParent(targetTileTransform, true);
                                    GameObject nowTile = aiToken.transform.parent.gameObject;
                                    Tile nowTileStats = nowTile.GetComponent<Tile>();
                                    _aiStats.SetAiPosHorizontal(nowTileStats.horizontal);
                                    _aiStats.SetAiPosVertical(nowTileStats.vertical);
                                    _aiStats.ReduceAiMoveCounterNow(1);
                                    LookForPlayer();
                                    Debug.Log("Ai Move 1 Tile right");
                                    //ruszam w prawo
                                }
                                else if (!isCentreTileRight && isCentreTileMinusRight)
                                {
                                    GameObject targetTile = GameObject.Find("Tile" + (_aiStats.GetAiPosHorizontal() - 1) + "/" + _aiStats.GetAiPosVertical());
                                    Transform targetTileTransform = targetTile.transform;
                                    aiToken.transform.position = targetTileTransform.transform.position;
                                    aiToken.transform.SetParent(targetTileTransform, true);
                                    GameObject nowTile = aiToken.transform.parent.gameObject;
                                    Tile nowTileStats = nowTile.GetComponent<Tile>();
                                    _aiStats.SetAiPosHorizontal(nowTileStats.horizontal);
                                    _aiStats.SetAiPosVertical(nowTileStats.vertical);
                                    _aiStats.ReduceAiMoveCounterNow(1);
                                    LookForPlayer();
                                    Debug.Log("Ai Move 1 Tile minus right");
                                    //ruszam w lewo
                                }

                            }
                        }




                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
        }

        public void AttackPlayer()
        {
            BaseAiStatsController _aiStats = aiStats.GetComponent<BaseAiStatsController>();
            BasePlayerStatsController _playerStats = playerStats.GetComponent<BasePlayerStatsController>();
            for (int i = 0; i <= _aiStats.GetAiActionCounterNow(); i++)
            {
                if ((!isNotPresentInLine && !isPresentUp && !isPresentMinusUp && !isPresentRight && !isPresentMinusRight) && (isPresentUpAdjTile || isPresentMinusUpTile || isPresentRight || isPresentRightTile))
                {
                    _playerStats.ReduceHealth(5);
                    _aiStats.ReduceAiActionCounterNow(1);
                    Debug.Log("Player Get Hit - 5 hp!");

                    if (isPresentUpAdjTile && NumberOfTilesInBetweenHorizontal == 0 && NumberOfTilesInBetweenVertical != 0)
                    {
                        int x = Random.Range(0, 100);
                        if (x >= 0 && x <= 50)
                        {
                            spellDeck.SimpleAttack(aiToken, "Up");
                            LookForPlayer();
                            _aiStats.ReduceAiActionCounterNow(1);
                        }
                        if (x > 50 && x <= 100)
                        {
                            spellDeck.PushAndDiamonAttackPattern(aiToken, "Up");
                            LookForPlayer();
                            _aiStats.ReduceAiActionCounterNow(1);
                        }
                    }
                    if (isPresentMinusUpTile && NumberOfTilesInBetweenHorizontal == 0 && NumberOfTilesInBetweenVertical != 0)
                    {
                        int x = Random.Range(0, 100);
                        if (x >= 0 && x <= 50)
                        {
                            spellDeck.SimpleAttack(aiToken, "minusUp");
                            LookForPlayer();
                            _aiStats.ReduceAiActionCounterNow(1);
                        }
                        if (x > 50 && x <= 100)
                        {
                            spellDeck.PushAndDiamonAttackPattern(aiToken, "minusUp");
                            LookForPlayer();
                            _aiStats.ReduceAiActionCounterNow(1);
                        }
                    }
                    if (isPresentRightTile && NumberOfTilesInBetweenHorizontal != 0 && NumberOfTilesInBetweenVertical == 0)
                    {
                        int x = Random.Range(0, 100);
                        if (x >= 0 && x <= 50)
                        {
                            spellDeck.SimpleAttack(aiToken, "Right");
                            LookForPlayer();
                            _aiStats.ReduceAiActionCounterNow(1);
                        }
                        if (x > 50 && x <= 100)
                        {
                            spellDeck.PushAndDiamonAttackPattern(aiToken, "Right");
                            LookForPlayer();
                            _aiStats.ReduceAiActionCounterNow(1);
                        }
                    }
                    if (isPresentMinusRightTile && NumberOfTilesInBetweenHorizontal != 0 && NumberOfTilesInBetweenVertical == 0)
                    {
                        int x = Random.Range(0, 100);
                        if (x >= 0 && x <= 50)
                        {
                            spellDeck.SimpleAttack(aiToken, "minusRight");
                            LookForPlayer();
                            _aiStats.ReduceAiActionCounterNow(1);
                        }
                        if (x > 50 && x <= 100)
                        {
                            spellDeck.PushAndDiamonAttackPattern(aiToken, "minusRight");
                            LookForPlayer();
                            _aiStats.ReduceAiActionCounterNow(1);
                        }
                    }



                }
            }

        }

    }
}
