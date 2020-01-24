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
            Scatter()
        }

        Chase()

        Scatter(scatterTime){
            //need to find original scatter method
            //https://gameinternals.com/understanding-pac-man-ghost-behavior
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
