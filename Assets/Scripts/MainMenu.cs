using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame()
   {
       SceneManager.LoadScene(GameManager.GetLevel()+1); //TODO MAKE VARIABLE DEPENDING ON CURRENT LEVEL
   }

    public void QuitGame()
    {
      Application.Quit();
    }
}