//Movement class all code will inherit 
//TODO: look into class inheritance for Mode Change Mode()
public class Movement{
    Stopwatch stopwatch = new Stopwatch();
    scatterTime = 7;

    public void MoveRightTopCorner(scatterTime){
        if(stop.Elapsed < scatterTime){
            upperCorner = new Vector3 (300f, 300f, 100f); // need to redfine after building wall
            currentPosition = ghost.position(); //look for unity method for this
            if (wall.position == (ghost.position + 4f)){
                rotate += 1;

                if (rotate % 2 == 0){
                transform.Rotate(Vector3.right, 90, 1);
                }
                else{
                    transform.Rotate(Vector3.left, 90, 1);
                    transform.Translate(Vector3.forward * speed);
                }
            }
            else{
                transform.Translate(Vector3.forward * speed);
            }
        }
        else{
            Mode();
        }
    }
}