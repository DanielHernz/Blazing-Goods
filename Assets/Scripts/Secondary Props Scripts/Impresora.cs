using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impresora : Boton
{
    public Transform NA;
    public Transform INT;
    private Vector3 Pos_Impresora;
    private Transform Etiqueta, Player_Trans;
    private GameObject Player_GO;

    // Start is called before the first frame update
    void Start()
    {
        Player_GO = GameObject.FindGameObjectWithTag("Player");
        Player_Trans = Player_GO.transform;

        Pos_Impresora = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (TriggerON == true && Case01_ON == true)
        {
            if (Input.GetMouseButtonDown(0)) 
            {
                Transform Instanciacion = Instantiate(NA,Pos_Impresora,Quaternion.identity);
                Instanciacion.parent = Impresora_Trans;
                Etiqueta = Impresora_Trans.GetChild(0);
                Etiqueta.SetParent(Player_Trans);
            }
            if (Input.GetMouseButtonDown(1)) 
            {
                Transform Instanciacion = Instantiate(INT,Pos_Impresora,Quaternion.identity);
                Instanciacion.parent = Impresora_Trans;
                Etiqueta = Impresora_Trans.GetChild(0);
                Etiqueta.SetParent(Player_Trans);
            } 
        }
    }
}
