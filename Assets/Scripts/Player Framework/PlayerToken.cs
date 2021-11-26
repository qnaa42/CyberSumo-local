using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GPC;

public class PlayerToken : MonoBehaviour
{
    public int id;
    public string playerName;

    public int level;
    public int health;

    public int manaNow;
    public int manaFull;

    public int moveNow;
    public int moveFull;

    public int handNow;
    public int handSize;

    public int posHorizontal;
    public int posVertical;

    public int manaCardCounterNow;
    public int manaCardCounterFull;

    public GameObject myStats;
    private BasePlayerStatsController _myStats;

    // Start is called before the first frame update
    void Start()
    {
        myStats = GameObject.Find("Player Manager");
        _myStats = myStats.GetComponent<BasePlayerStatsController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        id = 0;
        _myStats.SetPlayerDetails(id);

playerName = _myStats.GetName();

        level = _myStats.GetLevel();
        health = _myStats.GetHealth();

        manaNow = _myStats.GetManaNow();
        manaFull = _myStats.GetManaFull();

        moveNow = _myStats.GetMoveNow();
        moveFull = _myStats.GetMoveFull();

        handNow = _myStats.GetHandNow();
        handSize = _myStats.GetHandSize();

        posHorizontal = _myStats.GetPosHorizontal();
        posVertical = _myStats.GetPosVertical();

        manaCardCounterNow = _myStats.GetManaCardCounterNow();
        manaCardCounterFull = _myStats.GeteManaCardCounterFull();

}
}
