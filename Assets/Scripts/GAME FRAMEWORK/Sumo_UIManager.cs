using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GPC;

public class Sumo_UIManager : MonoBehaviour
{
    public Sumo_GameManager gameManager;
    public Sumo_UIManager _uiManager;
    public BaseUserManager _userManager;
    public BasePlayerStatsController _userStatsManager;
    public Sumo_GridManager _gridManager;
    public BaseAiStatsController _aiStats;
    public SpellDeck spellDeck;

    public GameObject playerToken;



    public GameObject ResolveButton;
    public GameObject CancelButton;
    public GameObject PassButton;
    public GameObject CardZone;

    [Header("MoveButtons")]
    public GameObject MoveButtonsBox;
    public GameObject UpButton;
    public GameObject minusUpButton;
    public GameObject RightButton;
    public GameObject minusRightButton;

    public Text currentStateText;
    public Text numbersOfCards;

    [Header("Land Cards Buttons")]
    public GameObject LandCardsDropBox;
    public GameObject JustOneOptionManaLandCard;
    public GameObject plusOneManaFullLandCard;
    public GameObject plusTwoManaFullLandCard;
    public GameObject plusOneManaNowLandCard;
    public GameObject plusTwoManaNowLandCard;
    public GameObject plusOneMoveFullLandCard;
    public GameObject plusTwoMoveFullLandCard;
    public GameObject plusOneMoveNowLandCard;
    public GameObject plusTwoMoveNowLandCard;

    [Header("Card 05 Direction Buttons")]
    public GameObject cs05DropBox;
    public GameObject c05UpButton;
    public GameObject c05minusUpButton;
    public GameObject c05RightButton;
    public GameObject c05minusRightButton;
    public GameObject c05ResolveButton;
    public GameObject cs05CancelButtonUp;
    public GameObject cs05CancelButtonMinusUp;
    public GameObject cs05CancelButtonRight;
    public GameObject cs05CancelButtonMinusRight;


    [Header("PlayerStats")]
    public Text idText;
    public Text hpText;
    public Text TypeText;
    public Text ManaNowText;
    public Text ManaMaxText;
    public Text MoveNowText;
    public Text MoveMaxText;
    public Text HandNowText;
    public Text HandMaxText;
    public Text PosHorizontalText;
    public Text PosVerticalText;

    [Header("Player Stats Bar")]
    public List<GameObject> HealthFull = new List<GameObject>();
    public List<GameObject> HealthPossible = new List<GameObject>();
    public List<GameObject> HealthEmpty = new List<GameObject>();
    public List<GameObject> ManaFull = new List<GameObject>();
    public List<GameObject> ManaPossible = new List<GameObject>();
    public List<GameObject> ManaEmpty = new List<GameObject>();
    public List<GameObject> MoveFull = new List<GameObject>();
    public List<GameObject> MovePossible = new List<GameObject>();
    public List<GameObject> MoveEmpty = new List<GameObject>();

    [Header("Turn Bar")]
    public List<GameObject> TurnActive = new List<GameObject>();
    public List<GameObject> TurnInActive = new List<GameObject>();





    public GameObject ResolvingCard;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void Update()
    {
        playerToken = GameObject.Find("PlayerToken(Clone)");
        //PLAYER STATS BOX

        hpText.text = "" + _userStatsManager.GetHealthNow().ToString();
        TypeText.text = "" + _userStatsManager.GetType().ToString();
        ManaNowText.text = "" + _userStatsManager.GetManaNow().ToString();
        ManaMaxText.text = "" + _userStatsManager.GetManaFull().ToString();
        MoveNowText.text = "" + _userStatsManager.GetMoveNow().ToString();
        MoveMaxText.text = "" + _userStatsManager.GetMoveFull().ToString();
        HandNowText.text = "" + _userStatsManager.GetHandNow().ToString();
        HandMaxText.text = "" + _userStatsManager.GetHandSize().ToString();
        PosHorizontalText.text = "" + _userStatsManager.GetPosHorizontal().ToString();
        PosVerticalText.text = "" + _userStatsManager.GetPosVertical().ToString();


        currentStateText.text = Sumo_GameManager.instance.currentGameState.ToString();
        numbersOfCards.text = Sumo_CardManager.deckSize.ToString();
        if (CardZone.GetComponent<Populated>().isNotPopulated == false)
        {
            ResolvingCard = CardZone.transform.GetChild(0).gameObject;
            if (ResolvingCard.GetComponent<DragDrop>().isDragging == false)
            {
                GameObject thisCard = ResolvingCard.transform.GetChild(0).gameObject;
                Card thisCardStats = thisCard.GetComponent<Card>();
                if (thisCardStats.id == 1)
                {
                    LandCardsDropBox.SetActive(true);
                    JustOneOptionManaLandCard.SetActive(true);
                    plusOneManaFullLandCard.SetActive(false);
                    plusTwoManaFullLandCard.SetActive(false);
                    plusOneManaNowLandCard.SetActive(false);
                    plusTwoManaNowLandCard.SetActive(false);
                    plusOneMoveFullLandCard.SetActive(false);
                    plusTwoMoveFullLandCard.SetActive(false);
                    plusOneMoveNowLandCard.SetActive(false);
                    plusTwoMoveNowLandCard.SetActive(true);
                    ResolveButton.SetActive(false);
                    CancelButton.SetActive(false);
                    PassButton.SetActive(false);
                    MoveButtonsBox.SetActive(false);
                    UpButton.SetActive(false);
                    minusUpButton.SetActive(false);
                    RightButton.SetActive(false);
                    minusRightButton.SetActive(false);
                    cs05DropBox.SetActive(false);
                    c05UpButton.SetActive(false);
                    c05minusUpButton.SetActive(false);
                    c05RightButton.SetActive(false);
                    c05minusRightButton.SetActive(false);
                    c05ResolveButton.SetActive(false);

                }
                else if (thisCardStats.id == 2)
                {
                    LandCardsDropBox.SetActive(true);
                    JustOneOptionManaLandCard.SetActive(true);
                    plusOneManaFullLandCard.SetActive(true);
                    plusTwoManaFullLandCard.SetActive(false);
                    plusOneManaNowLandCard.SetActive(false);
                    plusTwoManaNowLandCard.SetActive(false);
                    plusOneMoveFullLandCard.SetActive(false);
                    plusTwoMoveFullLandCard.SetActive(false);
                    plusOneMoveNowLandCard.SetActive(true);
                    plusTwoMoveNowLandCard.SetActive(false);
                    ResolveButton.SetActive(false);
                    CancelButton.SetActive(false);
                    PassButton.SetActive(false);
                    MoveButtonsBox.SetActive(false);
                    UpButton.SetActive(false);
                    minusUpButton.SetActive(false);
                    RightButton.SetActive(false);
                    minusRightButton.SetActive(false);
                    cs05DropBox.SetActive(false);
                    c05UpButton.SetActive(false);
                    c05minusUpButton.SetActive(false);
                    c05RightButton.SetActive(false);
                    c05minusRightButton.SetActive(false);
                    c05ResolveButton.SetActive(false);

                }
                else if (thisCardStats.id == 3)
                {
                    LandCardsDropBox.SetActive(true);
                    JustOneOptionManaLandCard.SetActive(true);
                    plusOneManaFullLandCard.SetActive(true);
                    plusTwoManaFullLandCard.SetActive(false);
                    plusOneManaNowLandCard.SetActive(false);
                    plusTwoManaNowLandCard.SetActive(false);
                    plusOneMoveFullLandCard.SetActive(false);
                    plusTwoMoveFullLandCard.SetActive(false);
                    plusOneMoveNowLandCard.SetActive(false);
                    plusTwoMoveNowLandCard.SetActive(false);
                    ResolveButton.SetActive(false);
                    CancelButton.SetActive(false);
                    PassButton.SetActive(false);
                    MoveButtonsBox.SetActive(false);
                    UpButton.SetActive(false);
                    minusUpButton.SetActive(false);
                    RightButton.SetActive(false);
                    minusRightButton.SetActive(false);
                    cs05DropBox.SetActive(false);
                    c05UpButton.SetActive(false);
                    c05minusUpButton.SetActive(false);
                    c05RightButton.SetActive(false);
                    c05minusRightButton.SetActive(false);
                    c05ResolveButton.SetActive(false);
                }
                else if (thisCardStats.id == 4)
                {
                    LandCardsDropBox.SetActive(true);
                    JustOneOptionManaLandCard.SetActive(true);
                    plusOneManaFullLandCard.SetActive(false);
                    plusTwoManaFullLandCard.SetActive(false);
                    plusOneManaNowLandCard.SetActive(false);
                    plusTwoManaNowLandCard.SetActive(false);
                    plusOneMoveFullLandCard.SetActive(true);
                    plusTwoMoveFullLandCard.SetActive(false);
                    plusOneMoveNowLandCard.SetActive(false);
                    plusTwoMoveNowLandCard.SetActive(false);
                    ResolveButton.SetActive(false);
                    CancelButton.SetActive(false);
                    PassButton.SetActive(false);
                    MoveButtonsBox.SetActive(false);
                    UpButton.SetActive(false);
                    minusUpButton.SetActive(false);
                    RightButton.SetActive(false);
                    minusRightButton.SetActive(false);
                    cs05DropBox.SetActive(false);
                    c05UpButton.SetActive(false);
                    c05minusUpButton.SetActive(false);
                    c05RightButton.SetActive(false);
                    c05minusRightButton.SetActive(false);
                    c05ResolveButton.SetActive(false);
                }
                else if (thisCardStats.id == 5)
                {
                    LandCardsDropBox.SetActive(false);
                    JustOneOptionManaLandCard.SetActive(false);
                    plusOneManaFullLandCard.SetActive(false);
                    plusTwoManaFullLandCard.SetActive(false);
                    plusOneManaNowLandCard.SetActive(false);
                    plusTwoManaNowLandCard.SetActive(false);
                    plusOneMoveFullLandCard.SetActive(false);
                    plusTwoMoveFullLandCard.SetActive(false);
                    plusOneMoveNowLandCard.SetActive(false);
                    plusTwoMoveNowLandCard.SetActive(false);
                    ResolveButton.SetActive(false);
                    CancelButton.SetActive(false);
                    PassButton.SetActive(false);
                    MoveButtonsBox.SetActive(false);
                    UpButton.SetActive(false);
                    minusUpButton.SetActive(false);
                    RightButton.SetActive(false);
                    minusRightButton.SetActive(false);
                    cs05DropBox.SetActive(true);
                    c05UpButton.SetActive(true);
                    c05minusUpButton.SetActive(true);
                    c05RightButton.SetActive(true);
                    c05minusRightButton.SetActive(true);
                    c05ResolveButton.SetActive(true);
                }
                else if (thisCardStats.id >5)
                {
                    LandCardsDropBox.SetActive(false);
                    JustOneOptionManaLandCard.SetActive(false);
                    plusOneManaFullLandCard.SetActive(false);
                    plusTwoManaFullLandCard.SetActive(false);
                    plusOneManaNowLandCard.SetActive(false);
                    plusTwoManaNowLandCard.SetActive(false);
                    plusOneMoveFullLandCard.SetActive(false);
                    plusTwoMoveFullLandCard.SetActive(false);
                    plusOneMoveNowLandCard.SetActive(false);
                    plusTwoMoveNowLandCard.SetActive(false);
                    ResolveButton.SetActive(true);
                    CancelButton.SetActive(true);
                    PassButton.SetActive(false);
                    MoveButtonsBox.SetActive(false);
                    UpButton.SetActive(false);
                    minusUpButton.SetActive(false);
                    RightButton.SetActive(false);
                    minusRightButton.SetActive(false);
                    cs05DropBox.SetActive(false);
                    c05UpButton.SetActive(false);
                    c05minusUpButton.SetActive(false);
                    c05RightButton.SetActive(false);
                    c05minusRightButton.SetActive(false);
                    c05ResolveButton.SetActive(false);
                }

            }
        }
        else if (CardZone.GetComponent<Populated>().isNotPopulated == true)
        {
            ResolveButton.SetActive(false);
            CancelButton.SetActive(false);
            PassButton.SetActive(true);
            MoveButtonsBox.SetActive(true);
            UpButton.SetActive(true);
            minusUpButton.SetActive(true);
            RightButton.SetActive(true);
            minusRightButton.SetActive(true);
            LandCardsDropBox.SetActive(false);
            JustOneOptionManaLandCard.SetActive(false);
            plusOneManaFullLandCard.SetActive(false);
            plusTwoManaFullLandCard.SetActive(false);
            plusOneManaNowLandCard.SetActive(false);
            plusTwoManaNowLandCard.SetActive(false);
            plusOneMoveFullLandCard.SetActive(false);
            plusTwoMoveFullLandCard.SetActive(false);
            plusOneMoveNowLandCard.SetActive(false);
            plusTwoMoveNowLandCard.SetActive(false);
            cs05DropBox.SetActive(false);
            c05UpButton.SetActive(false);
            c05minusUpButton.SetActive(false);
            c05RightButton.SetActive(false);
            c05minusRightButton.SetActive(false);
            c05ResolveButton.SetActive(false);
            cs05CancelButtonUp.SetActive(false);
            cs05CancelButtonMinusUp.SetActive(false);
            cs05CancelButtonRight.SetActive(false);
            cs05CancelButtonMinusRight.SetActive(false);
        }
        if (gameManager.currentGameState == Game.State.playerMove)
        {
            MoveButtonsBox.SetActive(true);
            UpButton.SetActive(true);
            minusUpButton.SetActive(true);
            RightButton.SetActive(true);
            minusRightButton.SetActive(true);       
        }
        else if (gameManager.currentGameState != Game.State.playerMove)
        {
            MoveButtonsBox.SetActive(false);
            UpButton.SetActive(false);
            minusUpButton.SetActive(false);
            RightButton.SetActive(false);
            minusRightButton.SetActive(false);
        }

//HEALTH BAR
        if (Sumo_GameManager.instance._playerStats.GetHealthFull() >= 0)
        {

            for (int i = 0; i < (Sumo_GameManager.instance._playerStats.GetHealthNow() / 10); i++)
            {
                HealthFull[i].SetActive(true);
            }
            for (int i = 9; i >= (Sumo_GameManager.instance._playerStats.GetHealthNow() / 10); i--)
            {
                HealthFull[i].SetActive(false);
            }
            for (int i = 0; i < (Sumo_GameManager.instance._playerStats.GetHealthFull() / 10); i++)
            {
                HealthPossible[i].SetActive(true);
            }
            for (int i = 9; i >= (Sumo_GameManager.instance._playerStats.GetHealthFull() / 10); i--)
            {
                HealthPossible[i].SetActive(false);
            }
        }
        //MANA BAR
        if (Sumo_GameManager.instance._playerStats.GetManaFull() >= 0)
        {

            for (int i = 0; i < Sumo_GameManager.instance._playerStats.GetManaNow(); i++)
            {
                ManaFull[i].SetActive(true);
            }
            for (int i = 9; i >= Sumo_GameManager.instance._playerStats.GetManaNow(); i--)
            {
                ManaFull[i].SetActive(false);
            }
            for (int i = 0; i < Sumo_GameManager.instance._playerStats.GetManaFull(); i++)
            {
                ManaPossible[i].SetActive(true);
            }
            for (int i = 9; i >= Sumo_GameManager.instance._playerStats.GetManaFull(); i--)
            {
                ManaPossible[i].SetActive(false);
            }
        }
//MOVE BAR


        if (Sumo_GameManager.instance._playerStats.GetMoveFull() >= 0)
        {

                for (int i = 0; i < Sumo_GameManager.instance._playerStats.GetMoveNow(); i++)
                {
                    MoveFull[i].SetActive(true);
                }
                for (int i = 9; i >= Sumo_GameManager.instance._playerStats.GetMoveNow(); i--)
                {
                    MoveFull[i].SetActive(false);
                }
                for (int i = 0; i < Sumo_GameManager.instance._playerStats.GetMoveFull(); i++)
                {
                    MovePossible[i].SetActive(true);
                }
                for (int i = 9; i >= Sumo_GameManager.instance._playerStats.GetMoveFull(); i--)
                {
                    MovePossible[i].SetActive(false);
                }
        }


        if (Sumo_GameManager.instance._playerStats.GetHealthNow() == 100)
        {

        }

    }
    public void ClickMoveUp()
    {
        _gridManager.MoveOneTile("up", 1, playerToken);
    }
    public void OnClickMinusUp()
    {
        _gridManager.MoveOneTile("-up", 1, playerToken);
    }
    public void OnClickRight()
    {
        _gridManager.MoveOneTile("right", 1, playerToken);
    }
    public void OnClickMinusRight()
    {
        _gridManager.MoveOneTile("-right", 1, playerToken);
    }
    public void AddManaFullLandCard(int value)
    {
        GameObject thisCard = ResolvingCard.gameObject;
        _userStatsManager.AddManaFull(value);
        Destroy(thisCard);
        _userStatsManager.ReduceHandNow(1);
        _userStatsManager.ReduceManaCardCounterNow(1);
    }
    public void AddManaNowLandCard(int value)
    {
        GameObject thisCard = ResolvingCard.gameObject;
        _userStatsManager.AddManaNow(value);
            Destroy(this);
        _userStatsManager.ReduceHandNow(1);
        _userStatsManager.ReduceManaCardCounterNow(1);
    }
    public void AddMoveFullLandCard(int value)
    {
        GameObject thisCard = ResolvingCard.gameObject;
        _userStatsManager.AddMoveFull(value);
        Destroy(thisCard);
        _userStatsManager.ReduceHandNow(1);
        _userStatsManager.ReduceManaCardCounterNow(1);
    }
    public void AddMoveNowLandCard(int value)
    {
        GameObject thisCard = ResolvingCard.gameObject;
        _userStatsManager.AddMoveNow(value);
        Destroy(thisCard);
        _userStatsManager.ReduceHandNow(1);
        _userStatsManager.ReduceManaCardCounterNow(1);
    }
    public void c05Cast(string direction)
    {
        if (direction == "Up")
        {
            GameObject thisCard = ResolvingCard.gameObject;
            GameObject _thisCard = thisCard.transform.GetChild(0).gameObject;
            Card thisCardStats = _thisCard.GetComponent<Card>();
            spellDeck.PushAndDiamonAttackPattern(playerToken, direction, thisCardStats.power, "No");
            cs05CancelButtonUp.SetActive(true);
            cs05CancelButtonMinusUp.SetActive(false);
            cs05CancelButtonRight.SetActive(false);
            cs05CancelButtonMinusRight.SetActive(false);
        }
        else if (direction == "minusUp")
        {
            GameObject thisCard = ResolvingCard.gameObject;
            GameObject _thisCard = thisCard.transform.GetChild(0).gameObject;
            Card thisCardStats = _thisCard.GetComponent<Card>();
            spellDeck.PushAndDiamonAttackPattern(playerToken, direction, thisCardStats.power, "No");
            cs05CancelButtonUp.SetActive(false);
            cs05CancelButtonMinusUp.SetActive(true);
            cs05CancelButtonRight.SetActive(false);
            cs05CancelButtonMinusRight.SetActive(false);
        }
        else if (direction == "Right")
        {
            GameObject thisCard = ResolvingCard.gameObject;
            GameObject _thisCard = thisCard.transform.GetChild(0).gameObject;
            Card thisCardStats = _thisCard.GetComponent<Card>();
            spellDeck.PushAndDiamonAttackPattern(playerToken, direction, thisCardStats.power, "No");
            cs05CancelButtonUp.SetActive(false);
            cs05CancelButtonMinusUp.SetActive(false);
            cs05CancelButtonRight.SetActive(true);
            cs05CancelButtonMinusRight.SetActive(false);
        }
        else if (direction == "minusRight")
        {
            GameObject thisCard = ResolvingCard.gameObject;
            GameObject _thisCard = thisCard.transform.GetChild(0).gameObject;
            Card thisCardStats = _thisCard.GetComponent<Card>();
            spellDeck.PushAndDiamonAttackPattern(playerToken, direction, thisCardStats.power, "No");
            cs05CancelButtonUp.SetActive(false);
            cs05CancelButtonMinusUp.SetActive(false);
            cs05CancelButtonRight.SetActive(false);
            cs05CancelButtonMinusRight.SetActive(true);
        }

    }
    public void c05Resolve()
    {
        GameObject thisCard = ResolvingCard.gameObject;
        GameObject _thisCard = thisCard.transform.GetChild(0).gameObject;
        Card thisCardStats = _thisCard.GetComponent<Card>();
        _userStatsManager.ReduceManaNow(thisCardStats.cost);
        Destroy(thisCard);
        _userStatsManager.ReduceHandNow(1);
    }
    public void cs05Cancel(string direction)
    {
        GameObject thisCard = ResolvingCard.gameObject;
        GameObject _thisCard = thisCard.transform.GetChild(0).gameObject;
        Card thisCardStats = _thisCard.GetComponent<Card>();
        spellDeck.PushAndDiamonAttackPattern(playerToken, direction, thisCardStats.power, "Yes");
        Sumo_GameManager.instance.CancelClick();
    }

    public void RefreshTurnBar()
    {
//PLAYER TURN
        if (Sumo_GameManager.instance.currentGameState == Game.State.playerUntap)
        {
            for (int i = 0; i <= 7; i++)
            {
                if (i == 0)
                { 
                    TurnActive[i].SetActive(true); 
                }
                else 
                {
                    TurnActive[i].SetActive(false);
                }

            }
        }
        else if (Sumo_GameManager.instance.currentGameState == Game.State.playerUpkeep)
        {
            for (int i = 0; i <= 7; i++)
            {
                if (i == 1)
                {
                    TurnActive[i].SetActive(true);
                }
                else
                {
                    TurnActive[i].SetActive(false);
                }

            }

        }
        else if (Sumo_GameManager.instance.currentGameState == Game.State.playerDraw)
        {
            for (int i = 0; i <= 7; i++)
            {
                if (i == 2)
                {
                    TurnActive[i].SetActive(true);
                }
                else
                {
                    TurnActive[i].SetActive(false);
                }

            }

        }
        else if (Sumo_GameManager.instance.currentGameState == Game.State.playerPlay1)
        {
            for (int i = 0; i <= 7; i++)
            {
                if (i == 3)
                {
                    TurnActive[i].SetActive(true);
                }
                else
                {
                    TurnActive[i].SetActive(false);
                }

            }

        }
        else if (Sumo_GameManager.instance.currentGameState == Game.State.playerMove)
        {
            for (int i = 0; i <= 7; i++)
            {
                if (i == 4)
                {
                    TurnActive[i].SetActive(true);
                }
                else
                {
                    TurnActive[i].SetActive(false);
                }

            }

        }
        else if (Sumo_GameManager.instance.currentGameState == Game.State.playerResolveDMG)
        {
            for (int i = 0; i <= 7; i++)
            {
                if (i == 5)
                {
                    TurnActive[i].SetActive(true);
                }
                else
                {
                    TurnActive[i].SetActive(false);
                }

            }

        }
        else if (Sumo_GameManager.instance.currentGameState == Game.State.playerPlay2)
        {
            for (int i = 0; i <= 7; i++)
            {
                if (i == 6)
                {
                    TurnActive[i].SetActive(true);
                }
                else
                {
                    TurnActive[i].SetActive(false);
                }

            }

        }
        else if (Sumo_GameManager.instance.currentGameState == Game.State.playerCleanUp)
        {
            for (int i = 0; i <= 7; i++)
            {
                if (i == 7)
                {
                    TurnActive[i].SetActive(true);
                }
                else
                {
                    TurnActive[i].SetActive(false);
                }

            }

        }

//AI TURN
        if (Sumo_GameManager.instance.currentGameState == Game.State.aiUntap)
        {

        }
        else if (Sumo_GameManager.instance.currentGameState == Game.State.aiUpkeep)
        { }
        else if (Sumo_GameManager.instance.currentGameState == Game.State.aiMove)
        { }
        else if (Sumo_GameManager.instance.currentGameState == Game.State.aiPlay)
        { }
        else if (Sumo_GameManager.instance.currentGameState == Game.State.playerTrigger1)
        { }
        else if (Sumo_GameManager.instance.currentGameState == Game.State.aiResolveDMG)
        { }
        else if (Sumo_GameManager.instance.currentGameState == Game.State.playerTrigger2)
        { }
        else if (Sumo_GameManager.instance.currentGameState == Game.State.aiCleanUp)
        { }

    }


    
}