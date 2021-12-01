using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GPC;
using UnityEngine.UI;
public class Sumo_GameManager : BaseGameManager
{
	public bool isPlayable;
	public bool GameLoopEvents;
	private GridClass grid;

	public GameObject PlayerArea;
	public GameObject CardZone;
	public GameObject Card;
	public GameObject CardToHand;
	public GameObject ButtonHandler;

	private GameObject card;
	private GameObject thiscard;

	public GameObject Tile;
	public GameObject TileToBoard;
	public GameObject GridArea;

	public GameObject PlayerPrefab;
	public GameObject AiPrefab;
	public int NumberOfAi;

	public Vector3 cardOriginalScale;





	public Sumo_UIManager _uiManager;
	public BaseUserManager _userManager;
	public BasePlayerStatsController _playerStats;
	public BaseAiStatsController _aiStats;
	public Grid _grid;
	public myBaseAiController _aiController;

	BaseUserManager _baseUserManager;


//SINGLETON

	public static Sumo_GameManager instance { get; private set; }
	public Sumo_GameManager()
	{
		instance = this;
	}
		
	void Start()
	{
	grid = new GridClass(7, 5, 150f);
	SetTargetState(Game.State.loaded);
	}

	public override void UpdateTargetState()
	{
		if (targetGameState == currentGameState)
			return;

		switch (targetGameState)
		{

//Game Starting Events

			case Game.State.loaded:
				isPlayable = false;
				GameLoopEvents = false;

				Loaded();
				SetTargetState(Game.State.gameStarting);
				break;

			case Game.State.gameStarting:
				GameLoopEvents = false;
				StartGame();
				SetTargetState(Game.State.gameStarted);
				break;

			case Game.State.gameStarted:
				GameLoopEvents = false;
				GameStarted();
				DrawGrid();
				break;

			case Game.State.gamePlaying:
				GameLoopEvents = false;
				SetTargetState(Game.State.playerPlay1);
				break;

//Player Turn

			case Game.State.playerUntap:
				GameLoopEvents = true;
				isPlayable = false;

				_playerStats.SetManaNow(_playerStats.GetManaFull());
				_playerStats.SetMoveNow(_playerStats.GetMoveFull());
				_playerStats.SetManaCardCounterNow(_playerStats.GeteManaCardCounterFull());
				break;

			case Game.State.playerUpkeep:
				GameLoopEvents = true;

				isPlayable = false;

				break;

			case Game.State.playerDraw:
				GameLoopEvents = true;
				isPlayable = false;

				if (_playerStats.GetHandNow() < _playerStats.GetHandSize())
				{
					Draw1Card();
				}
				break;

			case Game.State.playerPlay1:
				GameLoopEvents = true;
				isPlayable = true;

				break;

			case Game.State.playerMove:
				GameLoopEvents = true;
				isPlayable = false;

				break;

			case Game.State.playerResolveDMG:
				GameLoopEvents = true;
				isPlayable = false;

				break;

			case Game.State.playerPlay2:
				GameLoopEvents = true;
				isPlayable = true;

				break;

			case Game.State.playerCleanUp:
				GameLoopEvents = true;
				isPlayable = false;

				break;

			case Game.State.gameTurnPassPlayer:
				SetTargetState(Game.State.aiUntap);

				break;

//AI Turn

			case Game.State.aiUntap:
				GameLoopEvents = true;
				isPlayable = false;

				for (int i = 0; i <= NumberOfAi; i++)
				{
					_aiStats.SetAiDetails(i);
					_aiStats.SetAiMoveCounterNow(_aiStats.GetAiMoveCounterFull());
					_aiStats.SetAiActionCounterNow(_aiStats.GetAiActionCounterFull());
				}
				break;

			case Game.State.aiUpkeep:
				GameLoopEvents = true;
				isPlayable = false;

				break;

			case Game.State.aiMove:
				GameLoopEvents = true;
				isPlayable = false;

				for (int i = 0; i <= NumberOfAi; i++)
                {
					_aiController.MoveTowardsPlayer(i);
				}

				break;

			case Game.State.aiPlay:
				GameLoopEvents = true;
				isPlayable = false;

				for (int i = 0; i <= NumberOfAi; i++)
                {
					_aiController.AttackPlayer(i);
				}

				break;

			case Game.State.playerTrigger1:
				GameLoopEvents = true;
				isPlayable = true;

				break;

			case Game.State.aiResolveDMG:
				GameLoopEvents = true;
				isPlayable = false;

				break;

			case Game.State.playerTrigger2:
				GameLoopEvents = true;
				isPlayable = false;

				break;

			case Game.State.aiCleanUp:
				GameLoopEvents = true;
				isPlayable = false;

				break;

			case Game.State.gameTurnPassAI:
				SetTargetState(Game.State.playerUntap);
				break;

//End Game Events

			case Game.State.gameEnding:
				GameLoopEvents = false;
				isPlayable = false;
				GameEnding();
				break;

			case Game.State.gameEnded:
				GameLoopEvents = false;
				isPlayable = false;
				GameEnded();
				break;

			case Game.State.restartingGame:
				GameLoopEvents = false;
				isPlayable = false;
				RestartGameTest();
				break;



		}

// IMPORTANT: now update the current state to reflect the change
		currentGameState = targetGameState;
	}

		void StartGame()
		{
			Debug.Log("GameStart");
			StartCoroutine(Draw5Cards());
			_aiStats.Init();
			PlayerTokenSpawn();
        for (int i = 0; i <= NumberOfAi; i++)
        {
			AiSpawntest(i);
		}

		}
		void RestartGameTest()
		{
			Debug.Log("Restart");
			SetTargetState(Game.State.playerUntap);

		}

		void EndGame()
		{

		}

		// Update is called once per frame
		void Update()
		{
			if (_playerStats.GetHealthNow() <= 0)
			{
				SetTargetState(Game.State.gameEnding);
			}
		}
		public void ClickPassTurn()
		{
			Sumo_GameManager.instance.targetGameState++;
			Sumo_GameManager.instance.UpdateTargetState();

		}
		public void ClickResolve()
		{
			card = CardZone.transform.GetChild(0).gameObject;
			thiscard = card.transform.GetChild(0).gameObject;
			if (thiscard.GetComponent<Card>().cost <= _playerStats.GetManaNow())
			{
				_playerStats.ReduceManaNow(thiscard.GetComponent<Card>().cost);
				Destroy(card);
			}
			else
			if (thiscard.GetComponent<Card>().cost > _playerStats.GetManaNow())
			{
				CancelClick();
				Debug.Log("NotEnoughtMANA");
			}
			// resolving script WIP.
		}
		public void CancelClick()
		{
			card = CardZone.transform.GetChild(0).gameObject;
			card.transform.SetParent(PlayerArea.transform, true);
		}
		IEnumerator Draw5Cards()
		{
			for (int i = 0; i <= 4; i++)
			{
				ButtonHandler.SetActive(false);
				yield return new WaitForSeconds(1);
				GameObject _card = Instantiate(CardToHand, transform.position, transform.rotation);
				_card.transform.SetParent(PlayerArea.transform, true);
				_playerStats.AddHandNow(1);
			}
			ButtonHandler.SetActive(true);
		}
		IEnumerator Draw1Cards()
		{
			if (Sumo_CardManager.deckSize > 0)
			{
				for (int i = 0; i < 1; i++)
				{
					ButtonHandler.SetActive(false);
					yield return new WaitForSeconds(1);
					GameObject _card = Instantiate(CardToHand, transform.position, transform.rotation);
					_card.transform.SetParent(PlayerArea.transform, true);
					_playerStats.AddHandNow(1);
				}
				ButtonHandler.SetActive(true);
			}
			else
			if (Sumo_CardManager.deckSize <= 0)
			{
				Debug.Log("Youlost");
				SetTargetState(Game.State.idle);
			}
		}
		IEnumerator DrawGrid()
		{
			for (int i = 0; i <= 34; i++)
			{
				yield return new WaitForSeconds(0);
				GameObject _tile = Instantiate(TileToBoard, transform.position, transform.rotation);
				_tile.transform.SetParent(GridArea.transform, true);
			}
		}
		public void Draw5Card()
		{
			if (_playerStats.GetHandNow() < _playerStats.GetHandSize())
			{
				StartCoroutine(Draw5Cards());
			}
		}
		public void Draw1Card()
		{
			if (_playerStats.GetHandNow() < _playerStats.GetHandSize())
			{
				StartCoroutine(Draw1Cards());
			}
		}
		public void DrawGridOnStart()
		{
			StartCoroutine(DrawGrid());
		}
		public void ShowPositionOfTile(int horizontal, int vertical)
		{
		Debug.Log("ok");
		Debug.Log(" Hor " + horizontal + " " + " Ver " + vertical);
		

		}
		public void PlayerTokenSpawn()
		{
		Debug.Log("here");
		GameObject thisTile = GameObject.Find("Tile" + _playerStats.GetPosHorizontal() + "/" + _playerStats.GetPosVertical());
		Transform transformTile = thisTile.transform;
		Vector3 tileVector = new Vector3(transformTile.position.x, transformTile.position.y, transformTile.position.z);
		GameObject player = Instantiate(PlayerPrefab, tileVector, transformTile.rotation);
		player.transform.SetParent(transformTile, true);
		}

	//To remove later
		public void AiSpawntest(int id)
		{
		Debug.Log("AiSpawn");
		_aiStats.SetAiDetails(id);
		GameObject thisTile = GameObject.Find("Tile" + _aiStats.GetAiPosHorizontal() + "/" + _aiStats.GetAiPosVertical());
		Transform transformTile = thisTile.transform;
		Vector3 tileVector = new Vector3(transformTile.position.x, transformTile.position.y, transform.position.z);
		GameObject ai = Instantiate(AiPrefab, tileVector, transformTile.rotation);
		ai.transform.SetParent(transformTile, true);
		AIToken aiToken = ai.GetComponent<AIToken>();
		aiToken.id = id;
		_aiController.LookForPlayer(id);
		}

		
}

