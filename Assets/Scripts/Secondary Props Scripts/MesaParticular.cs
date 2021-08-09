using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MesaParticular : VariablesBase
{
    Transform Hijo_Mesa_Trans;
    // Start is called before the first frame update
    void Start()
    {
        PlayerGameObject = GameObject.FindGameObjectWithTag("Player");
        PlayerTransform = PlayerGameObject.GetComponent<Transform>();    
        Hijo_Mesa_Trans = gameObject.GetComponent<Transform>();
    }
    
    // Update is called once per frame
    void Update()
    {   
        if (TriggerON == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Hijo = transform.GetChild(0);
                Hijo.SetParent(PlayerTransform);
            } 
            if (Input.GetMouseButtonDown(1))
            {
                Hijo = PlayerTransform.GetChild(11);
                Hijo.SetParent(transform);
            } 
        }
    }
}
