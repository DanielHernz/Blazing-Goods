//Hernández Gutiérrez Daniel
//Programación Orientada a Objetos

/*
Este script hace que la cámara registre la posición del puntero en una coordenada 3D en el entorno.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player01MouseFollow : MonoBehaviour
{
    [SerializeField] private Camera Camara;
    private void Update() 
    {
/*
        Con Ray hacemos que la camara genere un punto, como un puntero laser, que haga resaltar el punto
        resultante donde registre la posición del puntero del mouse.
        Entre las clases sobre raycast y videos en internet resultó este script donde el LayerMask fue un desafío
        pero finalmente fue resuelto por una ligera inspiración.
*/

        Ray ray = Camara.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastaHit,float.MaxValue, LayerMask.NameToLayer("Ignore Ray")))
        {
            transform.position = raycastaHit.point;
        }
    }
}
