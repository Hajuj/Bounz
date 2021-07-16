using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Damage : MonoBehaviour
{
    public GameObject checkPoint;
    private Vector3 checkPos;
    public GameManager gameManager;
    private float updateValue;
    public GameObject healthBalls;

    void Start() {
        checkPos = checkPoint.transform.position;
        updateValue = 0.05f;
        Debug.Log("FUCK");
    }
    void Update () {  
        transform.Translate (0f, updateValue, 0f);  
          
    }  

    void OnCollisionEnter2D(Collision2D collider) {
        if(collider.gameObject.tag == "Player" || collider.gameObject.tag == "BigPlayer") {
            Debug.Log("Hey Morty we are lost in the universe!");
            gameManager.DecreaseHealth(healthBalls);
            if(gameManager.health > 0) {
                collider.transform.position = checkPos;
            }
        }       
    }

    public void UpdateValue(){
        updateValue = updateValue*-1;
    }

    
}
