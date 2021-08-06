using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mesas : MonoBehaviour
{
    protected bool TriggerON;
    protected GameObject PlayerGameObject;
    protected Transform PlayerTransform;
    public Transform Hijo;

    
    // Start is called before the first frame update
    void Start()
    {
        PlayerGameObject = GameObject.FindGameObjectWithTag("Player");
        PlayerTransform = PlayerGameObject.GetComponent<Transform>();
        //Hijo = PlayerTransform.GetChild(11).transform;
    }
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
    protected void ChildCheck()
    {
        
    }
    // Update is called once per frame
    void Update()
    {

    }
}
