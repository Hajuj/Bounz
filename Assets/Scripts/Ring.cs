using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    public bool active = true;
    public GameManager gameManager;
    public SpriteRenderer spriteRenderer;
    public Sprite ringCollected;

    void OnTriggerEnter2D(Collider2D col)
    {

        if(col.gameObject.tag != "BigPlayer" && active){
            gameManager.CollectRing();
            active = false;
            Debug.Log("collect Ring!");
            spriteRenderer.sprite = ringCollected;

          
        }
       
    }
       void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("collided, stop");
      
    }
}
