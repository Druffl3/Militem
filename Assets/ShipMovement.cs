using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{

  //TODO: add these to the ship classes themselves
  // public float currentSpeed = 0; //"current" movement speed when game unpauses
  // public float acceleration = 0; //current change in velocity
  // public float yawspeed = 30; //rate of yaw
  // public float rollspeed = 40; //rate of roll
  // public float pitchspeed = 50; //rate of pitch
  // public float accelRate = 0.1; //rate of acceleration
  // public float maxAcceleration = 10; //maximum acceleration, minimum is negative of this
  // public float maxSpeedDownWind = 100;
  // public float maxSpeedCrossWind = 80;
  // public float maxSpeedUpWind = 60;
  // public float maxSpeedNoWind = 75;
  // public float fuelLevel = 100;

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
          if(Input.GetKey(KeyCode.UpArrow)){
            acceleration = acceleration + accelRate;
            if acceleration > maxAcceleration{
              acceleration = maxAcceleration;
            } else if acceleration < (0 - maxAcceleration){
              acceleration = 0 - maxAcceleration;
            }
            currentSpeed = currentSpeed + acceleration;
          }

          //roll rotation
          //pitch rotation
          //yaw rotation
          //sail area [if the ship has a sail]
          //add action to queue
          timer.Stop();
          tempElement.milliseconds = timer.ElapsedMilliseconds;

        }
    }

    //apply movement inputs to the ship
    void applyMoves(){
      transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);
    }
}
