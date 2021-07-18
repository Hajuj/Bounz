using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseHealth : MonoBehaviour
{
public GameObject healthBalls;
public GameObject increaseHealthBall;
public GameManager gameManager;

 void OnTriggerEnter2D()
    {
        if(gameManager.GetHealth()!=5){
            gameManager.UpdateHealth(healthBalls, true);
            increaseHealthBall.SetActive(false);
            SoundManager.PlayLifeSound();
        }
    }
}
