using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Timers;

//TODO: add camera changes to PacMan Camera.main.transform.position = ...
//develop pacman start position, set up grid tiles 28*36

public class RedMovement : MonoBehaviour
{
    public GameObject pacman;
    public GameObject redGhost;
    public GameObject wall;

    private pacmanStartPos = new Vector3(0.0f, 0.0f, 30.0f); //update when finalized
    private currentLevel; //get from GameStart class
    private float redGhostSpeed = 3.9f;

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
        scatterTime = 7;

        for(i=0; i<4; i++){
            scatterTime = scatterTime - i;
            Scatter();
        }

       public void Chase(chaseTime){
           //define chaseTime and pacman positions
       }

        public void MoveRightTopCorner(){
            upperCorner = new Vector3 (300f, 300f, 100f); // need to redfine after building wall
            currentPosition = ghost.position(); //look for unity method for this
            if (wall.position == (ghost.position + 2f)){
                direction = currentPosition - previousPosition;
                //look at unity directions, 
                // from distance if 3right is less than 3 left distance go right
                // reverse for up and down
            }
        }

        public int Scatter(scatterTime){
            //origanal scatter method has red to top right corner
            //pink = left top  orange = bottom left    green = bottom right
            
            if (stopwatch.Elapsed < scatterTime){
                previousPosition = ghost.position();
                MoveRightTopCorner();
            }
            else{
                Chase();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

//next do chase method