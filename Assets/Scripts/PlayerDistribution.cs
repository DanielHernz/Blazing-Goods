//Este script asigna el array del script BasePlayers a los players 1 y 2.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDistribution : MonoBehaviour
{
    public int PlayerID;
    public string Nombre;
    public int VelocidadDIR;
    public int VelocidadROT;
    public int Impulso;
    BasePlayers bdPlayers =new BasePlayers();
    private void Start() 
    {
        bdPlayers = GameObject.FindObjectOfType<BasePlayers>();
        
        CargarDatos(PlayerID);
        CargarDatos(VelocidadDIR);
    }

    void CargarDatos(int id)
    {
        for (int i = 0; i < bdPlayers.NuevoJugador.Length; i++)
        {
            if (bdPlayers.NuevoJugador[i].PlayerID==id)
            {
                this.Nombre=bdPlayers.NuevoJugador[i].Nombre;
                this.VelocidadDIR=bdPlayers.NuevoJugador[i].VelocidadDIR;
                this.VelocidadROT=bdPlayers.NuevoJugador[i].VelocidadROT;
            }
        }
    }
}
