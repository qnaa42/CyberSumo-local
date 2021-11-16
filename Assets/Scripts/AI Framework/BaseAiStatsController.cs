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

//ACTION COUNTER
        public int GetAiActionCounter()
        {
            if (!didInit)
                Init();

            return _aiDataManager.GetAiActionCounter(myID);
        }
        
        public virtual void AddAiActionCounter(int anAmount)
        {
            if (!didInit)
                Init();

            _aiDataManager.AddAiActionCounter(myID, anAmount);
        }

        public virtual void ReduceAiActionCounter(int anAmount)
        {
            if (!didInit)
                Init();

            _aiDataManager.ReduceAiActionCounter(myID, anAmount);
        }

        public virtual void SetAiActionCounter(int anAmount)
        {
            if (!didInit)
                Init();

            _aiDataManager.SetAiActionCounter(myID, anAmount);
        }

//MOVE COUNTER
        public int GetAiMoveCounter()
        {
            if (!didInit)
                Init();

            return _aiDataManager.GetAiMoveCounter(myID);
        }

        public virtual void AddAiMoveCounter(int anAmount)
        {
            if (!didInit)
                Init();

            _aiDataManager.AddAiMoveCounter(myID, anAmount);
        }
        public virtual void ReduceAiMoveCounter(int anAmount)
        {
            if (!didInit)
                Init();

            _aiDataManager.ReduceAiMoveCounter(myID, anAmount);
        }

        public virtual void SetAiMoveCounter(int anAmount)
        {
            if (!didInit)
                Init();

            _aiDataManager.SetAiMoveCounter(myID, anAmount);
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
