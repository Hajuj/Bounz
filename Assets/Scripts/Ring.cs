using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class Ring : MonoBehaviour
{
    public bool active = true;
    public bool forBig;
    public GameManager gameManager;
    public SpriteRenderer spriteRendererBack;
    public SpriteRenderer spriteRendererFront;
    public GameObject canvasRing;
    public Sprite ringCollected;
    public Sprite ringCollectedBack;
    public Sprite ringCollectedFront;

    void OnTriggerEnter2D(Collider2D col)
    {

        if((forBig||col.gameObject.tag != "BigPlayer") && active){
            gameManager.CollectRing();
            active = false;
            Debug.Log("collect Ring!");
            spriteRendererBack.sprite = ringCollectedBack;
            spriteRendererFront.sprite = ringCollectedFront;
            canvasRing.GetComponent<UnityEngine.UI.Image>().sprite = ringCollected;
            SoundManager.PlayRingSound();

          
        }
       
    }
       void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("collided, stop");
      
    }
}
