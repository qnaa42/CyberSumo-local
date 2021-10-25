using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GPC
{
	public class Game
	{
		public enum State
		{	idle, 
			loading,
			loaded,
			gameStarting,
			gameStarted,

			gamePlaying,
			playerUntap,
			playerUpkeep,
			playerDraw,
			playerPlay1,
			playerMove,
			playerResolveDMG,
			playerPlay2,
			playerCleanUp,

			gameEnding,
			gameEnded,

			restartingGame,






		//	levelEnding,
		//	levelEnded,
		//	gamePausing,
		//	gameUnPausing,
		//	showingLevelResults,
		//	showingGameResults,
		//	restartingLevel,
		//	levelStarting,
		//	levelStarted,
		};
	}
}