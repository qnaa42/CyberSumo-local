using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardFlipper : MonoBehaviour
{
    public Sprite cardFront;
    public Sprite cardBack;

    // Fliping card script, based on sprite displayed
    public void Flip()
    {
        Sprite currentSprite = gameObject.GetComponent<Image>().sprite;
        if (currentSprite == cardFront)
        {
            gameObject.GetComponent<Image>().sprite = cardBack;
        }
        else
        {
            gameObject.GetComponent<Image>().sprite = cardFront;
        }
    }
   
}
