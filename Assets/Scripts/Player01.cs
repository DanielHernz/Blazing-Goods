//Este script provoca el movimiento y rotación del personaje.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player01 : MonoBehaviour
{
    //BasePlayers BaseJugadores = new BasePlayers();
    //PlayerDistribution DatosPlayer = new PlayerDistribution();
    //private PlayerDistribution PlayerDistribution;
    //private PlayerConstructor PlayerConstructor;
    public Rigidbody RigidbodyPlayer01;
    public Transform Player01Rot;
    public Transform MousePosition3D;
    public int VelocidadDir;
    private void Start() 
    {
        
    }

    private void Update() 
    {
        if (Input.GetKey("w"))
        {
            RigidbodyPlayer01.AddForce(0,0,VelocidadDir * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            RigidbodyPlayer01.AddForce(0,0,-VelocidadDir * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            RigidbodyPlayer01.AddForce(-VelocidadDir * Time.deltaTime,0,0);
        }
        if (Input.GetKey("d"))
        {
            RigidbodyPlayer01.AddForce(VelocidadDir * Time.deltaTime,0,0);
        }

        transform.LookAt(MousePosition3D);
    }
}
