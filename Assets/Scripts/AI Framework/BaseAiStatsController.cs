using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GPC
{
    [RequireComponent(typeof(BaseAiManager))]

    public class BaseAiStatsController : ExtendedCustomMonoBehaviour
    {
        public BaseAiManager _aiDataManager;
        public int myID;

        void Awake()
        {
            Init();
        }
    public virtual void Init()
        {
            Debug.Log("INIT AI CONTROLLER");

            SetupAiDataManager();
            didInit = true;
            _aiDataManager.AddNewAi();
        }

        public virtual void SetAiDetails(int anID)
        {
            myID = anID;
        }

        public virtual void SetupAiDataManager()
        {
            if (_aiDataManager == null)
                _aiDataManager = GetComponent<BaseAiManager>();

            if (_aiDataManager == null)
                _aiDataManager = gameObject.AddComponent<BaseAiManager>();

            if (_aiDataManager == null)
                _aiDataManager = GetComponent<BaseAiManager>();
        }

//NAME
        public string GetAiName()
        {
            if (!didInit)
                Init();

            return _aiDataManager.GetAiName(myID);
        }

        public virtual void SetAiName(string aName)
        {
            if (!didInit)
                Init();

            _aiDataManager.SetAiName(myID, aName);
        }

//LEVEL
        public int GetAiLevel()
        {
            if (!didInit)
                Init();

            return _aiDataManager.GetAiLevel(myID);
        }

        public virtual void SetAiLevel(int anAmount)
        {
            if (!didInit)
                Init();

            _aiDataManager.SetAiLevel(myID, anAmount);
        }

//HEALTH
        public int GetAiHealth()
        {
            if (!didInit)
                Init();

            return _aiDataManager.GetAiHealth(myID);
        }

        public virtual void AddAiHealth(int anAmount)
        {
            if (!didInit)
                Init();

            _aiDataManager.AddAiHealth(myID, anAmount);
        }

        public virtual void ReduceAiHealth(int anAmount)
        {
            if (!didInit)
                Init();

            _aiDataManager.ReduceAiHealth(myID, anAmount);
        }

        public virtual void SetAiHealth(int anAmount)
        {
            if (!didInit)
                Init();

            _aiDataManager.SetAiHealth(myID, anAmount);

        }

//TYPE
        public int GetAiType()
        {
            if (!didInit)
                Init();

            return _aiDataManager.GetAiType(myID);
        }

        public virtual void SetAiType(int anAmount)
        {
            if (!didInit)
                Init();

            _aiDataManager.SetAiType(myID, anAmount);
        }

//ACTION COUNTER NOW
        public int GetAiActionCounterNow()
        {
            if (!didInit)
                Init();

            return _aiDataManager.GetAiActionCounterNow(myID);
        }
        
        public virtual void AddAiActionCounterNow(int anAmount)
        {
            if (!didInit)
                Init();

            _aiDataManager.AddAiActionCounterNow(myID, anAmount);
        }

        public virtual void ReduceAiActionCounterNow(int anAmount)
        {
            if (!didInit)
                Init();

            _aiDataManager.ReduceAiActionCounterNow(myID, anAmount);
        }

        public virtual void SetAiActionCounterNow(int anAmount)
        {
            if (!didInit)
                Init();

            _aiDataManager.SetAiActionCounterNow(myID, anAmount);
        }

//ACTION COUNTER FULL
        public int GetAiActionCounterFull()
        {
            if (!didInit)
                Init();

            return _aiDataManager.GetAiActionCounterFull(myID);
        }

        public virtual void AddAiActionCounterFull(int anAmount)
        {
            if (!didInit)
                Init();

            _aiDataManager.AddAiACtionCounterFull(myID, anAmount);
        }

        public virtual void ReduceAiActionCounterFull(int anAmount)
        {
            if (!didInit)
                Init();

            _aiDataManager.ReduceAiActionCounterFull(myID, anAmount);
        }

        public virtual void SetAiActionCounterFull(int anAMount)
        {
            if (!didInit)
                Init();

            _aiDataManager.SetAiActionCounterFull(myID, anAMount);
        }

//MOVE COUNTER NOW
        public int GetAiMoveCounterNow()
        {
            if (!didInit)
                Init();

            return _aiDataManager.GetAiMoveCounterNow(myID);
        }

        public virtual void AddAiMoveCounterNow(int anAmount)
        {
            if (!didInit)
                Init();

            _aiDataManager.AddAiMoveCounterNow(myID, anAmount);
        }
        public virtual void ReduceAiMoveCounterNow(int anAmount)
        {
            if (!didInit)
                Init();

            _aiDataManager.ReduceAiMoveCounterNow(myID, anAmount);
        }

        public virtual void SetAiMoveCounterNow(int anAmount)
        {
            if (!didInit)
                Init();

            _aiDataManager.SetAiMoveCounterNow(myID, anAmount);
        }

//MOVE COUNTER FULL
        public int GetAiMoveCounterFull()
        {
            if (!didInit)
                Init();

            return _aiDataManager.GetAiMoveCounterFull(myID);
        }

        public virtual void AddAiMoveCounterFull(int anAmount)
        {
            if (!didInit)
                Init();

            _aiDataManager.AddAiMoveCounterFull(myID, anAmount);
        }

        public virtual void ReduceAiMoveCounterFull(int anAmount)
        {
            if (!didInit)
                Init();

            _aiDataManager.ReduceAiMoveCounterFull(myID, anAmount);
        }

        public virtual void SetAiMoveCounterFull(int anAmount)
        {
            _aiDataManager.SetAiMoveCounterFull(myID, anAmount);
        }

//AI POS HORIZONTAL
        public int GetAiPosHorizontal()
        {
            if (!didInit)
                Init();

            return _aiDataManager.GetAiPosHorizontal(myID);
        }    

        public virtual void AddAiPosHorizontal(int anAmount)
        {
            if (!didInit)
                Init();

            _aiDataManager.AddAiPosHorizontal(myID, anAmount);
        }

        public virtual void ReduceAiPosHorizontal(int anAmount)
        {
            if (!didInit)
                Init();

            _aiDataManager.ReduceAiPosHorizontal(myID, anAmount);
        }

        public virtual void SetAiPosHorizontal(int anAmount)
        {
            if (!didInit)
                Init();

            _aiDataManager.SetAiPosHorizontal(myID, anAmount);
        }

//AI POS VERTICAL
        public int GetAiPosVertical()
        {
            if (!didInit)
                Init();

            return _aiDataManager.GetAiPosVertical(myID);
        }   

        public virtual void AddAiPosVertical(int anAmount)
        {
            if (!didInit)
                Init();

            _aiDataManager.AddAiPosVertical(myID, anAmount);
        }

        public virtual void ReduceAiPosVertical(int anAmount)
        {
            if (!didInit)
                Init();

            _aiDataManager.ReduceAiPosVertical(myID, anAmount);
        }

        public virtual void SetAiPosVertical(int anAmount)
        {
            if (!didInit)
                Init();

            _aiDataManager.SetAiPosVertical(myID, anAmount);
        }

    }
}
