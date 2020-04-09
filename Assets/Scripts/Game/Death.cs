using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public string _nameOfCharacter;

        public void OnTriggerEnter2D(Collider2D collision)
        {
       // Debug.Log(collision.gameObject.tag);
        //Debug.Log(collision.gameObject.name);
        if (collision.gameObject.CompareTag("Player"))    
        {
            Player.GameOver();
        }
        

    }
    
}
