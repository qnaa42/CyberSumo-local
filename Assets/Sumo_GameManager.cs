using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GPC;

public class Sumo_GameManager : BaseGameManager
{
	public bool isPlayable;

	public GameObject PlayerArea;
	public GameObject CardZone;
	public GameObject Card;
	public GameObject CardToHand;
	private GameObject card;

	


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
        

        SetTargetState(Game.State.loaded);

		
	}
	public void OnClick()
	{
		for (int i = 0; i < 5; i++)
		{
			//GameObject card = Instantiate(Sumo_CardManager.CardManager.deck[Random.Range(0, Sumo_CardManager.CardManager.deck.Count)], new Vector2(0, 0), Quaternion.identity);
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

	//Game Starting Events

			case Game.State.loaded:
				isPlayable = false;
				Loaded();
				SetTargetState(Game.State.gameStarting);		
				break;

			case Game.State.gameStarting:
				StartGame();
				SetTargetState(Game.State.gameStarted);
				break;

			case Game.State.gameStarted:
				GameStarted();
				break;

			case Game.State.gamePlaying:
				SetTargetState(Game.State.playerPlay1);
				break;

	//Player Turn

			case Game.State.playerUntap:
				isPlayable = false;
				break;

			case Game.State.playerUpkeep:
				isPlayable = false;
				break;

			case Game.State.playerDraw:
				isPlayable = false;
				Draw1Card();
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

			case Game.State.gameTurnPassPlayer:
				SetTargetState(Game.State.aiUntap);
				break;

	//AI Turn

			case Game.State.aiUntap:
				break;

			case Game.State.aiUpkeep:
				break;

			case Game.State.aiMove:
				break;

			case Game.State.aiPlay:
				break;

			case Game.State.playerTrigger1:
				break;

			case Game.State.aiResolveDMG:
				break;

			case Game.State.playerTrigger2:
				break;

			case Game.State.aiCleanUp:
				break;

			case Game.State.gameTurnPassAI:
				SetTargetState(Game.State.playerUntap);
				break;

	//End Game Events

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
		StartCoroutine(Draw5Cards());
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
	    IEnumerator Draw5Cards()
    {
        for (int i=0; i<=4; i++)
        {
            yield return new WaitForSeconds(1);
            GameObject _card = Instantiate(CardToHand, transform.position, transform.rotation);
			_card.transform.SetParent(PlayerArea.transform, true);

		}
    }
	IEnumerator Draw1Cards()
	{
		if (Sumo_CardManager.deckSize > 0)
		{
			for (int i = 0; i < 1; i++)
			{
				yield return new WaitForSeconds(1);
				GameObject _card = Instantiate(CardToHand, transform.position, transform.rotation);
				_card.transform.SetParent(PlayerArea.transform, true);

			}
		}
		else 
		if (Sumo_CardManager.deckSize <= 0)
        {
			Debug.Log("Youlost");
			SetTargetState(Game.State.idle);
        }
	}
	public void Draw5Card()
    {
		StartCoroutine(Draw5Cards());
    }
	public void Draw1Card()
    {
		StartCoroutine(Draw1Cards());
		
    }
}
