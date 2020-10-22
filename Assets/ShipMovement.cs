using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{

  public float currentSpeed = 0f; //"current" movement speed when game unpauses
  public float acceleration = 0f; //current change in velocity
  public float yawspeed = 30f; //rate of yaw
  public float rollspeed = 40f; //rate of roll
  public float pitchspeed = 50f; //rate of pitch
  public float accelRate = 0.1f; //rate of acceleration
  public float maxAcceleration = 10f; //maximum acceleration, minimum is negative of this
  public float maxSpeedDownWind = 10f;
  public float maxSpeedCrossWind = 10f;
  public float maxSpeedUpWind = 10f;
  public float maxSpeedNoWind = 10f;
    // Start is called before the first frame update
    void Start()
    {
        boolean isPaused = true;

        //queue of movementActions?
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
        }
    }

    //apply movement inputs to the ship
    void applyMoves(){
      transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);
    }
}
