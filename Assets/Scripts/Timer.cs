using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
 private float seconds = 0.0f;
 private float minutes = 0.0f;
 private float hours = 0.0f;
 public GameObject txt;
 
 void Update(){

     seconds += Time.deltaTime;
     if(seconds > 60){
         minutes += 1;
         seconds = 0;
     }
     if(minutes > 60){
         hours += 1;
         minutes = 0;
     }
     string newTime="";
     if(hours<10){newTime+="0"+(int)hours;}else{newTime+=(int)hours;}
     newTime+=":";
     if(minutes<10){newTime+="0"+(int)minutes;}else{newTime+=(int)minutes;}
     newTime+=":";
     if(seconds<10){newTime+="0"+(int)seconds;}else{newTime+=(int)seconds;}
     txt.GetComponent<TMPro.TextMeshProUGUI>().text = newTime;

 }
}
