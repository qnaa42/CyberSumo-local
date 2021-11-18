namespace GPC
{
    [System.Serializable]
    public class AiData
    {
        public int id;
        public string enemyName = "default";

        public int level;
        public int health;
        public int type;

        public int actionCounterNow;
        public int actionCounterFull;

        public int moveCounterNow;
        public int moveCounterFull;

        public int posHorizontal;
        public int posVertical;


    }
}
