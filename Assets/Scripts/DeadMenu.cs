using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadMenu : MonoBehaviour
{
  public GameObject nextLevelPanelUI;
  public GameObject deadPanelUI;

void Start(){
  StartCoroutine(CoroutineStop(1f));
}
 public void Retry()
   {
      nextLevelPanelUI.SetActive(true);
      
      StartCoroutine(CoroutineNextLevel(1f));
   }

    IEnumerator CoroutineNextLevel(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        SceneManager.LoadScene(GameManager.level + 2); //TODO MAKE VARIABLE DEPENDING ON CURRENT LEVEL
    }

    IEnumerator CoroutineStop(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        deadPanelUI.SetActive(false);
    }
}
