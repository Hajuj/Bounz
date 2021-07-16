using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GetBig : MonoBehaviour
{
    public GameObject bigPlayer;

    void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log("collided, its a small step for a square but a big step for all circles");
        if (col.gameObject.tag == "Player")
        {
            Vector3 pos;
            pos = col.transform.position;
            Instantiate(bigPlayer, pos, col.transform.rotation);
            Destroy(col.gameObject);
            
        }
    }


}
