//Este script asigna el array del script BasePlayers a los players 1 y 2.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDistribution : MonoBehaviour
{
    public Rigidbody RigidbodyPlayer01;
    public Transform Player01Rot;
    public Transform MousePosition3D;


    public int PlayerID;
    public string Nombre;
    public int VelocidadDIR;
    BasePlayers bdPlayers =new BasePlayers();
    private void Start() 
    {
        bdPlayers = GameObject.FindObjectOfType<BasePlayers>();
        
        CargarDatos(PlayerID);
    }

    void CargarDatos(int id)
    {
        for (int i = 0; i < bdPlayers.NuevoJugador.Length; i++)
        {
            if (bdPlayers.NuevoJugador[i].PlayerID==id)
            {
                this.Nombre=bdPlayers.NuevoJugador[i].Nombre;
                this.VelocidadDIR=bdPlayers.NuevoJugador[i].VelocidadDIR;
            }
        }
    }

    private void Update() 
    {
        if (Input.GetKey("w"))
        {
            RigidbodyPlayer01.AddForce(0,0,VelocidadDIR * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            RigidbodyPlayer01.AddForce(0,0,-VelocidadDIR * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            RigidbodyPlayer01.AddForce(-VelocidadDIR * Time.deltaTime,0,0);
        }
        if (Input.GetKey("d"))
        {
            RigidbodyPlayer01.AddForce(VelocidadDIR * Time.deltaTime,0,0);
        }

        transform.LookAt(MousePosition3D);
    }
}
