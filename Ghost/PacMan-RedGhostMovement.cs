using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Timers;

//TODO: add camera changes to PacMan Camera.main.transform.position = ...
//develop pacman start position, set up grid tiles 28*36

public class RedMovement : MonoBehaviour, MovementInterface
{
    CharecterController CharecterController
    public GameObject pacman;
    public GameObject redGhost;
    public GameObject wall;

    private pacmanStartPos = new Vector3(0.0f, 0.0f, 30.0f); //update when finalized
    private currentLevel; //get from GameStart class
    private float redGhostSpeed = 3.9f;
    public bool gameOver = false;


    void Awake(){
        //outside ghost pen starting location
        transform.position = new Vector3(0.0f, 5.0f, 0.0f);

        //if pacman moves then start ghost algorithm
        if (pacman.position != pacmanStartPos) {
            Start();
        }
    }
    
    void Start()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        //ghosts alternate between scatter and chase for 4 cycles like original
        int scatterTime = 7;
        int scatterCallNum = 0;

        for(i=0; i<4; i++){
            scatterTime = scatterTime - i;
            Scatter(scatterTime, scatterCallNum);
        }

        void Scatter(scatterTime, scatterCallNum, gameOver){
            scatterCallNum += 1;
            if(gameOver = true){break;}
            //origanal scatter method has red to top right corner
            //pink = left top  orange = bottom left    green = bottom right
            
            while (stopwatch.Elapsed < scatterTime){
                int rotateX_Movement = 90;
                int rotateY_corner = 1;
                MovementInterface.scatterCorner(scatterTime, rotateX_Movement, rotateY_corner);
            }
            else{
                    MovementInterface.Chase(-1);
            }
        }

        void Chase(chaseTime, gameOver){
            // Chase method very different for each ghost
            if (chaseTime != 0){
                chaseTime -= 1;
                Vector2 ghostChasePoint = Vector2.MoveTowards(transform.position() , pacman.position(), speed);
                GetComponent<RedGhost>().MovePosition(ghostChasePoint);
                if(gameOver = true){
                    break;
                }
            }
            else{
                Chase(chaseTime, gameOver)
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
    
    }

//next do chase method