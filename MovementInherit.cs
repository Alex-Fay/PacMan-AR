//Movement class all code will inherit 

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
