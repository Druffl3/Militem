﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightControl : MonoBehaviour
{
  public float currentSpeed = 0; //"current" movement speed when game unpauses
  public float acceleration = 0; //current change in velocity
  public float yawspeed = 30; //rate of yaw
  public float rollspeed = 40; //rate of roll
  public float pitchspeed = 50; //rate of pitch
  public float accelRate = 100f; //rate of acceleration
  public float maxAcceleration = 1000; //maximum acceleration, minimum is negative of this
  public float maxSpeedDownWind = 10000;
  public float maxSpeedCrossWind = 8000;
  public float maxSpeedUpWind = 6000;
  public float maxSpeedNoWind = 7500;
  public float fuelLevel = 100;
    void Start() {}

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Return)){
        acceleration = acceleration + accelRate;
        if (acceleration > maxAcceleration){
          acceleration = maxAcceleration;
        }
        currentSpeed = currentSpeed + acceleration;
      } else if (Input.GetKeyUp(KeyCode.Return)){
        acceleration = 0;
      }

      if (currentSpeed > maxSpeedNoWind){
        currentSpeed = maxSpeedNoWind;
      }

      transform.Translate(Vector3.up * currentSpeed * Time.deltaTime);
    }
}
