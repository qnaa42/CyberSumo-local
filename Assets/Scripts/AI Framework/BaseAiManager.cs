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

            newAi.id = 0;
            newAi.enemyName = "default";

            newAi.level = 1;
            newAi.health = 20;
            newAi.type = 0;

            newAi.actionCounter = 2;
            newAi.moveCounter = 3;

            newAi.posHorizontal = 3;
            newAi.posVertical = 4;

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

//ACTION COUNTER
        public int GetAiActionCounter(int id)
        {
            if (!didInit)
                Init();

            return global_aiDatas[id].actionCounter;
        }

        public void AddAiActionCounter(int id, int num)
        {
            if (!didInit)
                Init();

            global_aiDatas[id].actionCounter += num;
        }

        public void ReduceAiActionCounter(int id, int num)
        {
            if (!didInit)
                Init();

            global_aiDatas[id].actionCounter -= num;
        }

        public void SetAiActionCounter(int id, int num)
        {
            if (!didInit)
                Init();

            global_aiDatas[id].actionCounter = num;
        }

//MOVE COUNTER
        public int GetAiMoveCounter(int id)
        {
            if (!didInit)
                Init();

            return global_aiDatas[id].moveCounter;
        }

        public void AddAiMoveCounter(int id, int num)
        {
            if (!didInit)
                Init();

            global_aiDatas[id].moveCounter += num;
        }

        public void ReduceAiMoveCounter(int id, int num)
        {
            if (!didInit)
                Init();

            global_aiDatas[id].moveCounter -= num;
        }

        public void SetAiMoveCounter(int id, int num)
        {
            if (!didInit)
                Init();

            global_aiDatas[id].moveCounter = num;
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
