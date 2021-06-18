using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoPartida : MonoBehaviour
{
    private float TiempoMaximo = 180;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Cargar escena
        //Deshabilitar script "PlayerControls"
        //Esperar 3 segundos
        //Habilitar script "PlayerControls"
        //Iniciar temporalizador (Temp ++)
        //if {keydown == Esc}
            //Pausar temporalizador
            //Deshabilitar script "PlayerControls"
            //if {pressbutton "Continuar"}
                //Reanudar temporalizador
                //Habilitar script "PlayerControls"
        //if {Temp == TiempoMaximo}
            //Deshabilitar scrpit "PlayerControls"
            //Mostrar puntuación obtenida en Canvas
    }
}
