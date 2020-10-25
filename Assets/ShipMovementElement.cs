using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
This is to store input data from player flight movements
These will be stored in an array in order to replay all of the movements at once
*/

public class ShipMovementElement : MonoBehaviour
{
    public int x_pos;
    public int y_pos;
    public int z_pos;
    public float x_rot;
    public float y_rot;
    public float z_rot;
    public float sailState;
    public float fuelLevel;
    public int milliseconds; //number of milliseconds since the previous action

}
