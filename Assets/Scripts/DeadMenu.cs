using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadMenu : MonoBehaviour
{

 public void Retry()
   {
       SceneManager.LoadScene(GameManager.GetLevel()+2);
   }
   
   public void MainMenu()
    {
      SceneManager.LoadScene(0);
    }
}
