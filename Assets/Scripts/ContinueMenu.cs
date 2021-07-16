using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueMenu : MonoBehaviour
{

 public void NextLevel()
   {
       SceneManager.LoadScene(GameManager.GetLevel()+1);
   }
   
   public void MainMenu()
    {
      SceneManager.LoadScene(0);
    }
}
