using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public GameObject checkpoint;
    public Sprite checkpointCollected;
    public SpriteRenderer checkpointSpriteRenderer;

   void OnTriggerEnter2D(Collider2D col)
    {
        checkpointSpriteRenderer.sprite = checkpointCollected;
        //Respawn.respawnPoint = checkpoint.transform;
        Damage.checkpoint = checkpoint.transform;
    }
}
