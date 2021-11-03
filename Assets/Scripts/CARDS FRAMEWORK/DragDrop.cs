using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject DropZone;
    
    

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
            startParent = PlayerArea.transform.parent.gameObject;
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
                transform.SetParent(dropZone.transform, true);
            }
            else
            {
                transform.position = startPosition;
                transform.SetParent(startParent.transform, true);
                transform.parent = startParent.transform;
            }
        }
    }   
}
