using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GPC;

public class Sumo_GameManager : BaseGameManager
{
	public bool isPlayable;
	public GameObject Card1;
	public GameObject Card2;
	public GameObject PlayerArea;
	public GameObject CardZone;

	private GameObject card;
	
	List<GameObject> deck = new List<GameObject>();


	public Sumo_UIManager _uiManager;

    
	//SINGLETON
	public static Sumo_GameManager instance { get; private set; }

    BaseUserManager _baseUserManager;

    public Sumo_GameManager()
    {
        instance = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("SetTargetGameState=" + targetGameState);

        SetTargetState(Game.State.loaded);

		deck.Add(Card1);
		deck.Add(Card2);
	}
	public void OnClick()
	{
		for (int i = 0; i < 5; i++)
		{
			GameObject card = Instantiate(deck[Random.Range(0, deck.Count)], new Vector2(0, 0), Quaternion.identity);
			card.transform.SetParent(PlayerArea.transform, false);
		}
	}

	public override void UpdateTargetState()
	{
		Debug.Log("currentGameState=" + currentGameState);
		Debug.Log("targetGameState=" + targetGameState);

		if (targetGameState == currentGameState)
			return;

		switch (targetGameState)
		{
			case Game.State.loaded:
				isPlayable = false;
				SetTargetState(Game.State.gameStarting);
				UpdateCurrentState();
				Loaded();
				break;

			case Game.State.gameStarting:

				//pressplay
				
				GameStarting();
				break;

			case Game.State.gameStarted:
				//map and enemies spawn
				GameStarted();
				break;

			case Game.State.gamePlaying:
				//press to draw oppening hand
				StartGame();
				break;

			case Game.State.playerUntap:
				isPlayable = false;
				break;

			case Game.State.playerUpkeep:
				isPlayable = false;
				break;

			case Game.State.playerDraw:
				isPlayable = false;
				break;

			case Game.State.playerPlay1:
				isPlayable = true;
				break;

			case Game.State.playerMove:
				isPlayable = false;
				break;

			case Game.State.playerResolveDMG:
				isPlayable = false;
				break;

			case Game.State.playerPlay2:
				isPlayable = true;
				break;

			case Game.State.playerCleanUp:
				isPlayable = false;
				break;

			case Game.State.gameEnding:
				GameEnding();
				break;

			case Game.State.gameEnded:
				GameEnded();
				break;

			case Game.State.restartingGame:
				RestartGameTest();
				break;


			
		}

		// IMPORTANT: now update the current state to reflect the change
		currentGameState = targetGameState;
	}

	void StartGame()
    {
		Debug.Log("GameStart");
		OnClick();
    }
	void RestartGameTest()
    {
		Debug.Log("Restart");
		SetTargetState(Game.State.gameStarting);
		
	}

	void EndGame()
    {

    }

	// Update is called once per frame
	void Update()
    {
        
    }
	public void ClickPassTurn()
	{
		Sumo_GameManager.instance.targetGameState++;
		Sumo_GameManager.instance.UpdateTargetState();

	}
	public void ClickResolve()
	{
		card = CardZone.transform.GetChild(0).gameObject;
		Destroy(card);
		// resolving script WIP.
	}
	public void CancelClick()
	{
		card = CardZone.transform.GetChild(0).gameObject;
		card.transform.position = PlayerArea.transform.position;
		card.transform.SetParent(PlayerArea.transform, true);
	}
}
