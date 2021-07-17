using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player01 : MonoBehaviour
{
    PlayerDistribution DatosPlayer = new PlayerDistribution();
    public Rigidbody RB;
    float VelocidadDir = 900f;
    float VelocidadRot = 200f;
    public Transform Player01Rot;

    private void Start() 
    {
        //DatosPlayer.VelocidadDIR = VelocidadDir;
    }
    private void Update() 
    {
        if (Input.GetKey("w"))
        {
            RB.AddForce(0,0,VelocidadDir * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            RB.AddForce(0,0,-VelocidadDir * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            RB.AddForce(-VelocidadDir * Time.deltaTime,0,0);
        }
        if (Input.GetKey("d"))
        {
            RB.AddForce(VelocidadDir * Time.deltaTime,0,0);
        }

        //float VistaX = Input.GetAxis("Mouse X") * VelocidadRot * Time.deltaTime;
        //float VistaY = Input.GetAxis("Mouse Y") * VelocidadRot * Time.deltaTime;
        //Player01Rot.Rotate(Vector3.up * VistaX);
    }
}
