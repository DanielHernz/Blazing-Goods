using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispensadorParticular : VariablesBase
{
    private Vector3 Posicion_Dispensador;

    // Start is called before the first frame update
    void Start()
    {
        PlayerGameObject = GameObject.FindGameObjectWithTag("Player");
        PlayerTransform = PlayerGameObject.transform; 

        Posicion_Dispensador = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (TriggerON == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Transform Instanciacion = Instantiate(Hijo,Posicion_Dispensador,Quaternion.identity);
                Instanciacion.parent = Dispensador;
                Hijo_Dispensado = Dispensador.GetChild(0);
                Hijo_Dispensado.SetParent(PlayerTransform);
            } 
        }
    }
}
