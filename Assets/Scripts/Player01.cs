using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player01 : MonoBehaviour
{
    PlayerDistribution DatosPlayer = new PlayerDistribution();
    public Rigidbody RB;
    int Velocidad;

    private void Start() 
    {
        DatosPlayer.VelocidadDIR = Velocidad;
    }
    private void Update() 
    {
        if (Input.GetKey("w"))
        {
            RB.AddForce(0,0,Velocidad* Time.deltaTime);
        }
    }
}
