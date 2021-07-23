//Script crea un array de dos espacios y asigna los valores a las variables ubicadas en el script PlayerConstructor

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
        NuevoJugador[0]= new PlayerConstructor("Player01",1,9000);
        NuevoJugador[1]= new PlayerConstructor("Player02",2,9000);
    }
}
