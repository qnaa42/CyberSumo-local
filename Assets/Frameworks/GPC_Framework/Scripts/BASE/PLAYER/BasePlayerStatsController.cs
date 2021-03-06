using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GPC
{
	[RequireComponent(typeof(BaseUserManager))]

	public class BasePlayerStatsController : ExtendedCustomMonoBehaviour
	{

		public BaseUserManager _myDataManager;
		public int myID;
		public bool disableAutoPlayerListAdd;

		void Awake()
		{
			Init();
		}

		public virtual void Init()
		{
			Debug.Log("INIT PLAYER CONTROLLER");

			SetupDataManager();
			didInit = true;
			_myDataManager.AddNewPlayer();
		}

		public virtual void SetPlayerDetails(int anID)
		{
			// this function can be used by a game manager to pass in details from the player list, such as
			// this players ID or perhaps you could override this in the future to add avatar support, loadouts or
			// special abilities etc?
			myID = anID;
		}

		public virtual void SetupDataManager()
		{
			// if a player manager is not set in the editor, let's try to find one
			if (_myDataManager == null)
				_myDataManager = GetComponent<BaseUserManager>();

			if (_myDataManager == null)
				_myDataManager = gameObject.AddComponent<BaseUserManager>();

			if (_myDataManager == null)
				_myDataManager = GetComponent<BaseUserManager>();
		}

//NAME
		public string GetName()
        {
			if (!didInit)
				Init();

			return _myDataManager.GetName(myID);
        }

		public virtual void SetName(string aName)
		{
			if (!didInit)
				Init();

			_myDataManager.SetName(myID, aName);
		}

//LEVEL
		public int GetLevel()
        {
			if (!didInit)
				Init();

			return _myDataManager.GetLevel(myID);
        }

		public virtual void SetLevel(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.SetLevel(myID, anAmount);
        }

//HEALTH
		public int GetHealthFull()
		{
			if (!didInit)
				Init();

			return _myDataManager.GetHealthFull(myID);
		}

		public virtual void AddHealthFull(int anAmount)
		{
			if (!didInit)
				Init();

			_myDataManager.AddHealthFull(myID, anAmount);
		}

		public virtual void ReduceHealthFull(int anAmount)
		{
			if (!didInit)
				Init();

			_myDataManager.ReduceHealthFull(myID, anAmount);
		}

		public virtual void SetHealthFull(int anAmount)
		{
			if (!didInit)
				Init();

			_myDataManager.SetHealthFull(myID, anAmount);
		}

//HEALTH NOW
		public int GetHealthNow()
        {
			if (!didInit)
				Init();

			return _myDataManager.GetHealthNow(myID);
		}

		public virtual void AddHealthNow(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.AddHealthNow(myID, anAmount);
		}

		public virtual void ReduceHealthNow(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.ReduceHealthNow(myID, anAmount);
		}

		public virtual void SetHealthNow(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.SetHealthNow(myID, anAmount);
		}
//TYPE
		public int GetTypee()
        {
			if (!didInit)
				Init();

			return _myDataManager.GetType(myID);
        }
		
		public virtual void SetType(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.SetLevel(myID, anAmount);
        }

//MANA FULL
		public int GetManaFull()
        {
			if (!didInit)
				Init();

			return _myDataManager.GetManaFull(myID);
        }

		public virtual void AddManaFull(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.AddManaFull(myID, anAmount);
        }
		
		public virtual void ReduceManaFull(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.ReduceManaFull(myID, anAmount);
        }

		public virtual void SetManaFull(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.SetManaFull(myID, anAmount);
        }

//MANA NOW
		public int GetManaNow()
        {
			if (!didInit)
				Init();

			return _myDataManager.GetManaNow(myID);
		}
		
		public virtual void AddManaNow(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.AddManaNow(myID, anAmount);
        }

		public virtual void ReduceManaNow(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.ReduceManaNow(myID, anAmount);
        }

		public virtual void SetManaNow(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.SetManaNow(myID, anAmount);
        }

//MOVE FULL
		public int GetMoveFull()
        {
			if (!didInit)
				Init();

			return _myDataManager.GetMoveFull(myID);
        }

		public virtual void AddMoveFull(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.AddMoveFull(myID, anAmount);
        }

		public virtual void ReduceMoveFull(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.ReduceMoveFull(myID, anAmount);
        }

		public virtual void SetMoveFull(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.SetMoveFull(myID, anAmount);
        }

//MOVE NOW
		public int GetMoveNow()
        {
			if (!didInit)
				Init();

			return _myDataManager.GetMoveNow(myID);
        }
		
		public virtual void AddMoveNow(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.AddMoveNow(myID, anAmount);
        }

		public virtual void ReduceMoveNow(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.ReduceMoveNow(myID, anAmount);
        }

		public virtual void SetMoveNow(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.SetMoveNow(myID, anAmount);
        }

//HAND SIZE
		public int GetHandSize()
        {
			if (!didInit)
				Init();

			return _myDataManager.GetHandSize(myID);
        }

		public virtual void SetHandSize(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.SetHandSize(myID, anAmount);
        }

//HAND NOW
		public int GetHandNow()
        {
			if (!didInit)
				Init();

			return _myDataManager.GetHandNow(myID);
        }

		public virtual void AddHandNow(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.AddHandNow(myID, anAmount);
        }

		public virtual void ReduceHandNow(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.ReduceHandNow(myID, anAmount);
        }

		public virtual void SetHandNow(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.SetHandNow(myID, anAmount);
        }

//POS HORIZONTAL

		public int GetPosHorizontal()
        {
			if (!didInit)
				Init();

			return _myDataManager.GetPosHorizontal(myID);
        }

		public virtual void AddPosHorizontal(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.AddPosHorizontal(myID, anAmount);
        }

		public virtual void ReducePosHorizontal(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.ReducePosHorizontal(myID, anAmount);
        }

		public virtual void SetPosHorizontal(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.SetPosHorizontal(myID, anAmount);
        }

//POS VERTICAL

		public int GetPosVertical()
        {
			if (!didInit)
				Init();

			return _myDataManager.GetPosVertical(myID);
        }

		public virtual void AddPosVertical(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.AddPosVertical(myID, anAmount);
        }	
		
		public virtual void ReducePosVertical(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.ReducePosVertical(myID, anAmount);
        }

		public virtual void SetPosVertical(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.SetPosVertical(myID, anAmount);
        }

//MANA CARD COUNTER NOW
		public int GetManaCardCounterNow()
        {
			if (!didInit)
				Init();

			return _myDataManager.GetManaCardCounterNow(myID);
		}

		public virtual void AddManaCardCounterNow(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.AddManaCardCounterNow(myID, anAmount);
		}

		public virtual void ReduceManaCardCounterNow(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.ReduceManaCardCounterNow(myID, anAmount);
		}

		public virtual void SetManaCardCounterNow(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.SetManaCardCounterNow(myID, anAmount);
		}

//MANA CARD COUNTER FULL
		public int GeteManaCardCounterFull()
        {
			if (!didInit)
				Init();

			return _myDataManager.GetManaCardCounterFull(myID);
		}

		public virtual void AddManaCardCounterFull(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.AddManaCardCounterFull(myID, anAmount);
		}

		public virtual void ReduceManaCardCounterFull(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.ReduceManaCardCounterFull(myID, anAmount);
		}

		public virtual void SetManaCardCounterFull(int anAmount)
        {
			if (!didInit)
				Init();

			_myDataManager.SetManaCardCounterFull(myID, anAmount);
		}
	}
}