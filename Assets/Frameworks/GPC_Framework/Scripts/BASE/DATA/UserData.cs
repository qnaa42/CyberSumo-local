namespace GPC
{
	[System.Serializable]
	public class UserData
	{
		public int id;
		public string playerName = "Anonymous"; 
		
		public int level;
		public int healthFull;
		public int healthNow;
		public int type;
		public int ManaFull;
		public int ManaNow;
		public int MoveFull;
		public int MoveNow;
		public int HandSize;
		public int HandNow;
		public int PosHorizontal;
		public int PosVertical;
		public int ManaCardCounterNow;
		public int ManaCardCounterFull;
		public bool isFinished;
	}
}