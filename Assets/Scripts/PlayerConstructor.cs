//Este script es el Constructor que declara las variables base del personaje.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerConstructor
{
    public int PlayerID;
    public string Nombre;
    public int VelocidadDIR;
    public int VelocidadROT;
    public int Impulso;
    private Transform PosicionPlayer;

    public PlayerConstructor(string Nombre, int ID, int VelD, int VelR, int Imp)
    {
        this.PlayerID=ID;
        this.Nombre=Nombre;
        this.VelocidadDIR=VelD;
        this.VelocidadROT=VelR;
        this.Impulso=Imp;
    }
}
