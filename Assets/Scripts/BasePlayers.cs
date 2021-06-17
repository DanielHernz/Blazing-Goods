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
        NuevoJugador[0]= new PlayerConstructor("Shark",1,10,7,5);
        NuevoJugador[1]= new PlayerConstructor("Mouse",2,10,7,5);
    }
}
