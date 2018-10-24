using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{

//This is for the ship variables tutorial

    public int Score = 100;
    public int Money = 1000;

    public float Health = 1.0f;
    public float firePower = 20.0f;

    public string ShipName = "Skíðblaðnir";
    public string FleetName;

    public Vector3 Movement;
    public Color ShipColor = Color.red;
    public Animation Anims;
    public UnityEventQueueSystem UnityEvent Event;

    }
}
