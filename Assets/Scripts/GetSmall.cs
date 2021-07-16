using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GetSmall : MonoBehaviour
{
    public GameObject smallPlayer;

    void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log("collided, its a small step for a square but a big step for all circles");
        if(col.gameObject.tag == "BigPlayer")
        {
            Vector3 pos;
            pos = col.transform.position;
            //Quanterion rot;
            //rot = col.transform.rotation;
            Instantiate(smallPlayer, pos, col.transform.rotation);
            Destroy(col.gameObject);
        }
    }
}
