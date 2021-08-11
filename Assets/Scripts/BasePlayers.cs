//Hernández Gutiérrez Daniel
//Programación Orientada a Objetos

/*
Script designado a heredar las variables declaradas en el constructor para asignarles finalment eun valor.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayers : MonoBehaviour
{
    public PlayerConstructor[] NuevoJugador; //Creamos un array para que más de un elemento de la misma clase herede las variables.

/*
Antes que el juego se ejecute estas variables ya tienen sus correspondientes valores.
*/

    // Start is called before the first frame update
    void Awake()
    {
        NuevoJugador=new PlayerConstructor[2];
        NuevoJugador[0]= new PlayerConstructor("Player01",1,1500);
        NuevoJugador[1]= new PlayerConstructor("Player02",2,1500);
    }
}
