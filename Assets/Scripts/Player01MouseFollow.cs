//Este script hace que la cámara encuentre el puntero del mouse en el espacio 3D y lo transforma en coordenadas.
//Necesario para poder rotar al personaje y facilitar el gameplay.

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
