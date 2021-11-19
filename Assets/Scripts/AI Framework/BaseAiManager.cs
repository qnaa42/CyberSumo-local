using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GPC;

namespace GPC
{
    [AddComponentMenu("CSSharpBookCode/Base/Base Ai Manager")]
    public class BaseAiManager : MonoBehaviour
    {
        public static List<AiData> global_aiDatas;
        public bool didInit;

        public void Init()
        {
            if (global_aiDatas == null)
                global_aiDatas = new List<AiData>();

            didInit = true;
        }
        public void ResetAi()
        {
            if (!didInit)
                Init();

            global_aiDatas = new List<AiData>();
        }
        public List<AiData> GetAiList()
        {
            if (global_aiDatas == null)
                Init();

            return global_aiDatas;
        }
        public int AddNewAi()
        {
            if (!didInit)
                Init();

            AiData newAi = new AiData();

            newAi.id = global_aiDatas.Count;
            newAi.enemyName = "default";

            newAi.level = 1;
            newAi.health = 20;
            newAi.type = 0;

            newAi.actionCounterNow = 0;
            newAi.actionCounterFull = 2;
            newAi.moveCounterNow = 0;
            newAi.actionCounterFull = 3;

            newAi.posHorizontal = 1;
            newAi.posVertical = 0;

            global_aiDatas.Add(newAi);

            return newAi.id;
        }


//AI NAME
        public string GetAiName(int id)
        {
            if (!didInit)
                Init();

            return global_aiDatas[id].enemyName;
        }
        public void SetAiName(int id, string aName)
        {
            if (!didInit)
                Init();

            global_aiDatas[id].enemyName = aName;
        }

//LEVEL
        public int GetAiLevel(int id)
        {
            if (!didInit)
                Init();

            return global_aiDatas[id].level;
        }
        
        public void SetAiLevel(int id, int num)
        {
            if (!didInit)
                Init();

            global_aiDatas[id].level = num;
        }    

//HEALTH
        public int GetAiHealth(int id)
        {
            if (!didInit)
                Init();

            return global_aiDatas[id].health;
        }

        public void AddAiHealth(int id, int num)
        {
            if (!didInit)
                Init();

            global_aiDatas[id].health += num;
        }

        public void ReduceAiHealth(int id, int num)
        {
            if (!didInit)
                Init();

            global_aiDatas[id].health -= num;
        }

        public void SetAiHealth(int id, int num)
        {
            if (!didInit)
                Init();

            global_aiDatas[id].health = num;
        }

//TYPE
        public void SetAiType(int id, int theType)
        {
            if (!didInit)
                Init();

            global_aiDatas[id].type = theType;
        }

        public int GetAiType(int id)
        {
            if (!didInit)
                Init();

            return global_aiDatas[id].type;
        }

//ACTION COUNTER NOW
        public int GetAiActionCounterNow(int id)
        {
            if (!didInit)
                Init();

            return global_aiDatas[id].actionCounterNow;
        }

        public void AddAiActionCounterNow(int id, int num)
        {
            if (!didInit)
                Init();

            global_aiDatas[id].actionCounterNow += num;
        }

        public void ReduceAiActionCounterNow(int id, int num)
        {
            if (!didInit)
                Init();

            global_aiDatas[id].actionCounterNow -= num;
        }

        public void SetAiActionCounterNow(int id, int num)
        {
            if (!didInit)
                Init();

            global_aiDatas[id].actionCounterNow = num;
        }

//ACTION COUNTER FULL
        public int GetAiActionCounterFull(int id)
        {
            if (!didInit)
                Init();

            return global_aiDatas[id].actionCounterFull;
        }

        public void AddAiACtionCounterFull(int id, int num)
        {
            if (!didInit)
                Init();

            global_aiDatas[id].actionCounterFull += num;
        }

        public void ReduceAiActionCounterFull(int id, int num)
        {
            if (!didInit)
                Init();

            global_aiDatas[id].actionCounterFull -= num;
        }

        public void SetAiActionCounterFull(int id, int num)
        {
            if (!didInit)
                Init();

            global_aiDatas[id].actionCounterFull = num;
        }

//MOVE COUNTER NOW
        public int GetAiMoveCounterNow(int id)
        {
            if (!didInit)
                Init();

            return global_aiDatas[id].moveCounterNow;
        }

        public void AddAiMoveCounterNow(int id, int num)
        {
            if (!didInit)
                Init();

            global_aiDatas[id].moveCounterNow += num;
        }

        public void ReduceAiMoveCounterNow(int id, int num)
        {
            if (!didInit)
                Init();

            global_aiDatas[id].moveCounterNow -= num;
        }

        public void SetAiMoveCounterNow(int id, int num)
        {
            if (!didInit)
                Init();

            global_aiDatas[id].moveCounterNow = num;
        }

//MOVE COUNTER FULL
        public int GetAiMoveCounterFull(int id)
        {
            if (!didInit)
                Init();

            return global_aiDatas[id].actionCounterFull;
        }

        public void AddAiMoveCounterFull(int id, int num)
        {
            if (!didInit)
                Init();

            global_aiDatas[id].moveCounterFull += num;
        }

        public void ReduceAiMoveCounterFull(int id, int num)
        {
            if (!didInit)
                Init();

            global_aiDatas[id].moveCounterFull = num;
        }

        public void SetAiMoveCounterFull(int id, int num)
        {
            if (!didInit)
                Init();

            global_aiDatas[id].moveCounterFull = num;
        }

//AI POS HORIZONTAL
        public int GetAiPosHorizontal(int id)
        {
            if (!didInit)
                Init();

            return global_aiDatas[id].posHorizontal;
        }

        public void AddAiPosHorizontal(int id, int num)
        {
            if (!didInit)
                Init();

            global_aiDatas[id].posHorizontal += num;
        }

        public void ReduceAiPosHorizontal(int id, int num)
        {
            if (!didInit)
                Init();

            global_aiDatas[id].posHorizontal -= num;
        }

        public void SetAiPosHorizontal(int id, int num)
        {
            if (!didInit)
                Init();

            global_aiDatas[id].posHorizontal = num;
        }

//AI POS VERTICAL
        public int GetAiPosVertical(int id)
        {
            if (!didInit)
                Init();

            return global_aiDatas[id].posVertical;
        }

        public void AddAiPosVertical(int id, int num)
        {
            if (!didInit)
                Init();

            global_aiDatas[id].posVertical += num;
        }

        public void ReduceAiPosVertical(int id, int num)
        {
            if (!didInit)
                Init();

            global_aiDatas[id].posVertical -= num;
        }

        public void SetAiPosVertical(int id, int num)
        {
            if (!didInit)
                Init();

            global_aiDatas[id].posVertical = num;
        }
    }
}
