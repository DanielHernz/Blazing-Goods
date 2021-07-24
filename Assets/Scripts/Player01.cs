//Hernández Gutiérrez Daniel
//Programación Orientada a Objetos

// Controlador. Entregable 24 de Julio.

/*Este script recopila sus variables del constructor, provoca el movimiento y rotación del personaje. Además de reproducir las respectivas animaciones.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player01 : MonoBehaviour
{
    public Rigidbody RigidbodyPlayer01; // Requerido para mover al personaje W/A/S/D
    public Transform Player01Rot; //Necesario para poder rotar el personaje.
    public Transform MousePosition3D; //Necesario para que el player rote observando a este objeto transform.
    Animator AnimPlayer;
    private bool AnimON = false; 
    public int PlayerID;
    public string Nombre;
    public int VelocidadDIR;
    BasePlayers bdPlayers =new BasePlayers();
    private void Awake() 
    {
        AnimPlayer = GetComponent<Animator>();
    }
    private void Start() 
    {
        bdPlayers = GameObject.FindObjectOfType<BasePlayers>(); 
        
        CargarDatos(PlayerID); // Pedimos ejecutar desde un inicio al método y así tener ya datos asignados y la fuerza requerida para mover al player.
    }

    void CargarDatos(int id) // Como este script lo llevará también otro player con controles independientes, este ciclo for solo pedirá el ID del otro player y así evitar modificar el código.
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
        if(Input.GetMouseButtonDown(0)) //Cuando se precione click izquierdo, la animación loop correrá y cuando se precione click derecho se detendrá
        {
            AnimON = true;
            AnimPlayer.SetBool("Cargar",AnimON);
        }
        if(Input.GetMouseButtonDown(1)) 
        {
            AnimON = false;
            AnimPlayer.SetBool("Cargar",AnimON);
        }


        //Tipico movimiento con W/A/S/D tomando la fuerza del movimiento a la varieble declarada en otro script.

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

        transform.LookAt(MousePosition3D); // El player siempre obervará al objeto transform MousePosition3D
    }
}
