using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GPC
{
	[RequireComponent(typeof(BaseUserManager))]

	public class BasePlayerStatsController : ExtendedCustomMonoBehaviour
	{
		public static Sumo_GameManager PlayerStats { get; private set; }

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
		public int GetHealth()
		{
			if (!didInit)
				Init();
			return _myDataManager.GetHealth(myID);
		}

		public virtual void AddHealth(int anAmount)
		{
			if (!didInit)
				Init();
			_myDataManager.AddHealth(myID, anAmount);
		}

		public virtual void ReduceHealth(int anAmount)
		{
			if (!didInit)
				Init();
			_myDataManager.ReduceHealth(myID, anAmount);
		}

		public virtual void SetHealth(int anAmount)
		{
			if (!didInit)
				Init();
			_myDataManager.SetHealth(myID, anAmount);
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
			_myDataManager.ReducePosVertical(myID, anAmount);
        }










	}
}