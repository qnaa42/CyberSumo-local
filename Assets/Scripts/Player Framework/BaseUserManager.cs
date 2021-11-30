using UnityEngine;
using System.Collections.Generic;
using GPC;

namespace GPC
{
	[AddComponentMenu("CSharpBookCode/Base/Base User Manager")]

	public class BaseUserManager : MonoBehaviour
	{
		public static List<UserData> global_userDatas;
		public bool didInit;

		public void Init()
		{
			if (global_userDatas == null)
				global_userDatas = new List<UserData>();

			didInit = true;
		}

		public void ResetUsers()
		{
			if (!didInit)
				Init();

			global_userDatas = new List<UserData>();
		}

		public List<UserData> GetPlayerList()
		{
			if (global_userDatas == null)
				Init();

			return global_userDatas;
		}

		public int AddNewPlayer()
		{
			if (!didInit)
				Init();

			UserData newUser = new UserData();
			
			newUser.id = global_userDatas.Count;
			newUser.playerName = "Anonymous";
			newUser.level = 1;
			newUser.healthFull = 100;
			newUser.healthNow = 100;
			newUser.ManaFull = 1;
			newUser.ManaNow = 1;
			newUser.MoveFull = 1;
			newUser.MoveNow = 1;
			newUser.HandSize = 7;
			newUser.HandNow = 0;
			newUser.PosHorizontal = 3;
			newUser.PosVertical = 2;
			newUser.ManaCardCounterNow = 1;
			newUser.ManaCardCounterFull = 1;
			newUser.isFinished = false;
			global_userDatas.Add(newUser);

			return newUser.id;
		}


//NAME
		public string GetName(int id)
		{
			if (!didInit)
				Init();

			return global_userDatas[id].playerName;
		}

		public void SetName(int id, string aName)
		{
			if (!didInit)
				Init();

			global_userDatas[id].playerName = aName;
		}

//LEVEL
		public int GetLevel(int id)
		{
			if (!didInit)
				Init();

			return global_userDatas[id].level;
		}

		public void SetLevel(int id, int num)
		{
			if (!didInit)
				Init();

			global_userDatas[id].level = num;
		}

//HEALTH FULL
		public int GetHealthFull(int id)
		{
			if (!didInit)
				Init();

			return global_userDatas[id].healthFull;
		}
		public void AddHealthFull(int id, int num)
		{
			if (!didInit)
				Init();

			global_userDatas[id].healthFull += num;
		}

		public void ReduceHealthFull(int id, int num)
		{
			if (!didInit)
				Init();

			global_userDatas[id].healthFull -= num;
		}

		public void SetHealthFull(int id, int num)
		{
			if (!didInit)
				Init();

			global_userDatas[id].healthFull = num;
		}

//HEALTH NOW
		public int GetHealthNow(int id)
        {
			if (!didInit)
				Init();

			return global_userDatas[id].healthNow;
		}
		
		public void AddHealthNow(int id, int num)
        {
			if (!didInit)
				Init();

			global_userDatas[id].healthNow += num;
		}
		
		public void ReduceHealthNow(int id, int num)
        {
			if (!didInit)
				Init();

			global_userDatas[id].healthNow -= num;
		}

		public void SetHealthNow(int id, int num)
        {
			if (!didInit)
				Init();

			global_userDatas[id].healthNow = num;
		}

//TYPE		
		public void SetType(int id, int theType)
		{
			if (!didInit)
				Init();

			global_userDatas[id].type = theType;
		}

		public int GetType(int id)
		{
			if (!didInit)
				Init();

			return global_userDatas[id].type;
		}

//MANA FULL
		public int GetManaFull(int id)
        {
			if (!didInit)
				Init();

			return global_userDatas[id].ManaFull;
        }

		public void AddManaFull(int id, int num)
        {
			if (!didInit)
				Init();

			global_userDatas[id].ManaFull += num;
        }
		
		public void ReduceManaFull(int id, int num)
        {
			if (!didInit)
				Init();

			global_userDatas[id].ManaFull -= num;
        }
		
		public void SetManaFull(int id, int num)
        {
			if (!didInit)
				Init();

			global_userDatas[id].ManaFull = num;
        }

//MANA NOW
		public int GetManaNow(int id)
        {
			if (!didInit)
				Init();

			return global_userDatas[id].ManaNow;
        }

		public void AddManaNow(int id, int num)
        {
			if (!didInit)
				Init();

			global_userDatas[id].ManaNow += num;
        }

		public void ReduceManaNow(int id, int num)
        {
			if (!didInit)
				Init();

			global_userDatas[id].ManaNow -= num;
        }

		public void SetManaNow(int id, int num)
        {
			if (!didInit)
				Init();

			global_userDatas[id].ManaNow = num;
        }

//MOVE FULL
		public int GetMoveFull(int id)
        {
			if (!didInit)
				Init();

			return global_userDatas[id].MoveFull;
        }

		public void AddMoveFull(int id, int num)
        {
			if (!didInit)
				Init();

			global_userDatas[id].MoveFull += num;
        }

		public void ReduceMoveFull(int id, int num)
        {
			if (!didInit)
				Init();

			global_userDatas[id].MoveFull -= num;
        }

		public void SetMoveFull(int id, int num)
        {
			if (!didInit)
				Init();

			global_userDatas[id].MoveFull = num;
        }
		
//MOVE NOW
		public int GetMoveNow(int id)
        {
			if(!didInit)
				Init();

			return global_userDatas[id].MoveNow;
        }

		public void AddMoveNow(int id, int num)
        {
			if (!didInit)
				Init();

			global_userDatas[id].MoveNow += num;
        }

		public void ReduceMoveNow(int id, int num)
        {
			if (!didInit)
				Init();

			global_userDatas[id].MoveNow -= num;
        }

		public void SetMoveNow(int id, int num)
		{
			if (!didInit)
				Init();

			global_userDatas[id].MoveNow = num;
        }

//HAND SIZE
		public int GetHandSize(int id)
        {
			if (!didInit)
				Init();

			return global_userDatas[id].HandSize;
        }

		public void SetHandSize(int id, int num)
        {
			if (!didInit)
				Init();

			global_userDatas[id].HandSize = num;
        }

//HAND NOW
		public int GetHandNow(int id)
        {
			if (!didInit)
				Init();

			return global_userDatas[id].HandNow;
        }

		public void AddHandNow(int id, int num)
        {
			if (!didInit)
				Init();

			global_userDatas[id].HandNow += num;
        }

		public void ReduceHandNow(int id, int num)
        {
			if (!didInit)
				Init();

			global_userDatas[id].HandNow -= num;
        }

		public void SetHandNow(int id, int num)
        {
			if (!didInit)
				Init();

			global_userDatas[id].HandNow = num;
		}

//POS HORIZONTAL
		public int GetPosHorizontal(int id)
        {
			if (!didInit)
				Init();

			return global_userDatas[id].PosHorizontal;
        }

		public void AddPosHorizontal(int id, int num)
        {
			if (!didInit)
				Init();

			global_userDatas[id].PosHorizontal += num;
        }

		public void ReducePosHorizontal(int id, int num)
        {
			if (!didInit)
				Init();

			global_userDatas[id].PosHorizontal -= num;
        }

		public void SetPosHorizontal(int id, int num)
        {
			if (!didInit)
				Init();

			global_userDatas[id].PosHorizontal = num;
        }

//POS VERTICAL

		public int GetPosVertical(int id)
        {
			if (!didInit)
				Init();

			return global_userDatas[id].PosVertical;
        }

		public void AddPosVertical(int id, int num)
        {
			if (!didInit)
				Init();

			global_userDatas[id].PosVertical += num;
        }

		public void ReducePosVertical(int id, int num)
        {
			if (!didInit)
				Init();

			global_userDatas[id].PosVertical -= num;
        }
		
		public void SetPosVertical(int id, int num)
        {
			if (!didInit)
				Init();

			global_userDatas[id].PosVertical = num;
        }

//MANA CARD COUNTER NOW
		public int GetManaCardCounterNow(int id)
        {
			if (!didInit)
				Init();

			return global_userDatas[id].ManaCardCounterNow;
		}

		public void AddManaCardCounterNow(int id, int num)
        {
			if (!didInit)
				Init();

			global_userDatas[id].ManaCardCounterNow += num;
		}

		public void ReduceManaCardCounterNow(int id, int num)
        {
			if (!didInit)
				Init();

			global_userDatas[id].ManaCardCounterNow -= num;
		}

		public void SetManaCardCounterNow(int id, int num)
        {
			if (!didInit)
				Init();

			global_userDatas[id].ManaCardCounterNow = num;
		}

//MANA CARD COUNTER FULL
		public int GetManaCardCounterFull(int id)
        {
			if (!didInit)
				Init();

			return global_userDatas[id].ManaCardCounterFull;
		}

		public void AddManaCardCounterFull(int id, int num)
        {
			if (!didInit)
				Init();

			global_userDatas[id].ManaCardCounterFull += num;
		}

		public void ReduceManaCardCounterFull(int id, int num)
        {
			if (!didInit)
				Init();

			global_userDatas[id].ManaCardCounterFull -= num;
		}
		
		public void SetManaCardCounterFull(int id, int num)
        {
			if (!didInit)
				Init();

			global_userDatas[id].ManaCardCounterFull = num;
		}
//ITS FINISHED
		public bool GetIsFinished(int id)
		{
			if (!didInit)
				Init();

			return global_userDatas[id].isFinished;
		}

		public void SetIsFinished(int id, bool aVal)
		{
			if (!didInit)
				Init();

			global_userDatas[id].isFinished = aVal;
		}
	}
}