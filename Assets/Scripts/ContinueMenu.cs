using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueMenu : MonoBehaviour
{
  public GameObject nextLevelPanelUI;
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

        SceneManager.LoadScene(GameManager.GetLevel() + 2); //TODO MAKE VARIABLE DEPENDING ON CURRENT LEVEL
    }
}
