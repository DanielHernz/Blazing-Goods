using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player01MouseFollow : MonoBehaviour
{
    public Camera Camera;
    Vector3 MousePos;
    public Transform Player01Rot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //MousePos = Camera.ScreenToViewportPoint(Input.mousePosition);
        float VistaX = Input.GetAxis("Mouse X") * 500 * Time.deltaTime;
        float VistaZ = Input.GetAxis("Mouse Z") * 500 * Time.deltaTime;
        Player01Rot.Rotate(Vector3.up * VistaX);
    }
    /*
    void FixedUpdate()
    {
        Vector3 LookDir = MousePos;
        float angulo = Mathf.Atan2(LookDir.x,LookDir.z) * Mathf.Rad2Deg - 90f;  
    }
    */
}
