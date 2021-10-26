using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPrefab : MonoBehaviour
{

    public GameObject Hand;
    public GameObject It;

    // Start is called before the first frame update
    void Start()
    {
        Hand = GameObject.Find("PlayerArea");   
    }

    // Update is called once per frame
    void Update()
    {
        It.transform.SetParent(Hand.transform, false);
        It.transform.localScale = Vector3.one;
        It.transform.position = new Vector3(transform.position.x, transform.position.y, -48);
        It.transform.eulerAngles = new Vector3(25, 0, 0);
    }
}
