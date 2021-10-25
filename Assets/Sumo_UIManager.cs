using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GPC;

public class Sumo_UIManager : MonoBehaviour
{
    public Sumo_UIManager _uiManager;

    public GameObject ResolveButton;
    public GameObject CancelButton;
    public GameObject PassButton;
    public GameObject CardZone;

    public Text currentStateText;


    private GameObject ResolvingCard;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void Update()
    {
        currentStateText.text = Sumo_GameManager.instance.currentGameState.ToString();
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
