using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueMenu : MonoBehaviour
{
public GameObject nextLevelPanelUI;
public GameObject startContinuePanelUI;


  void Start(){
  StartCoroutine(CoroutineStop(1f));
}
 public void NextLevel()

   {
        nextLevelPanelUI.SetActive(true);
        StartCoroutine(CoroutineNextLevel(1f));
   }
   
   public void MainMenu()
    {
      SceneManager.LoadScene(0);
    }

    IEnumerator CoroutineNextLevel(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        if(GameManager.level<5){
        SceneManager.LoadScene(GameManager.level + 2); 
        }else{
          SceneManager.LoadScene(2);
        }
    }


    IEnumerator CoroutineStop(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        startContinuePanelUI.SetActive(false);
    }
}
