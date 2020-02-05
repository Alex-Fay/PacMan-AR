using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 3.95f;
    public Node startingPosition;

    //timers 
    public int scatterModeTimer = 7; //7 sec 
    public int chaseModeTimer = 20;
    public int friightenModeTimer = 5;
    //bunch of other repeated timers

    //Mode Changes
    public int modeChangeNum = 1;
    private float modeChangeTimer = 0;
    
    public enum Mode{
        Chase,
        Scatter,
        Frightened
    }

    Mode currentMode = Mode.Scatter;
    Mode previousMode; 

    private GameObject pacMan;

    private Node currentNode, targetNode, previousNode;
    private Vector2 direction, nextDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ModeUpdate(){
        if (currentMode != Mode.Frightened){
            modeChangeTimer += Time.deltaTime;

            if (modeChangeIteration == 1){
                if(currentMode == Mode.Scatter && modeChangeTimer > scatterModeTimer){
                    ChangeMode(Mode.Chase);
                    modeChangeTimer = 0;
                }

            if (currentMode == Mode.Chase && modeChangeTimer > chaseModeTimer1){
                modeChangeTimer = 2;
                ChangeMode (Mode.Scatter);
                modeChangeTimer = 0;
            }

            else if (modeChangeIteration == 2){
                if (currentMode == Mode.Scatter && modeChangeTimer > scatterModeTime){
                currentMode (Mode.Chase);
                modeChangeTimer = 0;
                }

                if (currentMode == Mode.Chase && modeChangeTimer > chaseModeTimer){
                    modeChangeIteration = 3;
                    ChangeMode(Mode.Scatter);
                    modeChangeTimer = 0
                }

                //put in changes for Mode 3 and 4
            }

            }
        }
    }
}
