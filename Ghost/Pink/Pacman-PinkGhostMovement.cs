using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

//TODO: add grid square for chase and scatter movements 

public class PinkMovement: MonoBehaviour, MovementInherit{
    private scattercorner = new Vector3(15f, 0f, 0f);   //left upper corner 
    private speed = 3.9f;
    private pacmanStartPos = new Vector3(0.0f, 0.0f, 30.0f);
    Stopwatch pinkChaseTime = new Stopwatch();
    private scatterTime = 5;
    private chaseTime = 7;
    public GameObject pacman;
    public gameOver; //inherit from upper class

//if pacman moves then start ghost algorithm
    if (pacman.position != pacmanStartPos) {
        Chase();
    }

    private void Chase(pinkChaseTime){
        pinkSquare = pacman.position() + (4 * grid square);

        if (chaseTime != 0){
            chaseTime -= 1;
            Vector2 ghostChasePoint = Vector2.MoveTowards(transform.position(), pinkSquare, speed);
            GetComponent<PinkGhost>().MovePosition(ghostChasePoint);
            if(gameOver = true){
                break;
            }
        }
        else{
            Chase(chaseTime, gameOver)
        }
    }

}
