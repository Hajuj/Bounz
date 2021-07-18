using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public GameObject checkpoint;
    public Sprite checkpointCollected;
    public SpriteRenderer checkpointSpriteRenderer;
    public bool isTaken;
    
    void Start(){
        isTaken = false;
    }
   void OnTriggerEnter2D(Collider2D col)
    {
        if(!isTaken){
            isTaken = true;
        checkpointSpriteRenderer.sprite = checkpointCollected;
        //Respawn.respawnPoint = checkpoint.transform;
        Damage.checkpoint = checkpoint.transform;
        SoundManager.PlayCheckSound();
        }
    }
}
