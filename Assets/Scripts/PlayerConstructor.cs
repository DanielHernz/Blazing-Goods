//Hernández Gutiérrez Daniel
//Programación Orientada a Objetos

/*
Constructor que declara las variables base para el script principal del player.
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

/*
Como este script esta destinado a ser constructor, no puede llevar un método que esperemos que pueda ejecutar.
Lo unico que declaramos son las variables y les asignamos nombres para mandarlas a llamar.
*/
    public PlayerConstructor(string Nombre, int ID, int VelD)
    {
        this.PlayerID=ID;
        this.Nombre=Nombre;
        this.VelocidadDIR=VelD;
    }
}
