//Hernández Gutiérrez Daniel
//Programación Orientada a Objetos

// Controlador. Entregable 24 de Julio.
/*
Constructor que declara las variables base.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerConstructor
{
    public int PlayerID;
    public string Nombre;
    public int VelocidadDIR;
    
    private Transform PosicionPlayer;

    public PlayerConstructor(string Nombre, int ID, int VelD)
    {
        this.PlayerID=ID;
        this.Nombre=Nombre;
        this.VelocidadDIR=VelD;
    }
}
