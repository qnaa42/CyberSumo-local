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

    public GameObject playerToken;



    public GameObject ResolveButton;
    public GameObject CancelButton;
    public GameObject PassButton;
    public GameObject CardZone;

    [Header("MoveButtons")]
    public GameObject UpButton;
    public GameObject minusUpButton;
    public GameObject RightButton;
    public GameObject minusRightButton;

    public Text currentStateText;
    public Text numbersOfCards;

    [Header("Land Cards Buttons")]
    public GameObject JustOneOptionManaLandCard;
    public GameObject plusOneManaFullLandCard;
    public GameObject plusTwoManaFullLandCard;
    public GameObject plusOneManaNowLandCard;
    public GameObject plusTwoManaNowLandCard;
    public GameObject plusOneMoveFullLandCard;
    public GameObject plusTwoMoveFullLandCard;
    public GameObject plusOneMoveNowLandCard;
    public GameObject plusTwoMoveNowLandCard;


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





    public GameObject ResolvingCard;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void Update()
    {
        playerToken = GameObject.Find("PlayerToken(Clone)");
        //PLAYER STATS BOX

        hpText.text = "" + _userStatsManager.GetHealth().ToString();
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
        //        hpText.text = "" + HP;
        if (CardZone.GetComponent<Populated>().isNotPopulated == false)
        {
            ResolvingCard = CardZone.transform.GetChild(0).gameObject;
            if (ResolvingCard.GetComponent<DragDrop>().isDragging == false)
            {
                GameObject thisCard = ResolvingCard.transform.GetChild(0).gameObject;
                Card thisCardStats = thisCard.GetComponent<Card>();
                if (thisCardStats.id == 1)
                {
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
                    UpButton.SetActive(false);
                    minusUpButton.SetActive(false);
                    RightButton.SetActive(false);
                    minusRightButton.SetActive(false);

                }
                else if (thisCardStats.id == 2)
                {
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
                    UpButton.SetActive(false);
                    minusUpButton.SetActive(false);
                    RightButton.SetActive(false);
                    minusRightButton.SetActive(false);

                }
                else if (thisCardStats.id == 3)
                {
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
                    UpButton.SetActive(false);
                    minusUpButton.SetActive(false);
                    RightButton.SetActive(false);
                    minusRightButton.SetActive(false);
                }
                else if (thisCardStats.id == 4)
                {
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
                    UpButton.SetActive(false);
                    minusUpButton.SetActive(false);
                    RightButton.SetActive(false);
                    minusRightButton.SetActive(false);
                }
                else if (thisCardStats.id > 4)
                {
                    JustOneOptionManaLandCard.SetActive(false);
                    plusOneManaFullLandCard.SetActive(false);
                    plusTwoManaFullLandCard.SetActive(false);
                    plusOneManaNowLandCard.SetActive(false);
                    plusTwoManaNowLandCard.SetActive(false);
                    plusOneMoveFullLandCard.SetActive(false);
                    plusTwoMoveFullLandCard.SetActive(false);
                    plusOneMoveNowLandCard.SetActive(false);
                    plusTwoMoveNowLandCard.SetActive(false);
                    // Debug.Log("collisionin");
                    ResolveButton.SetActive(true);
                    CancelButton.SetActive(true);
                    PassButton.SetActive(false);
                    UpButton.SetActive(false);
                    minusUpButton.SetActive(false);
                    RightButton.SetActive(false);
                    minusRightButton.SetActive(false);
                }

            }
        }
        else if (CardZone.GetComponent<Populated>().isNotPopulated == true)
        {
            ResolveButton.SetActive(false);
            CancelButton.SetActive(false);
            PassButton.SetActive(true);
            UpButton.SetActive(true);
            minusUpButton.SetActive(true);
            RightButton.SetActive(true);
            minusRightButton.SetActive(true);
        }
        if (gameManager.currentGameState == Game.State.playerMove)
        {
            UpButton.SetActive(true);
            minusUpButton.SetActive(true);
            RightButton.SetActive(true);
            minusRightButton.SetActive(true);       
        }
        else if (gameManager.currentGameState != Game.State.playerMove)
        {
            UpButton.SetActive(false);
            minusUpButton.SetActive(false);
            RightButton.SetActive(false);
            minusRightButton.SetActive(false);
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
    }
    public void AddManaNowLandCard(int value)
    {
        GameObject thisCard = ResolvingCard.gameObject;
        _userStatsManager.AddManaNow(value);
            Destroy(this);
    }
    public void AddMoveFullLandCard(int value)
    {
        GameObject thisCard = ResolvingCard.gameObject;
        _userStatsManager.AddMoveFull(value);
        Destroy(thisCard);
    }
    public void AddMoveNowLandCard(int value)
    {
        GameObject thisCard = ResolvingCard.gameObject;
        _userStatsManager.AddMoveNow(value);
        Destroy(thisCard);
    }
}
