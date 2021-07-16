using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private Rigidbody2D playersRigidBody;

    void OnTriggerEnter2D(Collider2D other)
    {
        player.transform.position = respawnPoint.transform.position;
        playersRigidBody.velocity = new Vector2(0, 0);
    }
}
