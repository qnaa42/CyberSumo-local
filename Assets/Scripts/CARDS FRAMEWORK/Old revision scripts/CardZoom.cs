using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CardZoom : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject ZoomCard;
    public float offsetx;
    public float offsety;

    private GameObject zoomCard;
    private Sprite zoomSprite;
    
    public void Awake()
    {
        Canvas = GameObject.Find("Main Canvas");
        zoomSprite = gameObject.GetComponent<Image>().sprite;
    }

    // Update is called once per frame
    public void OnHoverEnter()
    {
        zoomCard = Instantiate(ZoomCard, new Vector2(Input.mousePosition.x + offsetx, Input.mousePosition.y + offsety), Quaternion.identity);
        zoomCard.GetComponent<Image>().sprite = zoomSprite;
        zoomCard.transform.SetParent(Canvas.transform, true);
        RectTransform rect = zoomCard.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(600, 900);
    }
    public void OnHoverExit()
    {
        Destroy(zoomCard);
    }
}
