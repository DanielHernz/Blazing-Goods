//Hernández Gutiérrez Daniel
//Programación Orientada a Objetos

// Controlador. Entregable 24 de Julio.

/*
Este script se encarga de hacer que el puntero del mouse pueda interactuar con el entorno 3D, facilitando el lookAt.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player01MouseFollow : MonoBehaviour
{
    [SerializeField] private Camera Camara;
    private void Update() 
    {
        Ray ray = Camara.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastaHit))
        {
            transform.position = raycastaHit.point;
        }
    }
}
