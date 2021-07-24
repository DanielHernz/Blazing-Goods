//Hernández Gutiérrez Daniel
//Programación Orientada a Objetos

// Controlador. Entregable 24 de Julio.
/*
Este script asigna los valores a las variables declaradas en el constructor y las ordena en un array.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayers : MonoBehaviour
{
    public PlayerConstructor[] NuevoJugador;


    // Start is called before the first frame update
    void Awake()
    {
        NuevoJugador=new PlayerConstructor[2];
        NuevoJugador[0]= new PlayerConstructor("Player01",1,1500);
        NuevoJugador[1]= new PlayerConstructor("Player02",2,1500);
    }
}
