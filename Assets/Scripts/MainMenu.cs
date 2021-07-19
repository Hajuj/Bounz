using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public GameObject gotoLevelUI;

   public void PlayGame()
   {
        gotoLevelUI.SetActive(true);

        StartCoroutine(CoroutinePlayGame(1f));
   }

    public void QuitGame()
    {
      Application.Quit();
    }

    IEnumerator CoroutinePlayGame(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        SceneManager.LoadScene(GameManager.level + 2); //TODO MAKE VARIABLE DEPENDING ON CURRENT LEVEL
    }

}