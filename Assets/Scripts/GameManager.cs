using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject completeLevelUI;
    public int health = 3;
     public int numRings;
    public int collectedRings;
    public bool allRingsCollected;

    public GameManager(){
        numRings = 2;
        collectedRings = 0;
        allRingsCollected = false;
    }

    public void DecreaseHealth() {
        health--;
        if (health == 0) {
            Debug.Log("YOU ARE DEAD BITCH!");
            EndGame();
        }
    }
    
    public void CollectRing(){
        collectedRings++;
        if(collectedRings==numRings){
            allRingsCollected = true;
        }
    }

    void EndGame()
    {
        Debug.Log("GAME OVER! Hard as this may be to believe, it's possible that I'm not boyfriend material.");

        completeLevelUI.SetActive(true);
    }

    public void CompleteLevel ()
    {
        if(allRingsCollected){
            Debug.Log("LEVEL WON! See? He's her lobster.");
            completeLevelUI.SetActive(true);
        }else{
            Debug.Log("Joey doesn't share his food! Get your own rings.");
        }
    }
}
