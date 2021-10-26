using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBackPrefab : MonoBehaviour
{
    public GameObject Deck;
    public GameObject It;
    // Start is called before the first frame update
    void Start()
    {
        Deck = GameObject.Find("Deck Panel");
    }

    // Update is called once per frame
    void Update()
    {
        It.transform.SetParent(Deck.transform, true);
        It.transform.localScale = Vector3.one;
        It.transform.position = new Vector3(transform.position.x, transform.position.y, -48);
        It.transform.eulerAngles = new Vector3(25, 0, 0);
    }
}
