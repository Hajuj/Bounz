using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject completeLevelUI;
    public GameObject youLostUI;
    public int health = 3;
    public int numRings;
    public int collectedRings;
    public bool allRingsCollected;
    public Sprite oneBall;
    public Sprite twoBall;
    public Sprite threeBall;
    public Sprite fourBall;
    public Sprite fiveBall;
    private static int level =1;

    void Start(){
        numRings = 3;
        collectedRings = 0;
        allRingsCollected = false;
        level=1;

    }

    public void UpdateHealth(GameObject healthBalls, bool increase) {
        if(increase){health++;}else{health--;}
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
          case 4:
              healthBalls.GetComponent<UnityEngine.UI.Image>().sprite = fourBall;
              break;
          case 5:
              healthBalls.GetComponent<UnityEngine.UI.Image>().sprite = fiveBall;
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

        youLostUI.SetActive(true);
        StartCoroutine(CoroutineYouLost(1f));
    }

    public void CompleteLevel ()
    {
        if(allRingsCollected){
            Debug.Log("LEVEL WON! See? He's her lobster.");
            completeLevelUI.SetActive(true);
            StartCoroutine(CoroutineLevelComplete(1f));

            
        }else{
            Debug.Log("Joey doesn't share his food! Get your own rings.");
        }
    }

    public static int GetLevel(){
        return level;
    }
    public int GetHealth(){
        return health;
    }


    IEnumerator CoroutineLevelComplete(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        SceneManager.LoadScene(1);
        level++;
    }

    IEnumerator CoroutineYouLost(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        SceneManager.LoadScene(2);
        level++;
    }
}
