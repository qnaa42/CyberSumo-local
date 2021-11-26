using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GPC;

public class AIToken : MonoBehaviour
{
    public int id;
    public string aiName;

    public int level;
    public int health;
    public int type;

    public int actionCounterNow;
    public int actionCounterFull;
    public int moveCounterNow;
    public int moveCounterFull;

    public int posHorizontal;
    public int posVertical;

    public GameObject myStats;
    private BaseAiStatsController _myStats;

    void Start()
    {
        myStats = GameObject.Find("AI Manager");
        _myStats = myStats.GetComponent<BaseAiStatsController>();       
    }

    void Update()
    {
        _myStats.SetAiDetails(id);
        aiName = _myStats.GetAiName();
        level = _myStats.GetAiLevel();
        health = _myStats.GetAiHealth();
        type = _myStats.GetAiType();
        actionCounterFull = _myStats.GetAiActionCounterFull();
        actionCounterNow = _myStats.GetAiActionCounterNow();
        moveCounterFull = _myStats.GetAiMoveCounterFull();
        moveCounterNow = _myStats.GetAiMoveCounterNow();
        posHorizontal = _myStats.GetAiPosHorizontal();
        posVertical = _myStats.GetAiPosVertical();
    }
}