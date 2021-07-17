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
    public Sprite oneBall;
    public Sprite twoBall;
    public Sprite threeBall;
    private static int level =1;

    public GameManager(){
        numRings = 3;
        collectedRings = 0;
        allRingsCollected = false;
        level=1;

    }

    public void DecreaseHealth(GameObject healthBalls) {
        health--;
         switch (health)
         {
          case 1:
              healthBalls.GetComponent<UnityEngine.UI.Image>().sprite = oneBall;
              break;
          case 2:
              healthBalls.GetComponent<UnityEngine.UI.Image>().sprite = twoBall;
              break;
          case 3:
              healthBalls.GetComponent<UnityEngine.UI.Image>().sprite = threeBall;
              break;
          case 0:
            Debug.Log("YOU ARE DEAD BITCH!");
            EndGame();
                          break;
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
            SceneManager.LoadScene(1);
            level++;
            
        }else{
            Debug.Log("Joey doesn't share his food! Get your own rings.");
        }
    }

    public static int GetLevel(){
        return level;
    }
}
