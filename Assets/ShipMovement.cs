using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{

  public float movespeed = 10f;
  public float currentSpeed = 10f;
  public float turnspeed = 50f;
  public float rollspeed = 50f;
  public float pitchspeed = 50f;
  public float accelRate = 10f;
  public float maxSpeedDownWind = 10f;
  public float maxSpeedCrossWind = 10f;
  public float maxSpeedUpWind = 10f;
  public float maxSpeedNoWind = 10f;
    // Start is called before the first frame update
    void Start()
    {
        boolean isPaused = true;

        //queue of movementActions? time limit of maneuvers?
    }

    // Update is called once per frame
    void Update()
    {
        if !isPaused{
          //apply directional forces from movement plan in order
          //check sail impact on speed
            //sail area
            //sail angle vs star
            //blocked?
          //check damage impact on movements

        } else {
          //let the player change directional forces
          //engine acceleration
          if(Input.GetKey(KeyCode.UpArrow))
             transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
          //roll rotation
          //pitch rotation
          //yaw rotation
          //sail area [if the ship has a sail]
          //add action to queue
        }
    }
}
