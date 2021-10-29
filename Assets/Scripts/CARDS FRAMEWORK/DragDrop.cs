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
    private bool isOverdropZone;
    private GameObject CardArea;



    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.Find("Main Canvas");
        DropZone = GameObject.Find("DropZone");
        CardArea = GameObject.Find("CardZone");
        startParent = GameObject.Find("PlayerArea");
     //   bool isNotPopulated = GameObject.Find("CardZone").GetComponent<>
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Sumo_GameManager.instance.isPlayable == true)
        {
            if (collision.gameObject.tag == "DropZone" && CardArea.gameObject.GetComponent<Populated>().isNotPopulated == true)
            {
                isOverdropZone = true;

                dropZone = GameObject.Find("CardZone");
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
         //   startParent = transform.parent.gameObject;
            startPosition = transform.position;
        }
    }
    public void EndDrag()
    {
        if (Sumo_GameManager.instance.isPlayable == true)
        {
            isDragging = false;
            if (isOverdropZone)
            {
                transform.SetParent(dropZone.transform, false);
            }
            else
            {
                transform.position = startPosition;
            //    transform.SetParent(startParent.transform, false);
                transform.parent = startParent.transform;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isDragging && Sumo_GameManager.instance.isPlayable == true)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            transform.SetParent(Canvas.transform, true);
        }
    }

    
}
