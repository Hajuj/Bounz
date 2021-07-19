using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Damage : MonoBehaviour
{
    public static Transform checkpoint;
    public GameManager gameManager;
    private float updateValue;
    public GameObject healthBalls;
    public bool isStationary;
    

    void Start() {
        updateValue = 0.02f;
        GameObject eg = new GameObject();
        eg.transform.Translate(-5f,-1f,0f);
        checkpoint = eg.transform;
        Debug.Log("FUCK");
    }
    void Update () {  
        if(!isStationary){
        transform.Translate (0f, updateValue, 0f); 
        } 
          
    }  

    void OnCollisionEnter2D(Collision2D collider) {
        if(collider.gameObject.tag == "Player" || collider.gameObject.tag == "BigPlayer") {
            Debug.Log("Hey Morty we are lost in the universe!");
            gameManager.UpdateHealth(healthBalls, false);
            if(gameManager.health > 0) {
                collider.transform.position = checkpoint.transform.position;
            }else{
                 gameManager.EndGame();
            }
        }       
    }

    public void UpdateValue(){
        updateValue = updateValue*-1;
    }


    
}
