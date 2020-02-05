using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Timers;

//Movement class all code will inherit 
//TODO: look into class inheritance for Mode Change Mode()
interface Movement{
    int rotate = 0;
    Stopwatch scatterWatch = new Stopwatch();

    public void scatterCorner(scatterTime, rotateX_Movement, rotateY_Movement, scatterCallNum){
        if(scatterWatch.Elapsed < scatterTime){
            if (wall.position == (ghost.position + 4f)){
                rotate += 1;

                if (rotate % 2 == 0){
                transform.Rotate(Vector3.right, rotateX_Movement, rotateY_Movement);
                }
                else{
                    transform.Rotate(Vector3.left, rotateX_Movement, rotateY_Movement);
                    transform.Translate(Vector3.forward * speed);
                }
            }
            else{
                transform.Translate(Vector3.forward * speed);
            }
        }
        else{
            Chase(); //TODO: add PacmanDirection or set up null?
        }
    }

    public void Chase(chasePredictor){
        int chaseTime;
        if(scatterCallNum < 3){
            chaseTime = 5;
        }
        else{
            chaseTime = 1000000;
        }

        movement = pacman.position() + chasePredictor;
        //Finish Chase method keep it generalized for each ghost
    }
}