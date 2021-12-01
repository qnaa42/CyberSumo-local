using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GPC;

public class DragDrop : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject DropZone;
    public GameObject thisCard;
    private Card thisCardStats;
    
    

    public bool isDragging = false;

    [SerializeField]
    private GameObject startParent;
    private Vector2 startPosition;
    private GameObject dropZone;
    [SerializeField]
    private bool isOverdropZone;
    private GameObject CardArea;
    private GameObject PlayerArea;



    // Start is called before the first frame update
    void Update()
    {
        thisCard = this.gameObject.transform.GetChild(0).gameObject;
        thisCardStats = thisCard.GetComponent<Card>();

        Canvas = GameObject.Find("Main Canvas");
        DropZone = GameObject.Find("DropZone");
        CardArea = GameObject.Find("CardZone");
        dropZone = GameObject.Find("CardZone");
        PlayerArea = GameObject.Find("PlayerArea");

        if (isDragging && Sumo_GameManager.instance.isPlayable == true)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            transform.SetParent(Canvas.transform, true);
        }

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (Sumo_GameManager.instance.isPlayable == true)
        {
            if (collision.gameObject.tag == "DropZone" && CardArea.gameObject.GetComponent<Populated>().isNotPopulated == true)
            {
                isOverdropZone = true;
            }
            else
            {
                isOverdropZone = false;
                dropZone = null;
            }
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isOverdropZone = false;
        dropZone = null;
    }

    public void StartDrag()
    {
        if (Sumo_GameManager.instance.isPlayable == true)
        {
            isDragging = true;
            startParent = PlayerArea.transform.gameObject;
            startPosition = PlayerArea.transform.position;
        }
    }
    public void EndDrag()
    {
        if (Sumo_GameManager.instance.isPlayable == true)
        {
            isDragging = false;
            if (isOverdropZone)
            {
                if (thisCardStats.id >= 1 && thisCardStats.id <=4)
                {
                    if (Sumo_GameManager.instance._playerStats.GetManaCardCounterNow() > 0)
                    { 
                        transform.SetParent(dropZone.transform, true);
                        Vector2 newScale = transform.transform.localScale;
                    }
                    else
                    {
                        transform.SetParent(startParent.transform, true);
                    }
                }
                //!!!!! 5 for now, increase when more card with cast emmerges !!!!!!!
                else if (thisCardStats.id == 5)
                {
                    if (Sumo_GameManager.instance._playerStats.GetManaNow() >= thisCardStats.cost)
                    {
                        transform.SetParent(dropZone.transform, true);
                    }
                    else
                    {
                        transform.SetParent(startParent.transform, true);
                    }
                }
                else
                {
                    transform.SetParent(dropZone.transform, true);
                }
            }
            else
            {
                transform.SetParent(startParent.transform, true);
            }
        }
    }   
}
