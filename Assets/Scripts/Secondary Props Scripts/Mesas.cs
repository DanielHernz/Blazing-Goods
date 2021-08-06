using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mesas : MonoBehaviour
{
    private bool TriggerON;
    private GameObject PlayerGameObject;
    private Transform PlayerTransform;
    public Transform Hijo;

    
    // Start is called before the first frame update
    void Start()
    {
        PlayerGameObject = GameObject.FindGameObjectWithTag("Player");
        PlayerTransform = PlayerGameObject.GetComponent<Transform>();
        Hijo = PlayerTransform.GetChild(11).transform;
    }
    private void OnTriggerEnter(Collider collider) 
    {
        TriggerON = true;
        Debug.Log("TriggerON ="+ TriggerON);
    }
    private void OnTriggerExit(Collider collider) 
    {
        TriggerON = false;
        Debug.Log("TriggerON ="+ TriggerON);
    }
    // Update is called once per frame
    void Update()
    {
        if (TriggerON == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Hijo.SetParent(PlayerTransform);
                Debug.Log("Levantar");  
            } 
            if (Input.GetMouseButtonDown(1))
            {
                Hijo.SetParent(gameObject.transform);
                Debug.Log("Dejar");  
            } 
        }
    }
}
