using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightControl : MonoBehaviour
{
  public float currentSpeed = 0; //"current" movement speed when game unpauses
  public float acceleration = 0; //current change in velocity
  public float yawspeed = 30; //rate of yaw
  public float rollspeed = 40; //rate of roll
  public float pitchspeed = 50; //rate of pitch
  public float accelRate = 0.1; //rate of acceleration
  public float maxAcceleration = 10; //maximum acceleration, minimum is negative of this
  public float maxSpeedDownWind = 1000;
  public float maxSpeedCrossWind = 800;
  public float maxSpeedUpWind = 600;
  public float maxSpeedNoWind = 750;
  public float fuelLevel = 100;
    void Start() {}

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(Keycode.Return)){
        acceleration = acceleration + accelRate;
        if (acceleration > maxAcceleration){
          acceleration = maxAcceleration;
        }

        currentSpeed = currentSpeed + acceleration;
        if (currentSpeed > maxSpeedNoWind){
          currentSpeed = maxSpeedNoWind;
        }
      } else if (Input.GetKeyUp(KeyKode.Return)){
        acceleration = 0;
      }

      transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);
    }
}
