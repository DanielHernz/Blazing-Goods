using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dispensador : Mesas
{   
    public GameObject Prop_Dispensado;
    Transform DispensadorPROP;
    Vector3 Nueva_Posicion;
    // Start is called before the first frame update
    void Start()
    {
        Nueva_Posicion = transform.position;
    }


    // Update is called once per frame
    void Update()
    {
        if (TriggerON == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(Prop_Dispensado,new Vector3(Nueva_Posicion), Prop_Dispensado.transform.rotation);
                Debug.Log("1"); 
                Prop_Dispensado.transform.SetParent(PlayerTransform);
                Debug.Log("2"); 
            } 
        }
    }
}
