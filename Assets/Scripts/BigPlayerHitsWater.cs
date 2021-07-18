using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigPlayerHitsWater : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log("trigger!!!");
        Rigidbody2D colRb;
        colRb = col.GetComponent<Rigidbody2D>();

        
        
        if(col.gameObject.tag == "Player" || col.gameObject.tag == "BigPlayer")
        {
            SoundManager.PlaySplashSound();
            if(col.gameObject.tag == "BigPlayer")
            {
                colRb.gravityScale = -1;
            }
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log("byebye trigger");
        Rigidbody2D colRb;
        colRb = col.GetComponent<Rigidbody2D>();
        if (col.gameObject.tag == "BigPlayer")
        {
            colRb.gravityScale = 1;
        }
    }
}
