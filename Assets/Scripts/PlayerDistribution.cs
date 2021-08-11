//Hernández Gutiérrez Daniel
//Programación Orientada a Objetos

/*
Script dedicado a crear un sistema que automaticamente se encuentren objetos y se les asignen las variables.
*/

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
        
        CargarDatos(PlayerID); //Ejecutamos el método al iniciar y pedimos de regreso la variable integral ID
    }

/*
El plan era que el videojuego pudiera jugarse con dos jugadores; por eso este script contenía este método.
La razón por la que no se pudo realizar este objetivo fue que para poder rotar al personaje se requería
del puntero del mouse. Si se continuaba con la jugabilidad de dos jugadores ambos jugadores verían al mismo sitio.
*/

    void CargarDatos(int id)
    {
/*
        Este ciclo estaba delimitado por la cantidad de jugadores declarados en el script BasePlayers
        Y mediante el ciclo avanzaba la asignación de sus variables lo hacia tambíen probresivamente.
*/

        for (int i = 0; i < bdPlayers.NuevoJugador.Length; i++)
        {
            if (bdPlayers.NuevoJugador[i].PlayerID==id)
            {
                this.Nombre=bdPlayers.NuevoJugador[i].Nombre;
                this.VelocidadDIR=bdPlayers.NuevoJugador[i].VelocidadDIR;
            }
        }
    }
}
