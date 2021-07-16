using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject bigPlayer;

    [SerializeField] Vector3 newPos;
    [SerializeField] Vector3 camPos;
    float newX;
    float newY;
    float camY;
    float scaleY;
    float height;
    //so camera won't be in a player point of view
    public float newZ;
    

//transform.position = player.position;
    void Start()
    {
        //get camera scale since we might want to change that later
        scaleY = transform.localScale.y;
    }


    // Update is called once per frame
    void Update()
    {
        
        player = GameObject.FindWithTag("Player");
        bigPlayer = GameObject.FindWithTag("BigPlayer");

        //get Position for the case that ball does not jump high enough to change y value
        camY = transform.position.y;
        //change position for small player
        if(player != null)
        {
            //get player x and y coordinates
            newX = GameObject.FindWithTag("Player").transform.position.x;
            newY = GameObject.FindWithTag("Player").transform.position.y;
            //change camera position
            GetPosition();

        }
        //change position for big player
        else if(bigPlayer != null){
            //get big player x and y coordinates
            newX = GameObject.FindWithTag("BigPlayer").transform.position.x;
            newY = GameObject.FindWithTag("BigPlayer").transform.position.y;
            //change camera position
            GetPosition();
            


        }

        void GetPosition()
        {
            //get new y coordinates for player jumps high enough (first) or player falls low enough (second)
            float newYposup = newY - scaleY / 2;
            float newYposdown = newY + scaleY / 2;
            //check if player jumps high enough + get new coordinates
            if ((camY + scaleY / 2) <= newY)
            {

                newPos = new Vector3(newX, newYposup, newZ);
            }
            //check if player falls low enough + get new coordinates
            else if ((camY - scaleY / 2) >= newY)
            {
                newPos = new Vector3(newX, newYposdown, newZ);

            }
            //if player doesn't change it's y coordinate enough
            else
            {
                newPos = new Vector3(newX, camY, newZ);
            }

            //change camera position
            transform.position = newPos;

        }

    }
}
