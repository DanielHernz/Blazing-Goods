using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesBase : MonoBehaviour
{   protected bool TriggerON;
    protected GameObject PlayerGameObject;
    protected Transform PlayerTransform;
    public Transform Hijo,Dispensador;



    
    protected void OnTriggerEnter(Collider collider) 
    {
        TriggerON = true;
        Debug.Log("TriggerON ="+ TriggerON);
    }
    protected void OnTriggerExit(Collider collider) 
    {
        TriggerON = false;
        Debug.Log("TriggerON ="+ TriggerON);
    }
}
