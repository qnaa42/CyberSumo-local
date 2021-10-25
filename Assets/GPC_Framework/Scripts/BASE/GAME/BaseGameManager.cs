using UnityEngine;
using UnityEngine.Events;

namespace GPC
{
	[AddComponentMenu("CSharpBookCode/Base/GameManager")]

	public class BaseGameManager : MonoBehaviour
	{
		public Game.State currentGameState;
		public Game.State targetGameState;
		public Game.State lastGameState;

		private bool paused;

		public virtual void SetTargetState(Game.State aState)
		{
			targetGameState = aState;

			if (targetGameState != currentGameState)
				UpdateTargetState();
		}

		public Game.State GetCurrentState()
		{
			return currentGameState;
		}

		[Header("Game Events")]

		public UnityEvent OnLoaded;
		public UnityEvent OnGameStarting;
		public UnityEvent OnGameStarted;
		public UnityEvent OnGameEnding;
		public UnityEvent OnGameEnded;
		public UnityEvent OnRestartGame;


	//	public UnityEvent OnGamePause;
	//	public UnityEvent OnGameUnPause;
	//	public UnityEvent OnShowLevelResults;
	//	public UnityEvent OnShowGameResults;
	//	public UnityEvent OnLevelStarting;
	//	public UnityEvent OnLevelStarted;
	//	public UnityEvent OnLevelEnding;
	//	public UnityEvent OnLevelEnded;
	//	public UnityEvent OnRestartLevel;
		
		[Header("Player Turn")]

		public UnityEvent OnUntap;
		public UnityEvent OnUnkeep;
		public UnityEvent OnDraw;
		public UnityEvent OnPlayerPlay1;
		public UnityEvent OnPlayerMove;
		public UnityEvent OnResolveDMGPlayer;
		public UnityEvent OnPlayerPlay2;
		public UnityEvent OnCleanUpPlayer;
		public UnityEvent OnGameTurnPassPlayer;

		[Header("AI Turn")]

		public UnityEvent OnAIUntap;
		public UnityEvent OnAIUpkeep;
		public UnityEvent OnAIMove;
		public UnityEvent OnAIPlay;
		public UnityEvent OnTrigger1;
		public UnityEvent OnAIResolveDMG;
		public UnityEvent OnTrigger2;
		public UnityEvent OnAICleanUP;
		public UnityEvent OnGameTurnPassAI;

		//Game Main Events

		public virtual void Loaded() { OnLoaded.Invoke(); }
		public virtual void GameStarting() { OnGameStarting.Invoke(); }
		public virtual void GameStarted() { OnGameStarted.Invoke(); }
		public virtual void GameEnding() { OnGameEnding.Invoke(); }
		public virtual void GameEnded() { OnGameEnded.Invoke(); }
		public virtual void RestartGame() { OnRestartGame.Invoke(); }

		//Player Turn

		public virtual void Untap () { OnUntap.Invoke(); }
		public virtual void Upkeep () { OnUnkeep.Invoke(); }
		public virtual void Draw() { OnDraw.Invoke(); }
		public virtual void PlayerPlayPhase1() { OnPlayerPlay1.Invoke();  }
		public virtual void PlayerMove() { OnPlayerMove.Invoke(); }
		public virtual void ResolveDMGPlayer() { OnResolveDMGPlayer.Invoke();  }
		public virtual void PlayerPlayPhase2() { OnPlayerPlay2.Invoke(); }
		public virtual void CleanUpPlayer() { OnCleanUpPlayer.Invoke(); }
		public virtual void TurnPassPlayer() { OnGameTurnPassPlayer.Invoke(); }

		//AI Turn

		public virtual void AIUntap() { OnAIUntap.Invoke(); }
		public virtual void AIUpkeep() { OnAIUpkeep.Invoke(); }
		public virtual void AIMove() { OnAIMove.Invoke(); }
		public virtual void AIPlay() { OnAIPlay.Invoke(); }
		public virtual void Trigger1() { OnTrigger1.Invoke(); }
		public virtual void AIResolveDMG() { OnAIResolveDMG.Invoke(); }
		public virtual void Trigger2() { OnTrigger2.Invoke(); }
		public virtual void AICleanUp() { OnAICleanUP.Invoke(); }
		public virtual void TurnPassAI() { OnGameTurnPassAI.Invoke(); }


	//	public virtual void LevelStarting() { OnLevelStarting.Invoke(); }
	//	public virtual void LevelStarted() { OnLevelStarted.Invoke(); }
	//	public virtual void LevelEnding() { OnLevelEnding.Invoke(); }
	//	public virtual void LevelEnded() { OnLevelEnded.Invoke(); }
	//	public virtual void GamePause() { OnGamePause.Invoke(); }
	//	public virtual void GameUnPause() { OnGameUnPause.Invoke(); }
	//	public virtual void ShowLevelResults() { OnShowLevelResults.Invoke(); }
	//	public virtual void ShowGameResults() { OnShowGameResults.Invoke(); }
	//	public virtual void RestartLevel() { OnRestartLevel.Invoke(); }

		public virtual void UpdateTargetState()
		{
			// we will never need to run target state functions if we're already in this state, so we check for that and drop out if needed
			if (targetGameState == currentGameState)
				return;

			switch (targetGameState)
			{

		//Game Starting Events

				case Game.State.idle:
					break;

				case Game.State.loading:
					break;

				case Game.State.loaded:
					Loaded();
					break;

				case Game.State.gameStarting:
					GameStarting();
					break;

				case Game.State.gameStarted:
					GameStarted();
					break;

				case Game.State.gamePlaying:
					break;

		//Player Turn

				case Game.State.playerUntap:
					break;

				case Game.State.playerUpkeep:
					break;

				case Game.State.playerDraw:
					break;

				case Game.State.playerPlay1:
					break;

				case Game.State.playerMove:
					break;

				case Game.State.playerResolveDMG:
					break;

				case Game.State.playerPlay2:
					break;

				case Game.State.playerCleanUp:
					break;

				case Game.State.gameTurnPassPlayer:
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
					break;

		//End Game Events

				case Game.State.gameEnding:
					GameEnding();
					break;

				case Game.State.gameEnded:
					GameEnded();
					break;

				case Game.State.restartingGame:
					RestartGame();
					break;

			//	case Game.State.gamePausing:
			//		GamePause();
			//		break;

			//	case Game.State.gameUnPausing:
			//		GameUnPause();
			//		break;

			//	case Game.State.showingLevelResults:
			//		ShowLevelResults();
			//		break;

			//	case Game.State.showingGameResults:
			//		ShowGameResults();
			//		break;
			//	case Game.State.levelEnding:
			//		LevelEnding();
			//		break;

			//	case Game.State.levelEnded:
			//		LevelEnded();
			//		break;
			//	case Game.State.levelStarting:
			//		LevelStarting();
			//		break;

			//	case Game.State.levelStarted:
			//		LevelStarted();
			//		break;
			//	case Game.State.restartingLevel:
			//		RestartLevel();
			//		break;
			}
				

			// now update the current state to reflect the change
			currentGameState = targetGameState;
		}

		public virtual void UpdateCurrentState()
		{
			switch (currentGameState)
			{
				
		//Game Starting Events

				case Game.State.idle:
					break;

				case Game.State.loading:
					break;

				case Game.State.loaded:
					break;

				case Game.State.gameStarting:
					break;

				case Game.State.gameStarted:
					break;

				case Game.State.gamePlaying:
					break;

		//Player Turn

				case Game.State.playerUntap:
					break;

				case Game.State.playerUpkeep:
					break;

				case Game.State.playerDraw:
					break;

				case Game.State.playerPlay1:
					break;

				case Game.State.playerMove:
					break;

				case Game.State.playerResolveDMG:
					break;

				case Game.State.playerPlay2:
					break;

				case Game.State.playerCleanUp:
					break;

				case Game.State.gameTurnPassPlayer:
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
					break;

		//End Game Events

				case Game.State.gameEnding:
					break;

				case Game.State.gameEnded:
					break;

				case Game.State.restartingGame:
					break;

			//	case Game.State.levelStarting:
			//		break;

			//	case Game.State.levelStarted:
			//		break;
			//	case Game.State.gamePausing:
			//		break;

			//	case Game.State.gameUnPausing:
			//		break;

			//	case Game.State.showingLevelResults:
			//		break;

			//	case Game.State.showingGameResults:
			//		break;

			//	case Game.State.restartingLevel:
			//		break;
			//	case Game.State.levelEnding:
			//		break;

			//	case Game.State.levelEnded:
			//		break;

			}
		}

	//	public virtual void GamePaused()
	//	{
	//		OnGamePause.Invoke();
	//		Paused = true;
	//	}

	//	public virtual void GameUnPaused()
	//	{
	//		OnGameUnPause.Invoke();
	//		Paused = false;
	//	}

	//	public bool Paused
	//	{
	//		get
	//		{
	//			// get paused
	//			return paused;
	//		}
	//		set
	//		{
	//			// set paused 
	//			paused = value;
	//
	//			if (paused)
	//			{
	//				// pause time
	//				Time.timeScale = 0f;
	//			}
	//			else
	//			{
	//				// unpause Unity
	//				Time.timeScale = 1f;
	//			}
	//		}
	//	}
	//
	}
}