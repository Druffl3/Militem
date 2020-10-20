using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        boolean isPaused = true
    }

    // Update is called once per frame
    void Update()
    {
        if !isPaused{
          //apply directional forces from movement plan
          //check sail impact on speed
            //sail area
            //sail angle vs star
            //blocked?
          //check damage impact on movements

        } else {
          //let the player change directional forces
          //engine acceleration
          //roll rotation
          //pitch rotation
          //yaw rotation
          //sail area [if the ship has a sail]
          //let players delay certain actionsfor later...queue of movementElement objects? Movement phases?

        }
    }
}
