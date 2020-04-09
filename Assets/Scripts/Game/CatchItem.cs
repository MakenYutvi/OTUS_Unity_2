using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchItem : MonoBehaviour
{
    public GameObject _item;
    // Start is called before the first frame update
    void Start()
    {
       // _item = GetComponentInParent < GameObject >();
    }

    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //Player.GameOver();
        Debug.Log("catch");
        _item.SetActive(false);
        

    }
}
