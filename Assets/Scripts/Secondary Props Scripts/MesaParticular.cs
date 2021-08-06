using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MesaParticular : Mesas
{
    GameObject Mesa_Obj;
    Transform Hijo_Mesa_Trans;
    // Start is called before the first frame update
    void Start()
    {
        PlayerGameObject = GameObject.FindGameObjectWithTag("Player");
        PlayerTransform = PlayerGameObject.GetComponent<Transform>();
        //Hijo = PlayerTransform.GetChild(11).transform;
    
        Hijo_Mesa_Trans = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {        
        if (TriggerON == true)
        {
            Hijo = PlayerTransform.GetChild(11).transform; 
            if (Hijo == null)
            {
                Hijo_Mesa_Trans = transform.GetChild(0);
                Debug.Log("100"); 
                if (Input.GetMouseButtonDown(0))
                {
                    Hijo_Mesa_Trans.SetParent(PlayerTransform);
                    Debug.Log("2"); 
                } 
            }
            if (Hijo)
            {
                if (Input.GetMouseButtonDown(1))
                {
                    Hijo.SetParent(gameObject.transform);
                    Debug.Log("1"); 
                } 
            }
        }
    }
}
