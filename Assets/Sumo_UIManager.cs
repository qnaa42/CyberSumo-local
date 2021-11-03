using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GPC;

public class Sumo_UIManager : MonoBehaviour
{
    public Sumo_UIManager _uiManager;
    public BaseUserManager _userManager;
    public BasePlayerStatsController _userStatsManager;

    public GameObject ResolveButton;
    public GameObject CancelButton;
    public GameObject PassButton;
    public GameObject CardZone;

    public Text currentStateText;
    public Text numbersOfCards;

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



    private GameObject ResolvingCard;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void Update()
    {
        //   int ID = BaseUserManager.global_userDatas[0].id;
    //    int HP = BasePlayerStatsController.PlayerStats.GetHealth().ToString();
        int type = BaseUserManager.global_userDatas[0].type;
        int ManaNow = BaseUserManager.global_userDatas[0].ManaNow;
        int ManaMax = BaseUserManager.global_userDatas[0].ManaFull;
        int MoveNow = BaseUserManager.global_userDatas[0].MoveNow;
        int MoveMax = BaseUserManager.global_userDatas[0].MoveFull;
        int HandNow = BaseUserManager.global_userDatas[0].HandNow;
        int HandMax = BaseUserManager.global_userDatas[0].HandSize;
        int PosHorizontal = BaseUserManager.global_userDatas[0].PosHorizontal;
        int PosVertical = BaseUserManager.global_userDatas[0].PosVertical;
        currentStateText.text = Sumo_GameManager.instance.currentGameState.ToString();
        numbersOfCards.text = Sumo_CardManager.deckSize.ToString();
//        hpText.text = "" + HP;
        if (CardZone.GetComponent<Populated>().isNotPopulated == false)
        {
            ResolvingCard = CardZone.transform.GetChild(0).gameObject;
            if (ResolvingCard.GetComponent<DragDrop>().isDragging == false)
            {
                // Debug.Log("collisionin");
                ResolveButton.SetActive(true);
                CancelButton.SetActive(true);
                PassButton.SetActive(false);

            }
        }
        else if (CardZone.GetComponent<Populated>().isNotPopulated == true)
        {
            ResolveButton.SetActive(false);
            CancelButton.SetActive(false);
            PassButton.SetActive(true);
        }
        
    }
}
