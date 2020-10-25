using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{

  //maybe make a different object type for this or store it as something else?
  public ShipMovementElement originalState; //the state the ship is in before the turn

  public ShipMovementElement[] movementArray;
    // Start is called before the first frame update
    void Start()
    {
        boolean isPaused = true;

        timer = Stopwatch.new();
    }

    // Update is called once per frame
    void Update()
    {
        if !isPaused{
          //apply directional forces from movement plan in order
          applyMoves()
          //check sail impact on speed
            //sail area
            //sail angle vs star
            //blocked?
          //check damage impact on movements
        } else {
          ShipMovementElement tempElement = new ShipMovementElement();
          timer.Start();
          //let the player change directional forces
          //engine acceleration
          //roll rotation
          //pitch rotation
          //yaw rotation
          //sail area [if the ship has a sail]
          //add action to array
          timer.Stop();
          tempElement.milliseconds = timer.ElapsedMilliseconds;

        }
    }

    //apply movement inputs to the ship
    void applyMoves(){
      //take movementElements from the array and move the ship to those positions
    }
}
