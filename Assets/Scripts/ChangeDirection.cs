using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDirection : MonoBehaviour
{
        void OnTriggerEnter2D(Collider2D col)
        {
 Debug.Log(col.gameObject.tag);
    if(col.gameObject.tag == "Virus")
        {
        col.gameObject.GetComponent<Damage>().UpdateValue();
        Debug.Log("Fuck Me");
        }
    }
}
